// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ManagedServices;

namespace Azure.ResourceManager.ManagedServices.Models
{
    /// <summary> The Azure Active Directory principal identifier, Azure built-in role, and just-in-time access policy that describes the just-in-time access the principal will receive on the delegated resource in the managed tenant. </summary>
    public partial class ManagedServicesEligibleAuthorization
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

        /// <summary> Initializes a new instance of <see cref="ManagedServicesEligibleAuthorization"/>. </summary>
        /// <param name="principalId"> The identifier of the Azure Active Directory principal. </param>
        /// <param name="roleDefinitionId"> The identifier of the Azure built-in role that defines the permissions that the Azure Active Directory principal will have on the projected scope. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        public ManagedServicesEligibleAuthorization(Guid principalId, string roleDefinitionId)
        {
            Argument.AssertNotNull(roleDefinitionId, nameof(roleDefinitionId));

            PrincipalId = principalId;
            RoleDefinitionId = roleDefinitionId;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedServicesEligibleAuthorization"/>. </summary>
        /// <param name="principalId"> The identifier of the Azure Active Directory principal. </param>
        /// <param name="principalIdDisplayName"> The display name of the Azure Active Directory principal. </param>
        /// <param name="roleDefinitionId"> The identifier of the Azure built-in role that defines the permissions that the Azure Active Directory principal will have on the projected scope. </param>
        /// <param name="justInTimeAccessPolicy"> The just-in-time access policy setting. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedServicesEligibleAuthorization(Guid principalId, string principalIdDisplayName, string roleDefinitionId, ManagedServicesJustInTimeAccessPolicy justInTimeAccessPolicy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PrincipalId = principalId;
            PrincipalIdDisplayName = principalIdDisplayName;
            RoleDefinitionId = roleDefinitionId;
            JustInTimeAccessPolicy = justInTimeAccessPolicy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedServicesEligibleAuthorization"/> for deserialization. </summary>
        internal ManagedServicesEligibleAuthorization()
        {
        }

        /// <summary> The identifier of the Azure Active Directory principal. </summary>
        public Guid PrincipalId { get; set; }
        /// <summary> The display name of the Azure Active Directory principal. </summary>
        public string PrincipalIdDisplayName { get; set; }
        /// <summary> The identifier of the Azure built-in role that defines the permissions that the Azure Active Directory principal will have on the projected scope. </summary>
        public string RoleDefinitionId { get; set; }
        /// <summary> The just-in-time access policy setting. </summary>
        public ManagedServicesJustInTimeAccessPolicy JustInTimeAccessPolicy { get; set; }
    }
}
