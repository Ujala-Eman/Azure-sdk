// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> API Authentication Settings. </summary>
    public partial class AuthenticationSettingsContract
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AuthenticationSettingsContract"/>. </summary>
        public AuthenticationSettingsContract()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AuthenticationSettingsContract"/>. </summary>
        /// <param name="oAuth2"> OAuth2 Authentication settings. </param>
        /// <param name="openId"> OpenID Connect Authentication Settings. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AuthenticationSettingsContract(OAuth2AuthenticationSettingsContract oAuth2, OpenIdAuthenticationSettingsContract openId, Dictionary<string, BinaryData> rawData)
        {
            OAuth2 = oAuth2;
            OpenId = openId;
            _rawData = rawData;
        }

        /// <summary> OAuth2 Authentication settings. </summary>
        public OAuth2AuthenticationSettingsContract OAuth2 { get; set; }
        /// <summary> OpenID Connect Authentication Settings. </summary>
        public OpenIdAuthenticationSettingsContract OpenId { get; set; }
    }
}
