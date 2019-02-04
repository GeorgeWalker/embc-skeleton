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
    /// AttributeRequiredLevelManagedProperty
    /// </summary>
    public partial class MicrosoftDynamicsCRMAttributeRequiredLevelManagedProperty
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMAttributeRequiredLevelManagedProperty class.
        /// </summary>
        public MicrosoftDynamicsCRMAttributeRequiredLevelManagedProperty()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMAttributeRequiredLevelManagedProperty class.
        /// </summary>
        /// <param name="value">Possible values include: 'None',
        /// 'SystemRequired', 'ApplicationRequired', 'Recommended'</param>
        public MicrosoftDynamicsCRMAttributeRequiredLevelManagedProperty(string value = default(string), bool? canBeChanged = default(bool?), string managedPropertyLogicalName = default(string))
        {
            Value = value;
            CanBeChanged = canBeChanged;
            ManagedPropertyLogicalName = managedPropertyLogicalName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'None', 'SystemRequired',
        /// 'ApplicationRequired', 'Recommended'
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public string Value { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanBeChanged")]
        public bool? CanBeChanged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ManagedPropertyLogicalName")]
        public string ManagedPropertyLogicalName { get; set; }

    }
}
