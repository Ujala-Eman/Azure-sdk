// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Settings with single toggle. </summary>
    public partial class Anomalies : SecurityInsightsSettingData
    {
        /// <summary> Initializes a new instance of <see cref="Anomalies"/>. </summary>
        public Anomalies()
        {
            Kind = SettingKind.Anomalies;
        }

        /// <summary> Initializes a new instance of <see cref="Anomalies"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the setting. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="isEnabled"> Determines whether the setting is enable or disabled. </param>
        internal Anomalies(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SettingKind kind, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData, bool? isEnabled) : base(id, name, resourceType, systemData, kind, etag, serializedAdditionalRawData)
        {
            IsEnabled = isEnabled;
            Kind = kind;
        }

        /// <summary> Determines whether the setting is enable or disabled. </summary>
        public bool? IsEnabled { get; }
    }
}
