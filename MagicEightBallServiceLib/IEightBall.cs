using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace MagicEightBallServiceLib
{
    [ServiceContract]
    public interface IEightBall
    {
        /// <summary>
        /// 问一个问题，获得答案
        /// </summary>
        /// <param name="userQuestion"></param>
        /// <returns></returns>
        [OperationContract]
        string ObtainAnswerToQuestion(string userQuestion);
    }
}
