// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class SingleQueryResult
    {
        /// <summary>
        /// Initializes a new instance of the SingleQueryResult class.
        /// </summary>
        public SingleQueryResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SingleQueryResult class.
        /// </summary>
        /// <param name="signatureId">The ID of the signature</param>
        /// <param name="mode">The current mode enforced, 0 - Disabled, 1 -
        /// Alert, 2 -Deny</param>
        /// <param name="severity">Describes the severity of signature: 1 -
        /// Low, 2 - Medium, 3 - High</param>
        /// <param name="direction">Describes in which direction signature is
        /// being enforced: 0 - Inbound, 1 - OutBound, 2 -
        /// Bidirectional</param>
        /// <param name="group">Describes the groups the signature belongs
        /// to</param>
        /// <param name="description">Describes what is the signature
        /// enforces</param>
        /// <param name="protocol">Describes the protocol the signatures is
        /// being enforced in</param>
        /// <param name="sourcePorts">Describes the list of source ports
        /// related to this signature</param>
        /// <param name="destinationPorts">Describes the list of destination
        /// ports related to this signature</param>
        /// <param name="lastUpdated">Describes the last updated time of the
        /// signature (provided from 3rd party vendor)</param>
        /// <param name="inheritedFromParentPolicy">Describes if this override
        /// is inherited from base policy or not</param>
        public SingleQueryResult(int? signatureId = default(int?), int? mode = default(int?), int? severity = default(int?), int? direction = default(int?), string group = default(string), string description = default(string), string protocol = default(string), IList<string> sourcePorts = default(IList<string>), IList<string> destinationPorts = default(IList<string>), string lastUpdated = default(string), bool? inheritedFromParentPolicy = default(bool?))
        {
            SignatureId = signatureId;
            Mode = mode;
            Severity = severity;
            Direction = direction;
            Group = group;
            Description = description;
            Protocol = protocol;
            SourcePorts = sourcePorts;
            DestinationPorts = destinationPorts;
            LastUpdated = lastUpdated;
            InheritedFromParentPolicy = inheritedFromParentPolicy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the signature
        /// </summary>
        [JsonProperty(PropertyName = "signatureId")]
        public int? SignatureId { get; set; }

        /// <summary>
        /// Gets or sets the current mode enforced, 0 - Disabled, 1 - Alert, 2
        /// -Deny
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public int? Mode { get; set; }

        /// <summary>
        /// Gets or sets describes the severity of signature: 1 - Low, 2 -
        /// Medium, 3 - High
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public int? Severity { get; set; }

        /// <summary>
        /// Gets or sets describes in which direction signature is being
        /// enforced: 0 - Inbound, 1 - OutBound, 2 - Bidirectional
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        public int? Direction { get; set; }

        /// <summary>
        /// Gets or sets describes the groups the signature belongs to
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }

        /// <summary>
        /// Gets or sets describes what is the signature enforces
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets describes the protocol the signatures is being
        /// enforced in
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets describes the list of source ports related to this
        /// signature
        /// </summary>
        [JsonProperty(PropertyName = "sourcePorts")]
        public IList<string> SourcePorts { get; set; }

        /// <summary>
        /// Gets or sets describes the list of destination ports related to
        /// this signature
        /// </summary>
        [JsonProperty(PropertyName = "destinationPorts")]
        public IList<string> DestinationPorts { get; set; }

        /// <summary>
        /// Gets or sets describes the last updated time of the signature
        /// (provided from 3rd party vendor)
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdated")]
        public string LastUpdated { get; set; }

        /// <summary>
        /// Gets or sets describes if this override is inherited from base
        /// policy or not
        /// </summary>
        [JsonProperty(PropertyName = "inheritedFromParentPolicy")]
        public bool? InheritedFromParentPolicy { get; set; }

    }
}
