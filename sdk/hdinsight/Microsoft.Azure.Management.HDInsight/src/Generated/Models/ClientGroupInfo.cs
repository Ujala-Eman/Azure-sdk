// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The information of AAD security group.
    /// </summary>
    public partial class ClientGroupInfo
    {
        /// <summary>
        /// Initializes a new instance of the ClientGroupInfo class.
        /// </summary>
        public ClientGroupInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClientGroupInfo class.
        /// </summary>
        /// <param name="groupName">The AAD security group name.</param>
        /// <param name="groupId">The AAD security group id.</param>
        public ClientGroupInfo(string groupName = default(string), string groupId = default(string))
        {
            GroupName = groupName;
            GroupId = groupId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the AAD security group name.
        /// </summary>
        [JsonProperty(PropertyName = "groupName")]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or sets the AAD security group id.
        /// </summary>
        [JsonProperty(PropertyName = "groupId")]
        public string GroupId { get; set; }

    }
}
