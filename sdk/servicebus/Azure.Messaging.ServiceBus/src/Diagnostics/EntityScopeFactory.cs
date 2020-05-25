﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using Azure.Core.Pipeline;

namespace Azure.Messaging.ServiceBus.Diagnostics
{
    /// <summary>
    ///   Enables diagnostics instrumentation to be applied to <see cref="ServiceBusMessage" />
    ///   instances.
    /// </summary>
    ///
    internal class EntityScopeFactory
    {
        /// <summary>The namespace used for the Service Bus diagnostic scope.</summary>
        public const string DiagnosticNamespace = "Azure.Messaging.ServiceBus";

        /// <summary>The namespace used for the Azure Resource Manager provider namespace.</summary>
        public const string ResourceProviderNamespace = "Microsoft.ServiceBus";
        private readonly string _entityPath;
        private readonly string _fullyQualifiedNamespace;

        /// <summary>
        ///   The client diagnostics instance responsible for managing scope.
        /// </summary>
        ///
        public static DiagnosticScopeFactory ScopeFactory { get; } = new DiagnosticScopeFactory(DiagnosticNamespace, ResourceProviderNamespace, true);

        public EntityScopeFactory(
            string entityPath,
            string fullyQualifiedNamespace)
        {
            _entityPath = entityPath;
            _fullyQualifiedNamespace = fullyQualifiedNamespace;
        }

        /// <summary>
        ///   Extracts a diagnostic id from the given event.
        /// </summary>
        ///
        /// <param name="properties">The properties holding the diagnostic id.</param>
        /// <param name="id">The value of the diagnostics identifier assigned to the event. </param>
        ///
        /// <returns><c>true</c> if the event was contained the diagnostic id; otherwise, <c>false</c>.</returns>
        ///
        public static bool TryExtractDiagnosticId(IDictionary<string, object> properties, out string id)
        {
            id = null;

            if (properties.TryGetValue(DiagnosticProperty.DiagnosticIdAttribute, out var objectId) && objectId is string stringId)
            {
                id = stringId;
                return true;
            }

            return false;
        }

        public DiagnosticScope CreateScope(
            string activityName,
            string kindAttribute = default,
            string lockToken = default,
            string sessionId = default,
            int? requestedMessageCount = default)
        {
            DiagnosticScope scope = ScopeFactory.CreateScope(activityName);
            scope.AddAttribute(DiagnosticProperty.KindAttribute, kindAttribute ?? DiagnosticProperty.ClientKind);
            scope.AddAttribute(
                DiagnosticProperty.ServiceContextAttribute,
                DiagnosticProperty.ServiceBusServiceContext);
            scope.AddAttribute(DiagnosticProperty.EntityAttribute, _entityPath);
            scope.AddAttribute(DiagnosticProperty.EndpointAttribute, _fullyQualifiedNamespace);
            if (lockToken != null)
            {
                scope.AddAttribute(DiagnosticProperty.LockTokensAttribute, lockToken);
            }
            if (sessionId != null)
            {
                scope.AddAttribute(DiagnosticProperty.SessionIdAttribute, sessionId);
            }
            if (requestedMessageCount != null)
            {
                scope.AddAttribute(DiagnosticProperty.RequestedMessageCountAttribute, requestedMessageCount);
            }
            return scope;
        }

        /// <summary>
        ///   Resets the instrumentation associated with a given event.
        /// </summary>
        ///
        /// <param name="message">The event to reset.</param>
        ///
        public static void ResetEvent(ServiceBusMessage message) =>
            message.Properties.Remove(DiagnosticProperty.DiagnosticIdAttribute);
    }
}
