// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Class for data inputs.
    /// NLP - Natural Language Processing.
    /// </summary>
    public partial class NlpVerticalDataSettings : DataSettings
    {
        /// <summary> Initializes a new instance of <see cref="NlpVerticalDataSettings"/>. </summary>
        /// <param name="targetColumnName">
        /// [Required] Target column name: This is prediction values column.
        /// Also known as label column name in context of classification tasks.
        /// </param>
        /// <param name="trainingDataSettings"> [Required] Training data input. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetColumnName"/> or <paramref name="trainingDataSettings"/> is null. </exception>
        public NlpVerticalDataSettings(string targetColumnName, TrainingDataSettings trainingDataSettings) : base(targetColumnName, trainingDataSettings)
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

        /// <summary> Initializes a new instance of <see cref="NlpVerticalDataSettings"/>. </summary>
        /// <param name="targetColumnName">
        /// [Required] Target column name: This is prediction values column.
        /// Also known as label column name in context of classification tasks.
        /// </param>
        /// <param name="testData"> Test data input. </param>
        /// <param name="trainingDataSettings"> [Required] Training data input. </param>
        /// <param name="validationData"> Validation data inputs. </param>
        internal NlpVerticalDataSettings(string targetColumnName, TestDataSettings testData, TrainingDataSettings trainingDataSettings, NlpVerticalValidationDataSettings validationData) : base(targetColumnName, testData, trainingDataSettings)
        {
            ValidationData = validationData;
        }

        /// <summary> Validation data inputs. </summary>
        public NlpVerticalValidationDataSettings ValidationData { get; set; }
    }
}
