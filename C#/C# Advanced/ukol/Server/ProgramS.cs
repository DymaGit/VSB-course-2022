using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using SrvLib;
namespace Server
{
    public class ProgramS
    { //start serveru
        public static void Main()
        {
            int srvPort = 1234;
            string channelID = " channel1 "; //na 1 portu může běžet souč.více kanálů,musí se

            //odlišit, říká se tomu URI (URL identifikátor)
            IChannel channel = new TcpServerChannel(srvPort); // vytvor novy komunikacni kanal
                                                  // TcpServerCh. dědí z IChannel
            ChannelServices.RegisterChannel(channel, false); //zaregistruj kanál do pole kanálů
                                                             //false: security vypnuto, ať se to pro začátek nekomplikuje
            SrvClass obj = new SrvClass();//budouci vzdálený objekt, poskytovaný klientům
            RemotingServices.Marshal(obj, channelID); //metoda Marshal poskytne
                                                      // předtím vytvořený objekt s názvem obj klientovi pod id channelID.
                                                      // První parametr metody musí být objekt třídy MarshalByRefObject,
                                                      // proto musí třída SrvClass (v další verzi srvInit) z této
                                                      //třídy dědit
            Console.WriteLine(" server bezi na portu: " +srvPort);
            while (true) { System.Threading.Thread.Sleep(1000); } //aby program hned neskončil.
        } //Sleep proto, aby nebyl procesor vytížen na 100 %
    }
}