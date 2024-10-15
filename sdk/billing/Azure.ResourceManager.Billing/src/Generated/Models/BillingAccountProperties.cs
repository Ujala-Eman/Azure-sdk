// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> A billing account. </summary>
    public partial class BillingAccountProperties
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

        /// <summary> Initializes a new instance of <see cref="BillingAccountProperties"/>. </summary>
        public BillingAccountProperties()
        {
            BillingRelationshipTypes = new ChangeTrackingList<BillingRelationshipType>();
            Qualifications = new ChangeTrackingList<string>();
            TaxIds = new ChangeTrackingList<BillingTaxIdentifier>();
        }

        /// <summary> Initializes a new instance of <see cref="BillingAccountProperties"/>. </summary>
        /// <param name="provisioningState"> The provisioning state of the resource during a long-running operation. </param>
        /// <param name="accountStatus"> The current status of the billing account. </param>
        /// <param name="accountType"> The type of customer. </param>
        /// <param name="accountSubType"> The tier of the account. </param>
        /// <param name="accountStatusReasonCode"> Reason for the specified billing account status. </param>
        /// <param name="agreementType"> The type of agreement. </param>
        /// <param name="displayName"> The billing account name. </param>
        /// <param name="enrollmentDetails"> The properties of an enrollment. </param>
        /// <param name="hasReadAccess"> Indicates whether user has read access to the billing account. </param>
        /// <param name="hasNoBillingProfiles"> Indicates whether or not the billing account has any billing profiles. </param>
        /// <param name="notificationEmailAddress"> Notification email address for legacy account. Available for agreement type Microsoft Online Services Program. </param>
        /// <param name="primaryBillingTenantId"> The tenant that was used to set up the billing account. By default, only users from this tenant can get role assignments on the billing account and all purchases are provisioned in this tenant. </param>
        /// <param name="soldTo"> The address of the individual or organization that is responsible for the billing account. </param>
        /// <param name="registrationNumber"> Describes the registration number of the organization linked with the billing account. </param>
        /// <param name="billingRelationshipTypes"> Identifies the billing relationships represented by a billing account. The billing relationship may be between Microsoft, the customer, and/or a third-party. </param>
        /// <param name="qualifications"> Qualifications for pricing on a billing account. Values may be Commercial, Education, Charity or Government. </param>
        /// <param name="taxIds"> A list of tax identifiers for the billing account. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BillingAccountProperties(BillingProvisioningState? provisioningState, BillingAccountStatus? accountStatus, BillingAccountType? accountType, BillingAccountSubType? accountSubType, BillingAccountStatusReasonCode? accountStatusReasonCode, BillingAgreementType? agreementType, string displayName, BillingAccountEnrollmentDetails enrollmentDetails, bool? hasReadAccess, bool? hasNoBillingProfiles, string notificationEmailAddress, Guid? primaryBillingTenantId, BillingAddressDetails soldTo, BillingRegistrationNumber registrationNumber, IReadOnlyList<BillingRelationshipType> billingRelationshipTypes, IReadOnlyList<string> qualifications, IList<BillingTaxIdentifier> taxIds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            AccountStatus = accountStatus;
            AccountType = accountType;
            AccountSubType = accountSubType;
            AccountStatusReasonCode = accountStatusReasonCode;
            AgreementType = agreementType;
            DisplayName = displayName;
            EnrollmentDetails = enrollmentDetails;
            HasReadAccess = hasReadAccess;
            HasNoBillingProfiles = hasNoBillingProfiles;
            NotificationEmailAddress = notificationEmailAddress;
            PrimaryBillingTenantId = primaryBillingTenantId;
            SoldTo = soldTo;
            RegistrationNumber = registrationNumber;
            BillingRelationshipTypes = billingRelationshipTypes;
            Qualifications = qualifications;
            TaxIds = taxIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The provisioning state of the resource during a long-running operation. </summary>
        [WirePath("provisioningState")]
        public BillingProvisioningState? ProvisioningState { get; }
        /// <summary> The current status of the billing account. </summary>
        [WirePath("accountStatus")]
        public BillingAccountStatus? AccountStatus { get; }
        /// <summary> The type of customer. </summary>
        [WirePath("accountType")]
        public BillingAccountType? AccountType { get; }
        /// <summary> The tier of the account. </summary>
        [WirePath("accountSubType")]
        public BillingAccountSubType? AccountSubType { get; }
        /// <summary> Reason for the specified billing account status. </summary>
        [WirePath("accountStatusReasonCode")]
        public BillingAccountStatusReasonCode? AccountStatusReasonCode { get; }
        /// <summary> The type of agreement. </summary>
        [WirePath("agreementType")]
        public BillingAgreementType? AgreementType { get; }
        /// <summary> The billing account name. </summary>
        [WirePath("displayName")]
        public string DisplayName { get; set; }
        /// <summary> The properties of an enrollment. </summary>
        [WirePath("enrollmentDetails")]
        public BillingAccountEnrollmentDetails EnrollmentDetails { get; set; }
        /// <summary> Indicates whether user has read access to the billing account. </summary>
        [WirePath("hasReadAccess")]
        public bool? HasReadAccess { get; set; }
        /// <summary> Indicates whether or not the billing account has any billing profiles. </summary>
        [WirePath("hasNoBillingProfiles")]
        public bool? HasNoBillingProfiles { get; set; }
        /// <summary> Notification email address for legacy account. Available for agreement type Microsoft Online Services Program. </summary>
        [WirePath("notificationEmailAddress")]
        public string NotificationEmailAddress { get; set; }
        /// <summary> The tenant that was used to set up the billing account. By default, only users from this tenant can get role assignments on the billing account and all purchases are provisioned in this tenant. </summary>
        [WirePath("primaryBillingTenantId")]
        public Guid? PrimaryBillingTenantId { get; set; }
        /// <summary> The address of the individual or organization that is responsible for the billing account. </summary>
        [WirePath("soldTo")]
        public BillingAddressDetails SoldTo { get; set; }
        /// <summary> Describes the registration number of the organization linked with the billing account. </summary>
        [WirePath("registrationNumber")]
        public BillingRegistrationNumber RegistrationNumber { get; set; }
        /// <summary> Identifies the billing relationships represented by a billing account. The billing relationship may be between Microsoft, the customer, and/or a third-party. </summary>
        [WirePath("billingRelationshipTypes")]
        public IReadOnlyList<BillingRelationshipType> BillingRelationshipTypes { get; }
        /// <summary> Qualifications for pricing on a billing account. Values may be Commercial, Education, Charity or Government. </summary>
        [WirePath("qualifications")]
        public IReadOnlyList<string> Qualifications { get; }
        /// <summary> A list of tax identifiers for the billing account. </summary>
        [WirePath("taxIds")]
        public IList<BillingTaxIdentifier> TaxIds { get; }
    }
}
