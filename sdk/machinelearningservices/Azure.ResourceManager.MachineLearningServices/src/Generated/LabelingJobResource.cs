// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A Class representing a LabelingJobResource along with the instance operations that can be performed on it. </summary>
    public class LabelingJobResource : LabelingJobResourceOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "LabelingJobResource"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal LabelingJobResource(ResourceOperationsBase options, LabelingJobResourceData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the LabelingJobResourceData. </summary>
        public LabelingJobResourceData Data { get; private set; }

        /// <inheritdoc />
        protected override LabelingJobResource GetResource(CancellationToken cancellation = default)
        {
            return this;
        }

        /// <inheritdoc />
        protected override Task<LabelingJobResource> GetResourceAsync(CancellationToken cancellation = default)
        {
            return Task.FromResult(this);
        }
    }
}
