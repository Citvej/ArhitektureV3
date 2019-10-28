﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.WebServiceClient {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/ArhitektureV3")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool adminField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string surnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.WebServiceClient.userType typeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string usernameField;
        
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
        public bool admin {
            get {
                return this.adminField;
            }
            set {
                if ((this.adminField.Equals(value) != true)) {
                    this.adminField = value;
                    this.RaisePropertyChanged("admin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string surname {
            get {
                return this.surnameField;
            }
            set {
                if ((object.ReferenceEquals(this.surnameField, value) != true)) {
                    this.surnameField = value;
                    this.RaisePropertyChanged("surname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.WebServiceClient.userType type {
            get {
                return this.typeField;
            }
            set {
                if ((this.typeField.Equals(value) != true)) {
                    this.typeField = value;
                    this.RaisePropertyChanged("type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string username {
            get {
                return this.usernameField;
            }
            set {
                if ((object.ReferenceEquals(this.usernameField, value) != true)) {
                    this.usernameField = value;
                    this.RaisePropertyChanged("username");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="userType", Namespace="http://schemas.datacontract.org/2004/07/ArhitektureV3")]
    public enum userType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        referent = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        profesor = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        student = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/ArhitektureV3")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idStudentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.WebServiceClient.User userField;
        
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
        public string idStudent {
            get {
                return this.idStudentField;
            }
            set {
                if ((object.ReferenceEquals(this.idStudentField, value) != true)) {
                    this.idStudentField = value;
                    this.RaisePropertyChanged("idStudent");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.WebServiceClient.User user {
            get {
                return this.userField;
            }
            set {
                if ((object.ReferenceEquals(this.userField, value) != true)) {
                    this.userField = value;
                    this.RaisePropertyChanged("user");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Subject", Namespace="http://schemas.datacontract.org/2004/07/ArhitektureV3")]
    [System.SerializableAttribute()]
    public partial class Subject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idSubjectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.WebServiceClient.User izvajalecField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
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
        public int idSubject {
            get {
                return this.idSubjectField;
            }
            set {
                if ((this.idSubjectField.Equals(value) != true)) {
                    this.idSubjectField = value;
                    this.RaisePropertyChanged("idSubject");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.WebServiceClient.User izvajalec {
            get {
                return this.izvajalecField;
            }
            set {
                if ((object.ReferenceEquals(this.izvajalecField, value) != true)) {
                    this.izvajalecField = value;
                    this.RaisePropertyChanged("izvajalec");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebServiceClient.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        Client.WebServiceClient.User Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        System.Threading.Tasks.Task<Client.WebServiceClient.User> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudents", ReplyAction="http://tempuri.org/IService1/GetStudentsResponse")]
        Client.WebServiceClient.Student[] GetStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudents", ReplyAction="http://tempuri.org/IService1/GetStudentsResponse")]
        System.Threading.Tasks.Task<Client.WebServiceClient.Student[]> GetStudentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSubjects", ReplyAction="http://tempuri.org/IService1/GetSubjectsResponse")]
        Client.WebServiceClient.Subject[] GetSubjects();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSubjects", ReplyAction="http://tempuri.org/IService1/GetSubjectsResponse")]
        System.Threading.Tasks.Task<Client.WebServiceClient.Subject[]> GetSubjectsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudentsFromSubject", ReplyAction="http://tempuri.org/IService1/GetStudentsFromSubjectResponse")]
        Client.WebServiceClient.Student[] GetStudentsFromSubject(int idSubject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudentsFromSubject", ReplyAction="http://tempuri.org/IService1/GetStudentsFromSubjectResponse")]
        System.Threading.Tasks.Task<Client.WebServiceClient.Student[]> GetStudentsFromSubjectAsync(int idSubject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSubjectsFromStudent", ReplyAction="http://tempuri.org/IService1/GetSubjectsFromStudentResponse")]
        Client.WebServiceClient.Subject[] GetSubjectsFromStudent(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSubjectsFromStudent", ReplyAction="http://tempuri.org/IService1/GetSubjectsFromStudentResponse")]
        System.Threading.Tasks.Task<Client.WebServiceClient.Subject[]> GetSubjectsFromStudentAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudent", ReplyAction="http://tempuri.org/IService1/GetStudentResponse")]
        Client.WebServiceClient.Student GetStudent(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudent", ReplyAction="http://tempuri.org/IService1/GetStudentResponse")]
        System.Threading.Tasks.Task<Client.WebServiceClient.Student> GetStudentAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBiggestSubject", ReplyAction="http://tempuri.org/IService1/GetBiggestSubjectResponse")]
        Client.WebServiceClient.Student GetBiggestSubject();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBiggestSubject", ReplyAction="http://tempuri.org/IService1/GetBiggestSubjectResponse")]
        System.Threading.Tasks.Task<Client.WebServiceClient.Student> GetBiggestSubjectAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetLongestName", ReplyAction="http://tempuri.org/IService1/GetLongestNameResponse")]
        Client.WebServiceClient.User GetLongestName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetLongestName", ReplyAction="http://tempuri.org/IService1/GetLongestNameResponse")]
        System.Threading.Tasks.Task<Client.WebServiceClient.User> GetLongestNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAverageNameLength", ReplyAction="http://tempuri.org/IService1/GetAverageNameLengthResponse")]
        float GetAverageNameLength();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAverageNameLength", ReplyAction="http://tempuri.org/IService1/GetAverageNameLengthResponse")]
        System.Threading.Tasks.Task<float> GetAverageNameLengthAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Client.WebServiceClient.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Client.WebServiceClient.IService1>, Client.WebServiceClient.IService1 {
        
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
        
        public Client.WebServiceClient.User Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<Client.WebServiceClient.User> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public Client.WebServiceClient.Student[] GetStudents() {
            return base.Channel.GetStudents();
        }
        
        public System.Threading.Tasks.Task<Client.WebServiceClient.Student[]> GetStudentsAsync() {
            return base.Channel.GetStudentsAsync();
        }
        
        public Client.WebServiceClient.Subject[] GetSubjects() {
            return base.Channel.GetSubjects();
        }
        
        public System.Threading.Tasks.Task<Client.WebServiceClient.Subject[]> GetSubjectsAsync() {
            return base.Channel.GetSubjectsAsync();
        }
        
        public Client.WebServiceClient.Student[] GetStudentsFromSubject(int idSubject) {
            return base.Channel.GetStudentsFromSubject(idSubject);
        }
        
        public System.Threading.Tasks.Task<Client.WebServiceClient.Student[]> GetStudentsFromSubjectAsync(int idSubject) {
            return base.Channel.GetStudentsFromSubjectAsync(idSubject);
        }
        
        public Client.WebServiceClient.Subject[] GetSubjectsFromStudent(int id) {
            return base.Channel.GetSubjectsFromStudent(id);
        }
        
        public System.Threading.Tasks.Task<Client.WebServiceClient.Subject[]> GetSubjectsFromStudentAsync(int id) {
            return base.Channel.GetSubjectsFromStudentAsync(id);
        }
        
        public Client.WebServiceClient.Student GetStudent(string id) {
            return base.Channel.GetStudent(id);
        }
        
        public System.Threading.Tasks.Task<Client.WebServiceClient.Student> GetStudentAsync(string id) {
            return base.Channel.GetStudentAsync(id);
        }
        
        public Client.WebServiceClient.Student GetBiggestSubject() {
            return base.Channel.GetBiggestSubject();
        }
        
        public System.Threading.Tasks.Task<Client.WebServiceClient.Student> GetBiggestSubjectAsync() {
            return base.Channel.GetBiggestSubjectAsync();
        }
        
        public Client.WebServiceClient.User GetLongestName() {
            return base.Channel.GetLongestName();
        }
        
        public System.Threading.Tasks.Task<Client.WebServiceClient.User> GetLongestNameAsync() {
            return base.Channel.GetLongestNameAsync();
        }
        
        public float GetAverageNameLength() {
            return base.Channel.GetAverageNameLength();
        }
        
        public System.Threading.Tasks.Task<float> GetAverageNameLengthAsync() {
            return base.Channel.GetAverageNameLengthAsync();
        }
    }
}
