// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The database edition capabilities.
    /// </summary>
    public partial class EditionCapability
    {
        /// <summary>
        /// Initializes a new instance of the EditionCapability class.
        /// </summary>
        public EditionCapability()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EditionCapability class.
        /// </summary>
        /// <param name="name">The edition name.</param>
        /// <param name="status">The status of the edition. Possible values
        /// include: 'Visible', 'Available', 'Default', 'Disabled'</param>
        /// <param name="supportedServiceLevelObjectives">The list of supported
        /// service objectives for the edition.</param>
        public EditionCapability(string name = default(string), CapabilityStatus? status = default(CapabilityStatus?), IList<ServiceObjectiveCapability> supportedServiceLevelObjectives = default(IList<ServiceObjectiveCapability>))
        {
            Name = name;
            Status = status;
            SupportedServiceLevelObjectives = supportedServiceLevelObjectives;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the edition name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the status of the edition. Possible values include: 'Visible',
        /// 'Available', 'Default', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public CapabilityStatus? Status { get; private set; }

        /// <summary>
        /// Gets the list of supported service objectives for the edition.
        /// </summary>
        [JsonProperty(PropertyName = "supportedServiceLevelObjectives")]
        public IList<ServiceObjectiveCapability> SupportedServiceLevelObjectives { get; private set; }

    }
}
