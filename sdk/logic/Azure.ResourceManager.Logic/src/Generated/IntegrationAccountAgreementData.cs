// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Logic
{
    /// <summary> A class representing the IntegrationAccountAgreement data model. </summary>
    public partial class IntegrationAccountAgreementData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of IntegrationAccountAgreementData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="agreementType"> The agreement type. </param>
        /// <param name="hostPartner"> The integration account partner that is set as host partner for this agreement. </param>
        /// <param name="guestPartner"> The integration account partner that is set as guest partner for this agreement. </param>
        /// <param name="hostIdentity"> The business identity of the host partner. </param>
        /// <param name="guestIdentity"> The business identity of the guest partner. </param>
        /// <param name="content"> The agreement content. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostPartner"/>, <paramref name="guestPartner"/>, <paramref name="hostIdentity"/>, <paramref name="guestIdentity"/> or <paramref name="content"/> is null. </exception>
        public IntegrationAccountAgreementData(AzureLocation location, IntegrationAccountAgreementType agreementType, string hostPartner, string guestPartner, IntegrationAccountBusinessIdentity hostIdentity, IntegrationAccountBusinessIdentity guestIdentity, IntegrationAccountAgreementContent content) : base(location)
        {
            if (hostPartner == null)
            {
                throw new ArgumentNullException(nameof(hostPartner));
            }
            if (guestPartner == null)
            {
                throw new ArgumentNullException(nameof(guestPartner));
            }
            if (hostIdentity == null)
            {
                throw new ArgumentNullException(nameof(hostIdentity));
            }
            if (guestIdentity == null)
            {
                throw new ArgumentNullException(nameof(guestIdentity));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            AgreementType = agreementType;
            HostPartner = hostPartner;
            GuestPartner = guestPartner;
            HostIdentity = hostIdentity;
            GuestIdentity = guestIdentity;
            Content = content;
        }

        /// <summary> Initializes a new instance of IntegrationAccountAgreementData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="createdOn"> The created time. </param>
        /// <param name="changedOn"> The changed time. </param>
        /// <param name="metadata"> The metadata. </param>
        /// <param name="agreementType"> The agreement type. </param>
        /// <param name="hostPartner"> The integration account partner that is set as host partner for this agreement. </param>
        /// <param name="guestPartner"> The integration account partner that is set as guest partner for this agreement. </param>
        /// <param name="hostIdentity"> The business identity of the host partner. </param>
        /// <param name="guestIdentity"> The business identity of the guest partner. </param>
        /// <param name="content"> The agreement content. </param>
        internal IntegrationAccountAgreementData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, DateTimeOffset? createdOn, DateTimeOffset? changedOn, BinaryData metadata, IntegrationAccountAgreementType agreementType, string hostPartner, string guestPartner, IntegrationAccountBusinessIdentity hostIdentity, IntegrationAccountBusinessIdentity guestIdentity, IntegrationAccountAgreementContent content) : base(id, name, resourceType, systemData, tags, location)
        {
            CreatedOn = createdOn;
            ChangedOn = changedOn;
            Metadata = metadata;
            AgreementType = agreementType;
            HostPartner = hostPartner;
            GuestPartner = guestPartner;
            HostIdentity = hostIdentity;
            GuestIdentity = guestIdentity;
            Content = content;
        }

        /// <summary> The created time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The changed time. </summary>
        public DateTimeOffset? ChangedOn { get; }
        /// <summary>
        /// The metadata..
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData Metadata { get; set; }
        /// <summary> The agreement type. </summary>
        public IntegrationAccountAgreementType AgreementType { get; set; }
        /// <summary> The integration account partner that is set as host partner for this agreement. </summary>
        public string HostPartner { get; set; }
        /// <summary> The integration account partner that is set as guest partner for this agreement. </summary>
        public string GuestPartner { get; set; }
        /// <summary> The business identity of the host partner. </summary>
        public IntegrationAccountBusinessIdentity HostIdentity { get; set; }
        /// <summary> The business identity of the guest partner. </summary>
        public IntegrationAccountBusinessIdentity GuestIdentity { get; set; }
        /// <summary> The agreement content. </summary>
        public IntegrationAccountAgreementContent Content { get; set; }
    }
}
