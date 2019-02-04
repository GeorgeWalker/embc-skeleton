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
    /// AttributeMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMAttributeMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMAttributeMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMAttributeMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMAttributeMetadata class.
        /// </summary>
        /// <param name="attributeType">Possible values include: 'Boolean',
        /// 'Customer', 'DateTime', 'Decimal', 'Double', 'Integer', 'Lookup',
        /// 'Memo', 'Money', 'Owner', 'PartyList', 'Picklist', 'State',
        /// 'Status', 'String', 'Uniqueidentifier', 'CalendarRules', 'Virtual',
        /// 'BigInt', 'ManagedProperty', 'EntityName'</param>
        public MicrosoftDynamicsCRMAttributeMetadata(string attributeOf = default(string), string attributeType = default(string), MicrosoftDynamicsCRMAttributeTypeDisplayName attributeTypeName = default(MicrosoftDynamicsCRMAttributeTypeDisplayName), int? columnNumber = default(int?), MicrosoftDynamicsCRMLabel description = default(MicrosoftDynamicsCRMLabel), MicrosoftDynamicsCRMLabel displayName = default(MicrosoftDynamicsCRMLabel), string deprecatedVersion = default(string), string introducedVersion = default(string), string entityLogicalName = default(string), MicrosoftDynamicsCRMBooleanManagedProperty isAuditEnabled = default(MicrosoftDynamicsCRMBooleanManagedProperty), bool? isCustomAttribute = default(bool?), bool? isPrimaryId = default(bool?), bool? isPrimaryName = default(bool?), bool? isValidForCreate = default(bool?), bool? isValidForRead = default(bool?), bool? isValidForUpdate = default(bool?), bool? canBeSecuredForRead = default(bool?), bool? canBeSecuredForCreate = default(bool?), bool? canBeSecuredForUpdate = default(bool?), bool? isSecured = default(bool?), bool? isRetrievable = default(bool?), bool? isFilterable = default(bool?), bool? isSearchable = default(bool?), bool? isManaged = default(bool?), MicrosoftDynamicsCRMBooleanManagedProperty isGlobalFilterEnabled = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty isSortableEnabled = default(MicrosoftDynamicsCRMBooleanManagedProperty), string linkedAttributeId = default(string), string logicalName = default(string), MicrosoftDynamicsCRMBooleanManagedProperty isCustomizable = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty isRenameable = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty isValidForAdvancedFind = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMAttributeRequiredLevelManagedProperty requiredLevel = default(MicrosoftDynamicsCRMAttributeRequiredLevelManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty canModifyAdditionalSettings = default(MicrosoftDynamicsCRMBooleanManagedProperty), string schemaName = default(string), bool? isLogical = default(bool?), string inheritsFrom = default(string), int? sourceType = default(int?))
        {
            AttributeOf = attributeOf;
            AttributeType = attributeType;
            AttributeTypeName = attributeTypeName;
            ColumnNumber = columnNumber;
            Description = description;
            DisplayName = displayName;
            DeprecatedVersion = deprecatedVersion;
            IntroducedVersion = introducedVersion;
            EntityLogicalName = entityLogicalName;
            IsAuditEnabled = isAuditEnabled;
            IsCustomAttribute = isCustomAttribute;
            IsPrimaryId = isPrimaryId;
            IsPrimaryName = isPrimaryName;
            IsValidForCreate = isValidForCreate;
            IsValidForRead = isValidForRead;
            IsValidForUpdate = isValidForUpdate;
            CanBeSecuredForRead = canBeSecuredForRead;
            CanBeSecuredForCreate = canBeSecuredForCreate;
            CanBeSecuredForUpdate = canBeSecuredForUpdate;
            IsSecured = isSecured;
            IsRetrievable = isRetrievable;
            IsFilterable = isFilterable;
            IsSearchable = isSearchable;
            IsManaged = isManaged;
            IsGlobalFilterEnabled = isGlobalFilterEnabled;
            IsSortableEnabled = isSortableEnabled;
            LinkedAttributeId = linkedAttributeId;
            LogicalName = logicalName;
            IsCustomizable = isCustomizable;
            IsRenameable = isRenameable;
            IsValidForAdvancedFind = isValidForAdvancedFind;
            RequiredLevel = requiredLevel;
            CanModifyAdditionalSettings = canModifyAdditionalSettings;
            SchemaName = schemaName;
            IsLogical = isLogical;
            InheritsFrom = inheritsFrom;
            SourceType = sourceType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AttributeOf")]
        public string AttributeOf { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Boolean', 'Customer',
        /// 'DateTime', 'Decimal', 'Double', 'Integer', 'Lookup', 'Memo',
        /// 'Money', 'Owner', 'PartyList', 'Picklist', 'State', 'Status',
        /// 'String', 'Uniqueidentifier', 'CalendarRules', 'Virtual', 'BigInt',
        /// 'ManagedProperty', 'EntityName'
        /// </summary>
        [JsonProperty(PropertyName = "AttributeType")]
        public string AttributeType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AttributeTypeName")]
        public MicrosoftDynamicsCRMAttributeTypeDisplayName AttributeTypeName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ColumnNumber")]
        public int? ColumnNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public MicrosoftDynamicsCRMLabel Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayName")]
        public MicrosoftDynamicsCRMLabel DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DeprecatedVersion")]
        public string DeprecatedVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IntroducedVersion")]
        public string IntroducedVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityLogicalName")]
        public string EntityLogicalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsAuditEnabled")]
        public MicrosoftDynamicsCRMBooleanManagedProperty IsAuditEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsCustomAttribute")]
        public bool? IsCustomAttribute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsPrimaryId")]
        public bool? IsPrimaryId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsPrimaryName")]
        public bool? IsPrimaryName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsValidForCreate")]
        public bool? IsValidForCreate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsValidForRead")]
        public bool? IsValidForRead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsValidForUpdate")]
        public bool? IsValidForUpdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanBeSecuredForRead")]
        public bool? CanBeSecuredForRead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanBeSecuredForCreate")]
        public bool? CanBeSecuredForCreate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanBeSecuredForUpdate")]
        public bool? CanBeSecuredForUpdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsSecured")]
        public bool? IsSecured { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsRetrievable")]
        public bool? IsRetrievable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsFilterable")]
        public bool? IsFilterable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsSearchable")]
        public bool? IsSearchable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsManaged")]
        public bool? IsManaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsGlobalFilterEnabled")]
        public MicrosoftDynamicsCRMBooleanManagedProperty IsGlobalFilterEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsSortableEnabled")]
        public MicrosoftDynamicsCRMBooleanManagedProperty IsSortableEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LinkedAttributeId")]
        public string LinkedAttributeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LogicalName")]
        public string LogicalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsCustomizable")]
        public MicrosoftDynamicsCRMBooleanManagedProperty IsCustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsRenameable")]
        public MicrosoftDynamicsCRMBooleanManagedProperty IsRenameable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsValidForAdvancedFind")]
        public MicrosoftDynamicsCRMBooleanManagedProperty IsValidForAdvancedFind { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RequiredLevel")]
        public MicrosoftDynamicsCRMAttributeRequiredLevelManagedProperty RequiredLevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanModifyAdditionalSettings")]
        public MicrosoftDynamicsCRMBooleanManagedProperty CanModifyAdditionalSettings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SchemaName")]
        public string SchemaName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsLogical")]
        public bool? IsLogical { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InheritsFrom")]
        public string InheritsFrom { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SourceType")]
        public int? SourceType { get; set; }

    }
}
