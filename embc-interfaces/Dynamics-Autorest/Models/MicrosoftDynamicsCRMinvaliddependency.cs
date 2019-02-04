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
    /// invaliddependency
    /// </summary>
    public partial class MicrosoftDynamicsCRMinvaliddependency
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMinvaliddependency class.
        /// </summary>
        public MicrosoftDynamicsCRMinvaliddependency()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMinvaliddependency class.
        /// </summary>
        public MicrosoftDynamicsCRMinvaliddependency(int? existingcomponenttype = default(int?), int? existingdependencytype = default(int?), string missingcomponentid = default(string), int? missingcomponentlookuptype = default(int?), string invaliddependencyid = default(string), string missingcomponentinfo = default(string), bool? isexistingnoderequiredcomponent = default(bool?), int? missingcomponenttype = default(int?), string existingcomponentid = default(string))
        {
            Existingcomponenttype = existingcomponenttype;
            Existingdependencytype = existingdependencytype;
            Missingcomponentid = missingcomponentid;
            Missingcomponentlookuptype = missingcomponentlookuptype;
            Invaliddependencyid = invaliddependencyid;
            Missingcomponentinfo = missingcomponentinfo;
            Isexistingnoderequiredcomponent = isexistingnoderequiredcomponent;
            Missingcomponenttype = missingcomponenttype;
            Existingcomponentid = existingcomponentid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "existingcomponenttype")]
        public int? Existingcomponenttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "existingdependencytype")]
        public int? Existingdependencytype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "missingcomponentid")]
        public string Missingcomponentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "missingcomponentlookuptype")]
        public int? Missingcomponentlookuptype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invaliddependencyid")]
        public string Invaliddependencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "missingcomponentinfo")]
        public string Missingcomponentinfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isexistingnoderequiredcomponent")]
        public bool? Isexistingnoderequiredcomponent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "missingcomponenttype")]
        public int? Missingcomponenttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "existingcomponentid")]
        public string Existingcomponentid { get; set; }

    }
}
