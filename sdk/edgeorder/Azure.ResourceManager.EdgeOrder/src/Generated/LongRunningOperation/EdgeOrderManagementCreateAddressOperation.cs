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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.EdgeOrder;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Creates a new address with the specified parameters. Existing address can be updated with this API. </summary>
    public partial class EdgeOrderManagementCreateAddressOperation : Operation<AddressResource>, IOperationSource<AddressResource>
    {
        private readonly OperationInternals<AddressResource> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of EdgeOrderManagementCreateAddressOperation for mocking. </summary>
        protected EdgeOrderManagementCreateAddressOperation()
        {
        }

        internal EdgeOrderManagementCreateAddressOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<AddressResource>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "EdgeOrderManagementCreateAddressOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override AddressResource Value => _operation.Value;

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
        public override ValueTask<Response<AddressResource>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<AddressResource>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        AddressResource IOperationSource<AddressResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AddressResourceData.DeserializeAddressResourceData(document.RootElement);
            return new AddressResource(_operationBase, data);
        }

        async ValueTask<AddressResource> IOperationSource<AddressResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AddressResourceData.DeserializeAddressResourceData(document.RootElement);
            return new AddressResource(_operationBase, data);
        }
    }
}
