// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Communication.PhoneNumbers.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> Search for available phone numbers to purchase. </summary>
    public partial class SearchAvailablePhoneNumbersOperation : Operation<PhoneNumberSearchResult>, IOperationSource<PhoneNumberSearchResult>
    {
        private readonly ArmOperationHelpers<PhoneNumberSearchResult> _operation;

        /// <inheritdoc />
        public override PhoneNumberSearchResult Value => _operation.Value;

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
        public override ValueTask<Response<PhoneNumberSearchResult>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<PhoneNumberSearchResult>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        PhoneNumberSearchResult IOperationSource<PhoneNumberSearchResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return PhoneNumberSearchResult.DeserializePhoneNumberSearchResult(document.RootElement);
        }

        async ValueTask<PhoneNumberSearchResult> IOperationSource<PhoneNumberSearchResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return PhoneNumberSearchResult.DeserializePhoneNumberSearchResult(document.RootElement);
        }
    }
}
