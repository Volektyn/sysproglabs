﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace useHTTP.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/plutoniy")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        useHTTP.ServiceReference1.CompositeType GetDataUsingDataContract(useHTTP.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<useHTTP.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(useHTTP.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsLoginFree", ReplyAction="http://tempuri.org/IService1/IsLoginFreeResponse")]
        bool IsLoginFree(string user_login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsLoginFree", ReplyAction="http://tempuri.org/IService1/IsLoginFreeResponse")]
        System.Threading.Tasks.Task<bool> IsLoginFreeAsync(string user_login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/MyIPAddress", ReplyAction="http://tempuri.org/IService1/MyIPAddressResponse")]
        string MyIPAddress();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/MyIPAddress", ReplyAction="http://tempuri.org/IService1/MyIPAddressResponse")]
        System.Threading.Tasks.Task<string> MyIPAddressAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ServerTime", ReplyAction="http://tempuri.org/IService1/ServerTimeResponse")]
        string ServerTime(string Format);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ServerTime", ReplyAction="http://tempuri.org/IService1/ServerTimeResponse")]
        System.Threading.Tasks.Task<string> ServerTimeAsync(string Format);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HeaterStopReason", ReplyAction="http://tempuri.org/IService1/HeaterStopReasonResponse")]
        string HeaterStopReason(int N);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HeaterStopReason", ReplyAction="http://tempuri.org/IService1/HeaterStopReasonResponse")]
        System.Threading.Tasks.Task<string> HeaterStopReasonAsync(int N);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HeaterStatus", ReplyAction="http://tempuri.org/IService1/HeaterStatusResponse")]
        string HeaterStatus(int N);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HeaterStatus", ReplyAction="http://tempuri.org/IService1/HeaterStatusResponse")]
        System.Threading.Tasks.Task<string> HeaterStatusAsync(int N);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HeaterStopDate", ReplyAction="http://tempuri.org/IService1/HeaterStopDateResponse")]
        string HeaterStopDate(int N);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HeaterStopDate", ReplyAction="http://tempuri.org/IService1/HeaterStopDateResponse")]
        System.Threading.Tasks.Task<string> HeaterStopDateAsync(int N);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : useHTTP.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<useHTTP.ServiceReference1.IService1>, useHTTP.ServiceReference1.IService1 {
        
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
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public useHTTP.ServiceReference1.CompositeType GetDataUsingDataContract(useHTTP.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<useHTTP.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(useHTTP.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public bool IsLoginFree(string user_login) {
            return base.Channel.IsLoginFree(user_login);
        }
        
        public System.Threading.Tasks.Task<bool> IsLoginFreeAsync(string user_login) {
            return base.Channel.IsLoginFreeAsync(user_login);
        }
        
        public string MyIPAddress() {
            return base.Channel.MyIPAddress();
        }
        
        public System.Threading.Tasks.Task<string> MyIPAddressAsync() {
            return base.Channel.MyIPAddressAsync();
        }
        
        public string ServerTime(string Format) {
            return base.Channel.ServerTime(Format);
        }
        
        public System.Threading.Tasks.Task<string> ServerTimeAsync(string Format) {
            return base.Channel.ServerTimeAsync(Format);
        }
        
        public string HeaterStopReason(int N) {
            return base.Channel.HeaterStopReason(N);
        }
        
        public System.Threading.Tasks.Task<string> HeaterStopReasonAsync(int N) {
            return base.Channel.HeaterStopReasonAsync(N);
        }
        
        public string HeaterStatus(int N) {
            return base.Channel.HeaterStatus(N);
        }
        
        public System.Threading.Tasks.Task<string> HeaterStatusAsync(int N) {
            return base.Channel.HeaterStatusAsync(N);
        }
        
        public string HeaterStopDate(int N) {
            return base.Channel.HeaterStopDate(N);
        }
        
        public System.Threading.Tasks.Task<string> HeaterStopDateAsync(int N) {
            return base.Channel.HeaterStopDateAsync(N);
        }
    }
}
