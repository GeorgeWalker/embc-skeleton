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
    /// fieldpermission
    /// </summary>
    public partial class MicrosoftDynamicsCRMfieldpermission
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMfieldpermission class.
        /// </summary>
        public MicrosoftDynamicsCRMfieldpermission()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMfieldpermission class.
        /// </summary>
        public MicrosoftDynamicsCRMfieldpermission(string attributelogicalname = default(string), string fieldpermissionid = default(string), int? cancreate = default(int?), int? componentstate = default(int?), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), int? canupdate = default(int?), string _organizationidValue = default(string), string fieldpermissionidunique = default(string), string solutionid = default(string), string _fieldsecurityprofileidValue = default(string), long? versionnumber = default(long?), string entityname = default(string), bool? ismanaged = default(bool?), int? canread = default(int?), IList<MicrosoftDynamicsCRMsyncerror> fieldPermissionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMfieldsecurityprofile fieldsecurityprofileid = default(MicrosoftDynamicsCRMfieldsecurityprofile))
        {
            Attributelogicalname = attributelogicalname;
            Fieldpermissionid = fieldpermissionid;
            Cancreate = cancreate;
            Componentstate = componentstate;
            Overwritetime = overwritetime;
            Canupdate = canupdate;
            this._organizationidValue = _organizationidValue;
            Fieldpermissionidunique = fieldpermissionidunique;
            Solutionid = solutionid;
            this._fieldsecurityprofileidValue = _fieldsecurityprofileidValue;
            Versionnumber = versionnumber;
            Entityname = entityname;
            Ismanaged = ismanaged;
            Canread = canread;
            FieldPermissionSyncErrors = fieldPermissionSyncErrors;
            Fieldsecurityprofileid = fieldsecurityprofileid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attributelogicalname")]
        public string Attributelogicalname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fieldpermissionid")]
        public string Fieldpermissionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cancreate")]
        public int? Cancreate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canupdate")]
        public int? Canupdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fieldpermissionidunique")]
        public string Fieldpermissionidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_fieldsecurityprofileid_value")]
        public string _fieldsecurityprofileidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityname")]
        public string Entityname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canread")]
        public int? Canread { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FieldPermission_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> FieldPermissionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fieldsecurityprofileid")]
        public MicrosoftDynamicsCRMfieldsecurityprofile Fieldsecurityprofileid { get; set; }

    }
}
