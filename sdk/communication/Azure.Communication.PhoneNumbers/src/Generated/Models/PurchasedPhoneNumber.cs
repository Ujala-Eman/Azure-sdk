// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> Represents a purchased phone number. </summary>
    public partial class PurchasedPhoneNumber
    {
        /// <summary> Initializes a new instance of <see cref="PurchasedPhoneNumber"/>. </summary>
        /// <param name="id"> The id of the phone number, e.g. 11234567890. </param>
        /// <param name="phoneNumber"> String of the E.164 format of the phone number, e.g. +11234567890. </param>
        /// <param name="countryCode"> The ISO 3166-2 code of the phone number's country, e.g. US. </param>
        /// <param name="phoneNumberType"> The phone number's type, e.g. geographic, tollFree. </param>
        /// <param name="capabilities"> Capabilities of a phone number. </param>
        /// <param name="assignmentType"> The assignment type of the phone number. A phone number can be assigned to a person, or to an application. </param>
        /// <param name="purchaseDate"> The date and time that the phone number was purchased. </param>
        /// <param name="cost"> The incurred cost for a single phone number. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="phoneNumber"/>, <paramref name="countryCode"/>, <paramref name="capabilities"/> or <paramref name="cost"/> is null. </exception>
        internal PurchasedPhoneNumber(string id, string phoneNumber, string countryCode, PhoneNumberType phoneNumberType, PhoneNumberCapabilities capabilities, PhoneNumberAssignmentType assignmentType, DateTimeOffset purchaseDate, PhoneNumberCost cost)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(phoneNumber, nameof(phoneNumber));
            Argument.AssertNotNull(countryCode, nameof(countryCode));
            Argument.AssertNotNull(capabilities, nameof(capabilities));
            Argument.AssertNotNull(cost, nameof(cost));

            Id = id;
            PhoneNumber = phoneNumber;
            CountryCode = countryCode;
            PhoneNumberType = phoneNumberType;
            Capabilities = capabilities;
            AssignmentType = assignmentType;
            PurchaseDate = purchaseDate;
            Cost = cost;
        }

        /// <summary> The id of the phone number, e.g. 11234567890. </summary>
        public string Id { get; }
        /// <summary> String of the E.164 format of the phone number, e.g. +11234567890. </summary>
        public string PhoneNumber { get; }
        /// <summary> The ISO 3166-2 code of the phone number's country, e.g. US. </summary>
        public string CountryCode { get; }
        /// <summary> The phone number's type, e.g. geographic, tollFree. </summary>
        public PhoneNumberType PhoneNumberType { get; }
        /// <summary> Capabilities of a phone number. </summary>
        public PhoneNumberCapabilities Capabilities { get; }
        /// <summary> The assignment type of the phone number. A phone number can be assigned to a person, or to an application. </summary>
        public PhoneNumberAssignmentType AssignmentType { get; }
        /// <summary> The date and time that the phone number was purchased. </summary>
        public DateTimeOffset PurchaseDate { get; }
        /// <summary> The incurred cost for a single phone number. </summary>
        public PhoneNumberCost Cost { get; }
    }
}
