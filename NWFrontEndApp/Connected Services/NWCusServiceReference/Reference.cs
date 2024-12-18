﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NWCusServiceReference
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Country", Namespace="http://schemas.datacontract.org/2004/07/NWWCFServiceApp.Entities")]
    public partial class Country : object
    {
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customers", Namespace="http://schemas.datacontract.org/2004/07/NWWCFServiceApp")]
    public partial class Customers : object
    {
        
        private string AddressField;
        
        private string CityField;
        
        private string CompanyNameField;
        
        private string ContactNameField;
        
        private string ContactTitleField;
        
        private string CountryField;
        
        private string CustomerIDField;
        
        private string FaxField;
        
        private string PhoneField;
        
        private string PostalCodeField;
        
        private string RegionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address
        {
            get
            {
                return this.AddressField;
            }
            set
            {
                this.AddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City
        {
            get
            {
                return this.CityField;
            }
            set
            {
                this.CityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CompanyName
        {
            get
            {
                return this.CompanyNameField;
            }
            set
            {
                this.CompanyNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactName
        {
            get
            {
                return this.ContactNameField;
            }
            set
            {
                this.ContactNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactTitle
        {
            get
            {
                return this.ContactTitleField;
            }
            set
            {
                this.ContactTitleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Country
        {
            get
            {
                return this.CountryField;
            }
            set
            {
                this.CountryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerID
        {
            get
            {
                return this.CustomerIDField;
            }
            set
            {
                this.CustomerIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fax
        {
            get
            {
                return this.FaxField;
            }
            set
            {
                this.FaxField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone
        {
            get
            {
                return this.PhoneField;
            }
            set
            {
                this.PhoneField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PostalCode
        {
            get
            {
                return this.PostalCodeField;
            }
            set
            {
                this.PostalCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Region
        {
            get
            {
                return this.RegionField;
            }
            set
            {
                this.RegionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Orders", Namespace="http://schemas.datacontract.org/2004/07/NWWCFServiceApp")]
    public partial class Orders : object
    {
        
        private string CustomerIDField;
        
        private System.Nullable<int> EmployeeIDField;
        
        private System.Nullable<decimal> FreightField;
        
        private System.Nullable<System.DateTime> OrderDateField;
        
        private int OrderIDField;
        
        private System.Nullable<System.DateTime> RequiredDateField;
        
        private string ShipAddressField;
        
        private string ShipCityField;
        
        private string ShipCountryField;
        
        private string ShipNameField;
        
        private string ShipPostalCodeField;
        
        private string ShipRegionField;
        
        private System.Nullable<int> ShipViaField;
        
        private System.Nullable<System.DateTime> ShippedDateField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerID
        {
            get
            {
                return this.CustomerIDField;
            }
            set
            {
                this.CustomerIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> EmployeeID
        {
            get
            {
                return this.EmployeeIDField;
            }
            set
            {
                this.EmployeeIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> Freight
        {
            get
            {
                return this.FreightField;
            }
            set
            {
                this.FreightField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> OrderDate
        {
            get
            {
                return this.OrderDateField;
            }
            set
            {
                this.OrderDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OrderID
        {
            get
            {
                return this.OrderIDField;
            }
            set
            {
                this.OrderIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> RequiredDate
        {
            get
            {
                return this.RequiredDateField;
            }
            set
            {
                this.RequiredDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShipAddress
        {
            get
            {
                return this.ShipAddressField;
            }
            set
            {
                this.ShipAddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShipCity
        {
            get
            {
                return this.ShipCityField;
            }
            set
            {
                this.ShipCityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShipCountry
        {
            get
            {
                return this.ShipCountryField;
            }
            set
            {
                this.ShipCountryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShipName
        {
            get
            {
                return this.ShipNameField;
            }
            set
            {
                this.ShipNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShipPostalCode
        {
            get
            {
                return this.ShipPostalCodeField;
            }
            set
            {
                this.ShipPostalCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShipRegion
        {
            get
            {
                return this.ShipRegionField;
            }
            set
            {
                this.ShipRegionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ShipVia
        {
            get
            {
                return this.ShipViaField;
            }
            set
            {
                this.ShipViaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ShippedDate
        {
            get
            {
                return this.ShippedDateField;
            }
            set
            {
                this.ShippedDateField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NWCusServiceReference.INWCustomerService")]
    public interface INWCustomerService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INWCustomerService/GetCustomerCountries", ReplyAction="http://tempuri.org/INWCustomerService/GetCustomerCountriesResponse")]
        NWCusServiceReference.GetCustomerCountriesResponse GetCustomerCountries(NWCusServiceReference.GetCustomerCountriesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INWCustomerService/GetCustomerCountries", ReplyAction="http://tempuri.org/INWCustomerService/GetCustomerCountriesResponse")]
        System.Threading.Tasks.Task<NWCusServiceReference.GetCustomerCountriesResponse> GetCustomerCountriesAsync(NWCusServiceReference.GetCustomerCountriesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INWCustomerService/GetCustomers", ReplyAction="http://tempuri.org/INWCustomerService/GetCustomersResponse")]
        NWCusServiceReference.GetCustomersResponse GetCustomers(NWCusServiceReference.GetCustomersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INWCustomerService/GetCustomers", ReplyAction="http://tempuri.org/INWCustomerService/GetCustomersResponse")]
        System.Threading.Tasks.Task<NWCusServiceReference.GetCustomersResponse> GetCustomersAsync(NWCusServiceReference.GetCustomersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INWCustomerService/GetCustomersByCountry", ReplyAction="http://tempuri.org/INWCustomerService/GetCustomersByCountryResponse")]
        NWCusServiceReference.GetCustomersByCountryResponse GetCustomersByCountry(NWCusServiceReference.GetCustomersByCountryRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INWCustomerService/GetCustomersByCountry", ReplyAction="http://tempuri.org/INWCustomerService/GetCustomersByCountryResponse")]
        System.Threading.Tasks.Task<NWCusServiceReference.GetCustomersByCountryResponse> GetCustomersByCountryAsync(NWCusServiceReference.GetCustomersByCountryRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INWCustomerService/GetOrdersByCustomer", ReplyAction="http://tempuri.org/INWCustomerService/GetOrdersByCustomerResponse")]
        NWCusServiceReference.GetOrdersByCustomerResponse GetOrdersByCustomer(NWCusServiceReference.GetOrdersByCustomerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INWCustomerService/GetOrdersByCustomer", ReplyAction="http://tempuri.org/INWCustomerService/GetOrdersByCustomerResponse")]
        System.Threading.Tasks.Task<NWCusServiceReference.GetOrdersByCustomerResponse> GetOrdersByCustomerAsync(NWCusServiceReference.GetOrdersByCustomerRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCustomerCountries", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetCustomerCountriesRequest
    {
        
        public GetCustomerCountriesRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCustomerCountriesResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetCustomerCountriesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public NWCusServiceReference.Country[] GetCustomerCountriesResult;
        
        public GetCustomerCountriesResponse()
        {
        }
        
        public GetCustomerCountriesResponse(NWCusServiceReference.Country[] GetCustomerCountriesResult)
        {
            this.GetCustomerCountriesResult = GetCustomerCountriesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCustomers", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetCustomersRequest
    {
        
        public GetCustomersRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCustomersResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetCustomersResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public NWCusServiceReference.Customers[] GetCustomersResult;
        
        public GetCustomersResponse()
        {
        }
        
        public GetCustomersResponse(NWCusServiceReference.Customers[] GetCustomersResult)
        {
            this.GetCustomersResult = GetCustomersResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCustomersByCountry", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetCustomersByCountryRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string countryName;
        
        public GetCustomersByCountryRequest()
        {
        }
        
        public GetCustomersByCountryRequest(string countryName)
        {
            this.countryName = countryName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCustomersByCountryResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetCustomersByCountryResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public NWCusServiceReference.Customers[] GetCustomersByCountryResult;
        
        public GetCustomersByCountryResponse()
        {
        }
        
        public GetCustomersByCountryResponse(NWCusServiceReference.Customers[] GetCustomersByCountryResult)
        {
            this.GetCustomersByCountryResult = GetCustomersByCountryResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetOrdersByCustomer", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetOrdersByCustomerRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string customerId;
        
        public GetOrdersByCustomerRequest()
        {
        }
        
        public GetOrdersByCustomerRequest(string customerId)
        {
            this.customerId = customerId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetOrdersByCustomerResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetOrdersByCustomerResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public NWCusServiceReference.Orders[] GetOrdersByCustomerResult;
        
        public GetOrdersByCustomerResponse()
        {
        }
        
        public GetOrdersByCustomerResponse(NWCusServiceReference.Orders[] GetOrdersByCustomerResult)
        {
            this.GetOrdersByCustomerResult = GetOrdersByCustomerResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface INWCustomerServiceChannel : NWCusServiceReference.INWCustomerService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class NWCustomerServiceClient : System.ServiceModel.ClientBase<NWCusServiceReference.INWCustomerService>, NWCusServiceReference.INWCustomerService
    {
        
        public NWCustomerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public NWCusServiceReference.GetCustomerCountriesResponse GetCustomerCountries(NWCusServiceReference.GetCustomerCountriesRequest request)
        {
            return base.Channel.GetCustomerCountries(request);
        }
        
        public System.Threading.Tasks.Task<NWCusServiceReference.GetCustomerCountriesResponse> GetCustomerCountriesAsync(NWCusServiceReference.GetCustomerCountriesRequest request)
        {
            return base.Channel.GetCustomerCountriesAsync(request);
        }
        
        public NWCusServiceReference.GetCustomersResponse GetCustomers(NWCusServiceReference.GetCustomersRequest request)
        {
            return base.Channel.GetCustomers(request);
        }
        
        public System.Threading.Tasks.Task<NWCusServiceReference.GetCustomersResponse> GetCustomersAsync(NWCusServiceReference.GetCustomersRequest request)
        {
            return base.Channel.GetCustomersAsync(request);
        }
        
        public NWCusServiceReference.GetCustomersByCountryResponse GetCustomersByCountry(NWCusServiceReference.GetCustomersByCountryRequest request)
        {
            return base.Channel.GetCustomersByCountry(request);
        }
        
        public System.Threading.Tasks.Task<NWCusServiceReference.GetCustomersByCountryResponse> GetCustomersByCountryAsync(NWCusServiceReference.GetCustomersByCountryRequest request)
        {
            return base.Channel.GetCustomersByCountryAsync(request);
        }
        
        public NWCusServiceReference.GetOrdersByCustomerResponse GetOrdersByCustomer(NWCusServiceReference.GetOrdersByCustomerRequest request)
        {
            return base.Channel.GetOrdersByCustomer(request);
        }
        
        public System.Threading.Tasks.Task<NWCusServiceReference.GetOrdersByCustomerResponse> GetOrdersByCustomerAsync(NWCusServiceReference.GetOrdersByCustomerRequest request)
        {
            return base.Channel.GetOrdersByCustomerAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
    }
}
