// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.IotCentral.Models
{
    /// <summary> IoT Central Application Template Locations. </summary>
    public partial class IotCentralAppTemplateLocation
    {
        /// <summary> Initializes a new instance of <see cref="IotCentralAppTemplateLocation"/>. </summary>
        internal IotCentralAppTemplateLocation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IotCentralAppTemplateLocation"/>. </summary>
        /// <param name="location"> The ID of the location. </param>
        /// <param name="displayName"> The display name of the location. </param>
        internal IotCentralAppTemplateLocation(AzureLocation? location, string displayName)
        {
            Location = location;
            DisplayName = displayName;
        }

        /// <summary> The ID of the location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> The display name of the location. </summary>
        public string DisplayName { get; }
    }
}
