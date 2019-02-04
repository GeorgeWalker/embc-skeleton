// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Embc.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// appmoduleroles
    /// </summary>
    public partial class MicrosoftDynamicsCRMappmoduleroles
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMappmoduleroles class.
        /// </summary>
        public MicrosoftDynamicsCRMappmoduleroles()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMappmoduleroles class.
        /// </summary>
        public MicrosoftDynamicsCRMappmoduleroles(string solutionid = default(string), int? componentstate = default(int?), string appmoduleroleidunique = default(string), string introducedversion = default(string), long? versionnumber = default(long?), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string appmoduleroleid = default(string), bool? ismanaged = default(bool?), string _appmoduleidValue = default(string), string _roleidValue = default(string))
        {
            Solutionid = solutionid;
            Componentstate = componentstate;
            Appmoduleroleidunique = appmoduleroleidunique;
            Introducedversion = introducedversion;
            Versionnumber = versionnumber;
            Overwritetime = overwritetime;
            Appmoduleroleid = appmoduleroleid;
            Ismanaged = ismanaged;
            this._appmoduleidValue = _appmoduleidValue;
            this._roleidValue = _roleidValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appmoduleroleidunique")]
        public string Appmoduleroleidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appmoduleroleid")]
        public string Appmoduleroleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_appmoduleid_value")]
        public string _appmoduleidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_roleid_value")]
        public string _roleidValue { get; set; }

    }
}
