// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Training data input. </summary>
    public partial class TrainingDataSettings
    {
        /// <summary> Initializes a new instance of <see cref="TrainingDataSettings"/>. </summary>
        /// <param name="data"> [Required] Training data MLTable. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public TrainingDataSettings(MLTableJobInput data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            Data = data;
        }

        /// <summary> [Required] Training data MLTable. </summary>
        public MLTableJobInput Data { get; set; }
    }
}
