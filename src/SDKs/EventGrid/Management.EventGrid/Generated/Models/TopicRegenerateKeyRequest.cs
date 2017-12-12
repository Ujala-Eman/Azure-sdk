// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Topic regenerate share access key key request
    /// </summary>
    public partial class TopicRegenerateKeyRequest
    {
        /// <summary>
        /// Initializes a new instance of the TopicRegenerateKeyRequest class.
        /// </summary>
        public TopicRegenerateKeyRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TopicRegenerateKeyRequest class.
        /// </summary>
        /// <param name="keyName">Key name to regenerate key1 or key2</param>
        public TopicRegenerateKeyRequest(string keyName)
        {
            KeyName = keyName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets key name to regenerate key1 or key2
        /// </summary>
        [JsonProperty(PropertyName = "keyName")]
        public string KeyName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (KeyName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "KeyName");
            }
        }
    }
}
