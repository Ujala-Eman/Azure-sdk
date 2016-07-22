// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Graph.RBAC.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Active Directory service principal Password Credential information
    /// </summary>
    public partial class PasswordCredential
    {
        /// <summary>
        /// Initializes a new instance of the PasswordCredential class.
        /// </summary>
        public PasswordCredential() { }

        /// <summary>
        /// Initializes a new instance of the PasswordCredential class.
        /// </summary>
        /// <param name="startDate">Gets or sets start date</param>
        /// <param name="endDate">Gets or sets end date</param>
        /// <param name="keyId">Gets or sets key Id</param>
        /// <param name="value">Gets or sets value</param>
        public PasswordCredential(DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), string keyId = default(string), string value = default(string))
        {
            StartDate = startDate;
            EndDate = endDate;
            KeyId = keyId;
            Value = value;
        }

        /// <summary>
        /// Gets or sets gets or sets start date
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets gets or sets end date
        /// </summary>
        [JsonProperty(PropertyName = "endDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets gets or sets key Id
        /// </summary>
        [JsonProperty(PropertyName = "keyId")]
        public string KeyId { get; set; }

        /// <summary>
        /// Gets or sets gets or sets value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
