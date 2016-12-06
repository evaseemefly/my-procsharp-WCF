using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using MathServiceLibrary;
using System.ServiceModel;

namespace MathWindowsService
{
    public partial class MyMathWinService : ServiceBase
    {
        //serviceHost类型的成员变量
        private ServiceHost myHost;

        public MyMathWinService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (myHost != null)
            {
                myHost.Close();
                myHost = null;
            }
            //创建宿主
            myHost = new ServiceHost(typeof(MathService));

            //创建代码中的abc
            Uri address = new Uri("http://localhost:8733/MathServiceLibrary");
            WSHttpBinding binding = new WSHttpBinding();
            Type contract = typeof(IBasicMath);

            //增加终结点
            myHost.AddServiceEndpoint(contract, binding, address);

            //打开宿主
            myHost.Open();

        }

        protected override void OnStop()
        {
            if (myHost != null)
            {
                myHost.Close();
            }
        }
    }
}
