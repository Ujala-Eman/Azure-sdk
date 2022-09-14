// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    /// <summary>
    /// Properties related to Digital Twins Endpoint
    /// Please note <see cref="DigitalTwinsEndpointResourceProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DigitalTwinsEventGridProperties"/>, <see cref="DigitalTwinsEventHubProperties"/> and <see cref="DigitalTwinsServiceBusProperties"/>.
    /// </summary>
    public abstract partial class DigitalTwinsEndpointResourceProperties
    {
        /// <summary> Initializes a new instance of DigitalTwinsEndpointResourceProperties. </summary>
        protected DigitalTwinsEndpointResourceProperties()
        {
        }

        /// <summary> Initializes a new instance of DigitalTwinsEndpointResourceProperties. </summary>
        /// <param name="endpointType"> The type of Digital Twins endpoint. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="createdOn"> Time when the Endpoint was added to DigitalTwinsInstance. </param>
        /// <param name="authenticationType"> Specifies the authentication type being used for connecting to the endpoint. Defaults to &apos;KeyBased&apos;. If &apos;KeyBased&apos; is selected, a connection string must be specified (at least the primary connection string). If &apos;IdentityBased&apos; is select, the endpointUri and entityPath properties must be specified. </param>
        /// <param name="deadLetterSecret"> Dead letter storage secret for key-based authentication. Will be obfuscated during read. </param>
        /// <param name="deadLetterUri"> Dead letter storage URL for identity-based authentication. </param>
        internal DigitalTwinsEndpointResourceProperties(EndpointType endpointType, DigitalTwinsEndpointProvisioningState? provisioningState, DateTimeOffset? createdOn, DigitalTwinsAuthenticationType? authenticationType, string deadLetterSecret, Uri deadLetterUri)
        {
            EndpointType = endpointType;
            ProvisioningState = provisioningState;
            CreatedOn = createdOn;
            AuthenticationType = authenticationType;
            DeadLetterSecret = deadLetterSecret;
            DeadLetterUri = deadLetterUri;
        }

        /// <summary> The type of Digital Twins endpoint. </summary>
        internal EndpointType EndpointType { get; set; }
        /// <summary> The provisioning state. </summary>
        public DigitalTwinsEndpointProvisioningState? ProvisioningState { get; }
        /// <summary> Time when the Endpoint was added to DigitalTwinsInstance. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Specifies the authentication type being used for connecting to the endpoint. Defaults to &apos;KeyBased&apos;. If &apos;KeyBased&apos; is selected, a connection string must be specified (at least the primary connection string). If &apos;IdentityBased&apos; is select, the endpointUri and entityPath properties must be specified. </summary>
        public DigitalTwinsAuthenticationType? AuthenticationType { get; set; }
        /// <summary> Dead letter storage secret for key-based authentication. Will be obfuscated during read. </summary>
        public string DeadLetterSecret { get; set; }
        /// <summary> Dead letter storage URL for identity-based authentication. </summary>
        public Uri DeadLetterUri { get; set; }
    }
}
