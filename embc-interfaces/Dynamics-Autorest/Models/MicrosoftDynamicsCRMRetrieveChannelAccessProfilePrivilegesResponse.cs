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
    /// RetrieveChannelAccessProfilePrivilegesResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMRetrieveChannelAccessProfilePrivilegesResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveChannelAccessProfilePrivilegesResponse
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveChannelAccessProfilePrivilegesResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveChannelAccessProfilePrivilegesResponse
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveChannelAccessProfilePrivilegesResponse(MicrosoftDynamicsCRMChannelAccessProfileWithPrivileges channelAccessProfile = default(MicrosoftDynamicsCRMChannelAccessProfileWithPrivileges))
        {
            ChannelAccessProfile = channelAccessProfile;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ChannelAccessProfile")]
        public MicrosoftDynamicsCRMChannelAccessProfileWithPrivileges ChannelAccessProfile { get; set; }

    }
}
