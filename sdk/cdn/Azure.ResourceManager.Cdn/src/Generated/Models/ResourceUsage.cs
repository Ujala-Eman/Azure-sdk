// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Output of check resource usage API. </summary>
    public partial class ResourceUsage
    {
        /// <summary> Initializes a new instance of ResourceUsage. </summary>
        internal ResourceUsage()
        {
        }

        /// <summary> Initializes a new instance of ResourceUsage. </summary>
        /// <param name="resourceType"> Resource type for which the usage is provided. </param>
        /// <param name="unit"> Unit of the usage. e.g. Count. </param>
        /// <param name="currentValue"> Actual value of usage on the specified resource type. </param>
        /// <param name="limit"> Quota of the specified resource type. </param>
        internal ResourceUsage(string resourceType, string unit, int? currentValue, int? limit)
        {
            ResourceType = resourceType;
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
        }

        /// <summary> Resource type for which the usage is provided. </summary>
        public string ResourceType { get; }
        /// <summary> Unit of the usage. e.g. Count. </summary>
        public string Unit { get; }
        /// <summary> Actual value of usage on the specified resource type. </summary>
        public int? CurrentValue { get; }
        /// <summary> Quota of the specified resource type. </summary>
        public int? Limit { get; }
    }
}
