// ------------------------------------------------------------------------------------------------
// <copyright file="ClientFactory.cs" company="Microsoft Corporation">
//   Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// ------------------------------------------------------------------------------------------------

namespace DnsResolver.Tests.Helpers
{
    using Microsoft.Azure.Management.DnsResolver;
    using Microsoft.Azure.Management.Resources;
    using Microsoft.Rest.ClientRuntime.Azure.TestFramework;

    public static class ClientFactory
    {
        /// <summary>
        /// Default constructor for management clients, using the TestSupport Infrastructure
        /// </summary>
        /// <param name="handler"></param>
        /// <returns>A resource management client, created from the current context (environment variables)</returns>
        public static ResourceManagementClient GetResourcesClient(
            MockContext context,
            RecordedDelegatingHandler handler)
        {
            handler.IsPassThrough = true;
            var client = context.GetServiceClient<ResourceManagementClient>(handlers: handler);
            return client;
        }

        /// <summary>
        /// Default constructor for management clients,
        ///  using the TestSupport Infrastructure
        /// </summary>
        /// <param name="handler"></param>
        /// <returns>A resource management client, created from the current context (environment variables)</returns>
        public static DnsResolverManagementClient GetDnsResolverClient(
            MockContext context,
            RecordedDelegatingHandler handler)
        {
            handler.IsPassThrough = true;
            var client = context.GetServiceClient<DnsResolverManagementClient>(handlers: handler);
            return client;
        }
    }
}