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
    /// AttributeTypeDisplayName
    /// </summary>
    public partial class MicrosoftDynamicsCRMAttributeTypeDisplayName
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMAttributeTypeDisplayName class.
        /// </summary>
        public MicrosoftDynamicsCRMAttributeTypeDisplayName()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMAttributeTypeDisplayName class.
        /// </summary>
        public MicrosoftDynamicsCRMAttributeTypeDisplayName(string value = default(string))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public string Value { get; set; }

    }
}
