using SrvLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace Klient {
    internal class ProgramKexc {
        static void Main(string[] args) {
            int srvPort = 1234;
            string channelID = "channel1";
            bool connectionOK = false;
            IChannel channel = new TcpClientChannel(); // Interface poskytujici kanal - je lepsi tvorit promenou nadrazeneho typu ( kvuli zobecneni)
            ChannelServices.RegisterChannel(channel, false);  //zaregistruj kanál do pole kanálů 
                                                              //false: security vypnuto, ať se to pro začátek nekomplikuje
            string srvIP = "127.0.0.1";                       // testovani klienta na stejnem stroji jako Server 
            string srvAdr = "tcp://" + srvIP + ":" + srvPort + "/" + channelID; // Connection string
            string jmeno = "Agent W4C";
            string heslo = "abraka dabra";
            SrvAuth objAut = new SrvAuth();

            while (connectionOK == false) {
                try {
                    SrvInit obj = (SrvInit)Activator.GetObject(typeof(SrvInit), srvAdr); // GetObject metoda vraci REFERENCI NA JIZ EXISTUJICI OBECNY OBJEKT ->
                                                                                         //SrvInit autorizace = new SrvInit();                                                                        // Provede deserializaci objektu ktery zaslal(serializoval) server ... nutnost pretypovani

                    //autorizace.authorize("abcd","123"); 
                    //obj.authorize(jmeno, heslo);
                    obj.authorize(obj.GetType().Name, heslo);
                    objAut = obj.authorize(jmeno, heslo);
                    Console.WriteLine("přihlásil se uživatel " + jmeno + "s heslem " + heslo);

                    // GetObject vytvori objekt, podari se i kdyz server nebezi(vtom pripade vraci NULL)
                    Console.WriteLine($"Program běží, připojuji se na server: {srvIP}:{srvPort}");

                    connectionOK = true;
                }
                catch (System.Net.Sockets.SocketException) {
                    Console.Write(".");
                    //System.Threading.Thread.Sleep(1000);
                }
            }

            int a;
            int b;

            try {

                if (objAut != null) {
                    do {
                        Console.Write("zadej a: ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("zadej b: ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Výsledek je: " + objAut.Sum(a, b));
                    } while (a != 0);
                }

                else
                    Console.WriteLine("Špatné přihlašovací údaje");
            }
            catch (System.Net.Sockets.SocketException e) { Console.WriteLine(e.Message); }





            //try {
            //    Console.WriteLine("Výsledek je: " + objAut.Sum(6, 7));
            //}
            //catch { Console.WriteLine("Špatné přihlašovací údaje"); }


            // Console.WriteLine($"6 + 7 = {obj.Sum(6,7)}"); // Zde program zhavaruje pokud = Server nebezi,spatna IP adr.,port nebo jmeno kanalu

            Console.ReadKey();
        }
    }
}
