// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Confluent.Models
{
    /// <summary> SaaS Offer Status for confluent RP. </summary>
    public readonly partial struct ConfluentSaaSOfferStatus : IEquatable<ConfluentSaaSOfferStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConfluentSaaSOfferStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConfluentSaaSOfferStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StartedValue = "Started";
        private const string PendingFulfillmentStartValue = "PendingFulfillmentStart";
        private const string InProgressValue = "InProgress";
        private const string SubscribedValue = "Subscribed";
        private const string SuspendedValue = "Suspended";
        private const string ReinstatedValue = "Reinstated";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string UnsubscribedValue = "Unsubscribed";
        private const string UpdatingValue = "Updating";

        /// <summary> Started. </summary>
        public static ConfluentSaaSOfferStatus Started { get; } = new ConfluentSaaSOfferStatus(StartedValue);
        /// <summary> PendingFulfillmentStart. </summary>
        public static ConfluentSaaSOfferStatus PendingFulfillmentStart { get; } = new ConfluentSaaSOfferStatus(PendingFulfillmentStartValue);
        /// <summary> InProgress. </summary>
        public static ConfluentSaaSOfferStatus InProgress { get; } = new ConfluentSaaSOfferStatus(InProgressValue);
        /// <summary> Subscribed. </summary>
        public static ConfluentSaaSOfferStatus Subscribed { get; } = new ConfluentSaaSOfferStatus(SubscribedValue);
        /// <summary> Suspended. </summary>
        public static ConfluentSaaSOfferStatus Suspended { get; } = new ConfluentSaaSOfferStatus(SuspendedValue);
        /// <summary> Reinstated. </summary>
        public static ConfluentSaaSOfferStatus Reinstated { get; } = new ConfluentSaaSOfferStatus(ReinstatedValue);
        /// <summary> Succeeded. </summary>
        public static ConfluentSaaSOfferStatus Succeeded { get; } = new ConfluentSaaSOfferStatus(SucceededValue);
        /// <summary> Failed. </summary>
        public static ConfluentSaaSOfferStatus Failed { get; } = new ConfluentSaaSOfferStatus(FailedValue);
        /// <summary> Unsubscribed. </summary>
        public static ConfluentSaaSOfferStatus Unsubscribed { get; } = new ConfluentSaaSOfferStatus(UnsubscribedValue);
        /// <summary> Updating. </summary>
        public static ConfluentSaaSOfferStatus Updating { get; } = new ConfluentSaaSOfferStatus(UpdatingValue);
        /// <summary> Determines if two <see cref="ConfluentSaaSOfferStatus"/> values are the same. </summary>
        public static bool operator ==(ConfluentSaaSOfferStatus left, ConfluentSaaSOfferStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConfluentSaaSOfferStatus"/> values are not the same. </summary>
        public static bool operator !=(ConfluentSaaSOfferStatus left, ConfluentSaaSOfferStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConfluentSaaSOfferStatus"/>. </summary>
        public static implicit operator ConfluentSaaSOfferStatus(string value) => new ConfluentSaaSOfferStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConfluentSaaSOfferStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConfluentSaaSOfferStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
