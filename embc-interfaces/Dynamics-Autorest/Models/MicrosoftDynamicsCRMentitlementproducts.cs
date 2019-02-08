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
    using System.Linq; using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// entitlementproducts
    /// </summary>
    public partial class MicrosoftDynamicsCRMentitlementproducts
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMentitlementproducts class.
        /// </summary>
        public MicrosoftDynamicsCRMentitlementproducts()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMentitlementproducts class.
        /// </summary>
        public MicrosoftDynamicsCRMentitlementproducts(int? timezoneruleversionnumber = default(int?), long? versionnumber = default(long?), string entitlementproductid = default(string), string entitlementid = default(string), int? importsequencenumber = default(int?), string productid = default(string), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), IList<MicrosoftDynamicsCRMasyncoperation> entitlementproductsAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> entitlementproductsMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> entitlementproductsBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> entitlementproductsPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Versionnumber = versionnumber;
            Entitlementproductid = entitlementproductid;
            Entitlementid = entitlementid;
            Importsequencenumber = importsequencenumber;
            Productid = productid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Overriddencreatedon = overriddencreatedon;
            EntitlementproductsAsyncOperations = entitlementproductsAsyncOperations;
            EntitlementproductsMailboxTrackingFolders = entitlementproductsMailboxTrackingFolders;
            EntitlementproductsBulkDeleteFailures = entitlementproductsBulkDeleteFailures;
            EntitlementproductsPrincipalObjectAttributeAccesses = entitlementproductsPrincipalObjectAttributeAccesses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementproductid")]
        public string Entitlementproductid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementid")]
        public string Entitlementid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productid")]
        public string Productid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementproducts_AsyncOperations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMasyncoperation> EntitlementproductsAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementproducts_MailboxTrackingFolders")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> EntitlementproductsMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementproducts_BulkDeleteFailures")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbulkdeletefailure> EntitlementproductsBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementproducts_PrincipalObjectAttributeAccesses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> EntitlementproductsPrincipalObjectAttributeAccesses { get; set; }

    }
}
