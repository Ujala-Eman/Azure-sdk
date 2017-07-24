// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System.Linq;

    /// <summary>
    /// The lock information.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ManagementLockObject : Microsoft.Rest.Azure.IResource
    {
        /// <summary>
        /// Initializes a new instance of the ManagementLockObject class.
        /// </summary>
        public ManagementLockObject() { }

        /// <summary>
        /// Initializes a new instance of the ManagementLockObject class.
        /// </summary>
        /// <param name="level">The level of the lock. Possible values are:
        /// NotSpecified, CanNotDelete, ReadOnly. CanNotDelete means
        /// authorized users are able to read and modify the resources, but
        /// not delete. ReadOnly means authorized users can only read from a
        /// resource, but they can't modify or delete it. Possible values
        /// include: 'NotSpecified', 'CanNotDelete', 'ReadOnly'</param>
        /// <param name="notes">Notes about the lock. Maximum of 512
        /// characters.</param>
        /// <param name="owners">The owners of the lock.</param>
        /// <param name="id">The resource ID of the lock.</param>
        /// <param name="type">The resource type of the lock -
        /// Microsoft.Authorization/locks.</param>
        /// <param name="name">The name of the lock.</param>
        public ManagementLockObject(string level, string notes = default(string), System.Collections.Generic.IList<ManagementLockOwner> owners = default(System.Collections.Generic.IList<ManagementLockOwner>), string id = default(string), string type = default(string), string name = default(string))
        {
            Level = level;
            Notes = notes;
            Owners = owners;
            Id = id;
            Type = type;
            Name = name;
        }

        /// <summary>
        /// Gets or sets the level of the lock. Possible values are:
        /// NotSpecified, CanNotDelete, ReadOnly. CanNotDelete means
        /// authorized users are able to read and modify the resources, but
        /// not delete. ReadOnly means authorized users can only read from a
        /// resource, but they can't modify or delete it. Possible values
        /// include: 'NotSpecified', 'CanNotDelete', 'ReadOnly'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.level")]
        public string Level { get; set; }

        /// <summary>
        /// Gets or sets notes about the lock. Maximum of 512 characters.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.notes")]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets the owners of the lock.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.owners")]
        public System.Collections.Generic.IList<ManagementLockOwner> Owners { get; set; }

        /// <summary>
        /// Gets the resource ID of the lock.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the resource type of the lock - Microsoft.Authorization/locks.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets the name of the lock.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Level == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Level");
            }
        }
    }
}
