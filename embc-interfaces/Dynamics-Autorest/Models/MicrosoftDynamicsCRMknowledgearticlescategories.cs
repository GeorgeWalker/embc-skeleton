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
    /// knowledgearticlescategories
    /// </summary>
    public partial class MicrosoftDynamicsCRMknowledgearticlescategories
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMknowledgearticlescategories class.
        /// </summary>
        public MicrosoftDynamicsCRMknowledgearticlescategories()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMknowledgearticlescategories class.
        /// </summary>
        public MicrosoftDynamicsCRMknowledgearticlescategories(string knowledgearticlecategoryid = default(string), string categoryid = default(string), string knowledgearticleid = default(string), long? versionnumber = default(long?))
        {
            Knowledgearticlecategoryid = knowledgearticlecategoryid;
            Categoryid = categoryid;
            Knowledgearticleid = knowledgearticleid;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticlecategoryid")]
        public string Knowledgearticlecategoryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "categoryid")]
        public string Categoryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticleid")]
        public string Knowledgearticleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

    }
}
