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
    /// msdyn_playbookinstance
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynPlaybookinstance
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynPlaybookinstance class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynPlaybookinstance()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynPlaybookinstance class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynPlaybookinstance(int? statuscode = default(int?), string _owneridValue = default(string), string _modifiedonbehalfbyValue = default(string), int? timezoneruleversionnumber = default(int?), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? msdynEstimatedclose = default(System.DateTimeOffset?), string _msdynPlaybooktemplateidValue = default(string), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), int? statecode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _createdbyValue = default(string), string _owninguserValue = default(string), bool? msdynTrackprogress = default(bool?), long? versionnumber = default(long?), string _regardingValue = default(string), bool? msdynEvaluateactivityclosure = default(bool?), string msdynName = default(string), int? msdynActivitiesclosed = default(int?), string _modifiedbyValue = default(string), int? msdynActivitiesassociated = default(int?), string _msdynCategoryidValue = default(string), string _owningteamValue = default(string), string _owningbusinessunitValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string msdynPlaybookinstanceid = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> msdynPlaybookinstanceActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMsyncerror> msdynPlaybookinstanceSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> msdynPlaybookinstanceDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> msdynPlaybookinstanceDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> msdynPlaybookinstanceAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> msdynPlaybookinstanceMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> msdynPlaybookinstanceProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> msdynPlaybookinstanceBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> msdynPlaybookinstancePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMappointment> msdynPlaybookinstanceAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> msdynPlaybookinstanceEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> msdynPlaybookinstanceFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> msdynPlaybookinstanceLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> msdynPlaybookinstancePhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMtask> msdynPlaybookinstanceTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> msdynPlaybookinstanceRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> msdynPlaybookinstanceSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMannotation> msdynPlaybookinstanceAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMserviceappointment> msdynPlaybookinstanceServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), MicrosoftDynamicsCRMmsdynPlaybooktemplate msdynPlaybooktemplateid = default(MicrosoftDynamicsCRMmsdynPlaybooktemplate), MicrosoftDynamicsCRMmsdynPlaybookcategory msdynCategoryid = default(MicrosoftDynamicsCRMmsdynPlaybookcategory), IList<MicrosoftDynamicsCRMopportunityclose> msdynPlaybookinstanceOpportunityCloses = default(IList<MicrosoftDynamicsCRMopportunityclose>), IList<MicrosoftDynamicsCRMorderclose> msdynPlaybookinstanceOrderCloses = default(IList<MicrosoftDynamicsCRMorderclose>), IList<MicrosoftDynamicsCRMquoteclose> msdynPlaybookinstanceQuoteCloses = default(IList<MicrosoftDynamicsCRMquoteclose>), MicrosoftDynamicsCRMopportunity regardingOpportunity = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMquote regardingQuote = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMsalesorder regardingSalesorder = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMinvoice regardingInvoice = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMlead regardingLead = default(MicrosoftDynamicsCRMlead))
        {
            Statuscode = statuscode;
            this._owneridValue = _owneridValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            MsdynEstimatedclose = msdynEstimatedclose;
            this._msdynPlaybooktemplateidValue = _msdynPlaybooktemplateidValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Modifiedon = modifiedon;
            Importsequencenumber = importsequencenumber;
            Statecode = statecode;
            Overriddencreatedon = overriddencreatedon;
            this._createdbyValue = _createdbyValue;
            this._owninguserValue = _owninguserValue;
            MsdynTrackprogress = msdynTrackprogress;
            Versionnumber = versionnumber;
            this._regardingValue = _regardingValue;
            MsdynEvaluateactivityclosure = msdynEvaluateactivityclosure;
            MsdynName = msdynName;
            MsdynActivitiesclosed = msdynActivitiesclosed;
            this._modifiedbyValue = _modifiedbyValue;
            MsdynActivitiesassociated = msdynActivitiesassociated;
            this._msdynCategoryidValue = _msdynCategoryidValue;
            this._owningteamValue = _owningteamValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Createdon = createdon;
            MsdynPlaybookinstanceid = msdynPlaybookinstanceid;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            MsdynPlaybookinstanceActivityPointers = msdynPlaybookinstanceActivityPointers;
            MsdynPlaybookinstanceSyncErrors = msdynPlaybookinstanceSyncErrors;
            MsdynPlaybookinstanceDuplicateMatchingRecord = msdynPlaybookinstanceDuplicateMatchingRecord;
            MsdynPlaybookinstanceDuplicateBaseRecord = msdynPlaybookinstanceDuplicateBaseRecord;
            MsdynPlaybookinstanceAsyncOperations = msdynPlaybookinstanceAsyncOperations;
            MsdynPlaybookinstanceMailboxTrackingFolders = msdynPlaybookinstanceMailboxTrackingFolders;
            MsdynPlaybookinstanceProcessSession = msdynPlaybookinstanceProcessSession;
            MsdynPlaybookinstanceBulkDeleteFailures = msdynPlaybookinstanceBulkDeleteFailures;
            MsdynPlaybookinstancePrincipalObjectAttributeAccesses = msdynPlaybookinstancePrincipalObjectAttributeAccesses;
            MsdynPlaybookinstanceAppointments = msdynPlaybookinstanceAppointments;
            MsdynPlaybookinstanceEmails = msdynPlaybookinstanceEmails;
            MsdynPlaybookinstanceFaxes = msdynPlaybookinstanceFaxes;
            MsdynPlaybookinstanceLetters = msdynPlaybookinstanceLetters;
            MsdynPlaybookinstancePhoneCalls = msdynPlaybookinstancePhoneCalls;
            MsdynPlaybookinstanceTasks = msdynPlaybookinstanceTasks;
            MsdynPlaybookinstanceRecurringAppointmentMasters = msdynPlaybookinstanceRecurringAppointmentMasters;
            MsdynPlaybookinstanceSocialActivities = msdynPlaybookinstanceSocialActivities;
            MsdynPlaybookinstanceAnnotations = msdynPlaybookinstanceAnnotations;
            MsdynPlaybookinstanceServiceAppointments = msdynPlaybookinstanceServiceAppointments;
            MsdynPlaybooktemplateid = msdynPlaybooktemplateid;
            MsdynCategoryid = msdynCategoryid;
            MsdynPlaybookinstanceOpportunityCloses = msdynPlaybookinstanceOpportunityCloses;
            MsdynPlaybookinstanceOrderCloses = msdynPlaybookinstanceOrderCloses;
            MsdynPlaybookinstanceQuoteCloses = msdynPlaybookinstanceQuoteCloses;
            RegardingOpportunity = regardingOpportunity;
            RegardingQuote = regardingQuote;
            RegardingSalesorder = regardingSalesorder;
            RegardingInvoice = regardingInvoice;
            RegardingLead = regardingLead;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_estimatedclose")]
        public System.DateTimeOffset? MsdynEstimatedclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_msdyn_playbooktemplateid_value")]
        public string _msdynPlaybooktemplateidValue { get; set; }

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
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_trackprogress")]
        public bool? MsdynTrackprogress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regarding_value")]
        public string _regardingValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_evaluateactivityclosure")]
        public bool? MsdynEvaluateactivityclosure { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_name")]
        public string MsdynName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_activitiesclosed")]
        public int? MsdynActivitiesclosed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_activitiesassociated")]
        public int? MsdynActivitiesassociated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_msdyn_categoryid_value")]
        public string _msdynCategoryidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookinstanceid")]
        public string MsdynPlaybookinstanceid { get; set; }

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
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookinstance_ActivityPointers")]
        [NotMapped] public IList<MicrosoftDynamicsCRMactivitypointer> MsdynPlaybookinstanceActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookinstance_SyncErrors")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsyncerror> MsdynPlaybookinstanceSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookinstance_DuplicateMatchingRecord")]
        [NotMapped] public IList<MicrosoftDynamicsCRMduplicaterecord> MsdynPlaybookinstanceDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookinstance_DuplicateBaseRecord")]
        [NotMapped] public IList<MicrosoftDynamicsCRMduplicaterecord> MsdynPlaybookinstanceDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookinstance_AsyncOperations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMasyncoperation> MsdynPlaybookinstanceAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookinstance_MailboxTrackingFolders")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> MsdynPlaybookinstanceMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookinstance_ProcessSession")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprocesssession> MsdynPlaybookinstanceProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookinstance_BulkDeleteFailures")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbulkdeletefailure> MsdynPlaybookinstanceBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookinstance_PrincipalObjectAttributeAccesses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> MsdynPlaybookinstancePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookinstance_Appointments")]
        [NotMapped] public IList<MicrosoftDynamicsCRMappointment> MsdynPlaybookinstanceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookinstance_Emails")]
        [NotMapped] public IList<MicrosoftDynamicsCRMemail> MsdynPlaybookinstanceEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookinstance_Faxes")]
        [NotMapped] public IList<MicrosoftDynamicsCRMfax> MsdynPlaybookinstanceFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookinstance_Letters")]
        [NotMapped] public IList<MicrosoftDynamicsCRMletter> MsdynPlaybookinstanceLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookinstance_PhoneCalls")]
        [NotMapped] public IList<MicrosoftDynamicsCRMphonecall> MsdynPlaybookinstancePhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookinstance_Tasks")]
        [NotMapped] public IList<MicrosoftDynamicsCRMtask> MsdynPlaybookinstanceTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookinstance_RecurringAppointmentMasters")]
        [NotMapped] public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> MsdynPlaybookinstanceRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookinstance_SocialActivities")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsocialactivity> MsdynPlaybookinstanceSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookinstance_Annotations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMannotation> MsdynPlaybookinstanceAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookinstance_ServiceAppointments")]
        [NotMapped] public IList<MicrosoftDynamicsCRMserviceappointment> MsdynPlaybookinstanceServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbooktemplateid")]
        public MicrosoftDynamicsCRMmsdynPlaybooktemplate MsdynPlaybooktemplateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_categoryid")]
        public MicrosoftDynamicsCRMmsdynPlaybookcategory MsdynCategoryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookinstance_OpportunityCloses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMopportunityclose> MsdynPlaybookinstanceOpportunityCloses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookinstance_OrderCloses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMorderclose> MsdynPlaybookinstanceOrderCloses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_playbookinstance_QuoteCloses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMquoteclose> MsdynPlaybookinstanceQuoteCloses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regarding_opportunity")]
        public MicrosoftDynamicsCRMopportunity RegardingOpportunity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regarding_quote")]
        public MicrosoftDynamicsCRMquote RegardingQuote { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regarding_salesorder")]
        public MicrosoftDynamicsCRMsalesorder RegardingSalesorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regarding_invoice")]
        public MicrosoftDynamicsCRMinvoice RegardingInvoice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regarding_lead")]
        public MicrosoftDynamicsCRMlead RegardingLead { get; set; }

    }
}
