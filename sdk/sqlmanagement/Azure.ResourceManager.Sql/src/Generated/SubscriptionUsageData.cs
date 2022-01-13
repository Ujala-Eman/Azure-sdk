// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the SubscriptionUsage data model. </summary>
    public partial class SubscriptionUsageData : Resource
    {
        /// <summary> Initializes a new instance of SubscriptionUsageData. </summary>
        public SubscriptionUsageData()
        {
        }

        /// <summary> Initializes a new instance of SubscriptionUsageData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="displayName"> User-readable name of the metric. </param>
        /// <param name="currentValue"> Current value of the metric. </param>
        /// <param name="limit"> Boundary value of the metric. </param>
        /// <param name="unit"> Unit of the metric. </param>
        internal SubscriptionUsageData(ResourceIdentifier id, string name, ResourceType type, string displayName, double? currentValue, double? limit, string unit) : base(id, name, type)
        {
            DisplayName = displayName;
            CurrentValue = currentValue;
            Limit = limit;
            Unit = unit;
        }

        /// <summary> User-readable name of the metric. </summary>
        public string DisplayName { get; }
        /// <summary> Current value of the metric. </summary>
        public double? CurrentValue { get; }
        /// <summary> Boundary value of the metric. </summary>
        public double? Limit { get; }
        /// <summary> Unit of the metric. </summary>
        public string Unit { get; }
    }
}
