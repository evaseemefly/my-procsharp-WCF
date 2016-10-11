using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using WcfServiceLibrary_Test;

namespace MagicEightBallServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
           

           
            using (ServiceHost serviceHost = new ServiceHost(typeof(WcfServiceLibrary_Test.MagicEightBallService)))
            {
                //打开宿主并启动对传入消息的监听
                serviceHost.Open();
                DisplayHostInfo(serviceHost);

                Console.WriteLine("服务已准备好");

                Console.WriteLine("");

                Console.ReadLine();
            }
        
           
        }

        static void DisplayHostInfo(ServiceHost host)
        {
            Console.WriteLine();
            Console.WriteLine("******Host Info*****");

            foreach (System.ServiceModel.Description.ServiceEndpoint item in host.Description.Endpoints)
            {
                Console.WriteLine("address:{0}",item.Address);
                Console.WriteLine("Binding:{0}",item.Binding.Name);
                Console.WriteLine("Contract:{0}",item.Contract.Name);
                Console.WriteLine();
            }

            Console.WriteLine("**********************");

        }
    }
}
