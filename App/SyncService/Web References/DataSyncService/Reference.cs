﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.42000 版自动生成。
// 
#pragma warning disable 1591

namespace SyncService.DataSyncService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="DataSyncWSSoap", Namespace="http://tempuri.org/")]
    public partial class DataSyncWS : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetServerDateOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetSyncDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback UploadSyncDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback PT_ValidUserOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public DataSyncWS() {
            this.Url = global::SyncService.Properties.Settings.Default.SyncService_DataSyncService_DataSyncWS;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetServerDateCompletedEventHandler GetServerDateCompleted;
        
        /// <remarks/>
        public event GetSyncDataCompletedEventHandler GetSyncDataCompleted;
        
        /// <remarks/>
        public event UploadSyncDataCompletedEventHandler UploadSyncDataCompleted;
        
        /// <remarks/>
        public event PT_ValidUserCompletedEventHandler PT_ValidUserCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetServerDate", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetServerDate(string verify, int connFlag) {
            object[] results = this.Invoke("GetServerDate", new object[] {
                        verify,
                        connFlag});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetServerDateAsync(string verify, int connFlag) {
            this.GetServerDateAsync(verify, connFlag, null);
        }
        
        /// <remarks/>
        public void GetServerDateAsync(string verify, int connFlag, object userState) {
            if ((this.GetServerDateOperationCompleted == null)) {
                this.GetServerDateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetServerDateOperationCompleted);
            }
            this.InvokeAsync("GetServerDate", new object[] {
                        verify,
                        connFlag}, this.GetServerDateOperationCompleted, userState);
        }
        
        private void OnGetServerDateOperationCompleted(object arg) {
            if ((this.GetServerDateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetServerDateCompleted(this, new GetServerDateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetSyncData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] GetSyncData(string verify, AuthenticationPT auth, out string message) {
            object[] results = this.Invoke("GetSyncData", new object[] {
                        verify,
                        auth});
            message = ((string)(results[1]));
            return ((byte[])(results[0]));
        }
        
        /// <remarks/>
        public void GetSyncDataAsync(string verify, AuthenticationPT auth) {
            this.GetSyncDataAsync(verify, auth, null);
        }
        
        /// <remarks/>
        public void GetSyncDataAsync(string verify, AuthenticationPT auth, object userState) {
            if ((this.GetSyncDataOperationCompleted == null)) {
                this.GetSyncDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSyncDataOperationCompleted);
            }
            this.InvokeAsync("GetSyncData", new object[] {
                        verify,
                        auth}, this.GetSyncDataOperationCompleted, userState);
        }
        
        private void OnGetSyncDataOperationCompleted(object arg) {
            if ((this.GetSyncDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSyncDataCompleted(this, new GetSyncDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UploadSyncData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool UploadSyncData(string verify, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] xmldata, AuthenticationPT auth, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] out byte[] xmlerrordata, out string message) {
            object[] results = this.Invoke("UploadSyncData", new object[] {
                        verify,
                        xmldata,
                        auth});
            xmlerrordata = ((byte[])(results[1]));
            message = ((string)(results[2]));
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void UploadSyncDataAsync(string verify, byte[] xmldata, AuthenticationPT auth) {
            this.UploadSyncDataAsync(verify, xmldata, auth, null);
        }
        
        /// <remarks/>
        public void UploadSyncDataAsync(string verify, byte[] xmldata, AuthenticationPT auth, object userState) {
            if ((this.UploadSyncDataOperationCompleted == null)) {
                this.UploadSyncDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUploadSyncDataOperationCompleted);
            }
            this.InvokeAsync("UploadSyncData", new object[] {
                        verify,
                        xmldata,
                        auth}, this.UploadSyncDataOperationCompleted, userState);
        }
        
        private void OnUploadSyncDataOperationCompleted(object arg) {
            if ((this.UploadSyncDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UploadSyncDataCompleted(this, new UploadSyncDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/PT_ValidUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public AuthenticationPT PT_ValidUser(string verify, AuthenticationPT auth) {
            object[] results = this.Invoke("PT_ValidUser", new object[] {
                        verify,
                        auth});
            return ((AuthenticationPT)(results[0]));
        }
        
        /// <remarks/>
        public void PT_ValidUserAsync(string verify, AuthenticationPT auth) {
            this.PT_ValidUserAsync(verify, auth, null);
        }
        
        /// <remarks/>
        public void PT_ValidUserAsync(string verify, AuthenticationPT auth, object userState) {
            if ((this.PT_ValidUserOperationCompleted == null)) {
                this.PT_ValidUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPT_ValidUserOperationCompleted);
            }
            this.InvokeAsync("PT_ValidUser", new object[] {
                        verify,
                        auth}, this.PT_ValidUserOperationCompleted, userState);
        }
        
        private void OnPT_ValidUserOperationCompleted(object arg) {
            if ((this.PT_ValidUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PT_ValidUserCompleted(this, new PT_ValidUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class AuthenticationPT {
        
        private string platIdField;
        
        private string userIdField;
        
        private string userCodeField;
        
        private string orgIdField;
        
        private string orgNameField;
        
        private string passwordField;
        
        private string spare_1Field;
        
        private string spare_2Field;
        
        private string spare_3Field;
        
        private string spare_4Field;
        
        private string spare_5Field;
        
        /// <remarks/>
        public string PlatId {
            get {
                return this.platIdField;
            }
            set {
                this.platIdField = value;
            }
        }
        
        /// <remarks/>
        public string UserId {
            get {
                return this.userIdField;
            }
            set {
                this.userIdField = value;
            }
        }
        
        /// <remarks/>
        public string UserCode {
            get {
                return this.userCodeField;
            }
            set {
                this.userCodeField = value;
            }
        }
        
        /// <remarks/>
        public string OrgId {
            get {
                return this.orgIdField;
            }
            set {
                this.orgIdField = value;
            }
        }
        
        /// <remarks/>
        public string OrgName {
            get {
                return this.orgNameField;
            }
            set {
                this.orgNameField = value;
            }
        }
        
        /// <remarks/>
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        public string Spare_1 {
            get {
                return this.spare_1Field;
            }
            set {
                this.spare_1Field = value;
            }
        }
        
        /// <remarks/>
        public string Spare_2 {
            get {
                return this.spare_2Field;
            }
            set {
                this.spare_2Field = value;
            }
        }
        
        /// <remarks/>
        public string Spare_3 {
            get {
                return this.spare_3Field;
            }
            set {
                this.spare_3Field = value;
            }
        }
        
        /// <remarks/>
        public string Spare_4 {
            get {
                return this.spare_4Field;
            }
            set {
                this.spare_4Field = value;
            }
        }
        
        /// <remarks/>
        public string Spare_5 {
            get {
                return this.spare_5Field;
            }
            set {
                this.spare_5Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void GetServerDateCompletedEventHandler(object sender, GetServerDateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetServerDateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetServerDateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void GetSyncDataCompletedEventHandler(object sender, GetSyncDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSyncDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSyncDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public byte[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((byte[])(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string message {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void UploadSyncDataCompletedEventHandler(object sender, UploadSyncDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UploadSyncDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UploadSyncDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public byte[] xmlerrordata {
            get {
                this.RaiseExceptionIfNecessary();
                return ((byte[])(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string message {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void PT_ValidUserCompletedEventHandler(object sender, PT_ValidUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PT_ValidUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal PT_ValidUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public AuthenticationPT Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((AuthenticationPT)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591