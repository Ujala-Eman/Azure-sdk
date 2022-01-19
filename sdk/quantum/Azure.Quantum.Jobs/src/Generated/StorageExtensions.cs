// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Quantum.Jobs
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Storage.
    /// </summary>
    public static partial class StorageExtensions
    {
            /// <summary>
            /// Gets a URL with SAS token for a container/blob in the storage account
            /// associated with the workspace. The SAS URL can be used to upload job input
            /// and/or download job output.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blobDetails'>
            /// The details (name and container) of the blob to store or download data.
            /// </param>
            public static SasUriResponse SasUri(this IStorage operations, BlobDetails blobDetails)
            {
                return operations.SasUriAsync(blobDetails).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a URL with SAS token for a container/blob in the storage account
            /// associated with the workspace. The SAS URL can be used to upload job input
            /// and/or download job output.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blobDetails'>
            /// The details (name and container) of the blob to store or download data.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SasUriResponse> SasUriAsync(this IStorage operations, BlobDetails blobDetails, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SasUriWithHttpMessagesAsync(blobDetails, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
