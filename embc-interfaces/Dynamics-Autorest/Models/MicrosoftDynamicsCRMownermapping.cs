// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Embc.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq; using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// ownermapping
    /// </summary>
    public partial class MicrosoftDynamicsCRMownermapping
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMownermapping
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMownermapping()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMownermapping
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMownermapping(string ownermappingid = default(string), string targetuservalueforsourcecrmuserlink = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? statuscode = default(int?), string _targetsystemuseridValue = default(string), string _modifiedonbehalfbyValue = default(string), int? processcode = default(int?), string targetsystemuserdomainname = default(string), string _importmapidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdbyValue = default(string), string _modifiedbyValue = default(string), string sourceuservalueforsourcecrmuserlink = default(string), string sourcesystemusername = default(string), string _createdonbehalfbyValue = default(string), int? statecode = default(int?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser targetsystemuserid = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMimportmap importmapid = default(MicrosoftDynamicsCRMimportmap))
        {
            Ownermappingid = ownermappingid;
            Targetuservalueforsourcecrmuserlink = targetuservalueforsourcecrmuserlink;
            Modifiedon = modifiedon;
            Statuscode = statuscode;
            this._targetsystemuseridValue = _targetsystemuseridValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Processcode = processcode;
            Targetsystemuserdomainname = targetsystemuserdomainname;
            this._importmapidValue = _importmapidValue;
            Createdon = createdon;
            this._createdbyValue = _createdbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Sourceuservalueforsourcecrmuserlink = sourceuservalueforsourcecrmuserlink;
            Sourcesystemusername = sourcesystemusername;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Statecode = statecode;
            Modifiedonbehalfby = modifiedonbehalfby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Createdby = createdby;
            Targetsystemuserid = targetsystemuserid;
            Importmapid = importmapid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownermappingid")]
        public string Ownermappingid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetuservalueforsourcecrmuserlink")]
        public string Targetuservalueforsourcecrmuserlink { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_targetsystemuserid_value")]
        public string _targetsystemuseridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processcode")]
        public int? Processcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetsystemuserdomainname")]
        public string Targetsystemuserdomainname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_importmapid_value")]
        public string _importmapidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourceuservalueforsourcecrmuserlink")]
        public string Sourceuservalueforsourcecrmuserlink { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourcesystemusername")]
        public string Sourcesystemusername { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

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
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetsystemuserid")]
        public MicrosoftDynamicsCRMsystemuser Targetsystemuserid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importmapid")]
        public MicrosoftDynamicsCRMimportmap Importmapid { get; set; }

    }
}