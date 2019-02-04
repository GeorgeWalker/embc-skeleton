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
    /// LinkEntity
    /// </summary>
    public partial class MicrosoftDynamicsCRMLinkEntity
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMLinkEntity
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMLinkEntity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMLinkEntity
        /// class.
        /// </summary>
        /// <param name="joinOperator">Possible values include: 'Inner',
        /// 'LeftOuter', 'Natural'</param>
        public MicrosoftDynamicsCRMLinkEntity(string linkFromAttributeName = default(string), string linkFromEntityName = default(string), string linkToEntityName = default(string), string linkToAttributeName = default(string), string joinOperator = default(string), MicrosoftDynamicsCRMFilterExpression linkCriteria = default(MicrosoftDynamicsCRMFilterExpression), IList<MicrosoftDynamicsCRMLinkEntity> linkEntities = default(IList<MicrosoftDynamicsCRMLinkEntity>), MicrosoftDynamicsCRMColumnSet columns = default(MicrosoftDynamicsCRMColumnSet), string entityAlias = default(string), IList<MicrosoftDynamicsCRMOrderExpression> orders = default(IList<MicrosoftDynamicsCRMOrderExpression>))
        {
            LinkFromAttributeName = linkFromAttributeName;
            LinkFromEntityName = linkFromEntityName;
            LinkToEntityName = linkToEntityName;
            LinkToAttributeName = linkToAttributeName;
            JoinOperator = joinOperator;
            LinkCriteria = linkCriteria;
            LinkEntities = linkEntities;
            Columns = columns;
            EntityAlias = entityAlias;
            Orders = orders;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LinkFromAttributeName")]
        public string LinkFromAttributeName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LinkFromEntityName")]
        public string LinkFromEntityName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LinkToEntityName")]
        public string LinkToEntityName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LinkToAttributeName")]
        public string LinkToAttributeName { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Inner', 'LeftOuter',
        /// 'Natural'
        /// </summary>
        [JsonProperty(PropertyName = "JoinOperator")]
        public string JoinOperator { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LinkCriteria")]
        public MicrosoftDynamicsCRMFilterExpression LinkCriteria { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LinkEntities")]
        public IList<MicrosoftDynamicsCRMLinkEntity> LinkEntities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Columns")]
        public MicrosoftDynamicsCRMColumnSet Columns { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityAlias")]
        public string EntityAlias { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Orders")]
        public IList<MicrosoftDynamicsCRMOrderExpression> Orders { get; set; }

    }
}
