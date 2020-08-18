// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Authorization.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Role Assignments
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RoleAssignment
    {
        /// <summary>
        /// Initializes a new instance of the RoleAssignment class.
        /// </summary>
        public RoleAssignment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoleAssignment class.
        /// </summary>
        /// <param name="id">The role assignment ID.</param>
        /// <param name="name">The role assignment name.</param>
        /// <param name="type">The role assignment type.</param>
        /// <param name="scope">The role assignment scope.</param>
        /// <param name="roleDefinitionId">The role definition ID.</param>
        /// <param name="principalId">The principal ID.</param>
        /// <param name="principalType">The principal type of the assigned
        /// principal ID. Possible values include: 'User', 'Group',
        /// 'ServicePrincipal', 'Unknown', 'DirectoryRoleTemplate',
        /// 'ForeignGroup', 'Application', 'MSI', 'DirectoryObjectOrGroup',
        /// 'Everyone'</param>
        /// <param name="canDelegate">The Delegation flag for the role
        /// assignment</param>
        /// <param name="description">Description of role assignment</param>
        /// <param name="condition">The conditions on the role assignment. This
        /// limits the resources it can be assigned to. e.g.:
        /// @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName]
        /// StringEqualsIgnoreCase 'foo_storage_container'</param>
        /// <param name="conditionVersion">Version of the condition. Currently
        /// accepted values are '1.0' or '2.0'</param>
        public RoleAssignment(string id = default(string), string name = default(string), string type = default(string), string scope = default(string), string roleDefinitionId = default(string), string principalId = default(string), string principalType = default(string), bool? canDelegate = default(bool?), string description = default(string), string condition = default(string), string conditionVersion = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            Scope = scope;
            RoleDefinitionId = roleDefinitionId;
            PrincipalId = principalId;
            PrincipalType = principalType;
            CanDelegate = canDelegate;
            Description = description;
            Condition = condition;
            ConditionVersion = conditionVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the role assignment ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the role assignment name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the role assignment type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets the role assignment scope.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or sets the role definition ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.roleDefinitionId")]
        public string RoleDefinitionId { get; set; }

        /// <summary>
        /// Gets or sets the principal ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.principalId")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the principal type of the assigned principal ID.
        /// Possible values include: 'User', 'Group', 'ServicePrincipal',
        /// 'Unknown', 'DirectoryRoleTemplate', 'ForeignGroup', 'Application',
        /// 'MSI', 'DirectoryObjectOrGroup', 'Everyone'
        /// </summary>
        [JsonProperty(PropertyName = "properties.principalType")]
        public string PrincipalType { get; set; }

        /// <summary>
        /// Gets or sets the Delegation flag for the role assignment
        /// </summary>
        [JsonProperty(PropertyName = "properties.canDelegate")]
        public bool? CanDelegate { get; set; }

        /// <summary>
        /// Gets or sets description of role assignment
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the conditions on the role assignment. This limits the
        /// resources it can be assigned to. e.g.:
        /// @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName]
        /// StringEqualsIgnoreCase 'foo_storage_container'
        /// </summary>
        [JsonProperty(PropertyName = "properties.condition")]
        public string Condition { get; set; }

        /// <summary>
        /// Gets or sets version of the condition. Currently accepted values
        /// are '1.0' or '2.0'
        /// </summary>
        [JsonProperty(PropertyName = "properties.conditionVersion")]
        public string ConditionVersion { get; set; }

    }
}
