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
    /// OrganizationDetail
    /// </summary>
    public partial class MicrosoftDynamicsCRMOrganizationDetail
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMOrganizationDetail class.
        /// </summary>
        public MicrosoftDynamicsCRMOrganizationDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMOrganizationDetail class.
        /// </summary>
        /// <param name="state">Possible values include: 'Enabled',
        /// 'Disabled'</param>
        public MicrosoftDynamicsCRMOrganizationDetail(string organizationId = default(string), string friendlyName = default(string), string organizationVersion = default(string), string urlName = default(string), string uniqueName = default(string), MicrosoftDynamicsCRMEndpointCollection endpoints = default(MicrosoftDynamicsCRMEndpointCollection), string state = default(string))
        {
            OrganizationId = organizationId;
            FriendlyName = friendlyName;
            OrganizationVersion = organizationVersion;
            UrlName = urlName;
            UniqueName = uniqueName;
            Endpoints = endpoints;
            State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrganizationId")]
        public string OrganizationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FriendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrganizationVersion")]
        public string OrganizationVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UrlName")]
        public string UrlName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UniqueName")]
        public string UniqueName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Endpoints")]
        public MicrosoftDynamicsCRMEndpointCollection Endpoints { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "State")]
        public string State { get; set; }

    }
}
