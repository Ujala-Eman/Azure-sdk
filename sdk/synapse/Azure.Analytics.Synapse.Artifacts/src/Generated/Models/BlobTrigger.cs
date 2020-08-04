// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Trigger that runs every time the selected Blob container changes. </summary>
    public partial class BlobTrigger : MultiplePipelineTrigger
    {
        /// <summary> Initializes a new instance of BlobTrigger. </summary>
        /// <param name="folderPath"> The path of the container/folder that will trigger the pipeline. </param>
        /// <param name="maxConcurrency"> The max number of parallel files to handle when it is triggered. </param>
        /// <param name="linkedService"> The Azure Storage linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="folderPath"/> or <paramref name="linkedService"/> is null. </exception>
        public BlobTrigger(string folderPath, int maxConcurrency, LinkedServiceReference linkedService)
        {
            if (folderPath == null)
            {
                throw new ArgumentNullException(nameof(folderPath));
            }
            if (linkedService == null)
            {
                throw new ArgumentNullException(nameof(linkedService));
            }

            FolderPath = folderPath;
            MaxConcurrency = maxConcurrency;
            LinkedService = linkedService;
            Type = "BlobTrigger";
        }

        /// <summary> Initializes a new instance of BlobTrigger. </summary>
        /// <param name="type"> Trigger type. </param>
        /// <param name="description"> Trigger description. </param>
        /// <param name="runtimeState"> Indicates if trigger is running or not. Updated when Start/Stop APIs are called on the Trigger. </param>
        /// <param name="annotations"> List of tags that can be used for describing the trigger. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="pipelines"> Pipelines that need to be started. </param>
        /// <param name="folderPath"> The path of the container/folder that will trigger the pipeline. </param>
        /// <param name="maxConcurrency"> The max number of parallel files to handle when it is triggered. </param>
        /// <param name="linkedService"> The Azure Storage linked service reference. </param>
        internal BlobTrigger(string type, string description, TriggerRuntimeState? runtimeState, IList<object> annotations, IDictionary<string, object> additionalProperties, IList<TriggerPipelineReference> pipelines, string folderPath, int maxConcurrency, LinkedServiceReference linkedService) : base(type, description, runtimeState, annotations, additionalProperties, pipelines)
        {
            FolderPath = folderPath;
            MaxConcurrency = maxConcurrency;
            LinkedService = linkedService;
            Type = type ?? "BlobTrigger";
        }

        /// <summary> The path of the container/folder that will trigger the pipeline. </summary>
        public string FolderPath { get; set; }
        /// <summary> The max number of parallel files to handle when it is triggered. </summary>
        public int MaxConcurrency { get; set; }
        /// <summary> The Azure Storage linked service reference. </summary>
        public LinkedServiceReference LinkedService { get; set; }
    }
}
