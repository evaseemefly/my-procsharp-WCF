using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MathServiceLibrary;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace MathWindowsServiceHost
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    public class MathWinService:ServiceHostBase
    {
        /// <summary>
        /// 提供服务的主机
        /// </summary>
        private ServiceHost myHost;

        public MathWinService()
        {
            InitializeRuntime();
        }

        

        public int Add(int x, int y)
        {
            //模拟长请求
            System.Threading.Thread.Sleep(5000);
            return x + y;
        }

        protected override ServiceDescription CreateDescription(out IDictionary<string, ContractDescription> implementedContracts)
        {
            throw new NotImplementedException();
        }
    }
}
