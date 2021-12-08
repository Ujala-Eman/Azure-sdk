// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabricMesh.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// This type represents the unencrypted value of the secret.
    /// </summary>
    public partial class SecretValue
    {
        /// <summary>
        /// Initializes a new instance of the SecretValue class.
        /// </summary>
        public SecretValue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SecretValue class.
        /// </summary>
        /// <param name="value">The actual value of the secret.</param>
        public SecretValue(string value = default(string))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the actual value of the secret.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
