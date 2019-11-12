﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#if CommonSDK
using Internals = Azure.Storage.Shared.Common;
namespace Azure.Storage.Shared.Common
#else
using Internals = Azure.Storage.Shared;
namespace Azure.Storage.Shared
#endif
{
    // TODO: Consider making public if there's ever a reason for developers to use this type
    internal sealed class SharedAccessSignatureCredentials
    {
        /// <summary>
        /// Gets the SAS token used to authenticate requests to the Storage
        /// service.
        /// </summary>
        public string SasToken { get; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SharedAccessSignatureCredentials"/> class.
        /// </summary>
        /// <param name="sasToken">
        /// The SAS token used to authenticate requests to the Storage service.
        /// </param>
        public SharedAccessSignatureCredentials(string sasToken) =>
            SasToken = sasToken;
    }
}
