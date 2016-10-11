using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MagicEightBallServiceClient.ServiceReference1;

namespace MagicEightBallServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******ask the magic 8 ball******\n");
            using(EightBallClient ball=new EightBallClient())
            {
                Console.WriteLine("输入你的问题");
                string question = Console.ReadLine();

                string answer = ball.ObtainAnswerToQuestion(question);
                Console.WriteLine("8-Ball says:{0}", answer);
            }
            Console.ReadLine();
        }
    }
}
