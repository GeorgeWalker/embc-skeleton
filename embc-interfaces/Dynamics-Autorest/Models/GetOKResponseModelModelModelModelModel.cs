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
    /// Collection of bcgov_customaddresses
    /// </summary>
    public partial class GetOKResponseModelModelModelModelModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GetOKResponseModelModelModelModelModel class.
        /// </summary>
        public GetOKResponseModelModelModelModelModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GetOKResponseModelModelModelModelModel class.
        /// </summary>
        public GetOKResponseModelModelModelModelModel(IList<MicrosoftDynamicsCRMbcgovCustomaddress> value = default(IList<MicrosoftDynamicsCRMbcgovCustomaddress>))
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
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMbcgovCustomaddress> Value { get; set; }

    }
}
