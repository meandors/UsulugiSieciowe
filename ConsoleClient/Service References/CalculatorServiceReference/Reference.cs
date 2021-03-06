﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleClient.CalculatorServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Complex", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class Complex : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double _imagField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double _realField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double _imag {
            get {
                return this._imagField;
            }
            set {
                if ((this._imagField.Equals(value) != true)) {
                    this._imagField = value;
                    this.RaisePropertyChanged("_imag");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double _real {
            get {
                return this._realField;
            }
            set {
                if ((this._realField.Equals(value) != true)) {
                    this._realField = value;
                    this.RaisePropertyChanged("_real");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculatorServiceReference.ICalc")]
    public interface ICalc {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/Add", ReplyAction="http://tempuri.org/ICalc/AddResponse")]
        double Add(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/Add", ReplyAction="http://tempuri.org/ICalc/AddResponse")]
        System.Threading.Tasks.Task<double> AddAsync(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/Sub", ReplyAction="http://tempuri.org/ICalc/SubResponse")]
        double Sub(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/Sub", ReplyAction="http://tempuri.org/ICalc/SubResponse")]
        System.Threading.Tasks.Task<double> SubAsync(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/Mult", ReplyAction="http://tempuri.org/ICalc/MultResponse")]
        double Mult(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/Mult", ReplyAction="http://tempuri.org/ICalc/MultResponse")]
        System.Threading.Tasks.Task<double> MultAsync(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/Div", ReplyAction="http://tempuri.org/ICalc/DivResponse")]
        double Div(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/Div", ReplyAction="http://tempuri.org/ICalc/DivResponse")]
        System.Threading.Tasks.Task<double> DivAsync(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/ComplexAdd", ReplyAction="http://tempuri.org/ICalc/ComplexAddResponse")]
        ConsoleClient.CalculatorServiceReference.Complex ComplexAdd(ConsoleClient.CalculatorServiceReference.Complex n1, ConsoleClient.CalculatorServiceReference.Complex n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/ComplexAdd", ReplyAction="http://tempuri.org/ICalc/ComplexAddResponse")]
        System.Threading.Tasks.Task<ConsoleClient.CalculatorServiceReference.Complex> ComplexAddAsync(ConsoleClient.CalculatorServiceReference.Complex n1, ConsoleClient.CalculatorServiceReference.Complex n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/ComplexSub", ReplyAction="http://tempuri.org/ICalc/ComplexSubResponse")]
        ConsoleClient.CalculatorServiceReference.Complex ComplexSub(ConsoleClient.CalculatorServiceReference.Complex n1, ConsoleClient.CalculatorServiceReference.Complex n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/ComplexSub", ReplyAction="http://tempuri.org/ICalc/ComplexSubResponse")]
        System.Threading.Tasks.Task<ConsoleClient.CalculatorServiceReference.Complex> ComplexSubAsync(ConsoleClient.CalculatorServiceReference.Complex n1, ConsoleClient.CalculatorServiceReference.Complex n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/ComplexMult", ReplyAction="http://tempuri.org/ICalc/ComplexMultResponse")]
        ConsoleClient.CalculatorServiceReference.Complex ComplexMult(ConsoleClient.CalculatorServiceReference.Complex n1, ConsoleClient.CalculatorServiceReference.Complex n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/ComplexMult", ReplyAction="http://tempuri.org/ICalc/ComplexMultResponse")]
        System.Threading.Tasks.Task<ConsoleClient.CalculatorServiceReference.Complex> ComplexMultAsync(ConsoleClient.CalculatorServiceReference.Complex n1, ConsoleClient.CalculatorServiceReference.Complex n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/ComplexDiv", ReplyAction="http://tempuri.org/ICalc/ComplexDivResponse")]
        ConsoleClient.CalculatorServiceReference.Complex ComplexDiv(ConsoleClient.CalculatorServiceReference.Complex n1, ConsoleClient.CalculatorServiceReference.Complex n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/ComplexDiv", ReplyAction="http://tempuri.org/ICalc/ComplexDivResponse")]
        System.Threading.Tasks.Task<ConsoleClient.CalculatorServiceReference.Complex> ComplexDivAsync(ConsoleClient.CalculatorServiceReference.Complex n1, ConsoleClient.CalculatorServiceReference.Complex n2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalcChannel : ConsoleClient.CalculatorServiceReference.ICalc, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalcClient : System.ServiceModel.ClientBase<ConsoleClient.CalculatorServiceReference.ICalc>, ConsoleClient.CalculatorServiceReference.ICalc {
        
        public CalcClient() {
        }
        
        public CalcClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalcClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Add(double number1, double number2) {
            return base.Channel.Add(number1, number2);
        }
        
        public System.Threading.Tasks.Task<double> AddAsync(double number1, double number2) {
            return base.Channel.AddAsync(number1, number2);
        }
        
        public double Sub(double number1, double number2) {
            return base.Channel.Sub(number1, number2);
        }
        
        public System.Threading.Tasks.Task<double> SubAsync(double number1, double number2) {
            return base.Channel.SubAsync(number1, number2);
        }
        
        public double Mult(double number1, double number2) {
            return base.Channel.Mult(number1, number2);
        }
        
        public System.Threading.Tasks.Task<double> MultAsync(double number1, double number2) {
            return base.Channel.MultAsync(number1, number2);
        }
        
        public double Div(double number1, double number2) {
            return base.Channel.Div(number1, number2);
        }
        
        public System.Threading.Tasks.Task<double> DivAsync(double number1, double number2) {
            return base.Channel.DivAsync(number1, number2);
        }
        
        public ConsoleClient.CalculatorServiceReference.Complex ComplexAdd(ConsoleClient.CalculatorServiceReference.Complex n1, ConsoleClient.CalculatorServiceReference.Complex n2) {
            return base.Channel.ComplexAdd(n1, n2);
        }
        
        public System.Threading.Tasks.Task<ConsoleClient.CalculatorServiceReference.Complex> ComplexAddAsync(ConsoleClient.CalculatorServiceReference.Complex n1, ConsoleClient.CalculatorServiceReference.Complex n2) {
            return base.Channel.ComplexAddAsync(n1, n2);
        }
        
        public ConsoleClient.CalculatorServiceReference.Complex ComplexSub(ConsoleClient.CalculatorServiceReference.Complex n1, ConsoleClient.CalculatorServiceReference.Complex n2) {
            return base.Channel.ComplexSub(n1, n2);
        }
        
        public System.Threading.Tasks.Task<ConsoleClient.CalculatorServiceReference.Complex> ComplexSubAsync(ConsoleClient.CalculatorServiceReference.Complex n1, ConsoleClient.CalculatorServiceReference.Complex n2) {
            return base.Channel.ComplexSubAsync(n1, n2);
        }
        
        public ConsoleClient.CalculatorServiceReference.Complex ComplexMult(ConsoleClient.CalculatorServiceReference.Complex n1, ConsoleClient.CalculatorServiceReference.Complex n2) {
            return base.Channel.ComplexMult(n1, n2);
        }
        
        public System.Threading.Tasks.Task<ConsoleClient.CalculatorServiceReference.Complex> ComplexMultAsync(ConsoleClient.CalculatorServiceReference.Complex n1, ConsoleClient.CalculatorServiceReference.Complex n2) {
            return base.Channel.ComplexMultAsync(n1, n2);
        }
        
        public ConsoleClient.CalculatorServiceReference.Complex ComplexDiv(ConsoleClient.CalculatorServiceReference.Complex n1, ConsoleClient.CalculatorServiceReference.Complex n2) {
            return base.Channel.ComplexDiv(n1, n2);
        }
        
        public System.Threading.Tasks.Task<ConsoleClient.CalculatorServiceReference.Complex> ComplexDivAsync(ConsoleClient.CalculatorServiceReference.Complex n1, ConsoleClient.CalculatorServiceReference.Complex n2) {
            return base.Channel.ComplexDivAsync(n1, n2);
        }
    }
}
