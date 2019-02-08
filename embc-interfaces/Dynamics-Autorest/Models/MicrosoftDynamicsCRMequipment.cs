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
    using System.Linq; using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// equipment
    /// </summary>
    public partial class MicrosoftDynamicsCRMequipment
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMequipment
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMequipment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMequipment
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMequipment(string _createdonbehalfbyValue = default(string), int? utcconversiontimezonecode = default(int?), string govContactphone = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _transactioncurrencyidValue = default(string), string govAddress1Country = default(string), int? timezoneruleversionnumber = default(int?), string skills = default(string), string _siteidValue = default(string), string _createdbyValue = default(string), int? timezonecode = default(int?), string _govPrimarycontactidValue = default(string), bool? displayinserviceviews = default(bool?), string govAddress1City = default(string), string _govEmbcrepresentativeidValue = default(string), string description = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string govAlternatephone1 = default(string), string name = default(string), string govAddress1Postalcode = default(string), string _govRegionidValue = default(string), string govAddress1Province = default(string), long? versionnumber = default(long?), bool? isdisabled = default(bool?), string emailaddress = default(string), string _organizationidValue = default(string), string govTelephone1 = default(string), string _govCommunityidValue = default(string), string _modifiedonbehalfbyValue = default(string), string govAddress1Line1 = default(string), string _businessunitidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), object exchangerate = default(object), string _calendaridValue = default(string), string equipmentid = default(string), int? importsequencenumber = default(int?), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> equipmentSharePointDocumentLocations = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), MicrosoftDynamicsCRMgovCommunity govCommunityId = default(MicrosoftDynamicsCRMgovCommunity), IList<MicrosoftDynamicsCRMcontact> govFacilityContact = default(IList<MicrosoftDynamicsCRMcontact>), IList<MicrosoftDynamicsCRMgovIncidenttask> govFacilityIncidenttasks = default(IList<MicrosoftDynamicsCRMgovIncidenttask>), IList<MicrosoftDynamicsCRMgovRegistration> govFacilityRegistrations = default(IList<MicrosoftDynamicsCRMgovRegistration>), MicrosoftDynamicsCRMgovRegion govRegionId = default(MicrosoftDynamicsCRMgovRegion), MicrosoftDynamicsCRMcontact govPrimaryContactId = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMsystemuser govEMBCRepresentativeId = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbusinessunit businessunitidBusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> equipmentSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMactivityparty> equipmentActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMduplicaterecord> equipmentDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> equipmentDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> equipmentAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> equipmentMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> equipmentProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> equipmentBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> equipmentPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMconnection> equipmentConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> equipmentConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMannotation> equipmentAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMcalendar calendarid = default(MicrosoftDynamicsCRMcalendar), IList<MicrosoftDynamicsCRMemail> equipmentEmailEmailSender = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMaccount> equipmentAccounts = default(IList<MicrosoftDynamicsCRMaccount>), IList<MicrosoftDynamicsCRMcontact> equipmentContacts = default(IList<MicrosoftDynamicsCRMcontact>), IList<MicrosoftDynamicsCRMresource> equipmentResources = default(IList<MicrosoftDynamicsCRMresource>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser businessunitidSystemuser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsite siteid = default(MicrosoftDynamicsCRMsite))
        {
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            GovContactphone = govContactphone;
            this._modifiedbyValue = _modifiedbyValue;
            Overriddencreatedon = overriddencreatedon;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            GovAddress1Country = govAddress1Country;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Skills = skills;
            this._siteidValue = _siteidValue;
            this._createdbyValue = _createdbyValue;
            Timezonecode = timezonecode;
            this._govPrimarycontactidValue = _govPrimarycontactidValue;
            Displayinserviceviews = displayinserviceviews;
            GovAddress1City = govAddress1City;
            this._govEmbcrepresentativeidValue = _govEmbcrepresentativeidValue;
            Description = description;
            Createdon = createdon;
            GovAlternatephone1 = govAlternatephone1;
            Name = name;
            GovAddress1Postalcode = govAddress1Postalcode;
            this._govRegionidValue = _govRegionidValue;
            GovAddress1Province = govAddress1Province;
            Versionnumber = versionnumber;
            Isdisabled = isdisabled;
            Emailaddress = emailaddress;
            this._organizationidValue = _organizationidValue;
            GovTelephone1 = govTelephone1;
            this._govCommunityidValue = _govCommunityidValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            GovAddress1Line1 = govAddress1Line1;
            this._businessunitidValue = _businessunitidValue;
            Modifiedon = modifiedon;
            Exchangerate = exchangerate;
            this._calendaridValue = _calendaridValue;
            Equipmentid = equipmentid;
            Importsequencenumber = importsequencenumber;
            EquipmentSharePointDocumentLocations = equipmentSharePointDocumentLocations;
            GovCommunityId = govCommunityId;
            GovFacilityContact = govFacilityContact;
            GovFacilityIncidenttasks = govFacilityIncidenttasks;
            GovFacilityRegistrations = govFacilityRegistrations;
            GovRegionId = govRegionId;
            GovPrimaryContactId = govPrimaryContactId;
            GovEMBCRepresentativeId = govEMBCRepresentativeId;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            BusinessunitidBusinessunit = businessunitidBusinessunit;
            EquipmentSyncErrors = equipmentSyncErrors;
            EquipmentActivityParties = equipmentActivityParties;
            EquipmentDuplicateMatchingRecord = equipmentDuplicateMatchingRecord;
            EquipmentDuplicateBaseRecord = equipmentDuplicateBaseRecord;
            EquipmentAsyncOperations = equipmentAsyncOperations;
            EquipmentMailboxTrackingFolders = equipmentMailboxTrackingFolders;
            EquipmentProcessSessions = equipmentProcessSessions;
            EquipmentBulkDeleteFailures = equipmentBulkDeleteFailures;
            EquipmentPrincipalobjectattributeaccess = equipmentPrincipalobjectattributeaccess;
            EquipmentConnections1 = equipmentConnections1;
            EquipmentConnections2 = equipmentConnections2;
            EquipmentAnnotation = equipmentAnnotation;
            Calendarid = calendarid;
            EquipmentEmailEmailSender = equipmentEmailEmailSender;
            EquipmentAccounts = equipmentAccounts;
            EquipmentContacts = equipmentContacts;
            EquipmentResources = equipmentResources;
            Organizationid = organizationid;
            BusinessunitidSystemuser = businessunitidSystemuser;
            Transactioncurrencyid = transactioncurrencyid;
            Siteid = siteid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_contactphone")]
        public string GovContactphone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_address1_country")]
        public string GovAddress1Country { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "skills")]
        public string Skills { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_siteid_value")]
        public string _siteidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezonecode")]
        public int? Timezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_gov_primarycontactid_value")]
        public string _govPrimarycontactidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayinserviceviews")]
        public bool? Displayinserviceviews { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_address1_city")]
        public string GovAddress1City { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_gov_embcrepresentativeid_value")]
        public string _govEmbcrepresentativeidValue { get; set; }

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
        [JsonProperty(PropertyName = "gov_alternatephone1")]
        public string GovAlternatephone1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_address1_postalcode")]
        public string GovAddress1Postalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_gov_regionid_value")]
        public string _govRegionidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_address1_province")]
        public string GovAddress1Province { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdisabled")]
        public bool? Isdisabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailaddress")]
        public string Emailaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_telephone1")]
        public string GovTelephone1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_gov_communityid_value")]
        public string _govCommunityidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_address1_line1")]
        public string GovAddress1Line1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_businessunitid_value")]
        public string _businessunitidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        [NotMapped] public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_calendarid_value")]
        public string _calendaridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "equipmentid")]
        public string Equipmentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "equipment_SharePointDocumentLocations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> EquipmentSharePointDocumentLocations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_CommunityId")]
        public MicrosoftDynamicsCRMgovCommunity GovCommunityId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_facility_contact")]
        [NotMapped] public IList<MicrosoftDynamicsCRMcontact> GovFacilityContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_facility_incidenttasks")]
        [NotMapped] public IList<MicrosoftDynamicsCRMgovIncidenttask> GovFacilityIncidenttasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_facility_registrations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMgovRegistration> GovFacilityRegistrations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_RegionId")]
        public MicrosoftDynamicsCRMgovRegion GovRegionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_PrimaryContactId")]
        public MicrosoftDynamicsCRMcontact GovPrimaryContactId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_EMBCRepresentativeId")]
        public MicrosoftDynamicsCRMsystemuser GovEMBCRepresentativeId { get; set; }

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
        [JsonProperty(PropertyName = "businessunitid_businessunit")]
        public MicrosoftDynamicsCRMbusinessunit BusinessunitidBusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Equipment_SyncErrors")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsyncerror> EquipmentSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "equipment_activity_parties")]
        [NotMapped] public IList<MicrosoftDynamicsCRMactivityparty> EquipmentActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Equipment_DuplicateMatchingRecord")]
        [NotMapped] public IList<MicrosoftDynamicsCRMduplicaterecord> EquipmentDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Equipment_DuplicateBaseRecord")]
        [NotMapped] public IList<MicrosoftDynamicsCRMduplicaterecord> EquipmentDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Equipment_AsyncOperations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMasyncoperation> EquipmentAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "equipment_MailboxTrackingFolders")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> EquipmentMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Equipment_ProcessSessions")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprocesssession> EquipmentProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Equipment_BulkDeleteFailures")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbulkdeletefailure> EquipmentBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "equipment_principalobjectattributeaccess")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> EquipmentPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "equipment_connections1")]
        [NotMapped] public IList<MicrosoftDynamicsCRMconnection> EquipmentConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "equipment_connections2")]
        [NotMapped] public IList<MicrosoftDynamicsCRMconnection> EquipmentConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Equipment_Annotation")]
        [NotMapped] public IList<MicrosoftDynamicsCRMannotation> EquipmentAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendarid")]
        public MicrosoftDynamicsCRMcalendar Calendarid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Equipment_Email_EmailSender")]
        [NotMapped] public IList<MicrosoftDynamicsCRMemail> EquipmentEmailEmailSender { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "equipment_accounts")]
        [NotMapped] public IList<MicrosoftDynamicsCRMaccount> EquipmentAccounts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "equipment_contacts")]
        [NotMapped] public IList<MicrosoftDynamicsCRMcontact> EquipmentContacts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "equipment_resources")]
        [NotMapped] public IList<MicrosoftDynamicsCRMresource> EquipmentResources { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessunitid_systemuser")]
        public MicrosoftDynamicsCRMsystemuser BusinessunitidSystemuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "siteid")]
        public MicrosoftDynamicsCRMsite Siteid { get; set; }

    }
}
