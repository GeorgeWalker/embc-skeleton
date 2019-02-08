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
    /// msdyn_upgraderun
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynUpgraderun
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynUpgraderun class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynUpgraderun()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynUpgraderun class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynUpgraderun(string msdynPackage = default(string), string msdynStartingversion = default(string), int? statecode = default(int?), string msdynUpgraderunid = default(string), string msdynTargetversion = default(string), string _modifiedbyValue = default(string), long? versionnumber = default(long?), string msdynError = default(string), int? importsequencenumber = default(int?), string _modifiedonbehalfbyValue = default(string), string msdynSummary = default(string), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? msdynFinished = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _createdbyValue = default(string), string _organizationidValue = default(string), int? msdynStatus = default(int?), int? statuscode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string msdynSolution = default(string), int? timezoneruleversionnumber = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> msdynUpgraderunSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> msdynUpgraderunAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> msdynUpgraderunMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> msdynUpgraderunProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> msdynUpgraderunBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> msdynUpgraderunPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMmsdynUpgradeversion> msdynMsdynUpgraderunMsdynUpgradeversionUpgradeRun = default(IList<MicrosoftDynamicsCRMmsdynUpgradeversion>))
        {
            MsdynPackage = msdynPackage;
            MsdynStartingversion = msdynStartingversion;
            Statecode = statecode;
            MsdynUpgraderunid = msdynUpgraderunid;
            MsdynTargetversion = msdynTargetversion;
            this._modifiedbyValue = _modifiedbyValue;
            Versionnumber = versionnumber;
            MsdynError = msdynError;
            Importsequencenumber = importsequencenumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            MsdynSummary = msdynSummary;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Createdon = createdon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            MsdynFinished = msdynFinished;
            Modifiedon = modifiedon;
            this._createdbyValue = _createdbyValue;
            this._organizationidValue = _organizationidValue;
            MsdynStatus = msdynStatus;
            Statuscode = statuscode;
            Overriddencreatedon = overriddencreatedon;
            MsdynSolution = msdynSolution;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            MsdynUpgraderunSyncErrors = msdynUpgraderunSyncErrors;
            MsdynUpgraderunAsyncOperations = msdynUpgraderunAsyncOperations;
            MsdynUpgraderunMailboxTrackingFolders = msdynUpgraderunMailboxTrackingFolders;
            MsdynUpgraderunProcessSession = msdynUpgraderunProcessSession;
            MsdynUpgraderunBulkDeleteFailures = msdynUpgraderunBulkDeleteFailures;
            MsdynUpgraderunPrincipalObjectAttributeAccesses = msdynUpgraderunPrincipalObjectAttributeAccesses;
            MsdynMsdynUpgraderunMsdynUpgradeversionUpgradeRun = msdynMsdynUpgraderunMsdynUpgradeversionUpgradeRun;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_package")]
        public string MsdynPackage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_startingversion")]
        public string MsdynStartingversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_upgraderunid")]
        public string MsdynUpgraderunid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_targetversion")]
        public string MsdynTargetversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_error")]
        public string MsdynError { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_summary")]
        public string MsdynSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_finished")]
        public System.DateTimeOffset? MsdynFinished { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

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
        [JsonProperty(PropertyName = "msdyn_status")]
        public int? MsdynStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_solution")]
        public string MsdynSolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

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
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_upgraderun_SyncErrors")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsyncerror> MsdynUpgraderunSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_upgraderun_AsyncOperations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMasyncoperation> MsdynUpgraderunAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_upgraderun_MailboxTrackingFolders")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> MsdynUpgraderunMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_upgraderun_ProcessSession")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprocesssession> MsdynUpgraderunProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_upgraderun_BulkDeleteFailures")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbulkdeletefailure> MsdynUpgraderunBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_upgraderun_PrincipalObjectAttributeAccesses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> MsdynUpgraderunPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_msdyn_upgraderun_msdyn_upgradeversion_UpgradeRun")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmsdynUpgradeversion> MsdynMsdynUpgraderunMsdynUpgradeversionUpgradeRun { get; set; }

    }
}