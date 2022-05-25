// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Regression task in AutoML Table vertical. </summary>
    public partial class Regression : AutoMLVertical
    {
        /// <summary> Initializes a new instance of Regression. </summary>
        public Regression()
        {
            AllowedModels = new ChangeTrackingList<RegressionModels>();
            BlockedModels = new ChangeTrackingList<RegressionModels>();
            TaskType = TaskType.Regression;
        }

        /// <summary> Initializes a new instance of Regression. </summary>
        /// <param name="logVerbosity"> Log verbosity for the job. </param>
        /// <param name="taskType"> [Required] Task type for AutoMLJob. </param>
        /// <param name="allowedModels"> Allowed models for regression task. </param>
        /// <param name="blockedModels"> Blocked models for regression task. </param>
        /// <param name="primaryMetric"> Primary metric for regression task. </param>
        /// <param name="dataSettings"> Data inputs for AutoMLJob. </param>
        /// <param name="featurizationSettings"> Featurization inputs needed for AutoML job. </param>
        /// <param name="limitSettings"> Execution constraints for AutoMLJob. </param>
        /// <param name="trainingSettings"> Inputs for training phase for an AutoML Job. </param>
        internal Regression(LogVerbosity? logVerbosity, TaskType taskType, IList<RegressionModels> allowedModels, IList<RegressionModels> blockedModels, RegressionPrimaryMetrics? primaryMetric, TableVerticalDataSettings dataSettings, TableVerticalFeaturizationSettings featurizationSettings, TableVerticalLimitSettings limitSettings, TrainingSettings trainingSettings) : base(logVerbosity, taskType)
        {
            AllowedModels = allowedModels;
            BlockedModels = blockedModels;
            PrimaryMetric = primaryMetric;
            DataSettings = dataSettings;
            FeaturizationSettings = featurizationSettings;
            LimitSettings = limitSettings;
            TrainingSettings = trainingSettings;
            TaskType = taskType;
        }

        /// <summary> Allowed models for regression task. </summary>
        public IList<RegressionModels> AllowedModels { get; set; }
        /// <summary> Blocked models for regression task. </summary>
        public IList<RegressionModels> BlockedModels { get; set; }
        /// <summary> Primary metric for regression task. </summary>
        public RegressionPrimaryMetrics? PrimaryMetric { get; set; }
        /// <summary> Data inputs for AutoMLJob. </summary>
        public TableVerticalDataSettings DataSettings { get; set; }
        /// <summary> Featurization inputs needed for AutoML job. </summary>
        public TableVerticalFeaturizationSettings FeaturizationSettings { get; set; }
        /// <summary> Execution constraints for AutoMLJob. </summary>
        public TableVerticalLimitSettings LimitSettings { get; set; }
        /// <summary> Inputs for training phase for an AutoML Job. </summary>
        public TrainingSettings TrainingSettings { get; set; }
    }
}
