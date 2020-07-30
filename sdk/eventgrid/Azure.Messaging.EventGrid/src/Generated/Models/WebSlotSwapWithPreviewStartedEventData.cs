// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.Models
{
    /// <summary> Schema of the Data property of an EventGridEvent for an Microsoft.Web.SlotSwapWithPreviewStarted event. </summary>
    internal partial class WebSlotSwapWithPreviewStartedEventData
    {
        /// <summary> Initializes a new instance of WebSlotSwapWithPreviewStartedEventData. </summary>
        internal WebSlotSwapWithPreviewStartedEventData()
        {
        }

        /// <summary> Detail of action on the app. </summary>
        public AppEventTypeDetail AppEventTypeDetail { get; }
        /// <summary> name of the web site that had this event. </summary>
        public string Name { get; }
        /// <summary> The client request id generated by the app service for the site API operation that triggered this event. </summary>
        public string ClientRequestId { get; }
        /// <summary> The correlation request id generated by the app service for the site API operation that triggered this event. </summary>
        public string CorrelationRequestId { get; }
        /// <summary> The request id generated by the app service for the site API operation that triggered this event. </summary>
        public string RequestId { get; }
        /// <summary> HTTP request URL of this operation. </summary>
        public string Address { get; }
        /// <summary> HTTP verb of this operation. </summary>
        public string Verb { get; }
    }
}
