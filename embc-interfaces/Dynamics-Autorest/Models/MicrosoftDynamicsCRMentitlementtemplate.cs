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
    /// entitlementtemplate
    /// </summary>
    public partial class MicrosoftDynamicsCRMentitlementtemplate
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMentitlementtemplate class.
        /// </summary>
        public MicrosoftDynamicsCRMentitlementtemplate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMentitlementtemplate class.
        /// </summary>
        public MicrosoftDynamicsCRMentitlementtemplate(bool? restrictcasecreation = default(bool?), string entitlementtemplateid = default(string), object exchangerate = default(object), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _transactioncurrencyidValue = default(string), int? importsequencenumber = default(int?), string _createdbyValue = default(string), string _organizationidValue = default(string), System.DateTimeOffset? startdate = default(System.DateTimeOffset?), int? decreaseremainingon = default(int?), System.DateTimeOffset? enddate = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), int? allocationtypecode = default(int?), string _modifiedbyValue = default(string), int? utcconversiontimezonecode = default(int?), string _slaidValue = default(string), long? versionnumber = default(long?), int? timezoneruleversionnumber = default(int?), string description = default(string), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), object totalterms = default(object), int? kbaccesslevel = default(int?), string name = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMactivitypointer> entitlementtemplateActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMappointment> entitlementtemplateAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> entitlementtemplateEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> entitlementtemplateFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> entitlementtemplateLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> entitlementtemplatePhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMserviceappointment> entitlementtemplateServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMtask> entitlementtemplateTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> entitlementtemplateRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMduplicaterecord> entitlementtemplateDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> entitlementtemplateDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMannotation> entitlementtemplateAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMasyncoperation> entitlementtemplateAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> entitlementtemplateBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMentitlement> entitlementtemplateidRelationShip = default(IList<MicrosoftDynamicsCRMentitlement>), IList<MicrosoftDynamicsCRMsyncerror> entitlementTemplateSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMproduct> productEntitlementtemplateAssociation = default(IList<MicrosoftDynamicsCRMproduct>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsla slaid = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMsocialactivity> entitlementtemplateSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMentitlementtemplatechannel> entitlementtemplateEntitlementchannelEntitlementtemplateid = default(IList<MicrosoftDynamicsCRMentitlementtemplatechannel>))
        {
            Restrictcasecreation = restrictcasecreation;
            Entitlementtemplateid = entitlementtemplateid;
            Exchangerate = exchangerate;
            Modifiedon = modifiedon;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Importsequencenumber = importsequencenumber;
            this._createdbyValue = _createdbyValue;
            this._organizationidValue = _organizationidValue;
            Startdate = startdate;
            Decreaseremainingon = decreaseremainingon;
            Enddate = enddate;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Allocationtypecode = allocationtypecode;
            this._modifiedbyValue = _modifiedbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._slaidValue = _slaidValue;
            Versionnumber = versionnumber;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Description = description;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Createdon = createdon;
            Overriddencreatedon = overriddencreatedon;
            Totalterms = totalterms;
            Kbaccesslevel = kbaccesslevel;
            Name = name;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            EntitlementtemplateActivityPointers = entitlementtemplateActivityPointers;
            EntitlementtemplateAppointments = entitlementtemplateAppointments;
            EntitlementtemplateEmails = entitlementtemplateEmails;
            EntitlementtemplateFaxes = entitlementtemplateFaxes;
            EntitlementtemplateLetters = entitlementtemplateLetters;
            EntitlementtemplatePhoneCalls = entitlementtemplatePhoneCalls;
            EntitlementtemplateServiceAppointments = entitlementtemplateServiceAppointments;
            EntitlementtemplateTasks = entitlementtemplateTasks;
            EntitlementtemplateRecurringAppointmentMasters = entitlementtemplateRecurringAppointmentMasters;
            EntitlementtemplateDuplicateMatchingRecord = entitlementtemplateDuplicateMatchingRecord;
            EntitlementtemplateDuplicateBaseRecord = entitlementtemplateDuplicateBaseRecord;
            EntitlementtemplateAnnotations = entitlementtemplateAnnotations;
            EntitlementtemplateAsyncOperations = entitlementtemplateAsyncOperations;
            EntitlementtemplateBulkDeleteFailures = entitlementtemplateBulkDeleteFailures;
            EntitlementtemplateidRelationShip = entitlementtemplateidRelationShip;
            EntitlementTemplateSyncErrors = entitlementTemplateSyncErrors;
            ProductEntitlementtemplateAssociation = productEntitlementtemplateAssociation;
            Transactioncurrencyid = transactioncurrencyid;
            Organizationid = organizationid;
            Slaid = slaid;
            EntitlementtemplateSocialActivities = entitlementtemplateSocialActivities;
            EntitlementtemplateEntitlementchannelEntitlementtemplateid = entitlementtemplateEntitlementchannelEntitlementtemplateid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "restrictcasecreation")]
        public bool? Restrictcasecreation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplateid")]
        public string Entitlementtemplateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

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
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startdate")]
        public System.DateTimeOffset? Startdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "decreaseremainingon")]
        public int? Decreaseremainingon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enddate")]
        public System.DateTimeOffset? Enddate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allocationtypecode")]
        public int? Allocationtypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_slaid_value")]
        public string _slaidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalterms")]
        public object Totalterms { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "kbaccesslevel")]
        public int? Kbaccesslevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> EntitlementtemplateActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> EntitlementtemplateAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_Emails")]
        public IList<MicrosoftDynamicsCRMemail> EntitlementtemplateEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> EntitlementtemplateFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_Letters")]
        public IList<MicrosoftDynamicsCRMletter> EntitlementtemplateLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> EntitlementtemplatePhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> EntitlementtemplateServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> EntitlementtemplateTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> EntitlementtemplateRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> EntitlementtemplateDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> EntitlementtemplateDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> EntitlementtemplateAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> EntitlementtemplateAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> EntitlementtemplateBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplateid_RelationShip")]
        public IList<MicrosoftDynamicsCRMentitlement> EntitlementtemplateidRelationShip { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntitlementTemplate_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> EntitlementTemplateSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_entitlementtemplate_association")]
        public IList<MicrosoftDynamicsCRMproduct> ProductEntitlementtemplateAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slaid")]
        public MicrosoftDynamicsCRMsla Slaid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> EntitlementtemplateSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplate_entitlementchannel_entitlementtemplateid")]
        public IList<MicrosoftDynamicsCRMentitlementtemplatechannel> EntitlementtemplateEntitlementchannelEntitlementtemplateid { get; set; }

    }
}
