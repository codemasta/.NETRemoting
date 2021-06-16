using Remoting.Model;
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Remoting
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel tcpChannel = new TcpChannel(5050);
            ChannelServices.RegisterChannel(tcpChannel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Weather), 
                "weather", WellKnownObjectMode.Singleton);
            Console.Write("Server is ready to communicate..........");
            Console.Read();
        }
    }
}
