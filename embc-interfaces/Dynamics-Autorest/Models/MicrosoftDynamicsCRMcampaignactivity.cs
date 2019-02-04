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
    /// campaignactivity
    /// </summary>
    public partial class MicrosoftDynamicsCRMcampaignactivity
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcampaignactivity class.
        /// </summary>
        public MicrosoftDynamicsCRMcampaignactivity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcampaignactivity class.
        /// </summary>
        public MicrosoftDynamicsCRMcampaignactivity(object actualcostBase = default(object), bool? donotsendonoptout = default(bool?), int? importsequencenumber = default(int?), object budgetedcostBase = default(object), object actualcost = default(object), bool? ignoreinactivelistmembers = default(bool?), int? typecode = default(int?), string subcategory = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? excludeifcontactedinxdays = default(int?), string category = default(string), object budgetedcost = default(object), int? channeltypecode = default(int?), IList<MicrosoftDynamicsCRMlist> campaignactivitylistAssociation = default(IList<MicrosoftDynamicsCRMlist>), IList<MicrosoftDynamicsCRMsalesliterature> campaignactivitysalesliteratureAssociation = default(IList<MicrosoftDynamicsCRMsalesliterature>), IList<MicrosoftDynamicsCRMactivityparty> campaignactivityActivityparties = default(IList<MicrosoftDynamicsCRMactivityparty>), MicrosoftDynamicsCRMcampaign regardingobjectidCampaignCampaignactivity = default(MicrosoftDynamicsCRMcampaign), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyidCampaignactivity = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMannotation> campaignActivityAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMqueueitem> campaignActivityQueueItem = default(IList<MicrosoftDynamicsCRMqueueitem>), IList<MicrosoftDynamicsCRMconnection> campaignactivityConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> campaignactivityConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMsystemuser createdbyCampaignactivity = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMactivityparty> campaignactivityActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMsyncerror> campaignActivitySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyCampaignactivity = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMletter> campaignActivityLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMbulkoperation> campaignActivityBulkOperations = default(IList<MicrosoftDynamicsCRMbulkoperation>), IList<MicrosoftDynamicsCRMfax> campaignActivityFaxes = default(IList<MicrosoftDynamicsCRMfax>), MicrosoftDynamicsCRMsystemuser createdonbehalfbyCampaignactivity = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguserCampaignactivity = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), IList<MicrosoftDynamicsCRMemail> campaignActivityEmails = default(IList<MicrosoftDynamicsCRMemail>), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), IList<MicrosoftDynamicsCRMtask> campaignActivityTasks = default(IList<MicrosoftDynamicsCRMtask>), MicrosoftDynamicsCRMteam owningteamCampaignactivity = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMbulkdeletefailure> campaignActivityBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMappointment> campaignActivityAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMphonecall> campaignActivityPhonecalls = default(IList<MicrosoftDynamicsCRMphonecall>), MicrosoftDynamicsCRMsystemuser modifiedbyCampaignactivity = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMactivitypointer> campaignActivityActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMasyncoperation> campaignActivityAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMbusinessunit owningbusinessunitCampaignactivity = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> campaignActivityRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>))
        {
            ActualcostBase = actualcostBase;
            Donotsendonoptout = donotsendonoptout;
            Importsequencenumber = importsequencenumber;
            BudgetedcostBase = budgetedcostBase;
            Actualcost = actualcost;
            Ignoreinactivelistmembers = ignoreinactivelistmembers;
            Typecode = typecode;
            Subcategory = subcategory;
            Overriddencreatedon = overriddencreatedon;
            Excludeifcontactedinxdays = excludeifcontactedinxdays;
            Category = category;
            Budgetedcost = budgetedcost;
            Channeltypecode = channeltypecode;
            CampaignactivitylistAssociation = campaignactivitylistAssociation;
            CampaignactivitysalesliteratureAssociation = campaignactivitysalesliteratureAssociation;
            CampaignactivityActivityparties = campaignactivityActivityparties;
            RegardingobjectidCampaignCampaignactivity = regardingobjectidCampaignCampaignactivity;
            TransactioncurrencyidCampaignactivity = transactioncurrencyidCampaignactivity;
            CampaignActivityAnnotation = campaignActivityAnnotation;
            CampaignActivityQueueItem = campaignActivityQueueItem;
            CampaignactivityConnections1 = campaignactivityConnections1;
            CampaignactivityConnections2 = campaignactivityConnections2;
            CreatedbyCampaignactivity = createdbyCampaignactivity;
            CampaignactivityActivityParties = campaignactivityActivityParties;
            CampaignActivitySyncErrors = campaignActivitySyncErrors;
            ModifiedonbehalfbyCampaignactivity = modifiedonbehalfbyCampaignactivity;
            CampaignActivityLetters = campaignActivityLetters;
            CampaignActivityBulkOperations = campaignActivityBulkOperations;
            CampaignActivityFaxes = campaignActivityFaxes;
            CreatedonbehalfbyCampaignactivity = createdonbehalfbyCampaignactivity;
            OwninguserCampaignactivity = owninguserCampaignactivity;
            ActivityidActivitypointer = activityidActivitypointer;
            CampaignActivityEmails = campaignActivityEmails;
            StageidProcessstage = stageidProcessstage;
            CampaignActivityTasks = campaignActivityTasks;
            OwningteamCampaignactivity = owningteamCampaignactivity;
            CampaignActivityBulkDeleteFailures = campaignActivityBulkDeleteFailures;
            CampaignActivityAppointments = campaignActivityAppointments;
            CampaignActivityPhonecalls = campaignActivityPhonecalls;
            ModifiedbyCampaignactivity = modifiedbyCampaignactivity;
            CampaignActivityActivityPointers = campaignActivityActivityPointers;
            CampaignActivityAsyncOperations = campaignActivityAsyncOperations;
            OwningbusinessunitCampaignactivity = owningbusinessunitCampaignactivity;
            CampaignActivityRecurringAppointmentMasters = campaignActivityRecurringAppointmentMasters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actualcost_base")]
        public object ActualcostBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "donotsendonoptout")]
        public bool? Donotsendonoptout { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "budgetedcost_base")]
        public object BudgetedcostBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actualcost")]
        public object Actualcost { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ignoreinactivelistmembers")]
        public bool? Ignoreinactivelistmembers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "typecode")]
        public int? Typecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "excludeifcontactedinxdays")]
        public int? Excludeifcontactedinxdays { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "budgetedcost")]
        public object Budgetedcost { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "channeltypecode")]
        public int? Channeltypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivitylist_association")]
        public IList<MicrosoftDynamicsCRMlist> CampaignactivitylistAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivitysalesliterature_association")]
        public IList<MicrosoftDynamicsCRMsalesliterature> CampaignactivitysalesliteratureAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivity_activityparties")]
        public IList<MicrosoftDynamicsCRMactivityparty> CampaignactivityActivityparties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaign_campaignactivity")]
        public MicrosoftDynamicsCRMcampaign RegardingobjectidCampaignCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid_campaignactivity")]
        public MicrosoftDynamicsCRMtransactioncurrency TransactioncurrencyidCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> CampaignActivityAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_QueueItem")]
        public IList<MicrosoftDynamicsCRMqueueitem> CampaignActivityQueueItem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivity_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> CampaignactivityConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivity_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> CampaignactivityConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_campaignactivity")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivity_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> CampaignactivityActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> CampaignActivitySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_campaignactivity")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_Letters")]
        public IList<MicrosoftDynamicsCRMletter> CampaignActivityLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_BulkOperations")]
        public IList<MicrosoftDynamicsCRMbulkoperation> CampaignActivityBulkOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> CampaignActivityFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_campaignactivity")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_campaignactivity")]
        public MicrosoftDynamicsCRMsystemuser OwninguserCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_Emails")]
        public IList<MicrosoftDynamicsCRMemail> CampaignActivityEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> CampaignActivityTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_campaignactivity")]
        public MicrosoftDynamicsCRMteam OwningteamCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> CampaignActivityBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> CampaignActivityAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_Phonecalls")]
        public IList<MicrosoftDynamicsCRMphonecall> CampaignActivityPhonecalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_campaignactivity")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> CampaignActivityActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> CampaignActivityAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_campaignactivity")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> CampaignActivityRecurringAppointmentMasters { get; set; }

    }
}
