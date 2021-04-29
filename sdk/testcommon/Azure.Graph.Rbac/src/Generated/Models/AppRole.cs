// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    /// <summary> The AppRole. </summary>
    public partial class AppRole
    {
        /// <summary> Initializes a new instance of AppRole. </summary>
        public AppRole()
        {
            AllowedMemberTypes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AppRole. </summary>
        /// <param name="id"> Unique role identifier inside the appRoles collection. </param>
        /// <param name="allowedMemberTypes"> Specifies whether this app role definition can be assigned to users and groups by setting to &apos;User&apos;, or to other applications (that are accessing this application in daemon service scenarios) by setting to &apos;Application&apos;, or to both. </param>
        /// <param name="description"> Permission help text that appears in the admin app assignment and consent experiences. </param>
        /// <param name="displayName"> Display name for the permission that appears in the admin consent and app assignment experiences. </param>
        /// <param name="isEnabled"> When creating or updating a role definition, this must be set to true (which is the default). To delete a role, this must first be set to false. At that point, in a subsequent call, this role may be removed. </param>
        /// <param name="value"> Specifies the value of the roles claim that the application should expect in the authentication and access tokens. </param>
        internal AppRole(string id, IList<string> allowedMemberTypes, string description, string displayName, bool? isEnabled, string value)
        {
            Id = id;
            AllowedMemberTypes = allowedMemberTypes;
            Description = description;
            DisplayName = displayName;
            IsEnabled = isEnabled;
            Value = value;
        }

        /// <summary> Unique role identifier inside the appRoles collection. </summary>
        public string Id { get; set; }
        /// <summary> Specifies whether this app role definition can be assigned to users and groups by setting to &apos;User&apos;, or to other applications (that are accessing this application in daemon service scenarios) by setting to &apos;Application&apos;, or to both. </summary>
        public IList<string> AllowedMemberTypes { get; }
        /// <summary> Permission help text that appears in the admin app assignment and consent experiences. </summary>
        public string Description { get; set; }
        /// <summary> Display name for the permission that appears in the admin consent and app assignment experiences. </summary>
        public string DisplayName { get; set; }
        /// <summary> When creating or updating a role definition, this must be set to true (which is the default). To delete a role, this must first be set to false. At that point, in a subsequent call, this role may be removed. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Specifies the value of the roles claim that the application should expect in the authentication and access tokens. </summary>
        public string Value { get; set; }
    }
}
