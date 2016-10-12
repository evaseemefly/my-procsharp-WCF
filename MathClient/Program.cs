using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathClient.ServiceReference1;
using System.Threading;

namespace MathClient
{
    /// <summary>
    /// 从客户端异步调用服务
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****异步计算器********");

            using(BasicMathClient proxy=new BasicMathClient())
            {
                proxy.Open();

                IAsyncResult result = proxy.BeginAdd(2, 3, ar =>
                {
                    Console.WriteLine("2+3={0}", proxy.EndAdd(ar));
                }, null);

                while (!result.IsCompleted)
                {
                    Thread.Sleep(200);
                    Console.WriteLine("正在工作中");
                }
            }
            Console.ReadLine();
        }
    }
}
