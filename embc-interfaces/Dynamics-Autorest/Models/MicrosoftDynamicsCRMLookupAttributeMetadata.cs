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
    /// LookupAttributeMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMLookupAttributeMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMLookupAttributeMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMLookupAttributeMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMLookupAttributeMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMLookupAttributeMetadata(IList<string> targets = default(IList<string>))
        {
            Targets = targets;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Targets")]
        public IList<string> Targets { get; set; }

    }
}
