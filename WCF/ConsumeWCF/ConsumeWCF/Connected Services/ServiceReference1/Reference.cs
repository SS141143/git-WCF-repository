﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsumeWCF.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SayHello", ReplyAction="http://tempuri.org/IService1/SayHelloResponse")]
        string SayHello(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SayHello", ReplyAction="http://tempuri.org/IService1/SayHelloResponse")]
        System.Threading.Tasks.Task<string> SayHelloAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TodayProgram", ReplyAction="http://tempuri.org/IService1/TodayProgramResponse")]
        string TodayProgram(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TodayProgram", ReplyAction="http://tempuri.org/IService1/TodayProgramResponse")]
        System.Threading.Tasks.Task<string> TodayProgramAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ConsumeWCF.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ConsumeWCF.ServiceReference1.IService1>, ConsumeWCF.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SayHello(string name) {
            return base.Channel.SayHello(name);
        }
        
        public System.Threading.Tasks.Task<string> SayHelloAsync(string name) {
            return base.Channel.SayHelloAsync(name);
        }
        
        public string TodayProgram(string name) {
            return base.Channel.TodayProgram(name);
        }
        
        public System.Threading.Tasks.Task<string> TodayProgramAsync(string name) {
            return base.Channel.TodayProgramAsync(name);
        }
    }
}