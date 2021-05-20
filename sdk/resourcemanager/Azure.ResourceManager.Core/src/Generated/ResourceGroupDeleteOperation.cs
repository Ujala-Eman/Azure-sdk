// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Core
{
    /// <summary> When you delete a resource group, all of its resources are also deleted. Deleting a resource group deletes all of its template deployments and currently stored operations. </summary>
    public partial class ResourceGroupDeleteOperation : Operation
    {
        private readonly OperationOrResponseInternals _operation;

        /// <summary> Initializes a new instance of ResourceGroupsDeleteOperation for mocking. </summary>
        protected ResourceGroupDeleteOperation()
        {
        }

        internal ResourceGroupDeleteOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationOrResponseInternals(clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ResourceGroupsDeleteOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> WaitForCompletionResponseAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionResponseAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> WaitForCompletionResponseAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionResponseAsync(pollingInterval, cancellationToken);
    }
}
