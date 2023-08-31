// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Sphere;

namespace Azure.ResourceManager.Sphere.Models
{
    /// <summary>
    /// The response of a DeviceGroup list operation.
    /// Serialized Name: DeviceGroupListResult
    /// </summary>
    internal partial class DeviceGroupListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DeviceGroupListResult"/>. </summary>
        /// <param name="value">
        /// The DeviceGroup items on this page
        /// Serialized Name: DeviceGroupListResult.value
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DeviceGroupListResult(IEnumerable<SphereDeviceGroupData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DeviceGroupListResult"/>. </summary>
        /// <param name="value">
        /// The DeviceGroup items on this page
        /// Serialized Name: DeviceGroupListResult.value
        /// </param>
        /// <param name="nextLink">
        /// The link to the next page of items
        /// Serialized Name: DeviceGroupListResult.nextLink
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DeviceGroupListResult(IReadOnlyList<SphereDeviceGroupData> value, Uri nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DeviceGroupListResult"/> for deserialization. </summary>
        internal DeviceGroupListResult()
        {
        }

        /// <summary>
        /// The DeviceGroup items on this page
        /// Serialized Name: DeviceGroupListResult.value
        /// </summary>
        public IReadOnlyList<SphereDeviceGroupData> Value { get; }
        /// <summary>
        /// The link to the next page of items
        /// Serialized Name: DeviceGroupListResult.nextLink
        /// </summary>
        public Uri NextLink { get; }
    }
}
