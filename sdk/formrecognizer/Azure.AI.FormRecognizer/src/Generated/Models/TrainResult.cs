// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.FormRecognizer.Training;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Custom model training result. </summary>
    internal partial class TrainResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TrainResult"/>. </summary>
        /// <param name="trainingDocuments"> List of the documents used to train the model and any errors reported in each document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trainingDocuments"/> is null. </exception>
        internal TrainResult(IEnumerable<TrainingDocumentInfo> trainingDocuments)
        {
            Argument.AssertNotNull(trainingDocuments, nameof(trainingDocuments));

            TrainingDocuments = trainingDocuments.ToList();
            Fields = new ChangeTrackingList<CustomFormModelField>();
            Errors = new ChangeTrackingList<FormRecognizerError>();
        }

        /// <summary> Initializes a new instance of <see cref="TrainResult"/>. </summary>
        /// <param name="trainingDocuments"> List of the documents used to train the model and any errors reported in each document. </param>
        /// <param name="fields"> List of fields used to train the model and the train operation error reported by each. </param>
        /// <param name="averageModelAccuracy"> Average accuracy. </param>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="errors"> Errors returned during the training operation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TrainResult(IReadOnlyList<TrainingDocumentInfo> trainingDocuments, IReadOnlyList<CustomFormModelField> fields, float? averageModelAccuracy, string modelId, IReadOnlyList<FormRecognizerError> errors, Dictionary<string, BinaryData> rawData)
        {
            TrainingDocuments = trainingDocuments;
            Fields = fields;
            AverageModelAccuracy = averageModelAccuracy;
            ModelId = modelId;
            Errors = errors;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="TrainResult"/> for deserialization. </summary>
        internal TrainResult()
        {
        }

        /// <summary> List of the documents used to train the model and any errors reported in each document. </summary>
        public IReadOnlyList<TrainingDocumentInfo> TrainingDocuments { get; }
        /// <summary> List of fields used to train the model and the train operation error reported by each. </summary>
        public IReadOnlyList<CustomFormModelField> Fields { get; }
        /// <summary> Average accuracy. </summary>
        public float? AverageModelAccuracy { get; }
        /// <summary> Errors returned during the training operation. </summary>
        public IReadOnlyList<FormRecognizerError> Errors { get; }
    }
}
