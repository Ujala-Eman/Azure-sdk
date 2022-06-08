// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> PyTorch distribution configuration. </summary>
    public partial class PyTorch : DistributionConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="PyTorch"/>. </summary>
        public PyTorch()
        {
            DistributionType = DistributionType.PyTorch;
        }

        /// <summary> Initializes a new instance of <see cref="PyTorch"/>. </summary>
        /// <param name="distributionType"> [Required] Specifies the type of distribution framework. </param>
        /// <param name="processCountPerInstance"> Number of processes per node. </param>
        internal PyTorch(DistributionType distributionType, int? processCountPerInstance) : base(distributionType)
        {
            ProcessCountPerInstance = processCountPerInstance;
            DistributionType = distributionType;
        }

        /// <summary> Number of processes per node. </summary>
        public int? ProcessCountPerInstance { get; set; }
    }
}
