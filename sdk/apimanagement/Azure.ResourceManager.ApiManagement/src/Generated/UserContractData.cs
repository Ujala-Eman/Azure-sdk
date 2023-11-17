// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the UserContract data model.
    /// User details.
    /// </summary>
    public partial class UserContractData : ResourceData
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
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="UserContractData"/>. </summary>
        public UserContractData()
        {
            Identities = new ChangeTrackingList<UserIdentityContract>();
            Groups = new ChangeTrackingList<GroupContractProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="UserContractData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="state"> Account state. Specifies whether the user is active or not. Blocked users are unable to sign into the developer portal or call any APIs of subscribed products. Default state is Active. </param>
        /// <param name="note"> Optional note about a user set by the administrator. </param>
        /// <param name="identities"> Collection of user identities. </param>
        /// <param name="firstName"> First name. </param>
        /// <param name="lastName"> Last name. </param>
        /// <param name="email"> Email address. </param>
        /// <param name="registriesOn">
        /// Date of user registration. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </param>
        /// <param name="groups"> Collection of groups user is part of. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UserContractData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ApiManagementUserState? state, string note, IList<UserIdentityContract> identities, string firstName, string lastName, string email, DateTimeOffset? registriesOn, IReadOnlyList<GroupContractProperties> groups, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            State = state;
            Note = note;
            Identities = identities;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            RegistriesOn = registriesOn;
            Groups = groups;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Account state. Specifies whether the user is active or not. Blocked users are unable to sign into the developer portal or call any APIs of subscribed products. Default state is Active. </summary>
        public ApiManagementUserState? State { get; set; }
        /// <summary> Optional note about a user set by the administrator. </summary>
        public string Note { get; set; }
        /// <summary> Collection of user identities. </summary>
        public IList<UserIdentityContract> Identities { get; }
        /// <summary> First name. </summary>
        public string FirstName { get; set; }
        /// <summary> Last name. </summary>
        public string LastName { get; set; }
        /// <summary> Email address. </summary>
        public string Email { get; set; }
        /// <summary>
        /// Date of user registration. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </summary>
        public DateTimeOffset? RegistriesOn { get; set; }
        /// <summary> Collection of groups user is part of. </summary>
        public IReadOnlyList<GroupContractProperties> Groups { get; }
    }
}
