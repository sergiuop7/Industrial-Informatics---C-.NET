﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WindowsFormsApp1.ServiceReference1.HelloWorldResponse HelloWorld(WindowsFormsApp1.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.HelloWorldResponse> HelloWorldAsync(WindowsFormsApp1.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CelsiusToFahrenheit", ReplyAction="*")]
        float CelsiusToFahrenheit(float x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CelsiusToFahrenheit", ReplyAction="*")]
        System.Threading.Tasks.Task<float> CelsiusToFahrenheitAsync(float x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FahrenheitToCelsius", ReplyAction="*")]
        float FahrenheitToCelsius(float y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FahrenheitToCelsius", ReplyAction="*")]
        System.Threading.Tasks.Task<float> FahrenheitToCelsiusAsync(float y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertLeiToEuro", ReplyAction="*")]
        float ConvertLeiToEuro(float leiAmount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertLeiToEuro", ReplyAction="*")]
        System.Threading.Tasks.Task<float> ConvertLeiToEuroAsync(float leiAmount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertEuroToLei", ReplyAction="*")]
        float ConvertEuroToLei(float euroAmount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertEuroToLei", ReplyAction="*")]
        System.Threading.Tasks.Task<float> ConvertEuroToLeiAsync(float euroAmount);
        
        // CODEGEN: Generating message contract since element name AfisareListaResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AfisareLista", ReplyAction="*")]
        WindowsFormsApp1.ServiceReference1.AfisareListaResponse AfisareLista(WindowsFormsApp1.ServiceReference1.AfisareListaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AfisareLista", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.AfisareListaResponse> AfisareListaAsync(WindowsFormsApp1.ServiceReference1.AfisareListaRequest request);
        
        // CODEGEN: Generating message contract since element name GetDateTimeResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDateTime", ReplyAction="*")]
        WindowsFormsApp1.ServiceReference1.GetDateTimeResponse GetDateTime(WindowsFormsApp1.ServiceReference1.GetDateTimeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDateTime", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.GetDateTimeResponse> GetDateTimeAsync(WindowsFormsApp1.ServiceReference1.GetDateTimeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApp1.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WindowsFormsApp1.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApp1.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WindowsFormsApp1.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AfisareListaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AfisareLista", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApp1.ServiceReference1.AfisareListaRequestBody Body;
        
        public AfisareListaRequest() {
        }
        
        public AfisareListaRequest(WindowsFormsApp1.ServiceReference1.AfisareListaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AfisareListaRequestBody {
        
        public AfisareListaRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AfisareListaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AfisareListaResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApp1.ServiceReference1.AfisareListaResponseBody Body;
        
        public AfisareListaResponse() {
        }
        
        public AfisareListaResponse(WindowsFormsApp1.ServiceReference1.AfisareListaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AfisareListaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WindowsFormsApp1.ServiceReference1.ArrayOfString AfisareListaResult;
        
        public AfisareListaResponseBody() {
        }
        
        public AfisareListaResponseBody(WindowsFormsApp1.ServiceReference1.ArrayOfString AfisareListaResult) {
            this.AfisareListaResult = AfisareListaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDateTimeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDateTime", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApp1.ServiceReference1.GetDateTimeRequestBody Body;
        
        public GetDateTimeRequest() {
        }
        
        public GetDateTimeRequest(WindowsFormsApp1.ServiceReference1.GetDateTimeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetDateTimeRequestBody {
        
        public GetDateTimeRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDateTimeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDateTimeResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApp1.ServiceReference1.GetDateTimeResponseBody Body;
        
        public GetDateTimeResponse() {
        }
        
        public GetDateTimeResponse(WindowsFormsApp1.ServiceReference1.GetDateTimeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetDateTimeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetDateTimeResult;
        
        public GetDateTimeResponseBody() {
        }
        
        public GetDateTimeResponseBody(string GetDateTimeResult) {
            this.GetDateTimeResult = GetDateTimeResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : WindowsFormsApp1.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WindowsFormsApp1.ServiceReference1.WebService1Soap>, WindowsFormsApp1.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApp1.ServiceReference1.HelloWorldResponse WindowsFormsApp1.ServiceReference1.WebService1Soap.HelloWorld(WindowsFormsApp1.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WindowsFormsApp1.ServiceReference1.HelloWorldRequest inValue = new WindowsFormsApp1.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WindowsFormsApp1.ServiceReference1.HelloWorldRequestBody();
            WindowsFormsApp1.ServiceReference1.HelloWorldResponse retVal = ((WindowsFormsApp1.ServiceReference1.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.HelloWorldResponse> WindowsFormsApp1.ServiceReference1.WebService1Soap.HelloWorldAsync(WindowsFormsApp1.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            WindowsFormsApp1.ServiceReference1.HelloWorldRequest inValue = new WindowsFormsApp1.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WindowsFormsApp1.ServiceReference1.HelloWorldRequestBody();
            return ((WindowsFormsApp1.ServiceReference1.WebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        public int Add(int a, int b) {
            return base.Channel.Add(a, b);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int a, int b) {
            return base.Channel.AddAsync(a, b);
        }
        
        public float CelsiusToFahrenheit(float x) {
            return base.Channel.CelsiusToFahrenheit(x);
        }
        
        public System.Threading.Tasks.Task<float> CelsiusToFahrenheitAsync(float x) {
            return base.Channel.CelsiusToFahrenheitAsync(x);
        }
        
        public float FahrenheitToCelsius(float y) {
            return base.Channel.FahrenheitToCelsius(y);
        }
        
        public System.Threading.Tasks.Task<float> FahrenheitToCelsiusAsync(float y) {
            return base.Channel.FahrenheitToCelsiusAsync(y);
        }
        
        public float ConvertLeiToEuro(float leiAmount) {
            return base.Channel.ConvertLeiToEuro(leiAmount);
        }
        
        public System.Threading.Tasks.Task<float> ConvertLeiToEuroAsync(float leiAmount) {
            return base.Channel.ConvertLeiToEuroAsync(leiAmount);
        }
        
        public float ConvertEuroToLei(float euroAmount) {
            return base.Channel.ConvertEuroToLei(euroAmount);
        }
        
        public System.Threading.Tasks.Task<float> ConvertEuroToLeiAsync(float euroAmount) {
            return base.Channel.ConvertEuroToLeiAsync(euroAmount);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApp1.ServiceReference1.AfisareListaResponse WindowsFormsApp1.ServiceReference1.WebService1Soap.AfisareLista(WindowsFormsApp1.ServiceReference1.AfisareListaRequest request) {
            return base.Channel.AfisareLista(request);
        }
        
        public WindowsFormsApp1.ServiceReference1.ArrayOfString AfisareLista() {
            WindowsFormsApp1.ServiceReference1.AfisareListaRequest inValue = new WindowsFormsApp1.ServiceReference1.AfisareListaRequest();
            inValue.Body = new WindowsFormsApp1.ServiceReference1.AfisareListaRequestBody();
            WindowsFormsApp1.ServiceReference1.AfisareListaResponse retVal = ((WindowsFormsApp1.ServiceReference1.WebService1Soap)(this)).AfisareLista(inValue);
            return retVal.Body.AfisareListaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.AfisareListaResponse> WindowsFormsApp1.ServiceReference1.WebService1Soap.AfisareListaAsync(WindowsFormsApp1.ServiceReference1.AfisareListaRequest request) {
            return base.Channel.AfisareListaAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.AfisareListaResponse> AfisareListaAsync() {
            WindowsFormsApp1.ServiceReference1.AfisareListaRequest inValue = new WindowsFormsApp1.ServiceReference1.AfisareListaRequest();
            inValue.Body = new WindowsFormsApp1.ServiceReference1.AfisareListaRequestBody();
            return ((WindowsFormsApp1.ServiceReference1.WebService1Soap)(this)).AfisareListaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApp1.ServiceReference1.GetDateTimeResponse WindowsFormsApp1.ServiceReference1.WebService1Soap.GetDateTime(WindowsFormsApp1.ServiceReference1.GetDateTimeRequest request) {
            return base.Channel.GetDateTime(request);
        }
        
        public string GetDateTime() {
            WindowsFormsApp1.ServiceReference1.GetDateTimeRequest inValue = new WindowsFormsApp1.ServiceReference1.GetDateTimeRequest();
            inValue.Body = new WindowsFormsApp1.ServiceReference1.GetDateTimeRequestBody();
            WindowsFormsApp1.ServiceReference1.GetDateTimeResponse retVal = ((WindowsFormsApp1.ServiceReference1.WebService1Soap)(this)).GetDateTime(inValue);
            return retVal.Body.GetDateTimeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.GetDateTimeResponse> WindowsFormsApp1.ServiceReference1.WebService1Soap.GetDateTimeAsync(WindowsFormsApp1.ServiceReference1.GetDateTimeRequest request) {
            return base.Channel.GetDateTimeAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.GetDateTimeResponse> GetDateTimeAsync() {
            WindowsFormsApp1.ServiceReference1.GetDateTimeRequest inValue = new WindowsFormsApp1.ServiceReference1.GetDateTimeRequest();
            inValue.Body = new WindowsFormsApp1.ServiceReference1.GetDateTimeRequestBody();
            return ((WindowsFormsApp1.ServiceReference1.WebService1Soap)(this)).GetDateTimeAsync(inValue);
        }
    }
}
