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
    /// Component
    /// </summary>
    public partial class MicrosoftDynamicsCRMComponent
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMComponent
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMComponent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMComponent
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMComponent(string displayName = default(string), string schemaName = default(string), int? componentType = default(int?), int? componentSubType = default(int?), string componentId = default(string), string parentEntityId = default(string), string parentEntityName = default(string))
        {
            DisplayName = displayName;
            SchemaName = schemaName;
            ComponentType = componentType;
            ComponentSubType = componentSubType;
            ComponentId = componentId;
            ParentEntityId = parentEntityId;
            ParentEntityName = parentEntityName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SchemaName")]
        public string SchemaName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ComponentType")]
        public int? ComponentType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ComponentSubType")]
        public int? ComponentSubType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ComponentId")]
        public string ComponentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ParentEntityId")]
        public string ParentEntityId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ParentEntityName")]
        public string ParentEntityName { get; set; }

    }
}