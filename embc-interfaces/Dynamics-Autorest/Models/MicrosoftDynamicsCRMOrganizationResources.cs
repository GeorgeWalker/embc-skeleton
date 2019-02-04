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
    /// OrganizationResources
    /// </summary>
    public partial class MicrosoftDynamicsCRMOrganizationResources
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMOrganizationResources class.
        /// </summary>
        public MicrosoftDynamicsCRMOrganizationResources()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMOrganizationResources class.
        /// </summary>
        public MicrosoftDynamicsCRMOrganizationResources(int? currentNumberOfActiveUsers = default(int?), int? maxNumberOfActiveUsers = default(int?), int? currentNumberOfNonInteractiveUsers = default(int?), int? maxNumberOfNonInteractiveUsers = default(int?), int? currentNumberOfCustomEntities = default(int?), int? maxNumberOfCustomEntities = default(int?), int? currentNumberOfPublishedWorkflows = default(int?), int? maxNumberOfPublishedWorkflows = default(int?), int? currentStorage = default(int?), int? maxStorage = default(int?))
        {
            CurrentNumberOfActiveUsers = currentNumberOfActiveUsers;
            MaxNumberOfActiveUsers = maxNumberOfActiveUsers;
            CurrentNumberOfNonInteractiveUsers = currentNumberOfNonInteractiveUsers;
            MaxNumberOfNonInteractiveUsers = maxNumberOfNonInteractiveUsers;
            CurrentNumberOfCustomEntities = currentNumberOfCustomEntities;
            MaxNumberOfCustomEntities = maxNumberOfCustomEntities;
            CurrentNumberOfPublishedWorkflows = currentNumberOfPublishedWorkflows;
            MaxNumberOfPublishedWorkflows = maxNumberOfPublishedWorkflows;
            CurrentStorage = currentStorage;
            MaxStorage = maxStorage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CurrentNumberOfActiveUsers")]
        public int? CurrentNumberOfActiveUsers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaxNumberOfActiveUsers")]
        public int? MaxNumberOfActiveUsers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CurrentNumberOfNonInteractiveUsers")]
        public int? CurrentNumberOfNonInteractiveUsers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaxNumberOfNonInteractiveUsers")]
        public int? MaxNumberOfNonInteractiveUsers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CurrentNumberOfCustomEntities")]
        public int? CurrentNumberOfCustomEntities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaxNumberOfCustomEntities")]
        public int? MaxNumberOfCustomEntities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CurrentNumberOfPublishedWorkflows")]
        public int? CurrentNumberOfPublishedWorkflows { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaxNumberOfPublishedWorkflows")]
        public int? MaxNumberOfPublishedWorkflows { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CurrentStorage")]
        public int? CurrentStorage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaxStorage")]
        public int? MaxStorage { get; set; }

    }
}
