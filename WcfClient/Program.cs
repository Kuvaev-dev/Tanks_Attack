using System;
using System.ServiceModel;
using WcfService1;

namespace WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Uri addr = new Uri("http://localhost:54565/Service1.svc");
                BasicHttpBinding basicHttp = new BasicHttpBinding();
                EndpointAddress endpoint = new EndpointAddress(addr);

                ChannelFactory<IService> channelFactory = new ChannelFactory<IService>(basicHttp, endpoint);
                IService channel = channelFactory.CreateChannel();

                Console.WriteLine(channel.GetData());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
