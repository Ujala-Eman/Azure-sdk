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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> Get the last completed troubleshooting result on a specified resource. </summary>
    public partial class NetworkWatchersGetTroubleshootingResultOperation : Operation<TroubleshootingResult>, IOperationSource<TroubleshootingResult>
    {
        private readonly ArmOperationHelpers<TroubleshootingResult> _operation;

        /// <summary> Initializes a new instance of NetworkWatchersGetTroubleshootingResultOperation for mocking. </summary>
        protected NetworkWatchersGetTroubleshootingResultOperation()
        {
        }

        internal NetworkWatchersGetTroubleshootingResultOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<TroubleshootingResult>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "NetworkWatchersGetTroubleshootingResultOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override TroubleshootingResult Value => _operation.Value;

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
        public override ValueTask<Response<TroubleshootingResult>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<TroubleshootingResult>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        TroubleshootingResult IOperationSource<TroubleshootingResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return TroubleshootingResult.DeserializeTroubleshootingResult(document.RootElement);
        }

        async ValueTask<TroubleshootingResult> IOperationSource<TroubleshootingResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return TroubleshootingResult.DeserializeTroubleshootingResult(document.RootElement);
        }
    }
}
