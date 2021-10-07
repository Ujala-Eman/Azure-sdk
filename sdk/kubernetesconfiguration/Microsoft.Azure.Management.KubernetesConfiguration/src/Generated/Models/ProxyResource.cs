// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KubernetesConfiguration.Models
{
    using System.Linq;

    /// <summary>
    /// ARM proxy resource.
    /// </summary>
    public partial class ProxyResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ProxyResource class.
        /// </summary>
        public ProxyResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProxyResource class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="systemData">Top level metadata
        /// https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/common-api-contracts.md#system-metadata-for-all-azure-resources</param>
        public ProxyResource(string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData))
            : base(id, name, type, systemData)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
