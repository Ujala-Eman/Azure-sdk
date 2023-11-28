// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Version of computeInstance. </summary>
    internal partial class ComputeInstanceVersion
    {
        /// <summary> Initializes a new instance of <see cref="ComputeInstanceVersion"/>. </summary>
        internal ComputeInstanceVersion()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ComputeInstanceVersion"/>. </summary>
        /// <param name="runtime"> Runtime of compute instance. </param>
        internal ComputeInstanceVersion(string runtime)
        {
            Runtime = runtime;
        }

        /// <summary> Runtime of compute instance. </summary>
        public string Runtime { get; }
    }
}
