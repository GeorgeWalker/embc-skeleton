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
    /// subscriptionstatisticsoffline
    /// </summary>
    public partial class MicrosoftDynamicsCRMsubscriptionstatisticsoffline
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsubscriptionstatisticsoffline class.
        /// </summary>
        public MicrosoftDynamicsCRMsubscriptionstatisticsoffline()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsubscriptionstatisticsoffline class.
        /// </summary>
        public MicrosoftDynamicsCRMsubscriptionstatisticsoffline(string subscriptionid = default(string), bool? fullsyncrequired = default(bool?), int? objecttypecode = default(int?))
        {
            Subscriptionid = subscriptionid;
            Fullsyncrequired = fullsyncrequired;
            Objecttypecode = objecttypecode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionid")]
        public string Subscriptionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fullsyncrequired")]
        public bool? Fullsyncrequired { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public int? Objecttypecode { get; set; }

    }
}
