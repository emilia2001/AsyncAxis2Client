﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AsyncAxis2Client.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://axis2server.services.com", ConfigurationName="ServiceReference2.TextFileContentRetrieverPortType")]
    public interface TextFileContentRetrieverPortType {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:test", ReplyAction="urn:testResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        AsyncAxis2Client.ServiceReference2.testResponse test(AsyncAxis2Client.ServiceReference2.testRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:test", ReplyAction="urn:testResponse")]
        System.IAsyncResult Begintest(AsyncAxis2Client.ServiceReference2.testRequest request, System.AsyncCallback callback, object asyncState);
        
        AsyncAxis2Client.ServiceReference2.testResponse Endtest(System.IAsyncResult result);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:retrieveTextFileContent", ReplyAction="urn:retrieveTextFileContentResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        AsyncAxis2Client.ServiceReference2.retrieveTextFileContentResponse retrieveTextFileContent(AsyncAxis2Client.ServiceReference2.retrieveTextFileContentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:retrieveTextFileContent", ReplyAction="urn:retrieveTextFileContentResponse")]
        System.IAsyncResult BeginretrieveTextFileContent(AsyncAxis2Client.ServiceReference2.retrieveTextFileContentRequest request, System.AsyncCallback callback, object asyncState);
        
        AsyncAxis2Client.ServiceReference2.retrieveTextFileContentResponse EndretrieveTextFileContent(System.IAsyncResult result);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="test", WrapperNamespace="http://axis2server.services.com", IsWrapped=true)]
    public partial class testRequest {
        
        public testRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="testResponse", WrapperNamespace="http://axis2server.services.com", IsWrapped=true)]
    public partial class testResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://axis2server.services.com", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string @return;
        
        public testResponse() {
        }
        
        public testResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="retrieveTextFileContent", WrapperNamespace="http://axis2server.services.com", IsWrapped=true)]
    public partial class retrieveTextFileContentRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://axis2server.services.com", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string path;
        
        public retrieveTextFileContentRequest() {
        }
        
        public retrieveTextFileContentRequest(string path) {
            this.path = path;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="retrieveTextFileContentResponse", WrapperNamespace="http://axis2server.services.com", IsWrapped=true)]
    public partial class retrieveTextFileContentResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://axis2server.services.com", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string @return;
        
        public retrieveTextFileContentResponse() {
        }
        
        public retrieveTextFileContentResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TextFileContentRetrieverPortTypeChannel : AsyncAxis2Client.ServiceReference2.TextFileContentRetrieverPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class testCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public testCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class retrieveTextFileContentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public retrieveTextFileContentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TextFileContentRetrieverPortTypeClient : System.ServiceModel.ClientBase<AsyncAxis2Client.ServiceReference2.TextFileContentRetrieverPortType>, AsyncAxis2Client.ServiceReference2.TextFileContentRetrieverPortType {
        
        private BeginOperationDelegate onBegintestDelegate;
        
        private EndOperationDelegate onEndtestDelegate;
        
        private System.Threading.SendOrPostCallback ontestCompletedDelegate;
        
        private BeginOperationDelegate onBeginretrieveTextFileContentDelegate;
        
        private EndOperationDelegate onEndretrieveTextFileContentDelegate;
        
        private System.Threading.SendOrPostCallback onretrieveTextFileContentCompletedDelegate;
        
        public TextFileContentRetrieverPortTypeClient() {
        }
        
        public TextFileContentRetrieverPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TextFileContentRetrieverPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TextFileContentRetrieverPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TextFileContentRetrieverPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<testCompletedEventArgs> testCompleted;
        
        public event System.EventHandler<retrieveTextFileContentCompletedEventArgs> retrieveTextFileContentCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AsyncAxis2Client.ServiceReference2.testResponse AsyncAxis2Client.ServiceReference2.TextFileContentRetrieverPortType.test(AsyncAxis2Client.ServiceReference2.testRequest request) {
            return base.Channel.test(request);
        }
        
        public string test() {
            AsyncAxis2Client.ServiceReference2.testRequest inValue = new AsyncAxis2Client.ServiceReference2.testRequest();
            AsyncAxis2Client.ServiceReference2.testResponse retVal = ((AsyncAxis2Client.ServiceReference2.TextFileContentRetrieverPortType)(this)).test(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult AsyncAxis2Client.ServiceReference2.TextFileContentRetrieverPortType.Begintest(AsyncAxis2Client.ServiceReference2.testRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.Begintest(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult Begintest(System.AsyncCallback callback, object asyncState) {
            AsyncAxis2Client.ServiceReference2.testRequest inValue = new AsyncAxis2Client.ServiceReference2.testRequest();
            return ((AsyncAxis2Client.ServiceReference2.TextFileContentRetrieverPortType)(this)).Begintest(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AsyncAxis2Client.ServiceReference2.testResponse AsyncAxis2Client.ServiceReference2.TextFileContentRetrieverPortType.Endtest(System.IAsyncResult result) {
            return base.Channel.Endtest(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string Endtest(System.IAsyncResult result) {
            AsyncAxis2Client.ServiceReference2.testResponse retVal = ((AsyncAxis2Client.ServiceReference2.TextFileContentRetrieverPortType)(this)).Endtest(result);
            return retVal.@return;
        }
        
        private System.IAsyncResult OnBegintest(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.Begintest(callback, asyncState);
        }
        
        private object[] OnEndtest(System.IAsyncResult result) {
            string retVal = this.Endtest(result);
            return new object[] {
                    retVal};
        }
        
        private void OntestCompleted(object state) {
            if ((this.testCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.testCompleted(this, new testCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void testAsync() {
            this.testAsync(null);
        }
        
        public void testAsync(object userState) {
            if ((this.onBegintestDelegate == null)) {
                this.onBegintestDelegate = new BeginOperationDelegate(this.OnBegintest);
            }
            if ((this.onEndtestDelegate == null)) {
                this.onEndtestDelegate = new EndOperationDelegate(this.OnEndtest);
            }
            if ((this.ontestCompletedDelegate == null)) {
                this.ontestCompletedDelegate = new System.Threading.SendOrPostCallback(this.OntestCompleted);
            }
            base.InvokeAsync(this.onBegintestDelegate, null, this.onEndtestDelegate, this.ontestCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AsyncAxis2Client.ServiceReference2.retrieveTextFileContentResponse AsyncAxis2Client.ServiceReference2.TextFileContentRetrieverPortType.retrieveTextFileContent(AsyncAxis2Client.ServiceReference2.retrieveTextFileContentRequest request) {
            return base.Channel.retrieveTextFileContent(request);
        }
        
        public string retrieveTextFileContent(string path) {
            AsyncAxis2Client.ServiceReference2.retrieveTextFileContentRequest inValue = new AsyncAxis2Client.ServiceReference2.retrieveTextFileContentRequest();
            inValue.path = path;
            AsyncAxis2Client.ServiceReference2.retrieveTextFileContentResponse retVal = ((AsyncAxis2Client.ServiceReference2.TextFileContentRetrieverPortType)(this)).retrieveTextFileContent(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult AsyncAxis2Client.ServiceReference2.TextFileContentRetrieverPortType.BeginretrieveTextFileContent(AsyncAxis2Client.ServiceReference2.retrieveTextFileContentRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginretrieveTextFileContent(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginretrieveTextFileContent(string path, System.AsyncCallback callback, object asyncState) {
            AsyncAxis2Client.ServiceReference2.retrieveTextFileContentRequest inValue = new AsyncAxis2Client.ServiceReference2.retrieveTextFileContentRequest();
            inValue.path = path;
            return ((AsyncAxis2Client.ServiceReference2.TextFileContentRetrieverPortType)(this)).BeginretrieveTextFileContent(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AsyncAxis2Client.ServiceReference2.retrieveTextFileContentResponse AsyncAxis2Client.ServiceReference2.TextFileContentRetrieverPortType.EndretrieveTextFileContent(System.IAsyncResult result) {
            return base.Channel.EndretrieveTextFileContent(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndretrieveTextFileContent(System.IAsyncResult result) {
            AsyncAxis2Client.ServiceReference2.retrieveTextFileContentResponse retVal = ((AsyncAxis2Client.ServiceReference2.TextFileContentRetrieverPortType)(this)).EndretrieveTextFileContent(result);
            return retVal.@return;
        }
        
        private System.IAsyncResult OnBeginretrieveTextFileContent(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string path = ((string)(inValues[0]));
            return this.BeginretrieveTextFileContent(path, callback, asyncState);
        }
        
        private object[] OnEndretrieveTextFileContent(System.IAsyncResult result) {
            string retVal = this.EndretrieveTextFileContent(result);
            return new object[] {
                    retVal};
        }
        
        private void OnretrieveTextFileContentCompleted(object state) {
            if ((this.retrieveTextFileContentCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.retrieveTextFileContentCompleted(this, new retrieveTextFileContentCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void retrieveTextFileContentAsync(string path) {
            this.retrieveTextFileContentAsync(path, null);
        }
        
        public void retrieveTextFileContentAsync(string path, object userState) {
            if ((this.onBeginretrieveTextFileContentDelegate == null)) {
                this.onBeginretrieveTextFileContentDelegate = new BeginOperationDelegate(this.OnBeginretrieveTextFileContent);
            }
            if ((this.onEndretrieveTextFileContentDelegate == null)) {
                this.onEndretrieveTextFileContentDelegate = new EndOperationDelegate(this.OnEndretrieveTextFileContent);
            }
            if ((this.onretrieveTextFileContentCompletedDelegate == null)) {
                this.onretrieveTextFileContentCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnretrieveTextFileContentCompleted);
            }
            base.InvokeAsync(this.onBeginretrieveTextFileContentDelegate, new object[] {
                        path}, this.onEndretrieveTextFileContentDelegate, this.onretrieveTextFileContentCompletedDelegate, userState);
        }
    }
}
