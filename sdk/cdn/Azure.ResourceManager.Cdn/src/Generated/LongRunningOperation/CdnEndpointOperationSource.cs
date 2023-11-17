// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Cdn
{
    internal class CdnEndpointOperationSource : IOperationSource<CdnEndpointResource>
    {
        private readonly ArmClient _client;
        private readonly Dictionary<string, string> _idMappings = new Dictionary<string, string>()
        {
            { "subscriptionId", "Microsoft.Resources/subscriptions" },
            { "resourceGroupName", "Microsoft.Resources/resourceGroups" },
            { "profileName", "Microsoft.Cdn/operationresults/profileresults" },
            { "endpointName", "Microsoft.Cdn/operationresults/profileresults/endpointresults" },
        };

        internal CdnEndpointOperationSource(ArmClient client)
        {
            _client = client;
        }

        CdnEndpointResource IOperationSource<CdnEndpointResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ScrubId(CdnEndpointData.DeserializeCdnEndpointData(document.RootElement));
            return new CdnEndpointResource(_client, data);
        }

        async ValueTask<CdnEndpointResource> IOperationSource<CdnEndpointResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ScrubId(CdnEndpointData.DeserializeCdnEndpointData(document.RootElement));
            return new CdnEndpointResource(_client, data);
        }

        private CdnEndpointData ScrubId(CdnEndpointData data)
        {
            if (data.Id.ResourceType == CdnEndpointResource.ResourceType)
                return data;

            var newId = CdnEndpointResource.CreateResourceIdentifier(
                GetName("subscriptionId", data.Id),
                GetName("resourceGroupName", data.Id),
                GetName("profileName", data.Id),
                GetName("endpointName", data.Id));

            return new CdnEndpointData(
                newId,
                newId.Name,
                newId.ResourceType,
                data.SystemData,
                data.Tags,
                data.Location,
                data.OriginPath,
                data.ContentTypesToCompress,
                data.OriginHostHeader,
                data.IsCompressionEnabled,
                data.IsHttpAllowed,
                data.IsHttpsAllowed,
                data.QueryStringCachingBehavior,
                data.OptimizationType,
                data.ProbePath,
                data.GeoFilters,
                data.DefaultOriginGroup,
                data.UriSigningKeys,
                data.DeliveryPolicy,
                data.WebApplicationFirewallPolicyLink,
                data.HostName,
                data.Origins,
                data.OriginGroups,
                data.CustomDomains,
                data.ResourceState,
                data.ProvisioningState,
                data.SerializedAdditionalRawData);
        }

        private string GetName(string param, ResourceIdentifier id)
        {
            while (id.ResourceType != _idMappings[param])
                id = id.Parent;
            return id.Name;
        }
    }
}
