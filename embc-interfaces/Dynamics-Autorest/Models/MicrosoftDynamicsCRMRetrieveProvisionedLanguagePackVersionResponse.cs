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
    /// RetrieveProvisionedLanguagePackVersionResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMRetrieveProvisionedLanguagePackVersionResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveProvisionedLanguagePackVersionResponse
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveProvisionedLanguagePackVersionResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveProvisionedLanguagePackVersionResponse
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveProvisionedLanguagePackVersionResponse(string version = default(string))
        {
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Version")]
        public string Version { get; set; }

    }
}
