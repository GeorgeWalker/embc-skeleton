// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Embc.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// pricelevel
    /// </summary>
    public partial class MicrosoftDynamicsCRMpricelevel
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMpricelevel
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMpricelevel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMpricelevel
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMpricelevel(string _transactioncurrencyidValue = default(string), int? paymentmethodcode = default(int?), string _createdonbehalfbyValue = default(string), int? freighttermscode = default(int?), long? versionnumber = default(long?), string description = default(string), object exchangerate = default(object), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), int? statecode = default(int?), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _organizationidValue = default(string), string name = default(string), System.DateTimeOffset? begindate = default(System.DateTimeOffset?), System.DateTimeOffset? enddate = default(System.DateTimeOffset?), int? statuscode = default(int?), string _modifiedonbehalfbyValue = default(string), string pricelevelid = default(string), int? shippingmethodcode = default(int?), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), string _createdbyValue = default(string), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMconnection> pricelevelConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMproduct> priceLevelProducts = default(IList<MicrosoftDynamicsCRMproduct>), IList<MicrosoftDynamicsCRMquote> priceLevelQuotes = default(IList<MicrosoftDynamicsCRMquote>), IList<MicrosoftDynamicsCRMproductpricelevel> priceLevelProductPriceLevels = default(IList<MicrosoftDynamicsCRMproductpricelevel>), IList<MicrosoftDynamicsCRMsalesorder> priceLevelOrders = default(IList<MicrosoftDynamicsCRMsalesorder>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMsyncerror> priceLevelSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMopportunity> priceLevelOpportunties = default(IList<MicrosoftDynamicsCRMopportunity>), IList<MicrosoftDynamicsCRMinvoice> priceLevelInvoices = default(IList<MicrosoftDynamicsCRMinvoice>), IList<MicrosoftDynamicsCRMbulkdeletefailure> priceLevelBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMaccount> priceLevelAccounts = default(IList<MicrosoftDynamicsCRMaccount>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMcampaign> priceListCampaigns = default(IList<MicrosoftDynamicsCRMcampaign>), IList<MicrosoftDynamicsCRMcontact> priceLevelContacts = default(IList<MicrosoftDynamicsCRMcontact>), IList<MicrosoftDynamicsCRMasyncoperation> priceLevelAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMconnection> pricelevelConnections1 = default(IList<MicrosoftDynamicsCRMconnection>))
        {
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Paymentmethodcode = paymentmethodcode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Freighttermscode = freighttermscode;
            Versionnumber = versionnumber;
            Description = description;
            Exchangerate = exchangerate;
            Overriddencreatedon = overriddencreatedon;
            this._modifiedbyValue = _modifiedbyValue;
            Statecode = statecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Createdon = createdon;
            this._organizationidValue = _organizationidValue;
            Name = name;
            Begindate = begindate;
            Enddate = enddate;
            Statuscode = statuscode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Pricelevelid = pricelevelid;
            Shippingmethodcode = shippingmethodcode;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Modifiedon = modifiedon;
            Importsequencenumber = importsequencenumber;
            this._createdbyValue = _createdbyValue;
            Modifiedonbehalfby = modifiedonbehalfby;
            Createdonbehalfby = createdonbehalfby;
            PricelevelConnections2 = pricelevelConnections2;
            PriceLevelProducts = priceLevelProducts;
            PriceLevelQuotes = priceLevelQuotes;
            PriceLevelProductPriceLevels = priceLevelProductPriceLevels;
            PriceLevelOrders = priceLevelOrders;
            Createdby = createdby;
            Modifiedby = modifiedby;
            Transactioncurrencyid = transactioncurrencyid;
            PriceLevelSyncErrors = priceLevelSyncErrors;
            PriceLevelOpportunties = priceLevelOpportunties;
            PriceLevelInvoices = priceLevelInvoices;
            PriceLevelBulkDeleteFailures = priceLevelBulkDeleteFailures;
            PriceLevelAccounts = priceLevelAccounts;
            Organizationid = organizationid;
            PriceListCampaigns = priceListCampaigns;
            PriceLevelContacts = priceLevelContacts;
            PriceLevelAsyncOperations = priceLevelAsyncOperations;
            PricelevelConnections1 = pricelevelConnections1;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "paymentmethodcode")]
        public int? Paymentmethodcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "freighttermscode")]
        public int? Freighttermscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "begindate")]
        public System.DateTimeOffset? Begindate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enddate")]
        public System.DateTimeOffset? Enddate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricelevelid")]
        public string Pricelevelid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shippingmethodcode")]
        public int? Shippingmethodcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricelevel_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> PricelevelConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_level_products")]
        public IList<MicrosoftDynamicsCRMproduct> PriceLevelProducts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_level_quotes")]
        public IList<MicrosoftDynamicsCRMquote> PriceLevelQuotes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_level_product_price_levels")]
        public IList<MicrosoftDynamicsCRMproductpricelevel> PriceLevelProductPriceLevels { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_level_orders")]
        public IList<MicrosoftDynamicsCRMsalesorder> PriceLevelOrders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PriceLevel_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> PriceLevelSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_level_opportunties")]
        public IList<MicrosoftDynamicsCRMopportunity> PriceLevelOpportunties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_level_invoices")]
        public IList<MicrosoftDynamicsCRMinvoice> PriceLevelInvoices { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PriceLevel_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> PriceLevelBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_level_accounts")]
        public IList<MicrosoftDynamicsCRMaccount> PriceLevelAccounts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PriceList_Campaigns")]
        public IList<MicrosoftDynamicsCRMcampaign> PriceListCampaigns { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_level_contacts")]
        public IList<MicrosoftDynamicsCRMcontact> PriceLevelContacts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PriceLevel_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> PriceLevelAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricelevel_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> PricelevelConnections1 { get; set; }

    }
}
