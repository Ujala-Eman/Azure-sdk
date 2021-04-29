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
    /// <summary> Gets the next hop from the specified VM. </summary>
    public partial class NetworkWatchersGetNextHopOperation : Operation<NextHopResult>, IOperationSource<NextHopResult>
    {
        private readonly ArmOperationHelpers<NextHopResult> _operation;

        /// <summary> Initializes a new instance of NetworkWatchersGetNextHopOperation for mocking. </summary>
        protected NetworkWatchersGetNextHopOperation()
        {
        }

        internal NetworkWatchersGetNextHopOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<NextHopResult>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "NetworkWatchersGetNextHopOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override NextHopResult Value => _operation.Value;

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
        public override ValueTask<Response<NextHopResult>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<NextHopResult>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        NextHopResult IOperationSource<NextHopResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return NextHopResult.DeserializeNextHopResult(document.RootElement);
        }

        async ValueTask<NextHopResult> IOperationSource<NextHopResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return NextHopResult.DeserializeNextHopResult(document.RootElement);
        }
    }
}
