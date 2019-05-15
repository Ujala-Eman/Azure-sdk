// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HealthcareApis.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The settings for the Cosmos DB database backing the service.
    /// </summary>
    public partial class ServiceCosmosDbConfigurationInfo
    {
        /// <summary>
        /// Initializes a new instance of the ServiceCosmosDbConfigurationInfo
        /// class.
        /// </summary>
        public ServiceCosmosDbConfigurationInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceCosmosDbConfigurationInfo
        /// class.
        /// </summary>
        /// <param name="offerThroughput">The provisioned throughput for the
        /// backing database.</param>
        public ServiceCosmosDbConfigurationInfo(int? offerThroughput = default(int?))
        {
            OfferThroughput = offerThroughput;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the provisioned throughput for the backing database.
        /// </summary>
        [JsonProperty(PropertyName = "offerThroughput")]
        public int? OfferThroughput { get; set; }

    }
}
