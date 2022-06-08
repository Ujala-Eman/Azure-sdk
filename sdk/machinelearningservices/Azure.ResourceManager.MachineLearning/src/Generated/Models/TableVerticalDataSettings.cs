// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Class for data inputs. </summary>
    public partial class TableVerticalDataSettings : DataSettings
    {
        /// <summary> Initializes a new instance of <see cref="TableVerticalDataSettings"/>. </summary>
        /// <param name="targetColumnName">
        /// [Required] Target column name: This is prediction values column.
        /// Also known as label column name in context of classification tasks.
        /// </param>
        /// <param name="trainingDataSettings"> [Required] Training data input. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetColumnName"/> or <paramref name="trainingDataSettings"/> is null. </exception>
        public TableVerticalDataSettings(string targetColumnName, TrainingDataSettings trainingDataSettings) : base(targetColumnName, trainingDataSettings)
        {
            if (targetColumnName == null)
            {
                throw new ArgumentNullException(nameof(targetColumnName));
            }
            if (trainingDataSettings == null)
            {
                throw new ArgumentNullException(nameof(trainingDataSettings));
            }
        }

        /// <summary> Initializes a new instance of <see cref="TableVerticalDataSettings"/>. </summary>
        /// <param name="targetColumnName">
        /// [Required] Target column name: This is prediction values column.
        /// Also known as label column name in context of classification tasks.
        /// </param>
        /// <param name="testData"> Test data input. </param>
        /// <param name="trainingDataSettings"> [Required] Training data input. </param>
        /// <param name="validationData"> Validation data inputs. </param>
        /// <param name="weightColumnName"> The name of the sample weight column. Automated ML supports a weighted column as an input, causing rows in the data to be weighted up or down. </param>
        internal TableVerticalDataSettings(string targetColumnName, TestDataSettings testData, TrainingDataSettings trainingDataSettings, TableVerticalValidationDataSettings validationData, string weightColumnName) : base(targetColumnName, testData, trainingDataSettings)
        {
            ValidationData = validationData;
            WeightColumnName = weightColumnName;
        }

        /// <summary> Validation data inputs. </summary>
        public TableVerticalValidationDataSettings ValidationData { get; set; }
        /// <summary> The name of the sample weight column. Automated ML supports a weighted column as an input, causing rows in the data to be weighted up or down. </summary>
        public string WeightColumnName { get; set; }
    }
}
