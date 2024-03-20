// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork
{
    internal class MobileNetworkDiagnosticsPackageOperationSource : IOperationSource<MobileNetworkDiagnosticsPackageResource>
    {
        private readonly ArmClient _client;

        internal MobileNetworkDiagnosticsPackageOperationSource(ArmClient client)
        {
            _client = client;
        }

        MobileNetworkDiagnosticsPackageResource IOperationSource<MobileNetworkDiagnosticsPackageResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MobileNetworkDiagnosticsPackageData.DeserializeMobileNetworkDiagnosticsPackageData(document.RootElement);
            return new MobileNetworkDiagnosticsPackageResource(_client, data);
        }

        async ValueTask<MobileNetworkDiagnosticsPackageResource> IOperationSource<MobileNetworkDiagnosticsPackageResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MobileNetworkDiagnosticsPackageData.DeserializeMobileNetworkDiagnosticsPackageData(document.RootElement);
            return new MobileNetworkDiagnosticsPackageResource(_client, data);
        }
    }
}
