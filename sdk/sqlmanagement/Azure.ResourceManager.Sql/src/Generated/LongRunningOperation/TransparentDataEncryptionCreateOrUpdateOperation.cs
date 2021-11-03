// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;
using SqlManagementClient;

namespace SqlManagementClient.Models
{
    /// <summary> Updates a logical database&apos;s transparent data encryption configuration. </summary>
    public partial class TransparentDataEncryptionCreateOrUpdateOperation : Operation<LogicalDatabaseTransparentDataEncryption>
    {
        private readonly OperationOrResponseInternals<LogicalDatabaseTransparentDataEncryption> _operation;

        /// <summary> Initializes a new instance of TransparentDataEncryptionCreateOrUpdateOperation for mocking. </summary>
        protected TransparentDataEncryptionCreateOrUpdateOperation()
        {
        }

        internal TransparentDataEncryptionCreateOrUpdateOperation(ArmResource operationsBase, Response<LogicalDatabaseTransparentDataEncryptionData> response)
        {
            _operation = new OperationOrResponseInternals<LogicalDatabaseTransparentDataEncryption>(Response.FromValue(new LogicalDatabaseTransparentDataEncryption(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override LogicalDatabaseTransparentDataEncryption Value => _operation.Value;

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
        public override ValueTask<Response<LogicalDatabaseTransparentDataEncryption>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<LogicalDatabaseTransparentDataEncryption>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
