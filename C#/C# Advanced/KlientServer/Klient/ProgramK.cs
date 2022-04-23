using SrvLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace Klient {
    internal class ProgramK {
        static void Main(string[] args) {
            int srvPort = 1234;
            string channelID = "channel1";
            IChannel channel = new TcpClientChannel(); // Interface poskytujici kanal - je lepsi tvorit promenou nadrazeneho typu ( kvuli zobecneni)
            ChannelServices.RegisterChannel(channel, false);  //zaregistruj kanál do pole kanálů 
                                                              //false: security vypnuto, ať se to pro začátek nekomplikuje
            string srvIP = "127.0.0.1";                       // testovani klienta na stejnem stroji jako Server 
            string srvAdr = "tcp://" + srvIP + ":" + srvPort + "/" + channelID; // Connection string
            SrvClass obj = (SrvClass)Activator.GetObject(typeof(SrvClass), srvAdr); // GetObject metoda vraci REFERENCI NA JIZ EXISTUJICI OBECNY OBJEKT ->
                                                                                    // Provede deserializaci objektu ktery zaslal(serializoval) server ... nutnost pretypovani
                                                                                    // GetObject vytvori objekt, podari se i kdyz server nebezi(vtom pripade vraci NULL)
            Console.WriteLine($"Client runs, connecting to server: {srvIP}:{srvPort}");
            Console.WriteLine($"6 + 7 = {obj.Sum(6,7)}"); // Zde program zhavaruje pokud = Server nebezi,spatna IP adr.,port nebo jmeno kanalu
            Console.ReadKey();
        }
    }
}
