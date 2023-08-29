// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ExtendedLocations.Models
{
    /// <summary> This is optional input that contains the authentication that should be used to generate the namespace. </summary>
    public partial class CustomLocationAuthentication
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CustomLocationAuthentication"/>. </summary>
        public CustomLocationAuthentication()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CustomLocationAuthentication"/>. </summary>
        /// <param name="customLocationPropertiesAuthenticationType"> The type of the Custom Locations authentication. </param>
        /// <param name="value"> The kubeconfig value. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomLocationAuthentication(string customLocationPropertiesAuthenticationType, string value, Dictionary<string, BinaryData> rawData)
        {
            CustomLocationPropertiesAuthenticationType = customLocationPropertiesAuthenticationType;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The type of the Custom Locations authentication. </summary>
        public string CustomLocationPropertiesAuthenticationType { get; set; }
        /// <summary> The kubeconfig value. </summary>
        public string Value { get; set; }
    }
}
