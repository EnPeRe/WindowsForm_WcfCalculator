﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsForm_WcfCalculator.ReferenciaWeb {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReferenciaWeb.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Sum", ReplyAction="http://tempuri.org/IService1/SumResponse")]
        int Sum(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Sum", ReplyAction="http://tempuri.org/IService1/SumResponse")]
        System.Threading.Tasks.Task<int> SumAsync(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Substract", ReplyAction="http://tempuri.org/IService1/SubstractResponse")]
        int Substract(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Substract", ReplyAction="http://tempuri.org/IService1/SubstractResponse")]
        System.Threading.Tasks.Task<int> SubstractAsync(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Multiply", ReplyAction="http://tempuri.org/IService1/MultiplyResponse")]
        int Multiply(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Multiply", ReplyAction="http://tempuri.org/IService1/MultiplyResponse")]
        System.Threading.Tasks.Task<int> MultiplyAsync(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Divide", ReplyAction="http://tempuri.org/IService1/DivideResponse")]
        int Divide(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Divide", ReplyAction="http://tempuri.org/IService1/DivideResponse")]
        System.Threading.Tasks.Task<int> DivideAsync(int num1, int num2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WindowsForm_WcfCalculator.ReferenciaWeb.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WindowsForm_WcfCalculator.ReferenciaWeb.IService1>, WindowsForm_WcfCalculator.ReferenciaWeb.IService1 {
        
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
        
        public int Sum(int num1, int num2) {
            return base.Channel.Sum(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> SumAsync(int num1, int num2) {
            return base.Channel.SumAsync(num1, num2);
        }
        
        public int Substract(int num1, int num2) {
            return base.Channel.Substract(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> SubstractAsync(int num1, int num2) {
            return base.Channel.SubstractAsync(num1, num2);
        }
        
        public int Multiply(int num1, int num2) {
            return base.Channel.Multiply(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> MultiplyAsync(int num1, int num2) {
            return base.Channel.MultiplyAsync(num1, num2);
        }
        
        public int Divide(int num1, int num2) {
            return base.Channel.Divide(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> DivideAsync(int num1, int num2) {
            return base.Channel.DivideAsync(num1, num2);
        }
    }
}
