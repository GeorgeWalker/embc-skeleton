// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Embc.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// This OData service is located at
    /// https://pillspressdev.api.crm3.dynamics.com/api/data/v8.2/
    /// </summary>
    public partial interface IDynamicsClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Gets the IAccounts.
        /// </summary>
        IAccounts Accounts { get; }
        
        /// <summary>
        /// Gets the IContacts.
        /// </summary>
        IContacts Contacts { get; }
      
        /// <summary>
        /// Gets the ISharepointsites.
        /// </summary>
        ISharepointsites Sharepointsites { get; }

        /// <summary>
        /// Gets the IEntitydefinitions.
        /// </summary>
        IEntitydefinitions Entitydefinitions { get; }

        /// <summary>
        /// Gets the IGlobaloptionsetdefinitions.
        /// </summary>
        IGlobaloptionsetdefinitions Globaloptionsetdefinitions { get; }

    }
}
