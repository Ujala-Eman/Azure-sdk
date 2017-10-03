// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Managed integration runtime, including managed elastic and managed
    /// dedicated integration runtimes.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Managed")]
    [Rest.Serialization.JsonTransformation]
    public partial class ManagedIntegrationRuntime : IntegrationRuntime
    {
        /// <summary>
        /// Initializes a new instance of the ManagedIntegrationRuntime class.
        /// </summary>
        public ManagedIntegrationRuntime()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedIntegrationRuntime class.
        /// </summary>
        /// <param name="description">Integration runtime description.</param>
        /// <param name="state">Integration runtime state, only valid for
        /// managed dedicated integration runtime. Possible values include:
        /// 'Initial', 'Stopped', 'Started', 'Starting', 'Stopping',
        /// 'NeedRegistration', 'Online', 'Limited', 'Offline'</param>
        /// <param name="computeProperties">The compute resource for managed
        /// integration runtime.</param>
        /// <param name="ssisProperties">SSIS properties for managed
        /// integration runtime.</param>
        public ManagedIntegrationRuntime(string description = default(string), string state = default(string), IntegrationRuntimeComputeProperties computeProperties = default(IntegrationRuntimeComputeProperties), IntegrationRuntimeSsisProperties ssisProperties = default(IntegrationRuntimeSsisProperties))
            : base(description)
        {
            State = state;
            ComputeProperties = computeProperties;
            SsisProperties = ssisProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets integration runtime state, only valid for managed dedicated
        /// integration runtime. Possible values include: 'Initial', 'Stopped',
        /// 'Started', 'Starting', 'Stopping', 'NeedRegistration', 'Online',
        /// 'Limited', 'Offline'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; private set; }

        /// <summary>
        /// Gets or sets the compute resource for managed integration runtime.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.computeProperties")]
        public IntegrationRuntimeComputeProperties ComputeProperties { get; set; }

        /// <summary>
        /// Gets or sets SSIS properties for managed integration runtime.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.ssisProperties")]
        public IntegrationRuntimeSsisProperties SsisProperties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ComputeProperties != null)
            {
                ComputeProperties.Validate();
            }
            if (SsisProperties != null)
            {
                SsisProperties.Validate();
            }
        }
    }
}
