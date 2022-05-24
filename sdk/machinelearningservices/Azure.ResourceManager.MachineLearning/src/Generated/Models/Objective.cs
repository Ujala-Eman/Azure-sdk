// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Optimization objective. </summary>
    public partial class Objective
    {
        /// <summary> Initializes a new instance of Objective. </summary>
        /// <param name="goal"> [Required] Defines supported metric goals for hyperparameter tuning. </param>
        /// <param name="primaryMetric"> [Required] Name of the metric to optimize. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="primaryMetric"/> is null. </exception>
        public Objective(Goal goal, string primaryMetric)
        {
            if (primaryMetric == null)
            {
                throw new ArgumentNullException(nameof(primaryMetric));
            }

            Goal = goal;
            PrimaryMetric = primaryMetric;
        }

        /// <summary> [Required] Defines supported metric goals for hyperparameter tuning. </summary>
        public Goal Goal { get; set; }
        /// <summary> [Required] Name of the metric to optimize. </summary>
        public string PrimaryMetric { get; set; }
    }
}
