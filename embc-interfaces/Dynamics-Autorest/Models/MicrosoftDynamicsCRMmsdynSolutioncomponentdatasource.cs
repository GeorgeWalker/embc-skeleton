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
    /// msdyn_solutioncomponentdatasource
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynSolutioncomponentdatasource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynSolutioncomponentdatasource class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynSolutioncomponentdatasource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynSolutioncomponentdatasource class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynSolutioncomponentdatasource(string msdynName = default(string), string msdynSolutioncomponentdatasourceid = default(string), IList<MicrosoftDynamicsCRMannotation> msdynSolutioncomponentdatasourceAnnotations = default(IList<MicrosoftDynamicsCRMannotation>))
        {
            MsdynName = msdynName;
            MsdynSolutioncomponentdatasourceid = msdynSolutioncomponentdatasourceid;
            MsdynSolutioncomponentdatasourceAnnotations = msdynSolutioncomponentdatasourceAnnotations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_name")]
        public string MsdynName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_solutioncomponentdatasourceid")]
        public string MsdynSolutioncomponentdatasourceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_solutioncomponentdatasource_Annotations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMannotation> MsdynSolutioncomponentdatasourceAnnotations { get; set; }

    }
}