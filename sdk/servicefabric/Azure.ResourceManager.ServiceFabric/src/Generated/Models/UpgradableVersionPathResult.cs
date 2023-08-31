// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> The list of intermediate cluster code versions for an upgrade or downgrade. Or minimum and maximum upgradable version if no target was given. </summary>
    public partial class UpgradableVersionPathResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="UpgradableVersionPathResult"/>. </summary>
        internal UpgradableVersionPathResult()
        {
            SupportedPath = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="UpgradableVersionPathResult"/>. </summary>
        /// <param name="supportedPath"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UpgradableVersionPathResult(IReadOnlyList<string> supportedPath, Dictionary<string, BinaryData> rawData)
        {
            SupportedPath = supportedPath;
            _rawData = rawData;
        }

        /// <summary> Gets the supported path. </summary>
        public IReadOnlyList<string> SupportedPath { get; }
    }
}
