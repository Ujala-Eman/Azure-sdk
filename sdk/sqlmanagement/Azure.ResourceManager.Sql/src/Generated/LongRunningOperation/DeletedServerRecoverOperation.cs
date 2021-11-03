// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using SqlManagementClient;

namespace SqlManagementClient.Models
{
    /// <summary> Recovers a deleted server. </summary>
    public partial class DeletedServerRecoverOperation : Operation<DeletedServerData>, IOperationSource<DeletedServerData>
    {
        private readonly OperationInternals<DeletedServerData> _operation;

        /// <summary> Initializes a new instance of DeletedServerRecoverOperation for mocking. </summary>
        protected DeletedServerRecoverOperation()
        {
        }

        internal DeletedServerRecoverOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<DeletedServerData>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "DeletedServerRecoverOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override DeletedServerData Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DeletedServerData>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DeletedServerData>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        DeletedServerData IOperationSource<DeletedServerData>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return DeletedServerData.DeserializeDeletedServerData(document.RootElement);
        }

        async ValueTask<DeletedServerData> IOperationSource<DeletedServerData>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return DeletedServerData.DeserializeDeletedServerData(document.RootElement);
        }
    }
}
