// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="HostingEnvironmentRecommendationResource"/> and their operations.
    /// Each <see cref="HostingEnvironmentRecommendationResource"/> in the collection will belong to the same instance of <see cref="AppServiceEnvironmentResource"/>.
    /// To get a <see cref="HostingEnvironmentRecommendationCollection"/> instance call the GetHostingEnvironmentRecommendations method from an instance of <see cref="AppServiceEnvironmentResource"/>.
    /// </summary>
    public partial class HostingEnvironmentRecommendationCollection : ArmCollection
    {
        private readonly ClientDiagnostics _hostingEnvironmentRecommendationRecommendationsClientDiagnostics;
        private readonly RecommendationsRestOperations _hostingEnvironmentRecommendationRecommendationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentRecommendationCollection"/> class for mocking. </summary>
        protected HostingEnvironmentRecommendationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentRecommendationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HostingEnvironmentRecommendationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hostingEnvironmentRecommendationRecommendationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", HostingEnvironmentRecommendationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HostingEnvironmentRecommendationResource.ResourceType, out string hostingEnvironmentRecommendationRecommendationsApiVersion);
            _hostingEnvironmentRecommendationRecommendationsRestClient = new RecommendationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hostingEnvironmentRecommendationRecommendationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppServiceEnvironmentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppServiceEnvironmentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get a recommendation rule for an app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{hostingEnvironmentName}/recommendations/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_GetRuleDetailsByHostingEnvironment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentRecommendationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the recommendation. </param>
        /// <param name="updateSeen"> Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of the recommendation object. </param>
        /// <param name="recommendationId"> The GUID of the recommendation object if you query an expired one. You don't need to specify it to query an active entry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<HostingEnvironmentRecommendationResource>> GetAsync(string name, bool? updateSeen = null, string recommendationId = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _hostingEnvironmentRecommendationRecommendationsClientDiagnostics.CreateScope("HostingEnvironmentRecommendationCollection.Get");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentRecommendationRecommendationsRestClient.GetRuleDetailsByHostingEnvironmentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, updateSeen, recommendationId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HostingEnvironmentRecommendationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get a recommendation rule for an app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{hostingEnvironmentName}/recommendations/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_GetRuleDetailsByHostingEnvironment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentRecommendationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the recommendation. </param>
        /// <param name="updateSeen"> Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of the recommendation object. </param>
        /// <param name="recommendationId"> The GUID of the recommendation object if you query an expired one. You don't need to specify it to query an active entry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<HostingEnvironmentRecommendationResource> Get(string name, bool? updateSeen = null, string recommendationId = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _hostingEnvironmentRecommendationRecommendationsClientDiagnostics.CreateScope("HostingEnvironmentRecommendationCollection.Get");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentRecommendationRecommendationsRestClient.GetRuleDetailsByHostingEnvironment(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, updateSeen, recommendationId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HostingEnvironmentRecommendationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{hostingEnvironmentName}/recommendations/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_GetRuleDetailsByHostingEnvironment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentRecommendationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the recommendation. </param>
        /// <param name="updateSeen"> Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of the recommendation object. </param>
        /// <param name="recommendationId"> The GUID of the recommendation object if you query an expired one. You don't need to specify it to query an active entry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, bool? updateSeen = null, string recommendationId = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _hostingEnvironmentRecommendationRecommendationsClientDiagnostics.CreateScope("HostingEnvironmentRecommendationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentRecommendationRecommendationsRestClient.GetRuleDetailsByHostingEnvironmentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, updateSeen, recommendationId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{hostingEnvironmentName}/recommendations/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_GetRuleDetailsByHostingEnvironment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentRecommendationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the recommendation. </param>
        /// <param name="updateSeen"> Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of the recommendation object. </param>
        /// <param name="recommendationId"> The GUID of the recommendation object if you query an expired one. You don't need to specify it to query an active entry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, bool? updateSeen = null, string recommendationId = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _hostingEnvironmentRecommendationRecommendationsClientDiagnostics.CreateScope("HostingEnvironmentRecommendationCollection.Exists");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentRecommendationRecommendationsRestClient.GetRuleDetailsByHostingEnvironment(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, updateSeen, recommendationId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{hostingEnvironmentName}/recommendations/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_GetRuleDetailsByHostingEnvironment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentRecommendationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the recommendation. </param>
        /// <param name="updateSeen"> Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of the recommendation object. </param>
        /// <param name="recommendationId"> The GUID of the recommendation object if you query an expired one. You don't need to specify it to query an active entry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<HostingEnvironmentRecommendationResource>> GetIfExistsAsync(string name, bool? updateSeen = null, string recommendationId = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _hostingEnvironmentRecommendationRecommendationsClientDiagnostics.CreateScope("HostingEnvironmentRecommendationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentRecommendationRecommendationsRestClient.GetRuleDetailsByHostingEnvironmentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, updateSeen, recommendationId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<HostingEnvironmentRecommendationResource>(response.GetRawResponse());
                return Response.FromValue(new HostingEnvironmentRecommendationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{hostingEnvironmentName}/recommendations/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_GetRuleDetailsByHostingEnvironment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentRecommendationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the recommendation. </param>
        /// <param name="updateSeen"> Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen timestamp of the recommendation object. </param>
        /// <param name="recommendationId"> The GUID of the recommendation object if you query an expired one. You don't need to specify it to query an active entry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<HostingEnvironmentRecommendationResource> GetIfExists(string name, bool? updateSeen = null, string recommendationId = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _hostingEnvironmentRecommendationRecommendationsClientDiagnostics.CreateScope("HostingEnvironmentRecommendationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentRecommendationRecommendationsRestClient.GetRuleDetailsByHostingEnvironment(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, updateSeen, recommendationId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<HostingEnvironmentRecommendationResource>(response.GetRawResponse());
                return Response.FromValue(new HostingEnvironmentRecommendationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
