﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MagicEightBallServiceLib.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IEightBall")]
    public interface IEightBall {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEightBall/ObtainAnswerToQuestion", ReplyAction="http://tempuri.org/IEightBall/ObtainAnswerToQuestionResponse")]
        string ObtainAnswerToQuestion(string userQuestion);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEightBallChannel : MagicEightBallServiceLib.ServiceReference1.IEightBall, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EightBallClient : System.ServiceModel.ClientBase<MagicEightBallServiceLib.ServiceReference1.IEightBall>, MagicEightBallServiceLib.ServiceReference1.IEightBall {
        
        public EightBallClient() {
        }
        
        public EightBallClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EightBallClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EightBallClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EightBallClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ObtainAnswerToQuestion(string userQuestion) {
            return base.Channel.ObtainAnswerToQuestion(userQuestion);
        }
    }
}
