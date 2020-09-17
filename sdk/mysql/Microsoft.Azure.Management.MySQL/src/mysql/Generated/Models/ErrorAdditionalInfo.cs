// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MySQL.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The resource management error additional info.
    /// </summary>
    public partial class ErrorAdditionalInfo
    {
        /// <summary>
        /// Initializes a new instance of the ErrorAdditionalInfo class.
        /// </summary>
        public ErrorAdditionalInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorAdditionalInfo class.
        /// </summary>
        /// <param name="type">The additional info type.</param>
        /// <param name="info">The additional info.</param>
        public ErrorAdditionalInfo(string type = default(string), object info = default(object))
        {
            Type = type;
            Info = info;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the additional info type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the additional info.
        /// </summary>
        [JsonProperty(PropertyName = "info")]
        public object Info { get; private set; }

    }
}
