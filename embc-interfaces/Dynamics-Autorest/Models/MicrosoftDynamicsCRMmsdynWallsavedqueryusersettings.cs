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
    /// msdyn_wallsavedqueryusersettings
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynWallsavedqueryusersettings
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynWallsavedqueryusersettings class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynWallsavedqueryusersettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynWallsavedqueryusersettings class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynWallsavedqueryusersettings(int? statuscode = default(int?), string _owningbusinessunitValue = default(string), string _modifiedonbehalfbyValue = default(string), int? msdynSortorder = default(int?), int? msdynType = default(int?), string msdynSavedqueryname = default(string), string _owningteamValue = default(string), string _owninguserValue = default(string), string msdynEntitydisplayname = default(string), int? importsequencenumber = default(int?), bool? msdynIncludewallinresponse = default(bool?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), bool? msdynIsfollowing = default(bool?), string _owneridValue = default(string), int? utcconversiontimezonecode = default(int?), int? statecode = default(int?), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? msdynDefault = default(int?), string _msdynUseridValue = default(string), long? versionnumber = default(long?), bool? msdynIsvisible = default(bool?), int? msdynIsvisiblebit = default(int?), string msdynData = default(string), string _createdbyValue = default(string), string msdynEntityname = default(string), bool? msdynIsvirtual = default(bool?), string msdynWallsavedqueryusersettingsid = default(string), string _modifiedbyValue = default(string), string _msdynWallsavedqueryidValue = default(string), int? msdynOtc = default(int?), int? timezoneruleversionnumber = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> msdynWallsavedqueryusersettingsSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> msdynWallsavedqueryusersettingsAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> msdynWallsavedqueryusersettingsMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> msdynWallsavedqueryusersettingsProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> msdynWallsavedqueryusersettingsBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> msdynWallsavedqueryusersettingsPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMsystemuser msdynUserid = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMmsdynWallsavedquery msdynWallsavedqueryid = default(MicrosoftDynamicsCRMmsdynWallsavedquery))
        {
            Statuscode = statuscode;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            MsdynSortorder = msdynSortorder;
            MsdynType = msdynType;
            MsdynSavedqueryname = msdynSavedqueryname;
            this._owningteamValue = _owningteamValue;
            this._owninguserValue = _owninguserValue;
            MsdynEntitydisplayname = msdynEntitydisplayname;
            Importsequencenumber = importsequencenumber;
            MsdynIncludewallinresponse = msdynIncludewallinresponse;
            Modifiedon = modifiedon;
            MsdynIsfollowing = msdynIsfollowing;
            this._owneridValue = _owneridValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Statecode = statecode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Overriddencreatedon = overriddencreatedon;
            Createdon = createdon;
            MsdynDefault = msdynDefault;
            this._msdynUseridValue = _msdynUseridValue;
            Versionnumber = versionnumber;
            MsdynIsvisible = msdynIsvisible;
            MsdynIsvisiblebit = msdynIsvisiblebit;
            MsdynData = msdynData;
            this._createdbyValue = _createdbyValue;
            MsdynEntityname = msdynEntityname;
            MsdynIsvirtual = msdynIsvirtual;
            MsdynWallsavedqueryusersettingsid = msdynWallsavedqueryusersettingsid;
            this._modifiedbyValue = _modifiedbyValue;
            this._msdynWallsavedqueryidValue = _msdynWallsavedqueryidValue;
            MsdynOtc = msdynOtc;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            MsdynWallsavedqueryusersettingsSyncErrors = msdynWallsavedqueryusersettingsSyncErrors;
            MsdynWallsavedqueryusersettingsAsyncOperations = msdynWallsavedqueryusersettingsAsyncOperations;
            MsdynWallsavedqueryusersettingsMailboxTrackingFolders = msdynWallsavedqueryusersettingsMailboxTrackingFolders;
            MsdynWallsavedqueryusersettingsProcessSession = msdynWallsavedqueryusersettingsProcessSession;
            MsdynWallsavedqueryusersettingsBulkDeleteFailures = msdynWallsavedqueryusersettingsBulkDeleteFailures;
            MsdynWallsavedqueryusersettingsPrincipalObjectAttributeAccesses = msdynWallsavedqueryusersettingsPrincipalObjectAttributeAccesses;
            MsdynUserid = msdynUserid;
            MsdynWallsavedqueryid = msdynWallsavedqueryid;
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
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_sortorder")]
        public int? MsdynSortorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_type")]
        public int? MsdynType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_savedqueryname")]
        public string MsdynSavedqueryname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_entitydisplayname")]
        public string MsdynEntitydisplayname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_includewallinresponse")]
        public bool? MsdynIncludewallinresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_isfollowing")]
        public bool? MsdynIsfollowing { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_default")]
        public int? MsdynDefault { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_msdyn_userid_value")]
        public string _msdynUseridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_isvisible")]
        public bool? MsdynIsvisible { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_isvisiblebit")]
        public int? MsdynIsvisiblebit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_data")]
        public string MsdynData { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_entityname")]
        public string MsdynEntityname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_isvirtual")]
        public bool? MsdynIsvirtual { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_wallsavedqueryusersettingsid")]
        public string MsdynWallsavedqueryusersettingsid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_msdyn_wallsavedqueryid_value")]
        public string _msdynWallsavedqueryidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_otc")]
        public int? MsdynOtc { get; set; }

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
        [JsonProperty(PropertyName = "msdyn_wallsavedqueryusersettings_SyncErrors")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsyncerror> MsdynWallsavedqueryusersettingsSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_wallsavedqueryusersettings_AsyncOperations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMasyncoperation> MsdynWallsavedqueryusersettingsAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_wallsavedqueryusersettings_MailboxTrackingFolders")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> MsdynWallsavedqueryusersettingsMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_wallsavedqueryusersettings_ProcessSession")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprocesssession> MsdynWallsavedqueryusersettingsProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_wallsavedqueryusersettings_BulkDeleteFailures")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbulkdeletefailure> MsdynWallsavedqueryusersettingsBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> MsdynWallsavedqueryusersettingsPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_userid")]
        public MicrosoftDynamicsCRMsystemuser MsdynUserid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_wallsavedqueryid")]
        public MicrosoftDynamicsCRMmsdynWallsavedquery MsdynWallsavedqueryid { get; set; }

    }
}