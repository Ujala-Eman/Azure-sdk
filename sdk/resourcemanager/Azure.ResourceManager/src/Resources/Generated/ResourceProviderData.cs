// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing the ResourceProvider data model.
    /// Resource provider information.
    /// </summary>
    public partial class ResourceProviderData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ResourceProviderData"/>. </summary>
        /// <param name="id"> The provider ID. </param>
        /// <param name="namespace"> The namespace of the resource provider. </param>
        /// <param name="registrationState"> The registration state of the resource provider. </param>
        /// <param name="registrationPolicy"> The registration policy of the resource provider. </param>
        /// <param name="resourceTypes"> The collection of provider resource types. </param>
        /// <param name="providerAuthorizationConsentState"> The provider authorization consent state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceProviderData(ResourceIdentifier id, string @namespace, string registrationState, string registrationPolicy, IReadOnlyList<ProviderResourceType> resourceTypes, ProviderAuthorizationConsentState? providerAuthorizationConsentState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Namespace = @namespace;
            RegistrationState = registrationState;
            RegistrationPolicy = registrationPolicy;
            ResourceTypes = resourceTypes;
            ProviderAuthorizationConsentState = providerAuthorizationConsentState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
        /// <summary> The namespace of the resource provider. </summary>
        public string Namespace { get; }
        /// <summary> The registration state of the resource provider. </summary>
        public string RegistrationState { get; }
        /// <summary> The registration policy of the resource provider. </summary>
        public string RegistrationPolicy { get; }
        /// <summary> The collection of provider resource types. </summary>
        public IReadOnlyList<ProviderResourceType> ResourceTypes { get; }
        /// <summary> The provider authorization consent state. </summary>
        public ProviderAuthorizationConsentState? ProviderAuthorizationConsentState { get; }
    }
}
