// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> An Application Insights component daily data volume cap status. </summary>
    public partial class ApplicationInsightsComponentFeature
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationInsightsComponentFeature"/>. </summary>
        internal ApplicationInsightsComponentFeature()
        {
            Capabilities = new ChangeTrackingList<ApplicationInsightsComponentFeatureCapability>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationInsightsComponentFeature"/>. </summary>
        /// <param name="featureName"> The pricing feature name. </param>
        /// <param name="meterId"> The meter id used for the feature. </param>
        /// <param name="meterRateFrequency"> The meter rate for the feature's meter. </param>
        /// <param name="resourceId"> Reserved, not used now. </param>
        /// <param name="isHidden"> Reserved, not used now. </param>
        /// <param name="capabilities"> A list of Application Insights component feature capability. </param>
        /// <param name="title"> Display name of the feature. </param>
        /// <param name="isMainFeature"> Whether can apply addon feature on to it. </param>
        /// <param name="supportedAddonFeatures"> The add on features on main feature. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationInsightsComponentFeature(string featureName, string meterId, string meterRateFrequency, string resourceId, bool? isHidden, IReadOnlyList<ApplicationInsightsComponentFeatureCapability> capabilities, string title, bool? isMainFeature, string supportedAddonFeatures, Dictionary<string, BinaryData> rawData)
        {
            FeatureName = featureName;
            MeterId = meterId;
            MeterRateFrequency = meterRateFrequency;
            ResourceId = resourceId;
            IsHidden = isHidden;
            Capabilities = capabilities;
            Title = title;
            IsMainFeature = isMainFeature;
            SupportedAddonFeatures = supportedAddonFeatures;
            _rawData = rawData;
        }

        /// <summary> The pricing feature name. </summary>
        public string FeatureName { get; }
        /// <summary> The meter id used for the feature. </summary>
        public string MeterId { get; }
        /// <summary> The meter rate for the feature's meter. </summary>
        public string MeterRateFrequency { get; }
        /// <summary> Reserved, not used now. </summary>
        public string ResourceId { get; }
        /// <summary> Reserved, not used now. </summary>
        public bool? IsHidden { get; }
        /// <summary> A list of Application Insights component feature capability. </summary>
        public IReadOnlyList<ApplicationInsightsComponentFeatureCapability> Capabilities { get; }
        /// <summary> Display name of the feature. </summary>
        public string Title { get; }
        /// <summary> Whether can apply addon feature on to it. </summary>
        public bool? IsMainFeature { get; }
        /// <summary> The add on features on main feature. </summary>
        public string SupportedAddonFeatures { get; }
    }
}
