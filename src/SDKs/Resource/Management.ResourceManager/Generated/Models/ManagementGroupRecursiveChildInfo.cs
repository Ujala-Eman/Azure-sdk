// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ResourceManager;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The unique identifier (ID) of a management group.
    /// </summary>
    public partial class ManagementGroupRecursiveChildInfo
    {
        /// <summary>
        /// Initializes a new instance of the ManagementGroupRecursiveChildInfo
        /// class.
        /// </summary>
        public ManagementGroupRecursiveChildInfo()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagementGroupRecursiveChildInfo
        /// class.
        /// </summary>
        /// <param name="childType">Managment Group Recursive Child
        /// Info</param>
        /// <param name="childId">The ID of the child resource (management
        /// group or subscription). E.g.
        /// /providers/Microsoft.Management/managementGroups/40000000-0000-0000-0000-000000000000</param>
        /// <param name="displayName">The friendly name of the child
        /// resource.</param>
        /// <param name="tenantId">(Optional) The AAD Tenant ID associated with
        /// the child resource.</param>
        /// <param name="children">The list of children.</param>
        public ManagementGroupRecursiveChildInfo(string childType = default(string), string childId = default(string), string displayName = default(string), System.Guid? tenantId = default(System.Guid?), IList<ManagementGroupRecursiveChildInfo> children = default(IList<ManagementGroupRecursiveChildInfo>))
        {
            ChildType = childType;
            ChildId = childId;
            DisplayName = displayName;
            TenantId = tenantId;
            Children = children;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets managment Group Recursive Child Info
        /// </summary>
        /// <remarks>
        /// Possible values include: 'Enrollment', 'Department', 'Account',
        /// 'Subscription'
        /// </remarks>
        [JsonProperty(PropertyName = "childType")]
        public string ChildType { get; set; }

        /// <summary>
        /// Gets or sets the ID of the child resource (management group or
        /// subscription). E.g.
        /// /providers/Microsoft.Management/managementGroups/40000000-0000-0000-0000-000000000000
        /// </summary>
        [JsonProperty(PropertyName = "childId")]
        public string ChildId { get; set; }

        /// <summary>
        /// Gets or sets the friendly name of the child resource.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets (Optional) The AAD Tenant ID associated with the child
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public System.Guid? TenantId { get; set; }

        /// <summary>
        /// Gets or sets the list of children.
        /// </summary>
        [JsonProperty(PropertyName = "children")]
        public IList<ManagementGroupRecursiveChildInfo> Children { get; set; }

    }
}
