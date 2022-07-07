// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The usage names. </summary>
    public partial class NetworkUsageName
    {
        /// <summary> Initializes a new instance of NetworkUsageName. </summary>
        internal NetworkUsageName()
        {
        }

        /// <summary> Initializes a new instance of NetworkUsageName. </summary>
        /// <param name="value"> A string describing the resource name. </param>
        /// <param name="localizedValue"> A localized string describing the resource name. </param>
        internal NetworkUsageName(string value, string localizedValue)
        {
            Value = value;
            LocalizedValue = localizedValue;
        }

        /// <summary> A string describing the resource name. </summary>
        public string Value { get; }
        /// <summary> A localized string describing the resource name. </summary>
        public string LocalizedValue { get; }
    }
}
