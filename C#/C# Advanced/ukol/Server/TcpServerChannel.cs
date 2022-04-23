using System.Runtime.Remoting.Channels;

namespace Server
{
    internal class TcpServerChannel : IChannel
    {
        public TcpServerChannel(int srvPort)
        {
            SrvPort = srvPort;
        }

        public int SrvPort { get; }

        public int ChannelPriority => throw new System.NotImplementedException();

        public string ChannelName => throw new System.NotImplementedException();

        public string Parse(string url, out string objectURI)
        {
            throw new System.NotImplementedException();
        }
    }
}