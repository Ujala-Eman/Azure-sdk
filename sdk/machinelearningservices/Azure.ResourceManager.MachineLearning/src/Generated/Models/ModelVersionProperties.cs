// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Model asset version details. </summary>
    public partial class ModelVersionProperties : AssetBase
    {
        /// <summary> Initializes a new instance of <see cref="ModelVersionProperties"/>. </summary>
        public ModelVersionProperties()
        {
            Flavors = new ChangeTrackingDictionary<string, FlavorData>();
        }

        /// <summary> Initializes a new instance of <see cref="ModelVersionProperties"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="isAnonymous"> If the name version are system generated (anonymous registration). </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="flavors"> Mapping of model flavors to their properties. </param>
        /// <param name="jobName"> Name of the training job which produced this model. </param>
        /// <param name="modelType"> The storage format for this entity. Used for NCD. </param>
        /// <param name="modelUri"> The URI path to the model contents. </param>
        internal ModelVersionProperties(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, bool? isAnonymous, bool? isArchived, IDictionary<string, FlavorData> flavors, string jobName, ModelType? modelType, Uri modelUri) : base(description, properties, tags, isAnonymous, isArchived)
        {
            Flavors = flavors;
            JobName = jobName;
            ModelType = modelType;
            ModelUri = modelUri;
        }

        /// <summary> Mapping of model flavors to their properties. </summary>
        public IDictionary<string, FlavorData> Flavors { get; set; }
        /// <summary> Name of the training job which produced this model. </summary>
        public string JobName { get; set; }
        /// <summary> The storage format for this entity. Used for NCD. </summary>
        public ModelType? ModelType { get; set; }
        /// <summary> The URI path to the model contents. </summary>
        public Uri ModelUri { get; set; }
    }
}
