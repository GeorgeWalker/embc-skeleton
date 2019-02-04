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
    /// bcgov_termsconditionspreset
    /// </summary>
    public partial class MicrosoftDynamicsCRMbcgovTermsconditionspreset
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovTermsconditionspreset class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovTermsconditionspreset()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovTermsconditionspreset class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovTermsconditionspreset(System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), int? statuscode = default(int?), string _owningbusinessunitValue = default(string), string _createdbyValue = default(string), string bcgovTermsconditionspresetid = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), long? versionnumber = default(long?), string _owninguserValue = default(string), string bcgovName = default(string), string _createdonbehalfbyValue = default(string), string bcgovContents = default(string), int? timezoneruleversionnumber = default(int?), int? statecode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), int? bcgovDisplayorder = default(int?), string _bcgovApplicationtypeValue = default(string), string _owneridValue = default(string), int? importsequencenumber = default(int?), string _owningteamValue = default(string), bool? bcgovIsdefault = default(bool?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> bcgovTermsconditionspresetSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> bcgovTermsconditionspresetDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> bcgovTermsconditionspresetDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> bcgovTermsconditionspresetAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> bcgovTermsconditionspresetBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMbcgovApplicationtype bcgovApplicationType = default(MicrosoftDynamicsCRMbcgovApplicationtype), IList<MicrosoftDynamicsCRMbcgovCertificatetermsandconditions> bcgovTermsconditionspresetBcgovCertificatetermsandconditionsPresetTerms = default(IList<MicrosoftDynamicsCRMbcgovCertificatetermsandconditions>))
        {
            Overriddencreatedon = overriddencreatedon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Statuscode = statuscode;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._createdbyValue = _createdbyValue;
            BcgovTermsconditionspresetid = bcgovTermsconditionspresetid;
            this._modifiedbyValue = _modifiedbyValue;
            Createdon = createdon;
            Versionnumber = versionnumber;
            this._owninguserValue = _owninguserValue;
            BcgovName = bcgovName;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            BcgovContents = bcgovContents;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Statecode = statecode;
            Modifiedon = modifiedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            BcgovDisplayorder = bcgovDisplayorder;
            this._bcgovApplicationtypeValue = _bcgovApplicationtypeValue;
            this._owneridValue = _owneridValue;
            Importsequencenumber = importsequencenumber;
            this._owningteamValue = _owningteamValue;
            BcgovIsdefault = bcgovIsdefault;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            BcgovTermsconditionspresetSyncErrors = bcgovTermsconditionspresetSyncErrors;
            BcgovTermsconditionspresetDuplicateMatchingRecord = bcgovTermsconditionspresetDuplicateMatchingRecord;
            BcgovTermsconditionspresetDuplicateBaseRecord = bcgovTermsconditionspresetDuplicateBaseRecord;
            BcgovTermsconditionspresetAsyncOperations = bcgovTermsconditionspresetAsyncOperations;
            BcgovTermsconditionspresetBulkDeleteFailures = bcgovTermsconditionspresetBulkDeleteFailures;
            BcgovApplicationType = bcgovApplicationType;
            BcgovTermsconditionspresetBcgovCertificatetermsandconditionsPresetTerms = bcgovTermsconditionspresetBcgovCertificatetermsandconditionsPresetTerms;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

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
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_termsconditionspresetid")]
        public string BcgovTermsconditionspresetid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_name")]
        public string BcgovName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_contents")]
        public string BcgovContents { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_displayorder")]
        public int? BcgovDisplayorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bcgov_applicationtype_value")]
        public string _bcgovApplicationtypeValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_isdefault")]
        public bool? BcgovIsdefault { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

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
        [JsonProperty(PropertyName = "bcgov_termsconditionspreset_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> BcgovTermsconditionspresetSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_termsconditionspreset_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BcgovTermsconditionspresetDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_termsconditionspreset_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BcgovTermsconditionspresetDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_termsconditionspreset_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> BcgovTermsconditionspresetAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_termsconditionspreset_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BcgovTermsconditionspresetBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_ApplicationType")]
        public MicrosoftDynamicsCRMbcgovApplicationtype BcgovApplicationType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_termsconditionspreset_bcgov_certificatetermsandconditions_PresetTerms")]
        public IList<MicrosoftDynamicsCRMbcgovCertificatetermsandconditions> BcgovTermsconditionspresetBcgovCertificatetermsandconditionsPresetTerms { get; set; }

    }
}
