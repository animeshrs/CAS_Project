﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CAS_Client.ExchangeRateServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ExchangeRateServiceReference.ExchangeRateServiceSoap")]
    public interface ExchangeRateServiceSoap {
        
        // CODEGEN: Generating message contract since element name fromCurrency from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExchangeRate", ReplyAction="*")]
        CAS_Client.ExchangeRateServiceReference.ExchangeRateResponse ExchangeRate(CAS_Client.ExchangeRateServiceReference.ExchangeRateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExchangeRate", ReplyAction="*")]
        System.Threading.Tasks.Task<CAS_Client.ExchangeRateServiceReference.ExchangeRateResponse> ExchangeRateAsync(CAS_Client.ExchangeRateServiceReference.ExchangeRateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExchangeRateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExchangeRate", Namespace="http://tempuri.org/", Order=0)]
        public CAS_Client.ExchangeRateServiceReference.ExchangeRateRequestBody Body;
        
        public ExchangeRateRequest() {
        }
        
        public ExchangeRateRequest(CAS_Client.ExchangeRateServiceReference.ExchangeRateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ExchangeRateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string fromCurrency;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string toCurrency;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public decimal amount;
        
        public ExchangeRateRequestBody() {
        }
        
        public ExchangeRateRequestBody(string fromCurrency, string toCurrency, decimal amount) {
            this.fromCurrency = fromCurrency;
            this.toCurrency = toCurrency;
            this.amount = amount;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExchangeRateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExchangeRateResponse", Namespace="http://tempuri.org/", Order=0)]
        public CAS_Client.ExchangeRateServiceReference.ExchangeRateResponseBody Body;
        
        public ExchangeRateResponse() {
        }
        
        public ExchangeRateResponse(CAS_Client.ExchangeRateServiceReference.ExchangeRateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ExchangeRateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ExchangeRateResult;
        
        public ExchangeRateResponseBody() {
        }
        
        public ExchangeRateResponseBody(string ExchangeRateResult) {
            this.ExchangeRateResult = ExchangeRateResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ExchangeRateServiceSoapChannel : CAS_Client.ExchangeRateServiceReference.ExchangeRateServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExchangeRateServiceSoapClient : System.ServiceModel.ClientBase<CAS_Client.ExchangeRateServiceReference.ExchangeRateServiceSoap>, CAS_Client.ExchangeRateServiceReference.ExchangeRateServiceSoap {
        
        public ExchangeRateServiceSoapClient() {
        }
        
        public ExchangeRateServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ExchangeRateServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExchangeRateServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExchangeRateServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CAS_Client.ExchangeRateServiceReference.ExchangeRateResponse CAS_Client.ExchangeRateServiceReference.ExchangeRateServiceSoap.ExchangeRate(CAS_Client.ExchangeRateServiceReference.ExchangeRateRequest request) {
            return base.Channel.ExchangeRate(request);
        }
        
        public string ExchangeRate(string fromCurrency, string toCurrency, decimal amount) {
            CAS_Client.ExchangeRateServiceReference.ExchangeRateRequest inValue = new CAS_Client.ExchangeRateServiceReference.ExchangeRateRequest();
            inValue.Body = new CAS_Client.ExchangeRateServiceReference.ExchangeRateRequestBody();
            inValue.Body.fromCurrency = fromCurrency;
            inValue.Body.toCurrency = toCurrency;
            inValue.Body.amount = amount;
            CAS_Client.ExchangeRateServiceReference.ExchangeRateResponse retVal = ((CAS_Client.ExchangeRateServiceReference.ExchangeRateServiceSoap)(this)).ExchangeRate(inValue);
            return retVal.Body.ExchangeRateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CAS_Client.ExchangeRateServiceReference.ExchangeRateResponse> CAS_Client.ExchangeRateServiceReference.ExchangeRateServiceSoap.ExchangeRateAsync(CAS_Client.ExchangeRateServiceReference.ExchangeRateRequest request) {
            return base.Channel.ExchangeRateAsync(request);
        }
        
        public System.Threading.Tasks.Task<CAS_Client.ExchangeRateServiceReference.ExchangeRateResponse> ExchangeRateAsync(string fromCurrency, string toCurrency, decimal amount) {
            CAS_Client.ExchangeRateServiceReference.ExchangeRateRequest inValue = new CAS_Client.ExchangeRateServiceReference.ExchangeRateRequest();
            inValue.Body = new CAS_Client.ExchangeRateServiceReference.ExchangeRateRequestBody();
            inValue.Body.fromCurrency = fromCurrency;
            inValue.Body.toCurrency = toCurrency;
            inValue.Body.amount = amount;
            return ((CAS_Client.ExchangeRateServiceReference.ExchangeRateServiceSoap)(this)).ExchangeRateAsync(inValue);
        }
    }
}
