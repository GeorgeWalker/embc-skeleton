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
    /// RolePrivilege
    /// </summary>
    public partial class MicrosoftDynamicsCRMRolePrivilege
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMRolePrivilege
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMRolePrivilege()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMRolePrivilege
        /// class.
        /// </summary>
        /// <param name="depth">Possible values include: 'Basic', 'Local',
        /// 'Deep', 'Global'</param>
        public MicrosoftDynamicsCRMRolePrivilege(string depth = default(string), string privilegeId = default(string), string businessUnitId = default(string))
        {
            Depth = depth;
            PrivilegeId = privilegeId;
            BusinessUnitId = businessUnitId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Basic', 'Local', 'Deep',
        /// 'Global'
        /// </summary>
        [JsonProperty(PropertyName = "Depth")]
        public string Depth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrivilegeId")]
        public string PrivilegeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BusinessUnitId")]
        public string BusinessUnitId { get; set; }

    }
}
