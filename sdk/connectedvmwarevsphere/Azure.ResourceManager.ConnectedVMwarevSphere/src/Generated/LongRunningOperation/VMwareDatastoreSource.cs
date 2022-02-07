// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    internal class VMwareDatastoreSource : IOperationSource<VMwareDatastore>
    {
        private readonly ArmClient _client;

        internal VMwareDatastoreSource(ArmClient client)
        {
            _client = client;
        }

        VMwareDatastore IOperationSource<VMwareDatastore>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VMwareDatastoreData.DeserializeVMwareDatastoreData(document.RootElement);
            return new VMwareDatastore(_client, data);
        }

        async ValueTask<VMwareDatastore> IOperationSource<VMwareDatastore>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VMwareDatastoreData.DeserializeVMwareDatastoreData(document.RootElement);
            return new VMwareDatastore(_client, data);
        }
    }
}
