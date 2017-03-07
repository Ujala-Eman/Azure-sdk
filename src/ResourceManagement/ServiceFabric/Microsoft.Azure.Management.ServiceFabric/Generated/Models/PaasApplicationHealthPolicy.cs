// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Paas application health policy
    /// </summary>
    public partial class PaasApplicationHealthPolicy
    {
        /// <summary>
        /// Initializes a new instance of the PaasApplicationHealthPolicy
        /// class.
        /// </summary>
        public PaasApplicationHealthPolicy() { }

        /// <summary>
        /// Initializes a new instance of the PaasApplicationHealthPolicy
        /// class.
        /// </summary>
        public PaasApplicationHealthPolicy(PaasServiceTypeHealthPolicy defaultServiceTypeHealthPolicy = default(PaasServiceTypeHealthPolicy), IDictionary<string, PaasServiceTypeHealthPolicy> serivceTypeHealthPolicies = default(IDictionary<string, PaasServiceTypeHealthPolicy>))
        {
            DefaultServiceTypeHealthPolicy = defaultServiceTypeHealthPolicy;
            SerivceTypeHealthPolicies = serivceTypeHealthPolicies;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultServiceTypeHealthPolicy")]
        public PaasServiceTypeHealthPolicy DefaultServiceTypeHealthPolicy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serivceTypeHealthPolicies")]
        public IDictionary<string, PaasServiceTypeHealthPolicy> SerivceTypeHealthPolicies { get; set; }

    }
}
