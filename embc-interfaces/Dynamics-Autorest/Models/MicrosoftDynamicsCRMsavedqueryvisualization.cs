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
    /// savedqueryvisualization
    /// </summary>
    public partial class MicrosoftDynamicsCRMsavedqueryvisualization
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsavedqueryvisualization class.
        /// </summary>
        public MicrosoftDynamicsCRMsavedqueryvisualization()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsavedqueryvisualization class.
        /// </summary>
        public MicrosoftDynamicsCRMsavedqueryvisualization(string presentationdescription = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), MicrosoftDynamicsCRMBooleanManagedProperty canbedeleted = default(MicrosoftDynamicsCRMBooleanManagedProperty), string _createdbyValue = default(string), int? type = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), string primaryentitytypecode = default(string), string description = default(string), string introducedversion = default(string), int? componentstate = default(int?), string datadescription = default(string), int? charttype = default(int?), bool? ismanaged = default(bool?), string _organizationidValue = default(string), string _modifiedonbehalfbyValue = default(string), long? versionnumber = default(long?), string savedqueryvisualizationid = default(string), string _webresourceidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string name = default(string), bool? isdefault = default(bool?), MicrosoftDynamicsCRMBooleanManagedProperty iscustomizable = default(MicrosoftDynamicsCRMBooleanManagedProperty), string _createdonbehalfbyValue = default(string), string savedqueryvisualizationidunique = default(string), string solutionid = default(string), IList<MicrosoftDynamicsCRMsyncerror> savedQueryVisualizationSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMwebresource webresourceid = default(MicrosoftDynamicsCRMwebresource), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Presentationdescription = presentationdescription;
            Overwritetime = overwritetime;
            Canbedeleted = canbedeleted;
            this._createdbyValue = _createdbyValue;
            Type = type;
            Modifiedon = modifiedon;
            this._modifiedbyValue = _modifiedbyValue;
            Primaryentitytypecode = primaryentitytypecode;
            Description = description;
            Introducedversion = introducedversion;
            Componentstate = componentstate;
            Datadescription = datadescription;
            Charttype = charttype;
            Ismanaged = ismanaged;
            this._organizationidValue = _organizationidValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Versionnumber = versionnumber;
            Savedqueryvisualizationid = savedqueryvisualizationid;
            this._webresourceidValue = _webresourceidValue;
            Createdon = createdon;
            Name = name;
            Isdefault = isdefault;
            Iscustomizable = iscustomizable;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Savedqueryvisualizationidunique = savedqueryvisualizationidunique;
            Solutionid = solutionid;
            SavedQueryVisualizationSyncErrors = savedQueryVisualizationSyncErrors;
            Createdonbehalfby = createdonbehalfby;
            Organizationid = organizationid;
            Createdby = createdby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Webresourceid = webresourceid;
            Modifiedby = modifiedby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "presentationdescription")]
        public string Presentationdescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canbedeleted")]
        public MicrosoftDynamicsCRMBooleanManagedProperty Canbedeleted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public int? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primaryentitytypecode")]
        public string Primaryentitytypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datadescription")]
        public string Datadescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "charttype")]
        public int? Charttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "savedqueryvisualizationid")]
        public string Savedqueryvisualizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_webresourceid_value")]
        public string _webresourceidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdefault")]
        public bool? Isdefault { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public MicrosoftDynamicsCRMBooleanManagedProperty Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "savedqueryvisualizationidunique")]
        public string Savedqueryvisualizationidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SavedQueryVisualization_SyncErrors")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsyncerror> SavedQueryVisualizationSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "webresourceid")]
        public MicrosoftDynamicsCRMwebresource Webresourceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

    }
}
