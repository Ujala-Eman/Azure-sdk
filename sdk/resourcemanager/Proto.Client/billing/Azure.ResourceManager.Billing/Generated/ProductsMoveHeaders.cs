// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Billing
{
    internal partial class ProductsMoveHeaders
    {
        private readonly Response _response;
        public ProductsMoveHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Location URI to poll for result. </summary>
        public string Location => _response.Headers.TryGetValue("Location", out string value) ? value : null;
        /// <summary> Recommended time to wait before making another request to check the status of the operation. The time is specified in seconds. </summary>
        public int? RetryAfter => _response.Headers.TryGetValue("Retry-After", out int? value) ? value : null;
    }
}
