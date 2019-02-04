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
    /// solution
    /// </summary>
    public partial class MicrosoftDynamicsCRMsolution
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsolution
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMsolution()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsolution
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMsolution(System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string pinpointsolutiondefaultlocale = default(string), string _configurationpageidValue = default(string), string _publisheridValue = default(string), string _modifiedbyValue = default(string), long? versionnumber = default(long?), string description = default(string), bool? isvisible = default(bool?), string _parentsolutionidValue = default(string), long? pinpointpublisherid = default(long?), string _createdonbehalfbyValue = default(string), long? pinpointsolutionid = default(long?), string _modifiedonbehalfbyValue = default(string), string solutionpackageversion = default(string), string _createdbyValue = default(string), System.DateTimeOffset? installedon = default(System.DateTimeOffset?), string solutionid = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string uniquename = default(string), string friendlyname = default(string), string pinpointassetid = default(string), int? solutiontype = default(int?), string _organizationidValue = default(string), bool? ismanaged = default(bool?), string version = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMwebresource configurationpageid = default(MicrosoftDynamicsCRMwebresource), IList<MicrosoftDynamicsCRMsolutioncomponent> solutionSolutioncomponent = default(IList<MicrosoftDynamicsCRMsolutioncomponent>), MicrosoftDynamicsCRMpublisher publisherid = default(MicrosoftDynamicsCRMpublisher), IList<MicrosoftDynamicsCRMsyncerror> solutionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsolution parentsolutionid = default(MicrosoftDynamicsCRMsolution), IList<MicrosoftDynamicsCRMsolution> solutionParentSolution = default(IList<MicrosoftDynamicsCRMsolution>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Createdon = createdon;
            Pinpointsolutiondefaultlocale = pinpointsolutiondefaultlocale;
            this._configurationpageidValue = _configurationpageidValue;
            this._publisheridValue = _publisheridValue;
            this._modifiedbyValue = _modifiedbyValue;
            Versionnumber = versionnumber;
            Description = description;
            Isvisible = isvisible;
            this._parentsolutionidValue = _parentsolutionidValue;
            Pinpointpublisherid = pinpointpublisherid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Pinpointsolutionid = pinpointsolutionid;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Solutionpackageversion = solutionpackageversion;
            this._createdbyValue = _createdbyValue;
            Installedon = installedon;
            Solutionid = solutionid;
            Modifiedon = modifiedon;
            Uniquename = uniquename;
            Friendlyname = friendlyname;
            Pinpointassetid = pinpointassetid;
            Solutiontype = solutiontype;
            this._organizationidValue = _organizationidValue;
            Ismanaged = ismanaged;
            Version = version;
            Createdby = createdby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Configurationpageid = configurationpageid;
            SolutionSolutioncomponent = solutionSolutioncomponent;
            Publisherid = publisherid;
            SolutionSyncErrors = solutionSyncErrors;
            Organizationid = organizationid;
            Parentsolutionid = parentsolutionid;
            SolutionParentSolution = solutionParentSolution;
            Createdonbehalfby = createdonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pinpointsolutiondefaultlocale")]
        public string Pinpointsolutiondefaultlocale { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_configurationpageid_value")]
        public string _configurationpageidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_publisherid_value")]
        public string _publisheridValue { get; set; }

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
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isvisible")]
        public bool? Isvisible { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentsolutionid_value")]
        public string _parentsolutionidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pinpointpublisherid")]
        public long? Pinpointpublisherid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pinpointsolutionid")]
        public long? Pinpointsolutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionpackageversion")]
        public string Solutionpackageversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "installedon")]
        public System.DateTimeOffset? Installedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uniquename")]
        public string Uniquename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "friendlyname")]
        public string Friendlyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pinpointassetid")]
        public string Pinpointassetid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutiontype")]
        public int? Solutiontype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

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
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "configurationpageid")]
        public MicrosoftDynamicsCRMwebresource Configurationpageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solution_solutioncomponent")]
        public IList<MicrosoftDynamicsCRMsolutioncomponent> SolutionSolutioncomponent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "publisherid")]
        public MicrosoftDynamicsCRMpublisher Publisherid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Solution_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SolutionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentsolutionid")]
        public MicrosoftDynamicsCRMsolution Parentsolutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solution_parent_solution")]
        public IList<MicrosoftDynamicsCRMsolution> SolutionParentSolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

    }
}
