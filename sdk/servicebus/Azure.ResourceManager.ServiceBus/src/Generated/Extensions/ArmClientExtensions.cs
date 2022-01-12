// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region ServiceBusNamespace
        /// <summary> Gets an object representing a ServiceBusNamespace along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusNamespace" /> object. </returns>
        public static ServiceBusNamespace GetServiceBusNamespace(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ServiceBusNamespace(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region NetworkRuleSet
        /// <summary> Gets an object representing a NetworkRuleSet along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkRuleSet" /> object. </returns>
        public static NetworkRuleSet GetNetworkRuleSet(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new NetworkRuleSet(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region PrivateEndpointConnection
        /// <summary> Gets an object representing a PrivateEndpointConnection along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateEndpointConnection" /> object. </returns>
        public static PrivateEndpointConnection GetPrivateEndpointConnection(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new PrivateEndpointConnection(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DisasterRecovery
        /// <summary> Gets an object representing a DisasterRecovery along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DisasterRecovery" /> object. </returns>
        public static DisasterRecovery GetDisasterRecovery(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DisasterRecovery(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region MigrationConfigProperties
        /// <summary> Gets an object representing a MigrationConfigProperties along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MigrationConfigProperties" /> object. </returns>
        public static MigrationConfigProperties GetMigrationConfigProperties(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new MigrationConfigProperties(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region NamespaceAuthorizationRule
        /// <summary> Gets an object representing a NamespaceAuthorizationRule along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NamespaceAuthorizationRule" /> object. </returns>
        public static NamespaceAuthorizationRule GetNamespaceAuthorizationRule(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new NamespaceAuthorizationRule(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region NamespaceQueueAuthorizationRule
        /// <summary> Gets an object representing a NamespaceQueueAuthorizationRule along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NamespaceQueueAuthorizationRule" /> object. </returns>
        public static NamespaceQueueAuthorizationRule GetNamespaceQueueAuthorizationRule(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new NamespaceQueueAuthorizationRule(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region NamespaceTopicAuthorizationRule
        /// <summary> Gets an object representing a NamespaceTopicAuthorizationRule along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NamespaceTopicAuthorizationRule" /> object. </returns>
        public static NamespaceTopicAuthorizationRule GetNamespaceTopicAuthorizationRule(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new NamespaceTopicAuthorizationRule(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region NamespaceDisasterRecoveryConfigAuthorizationRule
        /// <summary> Gets an object representing a NamespaceDisasterRecoveryConfigAuthorizationRule along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NamespaceDisasterRecoveryConfigAuthorizationRule" /> object. </returns>
        public static NamespaceDisasterRecoveryConfigAuthorizationRule GetNamespaceDisasterRecoveryConfigAuthorizationRule(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new NamespaceDisasterRecoveryConfigAuthorizationRule(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ServiceBusQueue
        /// <summary> Gets an object representing a ServiceBusQueue along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusQueue" /> object. </returns>
        public static ServiceBusQueue GetServiceBusQueue(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ServiceBusQueue(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ServiceBusTopic
        /// <summary> Gets an object representing a ServiceBusTopic along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusTopic" /> object. </returns>
        public static ServiceBusTopic GetServiceBusTopic(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ServiceBusTopic(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ServiceBusRule
        /// <summary> Gets an object representing a ServiceBusRule along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusRule" /> object. </returns>
        public static ServiceBusRule GetServiceBusRule(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ServiceBusRule(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ServiceBusSubscription
        /// <summary> Gets an object representing a ServiceBusSubscription along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusSubscription" /> object. </returns>
        public static ServiceBusSubscription GetServiceBusSubscription(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ServiceBusSubscription(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}
