// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.ServiceBus.DeadletterMessagesAvailableWithNoListenersEvent event. </summary>
    public partial class ServiceBusDeadletterMessagesAvailableWithNoListenersEventData
    {
        /// <summary> Initializes a new instance of ServiceBusDeadletterMessagesAvailableWithNoListenersEventData. </summary>
        internal ServiceBusDeadletterMessagesAvailableWithNoListenersEventData()
        {
        }

        /// <summary> Initializes a new instance of ServiceBusDeadletterMessagesAvailableWithNoListenersEventData. </summary>
        /// <param name="namespaceName"> The namespace name of the Microsoft.ServiceBus resource. </param>
        /// <param name="requestUri"> The endpoint of the Microsoft.ServiceBus resource. </param>
        /// <param name="entityType"> The entity type of the Microsoft.ServiceBus resource. Could be one of &apos;queue&apos; or &apos;subscriber&apos;. </param>
        /// <param name="queueName"> The name of the Microsoft.ServiceBus queue. If the entity type is of type &apos;subscriber&apos;, then this value will be null. </param>
        /// <param name="topicName"> The name of the Microsoft.ServiceBus topic. If the entity type is of type &apos;queue&apos;, then this value will be null. </param>
        /// <param name="subscriptionName"> The name of the Microsoft.ServiceBus topic&apos;s subscription. If the entity type is of type &apos;queue&apos;, then this value will be null. </param>
        internal ServiceBusDeadletterMessagesAvailableWithNoListenersEventData(string namespaceName, string requestUri, string entityType, string queueName, string topicName, string subscriptionName)
        {
            NamespaceName = namespaceName;
            RequestUri = requestUri;
            EntityType = entityType;
            QueueName = queueName;
            TopicName = topicName;
            SubscriptionName = subscriptionName;
        }

        /// <summary> The namespace name of the Microsoft.ServiceBus resource. </summary>
        public string NamespaceName { get; }
        /// <summary> The endpoint of the Microsoft.ServiceBus resource. </summary>
        public string RequestUri { get; }
        /// <summary> The entity type of the Microsoft.ServiceBus resource. Could be one of &apos;queue&apos; or &apos;subscriber&apos;. </summary>
        public string EntityType { get; }
        /// <summary> The name of the Microsoft.ServiceBus queue. If the entity type is of type &apos;subscriber&apos;, then this value will be null. </summary>
        public string QueueName { get; }
        /// <summary> The name of the Microsoft.ServiceBus topic. If the entity type is of type &apos;queue&apos;, then this value will be null. </summary>
        public string TopicName { get; }
        /// <summary> The name of the Microsoft.ServiceBus topic&apos;s subscription. If the entity type is of type &apos;queue&apos;, then this value will be null. </summary>
        public string SubscriptionName { get; }
    }
}
