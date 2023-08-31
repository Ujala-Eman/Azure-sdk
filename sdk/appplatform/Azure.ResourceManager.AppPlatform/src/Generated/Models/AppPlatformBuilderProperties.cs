// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> KPack Builder properties payload. </summary>
    public partial class AppPlatformBuilderProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppPlatformBuilderProperties"/>. </summary>
        public AppPlatformBuilderProperties()
        {
            BuildpackGroups = new ChangeTrackingList<BuildpacksGroupProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformBuilderProperties"/>. </summary>
        /// <param name="provisioningState"> Builder provision status. </param>
        /// <param name="stack"> Builder cluster stack property. </param>
        /// <param name="buildpackGroups"> Builder buildpack groups. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformBuilderProperties(AppPlatformBuilderProvisioningState? provisioningState, AppPlatformClusterStackProperties stack, IList<BuildpacksGroupProperties> buildpackGroups, Dictionary<string, BinaryData> rawData)
        {
            ProvisioningState = provisioningState;
            Stack = stack;
            BuildpackGroups = buildpackGroups;
            _rawData = rawData;
        }

        /// <summary> Builder provision status. </summary>
        public AppPlatformBuilderProvisioningState? ProvisioningState { get; }
        /// <summary> Builder cluster stack property. </summary>
        public AppPlatformClusterStackProperties Stack { get; set; }
        /// <summary> Builder buildpack groups. </summary>
        public IList<BuildpacksGroupProperties> BuildpackGroups { get; }
    }
}
