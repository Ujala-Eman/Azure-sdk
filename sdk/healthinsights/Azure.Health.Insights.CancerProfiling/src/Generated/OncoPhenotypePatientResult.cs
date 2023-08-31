// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Health.Insights.CancerProfiling
{
    /// <summary> The results of the model's work for a single patient. </summary>
    public partial class OncoPhenotypePatientResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of OncoPhenotypePatientResult. </summary>
        /// <param name="id"> The identifier given for the patient in the request. </param>
        /// <param name="inferences"> The model's inferences for the given patient. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="inferences"/> is null. </exception>
        internal OncoPhenotypePatientResult(string id, IEnumerable<OncoPhenotypeInference> inferences)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(inferences, nameof(inferences));

            Id = id;
            Inferences = inferences.ToList();
        }

        /// <summary> Initializes a new instance of OncoPhenotypePatientResult. </summary>
        /// <param name="id"> The identifier given for the patient in the request. </param>
        /// <param name="inferences"> The model's inferences for the given patient. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal OncoPhenotypePatientResult(string id, IReadOnlyList<OncoPhenotypeInference> inferences, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            Inferences = inferences;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="OncoPhenotypePatientResult"/> for deserialization. </summary>
        internal OncoPhenotypePatientResult()
        {
        }

        /// <summary> The identifier given for the patient in the request. </summary>
        public string Id { get; }
        /// <summary> The model's inferences for the given patient. </summary>
        public IReadOnlyList<OncoPhenotypeInference> Inferences { get; }
    }
}
