// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Validation settings for AutoML Table vertical tasks - Classification/Regression/Forecasting. </summary>
    public partial class TableVerticalValidationDataSettings : ValidationDataSettings
    {
        /// <summary> Initializes a new instance of <see cref="TableVerticalValidationDataSettings"/>. </summary>
        public TableVerticalValidationDataSettings()
        {
            CvSplitColumnNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="TableVerticalValidationDataSettings"/>. </summary>
        /// <param name="data"> Validation data MLTable. </param>
        /// <param name="validationDataSize">
        /// The fraction of training dataset that needs to be set aside for validation purpose.
        /// Values between (0.0 , 1.0)
        /// Applied when validation dataset is not provided.
        /// </param>
        /// <param name="cvSplitColumnNames"> Columns to use for CVSplit data. </param>
        /// <param name="nCrossValidations">
        /// Number of cross validation folds to be applied on training dataset
        /// when validation dataset is not provided.
        /// Please note <see cref="NCrossValidations"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AutoNCrossValidations"/> and <see cref="CustomNCrossValidations"/>.
        /// </param>
        internal TableVerticalValidationDataSettings(MLTableJobInput data, double? validationDataSize, IList<string> cvSplitColumnNames, NCrossValidations nCrossValidations) : base(data, validationDataSize)
        {
            CvSplitColumnNames = cvSplitColumnNames;
            NCrossValidations = nCrossValidations;
        }

        /// <summary> Columns to use for CVSplit data. </summary>
        public IList<string> CvSplitColumnNames { get; set; }
        /// <summary>
        /// Number of cross validation folds to be applied on training dataset
        /// when validation dataset is not provided.
        /// Please note <see cref="NCrossValidations"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AutoNCrossValidations"/> and <see cref="CustomNCrossValidations"/>.
        /// </summary>
        public NCrossValidations NCrossValidations { get; set; }
    }
}
