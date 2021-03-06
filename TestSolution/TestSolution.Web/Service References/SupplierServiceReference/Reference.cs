﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestSolution.Web.SupplierServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Supplier", Namespace="http://schemas.datacontract.org/2004/07/WcfService2")]
    [System.SerializableAttribute()]
    public partial class Supplier : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NotesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SupplierIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SupplierNameField;
        
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
        public string ContactNumber {
            get {
                return this.ContactNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactNumberField, value) != true)) {
                    this.ContactNumberField = value;
                    this.RaisePropertyChanged("ContactNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Notes {
            get {
                return this.NotesField;
            }
            set {
                if ((object.ReferenceEquals(this.NotesField, value) != true)) {
                    this.NotesField = value;
                    this.RaisePropertyChanged("Notes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SupplierId {
            get {
                return this.SupplierIdField;
            }
            set {
                if ((this.SupplierIdField.Equals(value) != true)) {
                    this.SupplierIdField = value;
                    this.RaisePropertyChanged("SupplierId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SupplierName {
            get {
                return this.SupplierNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SupplierNameField, value) != true)) {
                    this.SupplierNameField = value;
                    this.RaisePropertyChanged("SupplierName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SupplierServiceReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSuppliers", ReplyAction="http://tempuri.org/IService1/GetSuppliersResponse")]
        TestSolution.Web.SupplierServiceReference.Supplier[] GetSuppliers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSuppliers", ReplyAction="http://tempuri.org/IService1/GetSuppliersResponse")]
        System.Threading.Tasks.Task<TestSolution.Web.SupplierServiceReference.Supplier[]> GetSuppliersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertSupplier", ReplyAction="http://tempuri.org/IService1/InsertSupplierResponse")]
        void InsertSupplier(TestSolution.Web.SupplierServiceReference.Supplier sObj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertSupplier", ReplyAction="http://tempuri.org/IService1/InsertSupplierResponse")]
        System.Threading.Tasks.Task InsertSupplierAsync(TestSolution.Web.SupplierServiceReference.Supplier sObj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateSupplier", ReplyAction="http://tempuri.org/IService1/UpdateSupplierResponse")]
        void UpdateSupplier(TestSolution.Web.SupplierServiceReference.Supplier sObj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateSupplier", ReplyAction="http://tempuri.org/IService1/UpdateSupplierResponse")]
        System.Threading.Tasks.Task UpdateSupplierAsync(TestSolution.Web.SupplierServiceReference.Supplier sObj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSupplier", ReplyAction="http://tempuri.org/IService1/GetSupplierResponse")]
        TestSolution.Web.SupplierServiceReference.Supplier GetSupplier(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSupplier", ReplyAction="http://tempuri.org/IService1/GetSupplierResponse")]
        System.Threading.Tasks.Task<TestSolution.Web.SupplierServiceReference.Supplier> GetSupplierAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteSupplier", ReplyAction="http://tempuri.org/IService1/DeleteSupplierResponse")]
        void DeleteSupplier(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteSupplier", ReplyAction="http://tempuri.org/IService1/DeleteSupplierResponse")]
        System.Threading.Tasks.Task DeleteSupplierAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : TestSolution.Web.SupplierServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<TestSolution.Web.SupplierServiceReference.IService1>, TestSolution.Web.SupplierServiceReference.IService1 {
        
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
        
        public TestSolution.Web.SupplierServiceReference.Supplier[] GetSuppliers() {
            return base.Channel.GetSuppliers();
        }
        
        public System.Threading.Tasks.Task<TestSolution.Web.SupplierServiceReference.Supplier[]> GetSuppliersAsync() {
            return base.Channel.GetSuppliersAsync();
        }
        
        public void InsertSupplier(TestSolution.Web.SupplierServiceReference.Supplier sObj) {
            base.Channel.InsertSupplier(sObj);
        }
        
        public System.Threading.Tasks.Task InsertSupplierAsync(TestSolution.Web.SupplierServiceReference.Supplier sObj) {
            return base.Channel.InsertSupplierAsync(sObj);
        }
        
        public void UpdateSupplier(TestSolution.Web.SupplierServiceReference.Supplier sObj) {
            base.Channel.UpdateSupplier(sObj);
        }
        
        public System.Threading.Tasks.Task UpdateSupplierAsync(TestSolution.Web.SupplierServiceReference.Supplier sObj) {
            return base.Channel.UpdateSupplierAsync(sObj);
        }
        
        public TestSolution.Web.SupplierServiceReference.Supplier GetSupplier(int id) {
            return base.Channel.GetSupplier(id);
        }
        
        public System.Threading.Tasks.Task<TestSolution.Web.SupplierServiceReference.Supplier> GetSupplierAsync(int id) {
            return base.Channel.GetSupplierAsync(id);
        }
        
        public void DeleteSupplier(int id) {
            base.Channel.DeleteSupplier(id);
        }
        
        public System.Threading.Tasks.Task DeleteSupplierAsync(int id) {
            return base.Channel.DeleteSupplierAsync(id);
        }
    }
}
