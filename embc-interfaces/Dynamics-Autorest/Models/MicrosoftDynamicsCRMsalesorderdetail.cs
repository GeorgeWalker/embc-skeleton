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
    /// salesorderdetail
    /// </summary>
    public partial class MicrosoftDynamicsCRMsalesorderdetail
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsalesorderdetail class.
        /// </summary>
        public MicrosoftDynamicsCRMsalesorderdetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsalesorderdetail class.
        /// </summary>
        public MicrosoftDynamicsCRMsalesorderdetail(string owningbusinessunit = default(string), string shiptoCity = default(string), int? lineitemnumber = default(int?), object quantity = default(object), bool? isproductoverridden = default(bool?), int? pricingerrorcode = default(int?), string parentbundleid = default(string), string shiptoCountry = default(string), string productdescription = default(string), string shiptoContactname = default(string), int? shiptoFreighttermscode = default(int?), int? importsequencenumber = default(int?), string owninguser = default(string), object manualdiscountamountBase = default(object), string _productidValue = default(string), bool? iscopied = default(bool?), string shiptoLine1 = default(string), string description = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), int? propertyconfigurationstatus = default(int?), object extendedamount = default(object), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), object quantityshipped = default(object), bool? salesorderispricelocked = default(bool?), string _uomidValue = default(string), int? utcconversiontimezonecode = default(int?), int? producttypecode = default(int?), string salesorderdetailid = default(string), bool? ispriceoverridden = default(bool?), object volumediscountamountBase = default(object), object baseamountBase = default(object), object tax = default(object), object baseamount = default(object), string shiptoLine3 = default(string), string productassociationid = default(string), string shiptoLine2 = default(string), int? sequencenumber = default(int?), string shiptoAddressid = default(string), string _modifiedbyValue = default(string), object quantitycancelled = default(object), string _salesrepidValue = default(string), string _salesorderidValue = default(string), object exchangerate = default(object), string shiptoFax = default(string), string shiptoStateorprovince = default(string), string shiptoTelephone = default(string), string _createdonbehalfbyValue = default(string), object priceperunitBase = default(object), System.DateTimeOffset? requestdeliveryby = default(System.DateTimeOffset?), object quantitybackordered = default(object), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string shiptoName = default(string), object extendedamountBase = default(object), object manualdiscountamount = default(object), string shiptoPostalcode = default(string), object priceperunit = default(object), int? timezoneruleversionnumber = default(int?), int? salesorderstatecode = default(int?), long? versionnumber = default(long?), bool? willcall = default(bool?), object taxBase = default(object), object volumediscountamount = default(object), string _owneridValue = default(string), string _transactioncurrencyidValue = default(string), string _createdbyValue = default(string), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsalesorderdetail parentbundleidSalesorderdetail = default(MicrosoftDynamicsCRMsalesorderdetail), IList<MicrosoftDynamicsCRMsalesorderdetail> salesorderdetailParentSalesorderdetail = default(IList<MicrosoftDynamicsCRMsalesorderdetail>), MicrosoftDynamicsCRMuom uomid = default(MicrosoftDynamicsCRMuom), MicrosoftDynamicsCRMproductassociation productassociationidProductassociation = default(MicrosoftDynamicsCRMproductassociation), MicrosoftDynamicsCRMsalesorder salesorderid = default(MicrosoftDynamicsCRMsalesorder), IList<MicrosoftDynamicsCRMasyncoperation> salesOrderDetailAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser salesrepid = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMdynamicpropertyinstance> salesOrderDetailDynamicpropertyinstance = default(IList<MicrosoftDynamicsCRMdynamicpropertyinstance>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMproduct productid = default(MicrosoftDynamicsCRMproduct), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkdeletefailure> salesOrderDetailBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMsyncerror> salesOrderDetailSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>))
        {
            Owningbusinessunit = owningbusinessunit;
            ShiptoCity = shiptoCity;
            Lineitemnumber = lineitemnumber;
            Quantity = quantity;
            Isproductoverridden = isproductoverridden;
            Pricingerrorcode = pricingerrorcode;
            Parentbundleid = parentbundleid;
            ShiptoCountry = shiptoCountry;
            Productdescription = productdescription;
            ShiptoContactname = shiptoContactname;
            ShiptoFreighttermscode = shiptoFreighttermscode;
            Importsequencenumber = importsequencenumber;
            Owninguser = owninguser;
            ManualdiscountamountBase = manualdiscountamountBase;
            this._productidValue = _productidValue;
            Iscopied = iscopied;
            ShiptoLine1 = shiptoLine1;
            Description = description;
            Createdon = createdon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Propertyconfigurationstatus = propertyconfigurationstatus;
            Extendedamount = extendedamount;
            Modifiedon = modifiedon;
            Quantityshipped = quantityshipped;
            Salesorderispricelocked = salesorderispricelocked;
            this._uomidValue = _uomidValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Producttypecode = producttypecode;
            Salesorderdetailid = salesorderdetailid;
            Ispriceoverridden = ispriceoverridden;
            VolumediscountamountBase = volumediscountamountBase;
            BaseamountBase = baseamountBase;
            Tax = tax;
            Baseamount = baseamount;
            ShiptoLine3 = shiptoLine3;
            Productassociationid = productassociationid;
            ShiptoLine2 = shiptoLine2;
            Sequencenumber = sequencenumber;
            ShiptoAddressid = shiptoAddressid;
            this._modifiedbyValue = _modifiedbyValue;
            Quantitycancelled = quantitycancelled;
            this._salesrepidValue = _salesrepidValue;
            this._salesorderidValue = _salesorderidValue;
            Exchangerate = exchangerate;
            ShiptoFax = shiptoFax;
            ShiptoStateorprovince = shiptoStateorprovince;
            ShiptoTelephone = shiptoTelephone;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            PriceperunitBase = priceperunitBase;
            Requestdeliveryby = requestdeliveryby;
            Quantitybackordered = quantitybackordered;
            Overriddencreatedon = overriddencreatedon;
            ShiptoName = shiptoName;
            ExtendedamountBase = extendedamountBase;
            Manualdiscountamount = manualdiscountamount;
            ShiptoPostalcode = shiptoPostalcode;
            Priceperunit = priceperunit;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Salesorderstatecode = salesorderstatecode;
            Versionnumber = versionnumber;
            Willcall = willcall;
            TaxBase = taxBase;
            Volumediscountamount = volumediscountamount;
            this._owneridValue = _owneridValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            this._createdbyValue = _createdbyValue;
            Createdonbehalfby = createdonbehalfby;
            ParentbundleidSalesorderdetail = parentbundleidSalesorderdetail;
            SalesorderdetailParentSalesorderdetail = salesorderdetailParentSalesorderdetail;
            Uomid = uomid;
            ProductassociationidProductassociation = productassociationidProductassociation;
            Salesorderid = salesorderid;
            SalesOrderDetailAsyncOperations = salesOrderDetailAsyncOperations;
            Createdby = createdby;
            Salesrepid = salesrepid;
            SalesOrderDetailDynamicpropertyinstance = salesOrderDetailDynamicpropertyinstance;
            Modifiedonbehalfby = modifiedonbehalfby;
            Transactioncurrencyid = transactioncurrencyid;
            Productid = productid;
            Modifiedby = modifiedby;
            SalesOrderDetailBulkDeleteFailures = salesOrderDetailBulkDeleteFailures;
            SalesOrderDetailSyncErrors = salesOrderDetailSyncErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public string Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_city")]
        public string ShiptoCity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lineitemnumber")]
        public int? Lineitemnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public object Quantity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isproductoverridden")]
        public bool? Isproductoverridden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricingerrorcode")]
        public int? Pricingerrorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentbundleid")]
        public string Parentbundleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_country")]
        public string ShiptoCountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productdescription")]
        public string Productdescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_contactname")]
        public string ShiptoContactname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_freighttermscode")]
        public int? ShiptoFreighttermscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public string Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualdiscountamount_base")]
        public object ManualdiscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_productid_value")]
        public string _productidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscopied")]
        public bool? Iscopied { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line1")]
        public string ShiptoLine1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "propertyconfigurationstatus")]
        public int? Propertyconfigurationstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extendedamount")]
        public object Extendedamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantityshipped")]
        public object Quantityshipped { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesorderispricelocked")]
        public bool? Salesorderispricelocked { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_uomid_value")]
        public string _uomidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "producttypecode")]
        public int? Producttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesorderdetailid")]
        public string Salesorderdetailid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ispriceoverridden")]
        public bool? Ispriceoverridden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "volumediscountamount_base")]
        public object VolumediscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseamount_base")]
        public object BaseamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tax")]
        public object Tax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseamount")]
        public object Baseamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line3")]
        public string ShiptoLine3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productassociationid")]
        public string Productassociationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line2")]
        public string ShiptoLine2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sequencenumber")]
        public int? Sequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_addressid")]
        public string ShiptoAddressid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantitycancelled")]
        public object Quantitycancelled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_salesrepid_value")]
        public string _salesrepidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_salesorderid_value")]
        public string _salesorderidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_fax")]
        public string ShiptoFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_stateorprovince")]
        public string ShiptoStateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_telephone")]
        public string ShiptoTelephone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "priceperunit_base")]
        public object PriceperunitBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requestdeliveryby")]
        public System.DateTimeOffset? Requestdeliveryby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantitybackordered")]
        public object Quantitybackordered { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_name")]
        public string ShiptoName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extendedamount_base")]
        public object ExtendedamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualdiscountamount")]
        public object Manualdiscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_postalcode")]
        public string ShiptoPostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "priceperunit")]
        public object Priceperunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesorderstatecode")]
        public int? Salesorderstatecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "willcall")]
        public bool? Willcall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tax_base")]
        public object TaxBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "volumediscountamount")]
        public object Volumediscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentbundleid_salesorderdetail")]
        public MicrosoftDynamicsCRMsalesorderdetail ParentbundleidSalesorderdetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesorderdetail_parent_salesorderdetail")]
        public IList<MicrosoftDynamicsCRMsalesorderdetail> SalesorderdetailParentSalesorderdetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomid")]
        public MicrosoftDynamicsCRMuom Uomid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productassociationid_productassociation")]
        public MicrosoftDynamicsCRMproductassociation ProductassociationidProductassociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesorderid")]
        public MicrosoftDynamicsCRMsalesorder Salesorderid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrderDetail_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SalesOrderDetailAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesrepid")]
        public MicrosoftDynamicsCRMsystemuser Salesrepid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrderDetail_Dynamicpropertyinstance")]
        public IList<MicrosoftDynamicsCRMdynamicpropertyinstance> SalesOrderDetailDynamicpropertyinstance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productid")]
        public MicrosoftDynamicsCRMproduct Productid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrderDetail_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SalesOrderDetailBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrderDetail_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SalesOrderDetailSyncErrors { get; set; }

    }
}
