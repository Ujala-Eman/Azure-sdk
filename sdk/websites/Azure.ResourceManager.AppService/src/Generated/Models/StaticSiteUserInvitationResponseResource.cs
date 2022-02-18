// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Static sites user roles invitation link resource. </summary>
    public partial class StaticSiteUserInvitationResponseResource : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of StaticSiteUserInvitationResponseResource. </summary>
        public StaticSiteUserInvitationResponseResource()
        {
        }

        /// <summary> Initializes a new instance of StaticSiteUserInvitationResponseResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="expiresOn"> The expiration time of the invitation. </param>
        /// <param name="invitationUrl"> The url for the invitation link. </param>
        internal StaticSiteUserInvitationResponseResource(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string kind, DateTimeOffset? expiresOn, string invitationUrl) : base(id, name, type, systemData, kind)
        {
            ExpiresOn = expiresOn;
            InvitationUrl = invitationUrl;
        }

        /// <summary> The expiration time of the invitation. </summary>
        public DateTimeOffset? ExpiresOn { get; }
        /// <summary> The url for the invitation link. </summary>
        public string InvitationUrl { get; }
    }
}
