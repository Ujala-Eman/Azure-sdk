// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes scaling information of a SKU. </summary>
    public partial class ComputeResourceSkuCapacity
    {
        /// <summary> Initializes a new instance of <see cref="ComputeResourceSkuCapacity"/>. </summary>
        internal ComputeResourceSkuCapacity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ComputeResourceSkuCapacity"/>. </summary>
        /// <param name="minimum"> The minimum capacity. </param>
        /// <param name="maximum"> The maximum capacity that can be set. </param>
        /// <param name="default"> The default capacity. </param>
        /// <param name="scaleType"> The scale type applicable to the sku. </param>
        internal ComputeResourceSkuCapacity(long? minimum, long? maximum, long? @default, ResourceSkuCapacityScaleType? scaleType)
        {
            Minimum = minimum;
            Maximum = maximum;
            Default = @default;
            ScaleType = scaleType;
        }

        /// <summary> The minimum capacity. </summary>
        public long? Minimum { get; }
        /// <summary> The maximum capacity that can be set. </summary>
        public long? Maximum { get; }
        /// <summary> The default capacity. </summary>
        public long? Default { get; }
        /// <summary> The scale type applicable to the sku. </summary>
        public ResourceSkuCapacityScaleType? ScaleType { get; }
    }
}
