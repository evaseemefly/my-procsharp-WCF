using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary_Test
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    public class MagicEightBallService : IEightBall
    {

        public MagicEightBallService()
        {
            Console.WriteLine("等待你的提问...");
        }

        public string ObtainAnswerToQuestion(string userQuestion)
        {
            string[] answers = { "Future Uncertain", "yes", "no" };

            Random r = new Random();
            return answers[r.Next(answers.Length)];
        }
    }
}
