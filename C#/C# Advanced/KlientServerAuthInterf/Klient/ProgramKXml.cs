
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using SrvInterface;
namespace Klient {
    internal class ProgramKXml {
        static void Mainx(string[] args) {
            string cesta = "";
            try {
                if (args.Length == 0) {
                    throw new ArgumentException("není args");

                }
                if (!File.Exists(cesta)) {
                    throw new ArgumentException("není cesta");
                }
            }
            catch {
                Console.WriteLine("zadej cestu k souboru configinner.xml");
                cesta = Console.ReadLine();
            }

            //if ((args.Length == 0) || (!File.Exists(cesta))) {
            //    Console.WriteLine("soubor neexistuje");
            //    Console.WriteLine("zadej cestu k souboru configinner.xml");
            //    cesta = Console.ReadLine();
            //}

            XmlDocument xmlDoc = new XmlDocument();   //xmlDomInner.cs
            try {
                xmlDoc.Load(cesta);


                XmlElement root = xmlDoc.DocumentElement;
                string srvIP = root.SelectSingleNode("server/ip").InnerText;
                int srvPort = int.Parse(root.SelectSingleNode("server/port").InnerText);
                string name = root.SelectSingleNode("uzivatel/name").InnerText;
                string pass = root.SelectSingleNode("uzivatel/pass").InnerText;


                //int srvPort = 1234;
                string channelID = "channel1";
                IChannel channel = new TcpClientChannel(); // Interface poskytujici kanal - je lepsi tvorit promenou nadrazeneho typu ( kvuli zobecneni)
                ChannelServices.RegisterChannel(channel, false);  //zaregistruj kanál do pole kanálů 


                //false: security vypnuto, ať se to pro začátek nekomplikuje
                //string srvIP = "127.0.0.1";                       // testovani klienta na stejnem stroji jako Server 
                string srvAdr = "tcp://" + srvIP + ":" + srvPort + "/" + channelID; // Connection string
                ISrvInit obj = (ISrvInit)Activator.GetObject(typeof(ISrvInit), srvAdr); // GetObject metoda vraci REFERENCI NA JIZ EXISTUJICI OBECNY OBJEKT ->
                                                                                        //SrvInit autorizace = new SrvInit();                                                                        // Provede deserializaci objektu ktery zaslal(serializoval) server ... nutnost pretypovani
                string jmeno = name;
                string heslo = pass;
                //autorizace.authorize("abcd","123"); 
                //obj.authorize(jmeno, heslo);

                ISrvAuth auth = obj.authorize(jmeno, heslo);


                Console.WriteLine("přihlásil se uživatel " + jmeno + "s heslem " + heslo);
                // GetObject vytvori objekt, podari se i kdyz server nebezi(vtom pripade vraci NULL)
                Console.WriteLine($"Program běží, připojuji se na server: {srvIP}:{srvPort}");
                // Console.WriteLine($"6 + 7 = {obj.Sum(6,7)}"); // Zde program zhavaruje pokud = Server nebezi,spatna IP adr.,port nebo jmeno kanalu
                Console.WriteLine("Výsledek je: " + auth.Sum(6, 7));
                Console.ReadKey();

            }
            catch (XmlException e) { Console.WriteLine(e.Message); }
            catch (FileNotFoundException e) { Console.WriteLine(e.Message); }
            catch (System.NullReferenceException e) { Console.WriteLine(e.Message); }
            catch (System.FormatException e) { Console.WriteLine(e.Message); }
        }
    }
}
