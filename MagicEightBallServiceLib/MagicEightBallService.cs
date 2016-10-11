using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicEightBallServiceLib
{
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
