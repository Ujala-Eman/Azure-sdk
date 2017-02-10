// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The integration account partner.
    /// </summary>
    [JsonTransformation]
    public partial class IntegrationAccountPartner : Resource
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationAccountPartner class.
        /// </summary>
        public IntegrationAccountPartner() { }

        /// <summary>
        /// Initializes a new instance of the IntegrationAccountPartner class.
        /// </summary>
        public IntegrationAccountPartner(PartnerType? partnerType, PartnerContent content, string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), DateTime? createdTime = default(DateTime?), DateTime? changedTime = default(DateTime?), object metadata = default(object))
            : base(id, name, type, location, tags)
        {
            PartnerType = partnerType;
            CreatedTime = createdTime;
            ChangedTime = changedTime;
            Metadata = metadata;
            Content = content;
        }

        /// <summary>
        /// Gets or sets the partner type. Possible values include:
        /// 'NotSpecified', 'B2B'
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnerType")]
        public PartnerType? PartnerType { get; set; }

        /// <summary>
        /// Gets the created time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdTime")]
        public DateTime? CreatedTime { get; private set; }

        /// <summary>
        /// Gets the changed time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.changedTime")]
        public DateTime? ChangedTime { get; private set; }

        /// <summary>
        /// Gets or sets the metadata.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metadata")]
        public object Metadata { get; set; }

        /// <summary>
        /// Gets or sets the partner content.
        /// </summary>
        [JsonProperty(PropertyName = "properties.content")]
        public PartnerContent Content { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Content == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Content");
            }
        }
    }
}
