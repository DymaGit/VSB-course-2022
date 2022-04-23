using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using SrvLib;
namespace KlientServer
{
    internal class ProgramK
    {
        static void Main(string[] args)
        {
            int srvPort = 1234;
            string channelID = "channel1";
            IChannel channel = new TcpClientChannel();
            ChannelServices.RegisterChannel(channel, false);
            string srvIP = "127.0.0.1";
            string srvAdr = "tcp://" + srvIP + ":" + srvPort + "/" + channelID;

            SrvClass obj = (SrvClass)Activator.GetObject(typeof(SrvClass), srvAdr);
            Console.WriteLine("klient bezi, pripojuje se na server: " + srvIP + ":" + srvPort);
            Console.WriteLine("6 + 7  = " +(obj.sum(6, 7)));
            Console.ReadKey();

         


        }
    }
}
