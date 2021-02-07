// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.Storage.Files.Shares
{
    internal class ShareDeleteHeaders
    {
        private readonly Response _response;
        public ShareDeleteHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Indicates the version of the File service used to execute the request. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
    }
}
