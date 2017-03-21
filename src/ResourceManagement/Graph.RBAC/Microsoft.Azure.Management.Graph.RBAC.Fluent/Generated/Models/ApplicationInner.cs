// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Graph;
    using Microsoft.Azure.Management.Graph.RBAC;
    using Microsoft.Azure.Management.Graph.RBAC.Fluent;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Active Directory application information.
    /// </summary>
    public partial class ApplicationInner
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationInner class.
        /// </summary>
        public ApplicationInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationInner class.
        /// </summary>
        /// <param name="objectId">The object ID.</param>
        /// <param name="objectType">The object type.</param>
        /// <param name="appId">The application ID.</param>
        /// <param name="appPermissions">The application permissions.</param>
        /// <param name="availableToOtherTenants">Whether the application is be
        /// available to other tenants.</param>
        /// <param name="displayName">The display name of the
        /// application.</param>
        /// <param name="identifierUris">A collection of URIs for the
        /// application.</param>
        /// <param name="replyUrls">A collection of reply URLs for the
        /// application.</param>
        /// <param name="homepage">The home page of the application.</param>
        public ApplicationInner(string objectId = default(string), string objectType = default(string), string appId = default(string), IList<string> appPermissions = default(IList<string>), bool? availableToOtherTenants = default(bool?), string displayName = default(string), IList<string> identifierUris = default(IList<string>), IList<string> replyUrls = default(IList<string>), string homepage = default(string))
        {
            ObjectId = objectId;
            ObjectType = objectType;
            AppId = appId;
            AppPermissions = appPermissions;
            AvailableToOtherTenants = availableToOtherTenants;
            DisplayName = displayName;
            IdentifierUris = identifierUris;
            ReplyUrls = replyUrls;
            Homepage = homepage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the object ID.
        /// </summary>
        [JsonProperty(PropertyName = "objectId")]
        public string ObjectId { get; set; }

        /// <summary>
        /// Gets or sets the object type.
        /// </summary>
        [JsonProperty(PropertyName = "objectType")]
        public string ObjectType { get; set; }

        /// <summary>
        /// Gets or sets the application ID.
        /// </summary>
        [JsonProperty(PropertyName = "appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Gets or sets the application permissions.
        /// </summary>
        [JsonProperty(PropertyName = "appPermissions")]
        public IList<string> AppPermissions { get; set; }

        /// <summary>
        /// Gets or sets whether the application is be available to other
        /// tenants.
        /// </summary>
        [JsonProperty(PropertyName = "availableToOtherTenants")]
        public bool? AvailableToOtherTenants { get; set; }

        /// <summary>
        /// Gets or sets the display name of the application.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets a collection of URIs for the application.
        /// </summary>
        [JsonProperty(PropertyName = "identifierUris")]
        public IList<string> IdentifierUris { get; set; }

        /// <summary>
        /// Gets or sets a collection of reply URLs for the application.
        /// </summary>
        [JsonProperty(PropertyName = "replyUrls")]
        public IList<string> ReplyUrls { get; set; }

        /// <summary>
        /// Gets or sets the home page of the application.
        /// </summary>
        [JsonProperty(PropertyName = "homepage")]
        public string Homepage { get; set; }

    }
}
