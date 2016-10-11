using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary_Test
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
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
