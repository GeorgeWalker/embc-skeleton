// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Embc.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// dynamicpropertyinstance
    /// </summary>
    public partial class MicrosoftDynamicsCRMdynamicpropertyinstance
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMdynamicpropertyinstance class.
        /// </summary>
        public MicrosoftDynamicsCRMdynamicpropertyinstance()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMdynamicpropertyinstance class.
        /// </summary>
        public MicrosoftDynamicsCRMdynamicpropertyinstance(long? versionnumber = default(long?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), double? valuedouble = default(double?), object valuedecimal = default(object), string _modifiedonbehalfbyValue = default(string), string valuestring = default(string), string _createdonbehalfbyValue = default(string), int? dmtimportstate = default(int?), string _modifiedbyValue = default(string), string _createdbyValue = default(string), bool? validationstatus = default(bool?), string _dynamicpropertyidValue = default(string), string _transactioncurrencyidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _regardingobjectidValue = default(string), string _owningbusinessunitValue = default(string), string _owneridValue = default(string), string _owninguserValue = default(string), object exchangerate = default(object), int? valueinteger = default(int?), string dynamicpropertyinstanceid = default(string), string _owningteamValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMdynamicproperty dynamicpropertyid = default(MicrosoftDynamicsCRMdynamicproperty), MicrosoftDynamicsCRMquotedetail regardingobjectidQuotedetail = default(MicrosoftDynamicsCRMquotedetail), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMinvoicedetail regardingobjectidInvoicedetail = default(MicrosoftDynamicsCRMinvoicedetail), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMopportunityproduct regardingobjectidOpportunityproduct = default(MicrosoftDynamicsCRMopportunityproduct), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsalesorderdetail regardingobjectidSalesorderdetail = default(MicrosoftDynamicsCRMsalesorderdetail), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Versionnumber = versionnumber;
            Modifiedon = modifiedon;
            Valuedouble = valuedouble;
            Valuedecimal = valuedecimal;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Valuestring = valuestring;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Dmtimportstate = dmtimportstate;
            this._modifiedbyValue = _modifiedbyValue;
            this._createdbyValue = _createdbyValue;
            Validationstatus = validationstatus;
            this._dynamicpropertyidValue = _dynamicpropertyidValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Createdon = createdon;
            this._regardingobjectidValue = _regardingobjectidValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owneridValue = _owneridValue;
            this._owninguserValue = _owninguserValue;
            Exchangerate = exchangerate;
            Valueinteger = valueinteger;
            Dynamicpropertyinstanceid = dynamicpropertyinstanceid;
            this._owningteamValue = _owningteamValue;
            Createdby = createdby;
            Dynamicpropertyid = dynamicpropertyid;
            RegardingobjectidQuotedetail = regardingobjectidQuotedetail;
            Modifiedby = modifiedby;
            Owningbusinessunit = owningbusinessunit;
            RegardingobjectidInvoicedetail = regardingobjectidInvoicedetail;
            Ownerid = ownerid;
            Owningteam = owningteam;
            RegardingobjectidOpportunityproduct = regardingobjectidOpportunityproduct;
            Createdonbehalfby = createdonbehalfby;
            RegardingobjectidSalesorderdetail = regardingobjectidSalesorderdetail;
            Owninguser = owninguser;
            Transactioncurrencyid = transactioncurrencyid;
            Modifiedonbehalfby = modifiedonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "valuedouble")]
        public double? Valuedouble { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "valuedecimal")]
        public object Valuedecimal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "valuestring")]
        public string Valuestring { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dmtimportstate")]
        public int? Dmtimportstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "validationstatus")]
        public bool? Validationstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_dynamicpropertyid_value")]
        public string _dynamicpropertyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "valueinteger")]
        public int? Valueinteger { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyinstanceid")]
        public string Dynamicpropertyinstanceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyid")]
        public MicrosoftDynamicsCRMdynamicproperty Dynamicpropertyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_quotedetail")]
        public MicrosoftDynamicsCRMquotedetail RegardingobjectidQuotedetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_invoicedetail")]
        public MicrosoftDynamicsCRMinvoicedetail RegardingobjectidInvoicedetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunityproduct")]
        public MicrosoftDynamicsCRMopportunityproduct RegardingobjectidOpportunityproduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_salesorderdetail")]
        public MicrosoftDynamicsCRMsalesorderdetail RegardingobjectidSalesorderdetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

    }
}
