// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> Represents the prediction section of a LUIS Deepstack project. </summary>
    public partial class DeepstackPrediction : BasePrediction
    {
        /// <summary> Initializes a new instance of DeepstackPrediction. </summary>
        /// <param name="intents"> The intent classification results. </param>
        /// <param name="entities"> The entity extraction results. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="intents"/> or <paramref name="entities"/> is null. </exception>
        internal DeepstackPrediction(IEnumerable<DeepstackIntent> intents, IEnumerable<DeepstackEntity> entities)
        {
            if (intents == null)
            {
                throw new ArgumentNullException(nameof(intents));
            }
            if (entities == null)
            {
                throw new ArgumentNullException(nameof(entities));
            }

            Intents = intents.ToList();
            Entities = entities.ToList();
            ProjectKind = ProjectKind.Conversation;
        }

        /// <summary> Initializes a new instance of DeepstackPrediction. </summary>
        /// <param name="projectKind"> The type of the project. </param>
        /// <param name="topIntent"> The intent with the highest score. </param>
        /// <param name="intents"> The intent classification results. </param>
        /// <param name="entities"> The entity extraction results. </param>
        internal DeepstackPrediction(ProjectKind projectKind, string topIntent, IReadOnlyList<DeepstackIntent> intents, IReadOnlyList<DeepstackEntity> entities) : base(projectKind, topIntent)
        {
            Intents = intents;
            Entities = entities;
            ProjectKind = projectKind;
        }

        /// <summary> The intent classification results. </summary>
        public IReadOnlyList<DeepstackIntent> Intents { get; }
        /// <summary> The entity extraction results. </summary>
        public IReadOnlyList<DeepstackEntity> Entities { get; }
    }
}
