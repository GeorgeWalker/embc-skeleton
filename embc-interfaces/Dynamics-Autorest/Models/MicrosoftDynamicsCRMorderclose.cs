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
    /// orderclose
    /// </summary>
    public partial class MicrosoftDynamicsCRMorderclose
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMorderclose
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMorderclose()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMorderclose
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMorderclose(int? importsequencenumber = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? revision = default(int?), string category = default(string), string _salesorderidValue = default(string), string subcategory = default(string), string ordernumber = default(string), MicrosoftDynamicsCRMsystemuser createdonbehalfbyOrderclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbusinessunit owningbusinessunitOrderclose = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> orderCloseSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsystemuser modifiedbyOrderclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyOrderclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdbyOrderclose = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkdeletefailure> orderCloseBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMservice serviceidOrderclose = default(MicrosoftDynamicsCRMservice), IList<MicrosoftDynamicsCRMannotation> orderCloseAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMactivityparty> ordercloseActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), MicrosoftDynamicsCRMsystemuser owninguserOrderclose = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> orderCloseAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsalesorder salesorderid = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMteam owningteamOrderclose = default(MicrosoftDynamicsCRMteam))
        {
            Importsequencenumber = importsequencenumber;
            Overriddencreatedon = overriddencreatedon;
            Revision = revision;
            Category = category;
            this._salesorderidValue = _salesorderidValue;
            Subcategory = subcategory;
            Ordernumber = ordernumber;
            CreatedonbehalfbyOrderclose = createdonbehalfbyOrderclose;
            OwningbusinessunitOrderclose = owningbusinessunitOrderclose;
            OrderCloseSyncErrors = orderCloseSyncErrors;
            ModifiedbyOrderclose = modifiedbyOrderclose;
            ModifiedonbehalfbyOrderclose = modifiedonbehalfbyOrderclose;
            CreatedbyOrderclose = createdbyOrderclose;
            OrderCloseBulkDeleteFailures = orderCloseBulkDeleteFailures;
            ServiceidOrderclose = serviceidOrderclose;
            OrderCloseAnnotation = orderCloseAnnotation;
            OrdercloseActivityParties = ordercloseActivityParties;
            OwninguserOrderclose = owninguserOrderclose;
            OrderCloseAsyncOperations = orderCloseAsyncOperations;
            Salesorderid = salesorderid;
            ActivityidActivitypointer = activityidActivitypointer;
            OwningteamOrderclose = owningteamOrderclose;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "revision")]
        public int? Revision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_salesorderid_value")]
        public string _salesorderidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ordernumber")]
        public string Ordernumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_orderclose")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyOrderclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_orderclose")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitOrderclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrderClose_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> OrderCloseSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_orderclose")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyOrderclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_orderclose")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyOrderclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_orderclose")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyOrderclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrderClose_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> OrderCloseBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid_orderclose")]
        public MicrosoftDynamicsCRMservice ServiceidOrderclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrderClose_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> OrderCloseAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "orderclose_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> OrdercloseActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_orderclose")]
        public MicrosoftDynamicsCRMsystemuser OwninguserOrderclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrderClose_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> OrderCloseAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesorderid")]
        public MicrosoftDynamicsCRMsalesorder Salesorderid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_orderclose")]
        public MicrosoftDynamicsCRMteam OwningteamOrderclose { get; set; }

    }
}
