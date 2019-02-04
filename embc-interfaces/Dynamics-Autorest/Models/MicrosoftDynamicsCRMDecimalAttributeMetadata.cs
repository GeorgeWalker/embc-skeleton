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
    /// DecimalAttributeMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMDecimalAttributeMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMDecimalAttributeMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMDecimalAttributeMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMDecimalAttributeMetadata class.
        /// </summary>
        /// <param name="imeMode">Possible values include: 'Auto', 'Inactive',
        /// 'Active', 'Disabled'</param>
        public MicrosoftDynamicsCRMDecimalAttributeMetadata(object maxValue = default(object), object minValue = default(object), int? precision = default(int?), string imeMode = default(string), string formulaDefinition = default(string), int? sourceTypeMask = default(int?))
        {
            MaxValue = maxValue;
            MinValue = minValue;
            Precision = precision;
            ImeMode = imeMode;
            FormulaDefinition = formulaDefinition;
            SourceTypeMask = sourceTypeMask;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaxValue")]
        public object MaxValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MinValue")]
        public object MinValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Precision")]
        public int? Precision { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Auto', 'Inactive', 'Active',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "ImeMode")]
        public string ImeMode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FormulaDefinition")]
        public string FormulaDefinition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SourceTypeMask")]
        public int? SourceTypeMask { get; set; }

    }
}
