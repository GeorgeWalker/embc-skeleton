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
    /// opportunitycompetitors
    /// </summary>
    public partial class MicrosoftDynamicsCRMopportunitycompetitors
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMopportunitycompetitors class.
        /// </summary>
        public MicrosoftDynamicsCRMopportunitycompetitors()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMopportunitycompetitors class.
        /// </summary>
        public MicrosoftDynamicsCRMopportunitycompetitors(string opportunitycompetitorid = default(string), long? versionnumber = default(long?), string opportunityid = default(string), string competitorid = default(string))
        {
            Opportunitycompetitorid = opportunitycompetitorid;
            Versionnumber = versionnumber;
            Opportunityid = opportunityid;
            Competitorid = competitorid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunitycompetitorid")]
        public string Opportunitycompetitorid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityid")]
        public string Opportunityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorid")]
        public string Competitorid { get; set; }

    }
}
