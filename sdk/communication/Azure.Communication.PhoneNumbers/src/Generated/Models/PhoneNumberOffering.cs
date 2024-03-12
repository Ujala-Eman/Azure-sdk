// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> Represents a phone number capability offering. </summary>
    public partial class PhoneNumberOffering
    {
        /// <summary> Initializes a new instance of <see cref="PhoneNumberOffering"/>. </summary>
        /// <param name="cost"> The incurred cost for a single phone number. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cost"/> is null. </exception>
        internal PhoneNumberOffering(PhoneNumberCost cost)
        {
            Argument.AssertNotNull(cost, nameof(cost));

            Cost = cost;
        }

        /// <summary> Initializes a new instance of <see cref="PhoneNumberOffering"/>. </summary>
        /// <param name="phoneNumberType"> Represents the number type of the offering. </param>
        /// <param name="assignmentType"> Represents the assignment type of the offering. </param>
        /// <param name="availableCapabilities"> Capabilities of a phone number. </param>
        /// <param name="cost"> The incurred cost for a single phone number. </param>
        internal PhoneNumberOffering(PhoneNumberType? phoneNumberType, PhoneNumberAssignmentType? assignmentType, PhoneNumberCapabilities availableCapabilities, PhoneNumberCost cost)
        {
            PhoneNumberType = phoneNumberType;
            AssignmentType = assignmentType;
            AvailableCapabilities = availableCapabilities;
            Cost = cost;
        }

        /// <summary> Represents the number type of the offering. </summary>
        public PhoneNumberType? PhoneNumberType { get; }
        /// <summary> Represents the assignment type of the offering. </summary>
        public PhoneNumberAssignmentType? AssignmentType { get; }
        /// <summary> Capabilities of a phone number. </summary>
        public PhoneNumberCapabilities AvailableCapabilities { get; }
        /// <summary> The incurred cost for a single phone number. </summary>
        public PhoneNumberCost Cost { get; }
    }
}
