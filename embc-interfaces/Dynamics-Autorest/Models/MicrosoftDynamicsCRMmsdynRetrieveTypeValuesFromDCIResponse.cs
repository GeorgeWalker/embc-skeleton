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
    /// msdyn_RetrieveTypeValuesFromDCIResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynRetrieveTypeValuesFromDCIResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynRetrieveTypeValuesFromDCIResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynRetrieveTypeValuesFromDCIResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynRetrieveTypeValuesFromDCIResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynRetrieveTypeValuesFromDCIResponse(string responseValues = default(string))
        {
            ResponseValues = responseValues;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResponseValues")]
        public string ResponseValues { get; set; }

    }
}