// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Enumerates the possible value of keySource for Encryption. </summary>
    public readonly partial struct EventHubsEncryptionKeySource : IEquatable<EventHubsEncryptionKeySource>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventHubsEncryptionKeySource"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventHubsEncryptionKeySource(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftKeyVaultValue = "Microsoft.KeyVault";

        /// <summary> Microsoft.KeyVault. </summary>
        public static EventHubsEncryptionKeySource MicrosoftKeyVault { get; } = new EventHubsEncryptionKeySource(MicrosoftKeyVaultValue);
        /// <summary> Determines if two <see cref="EventHubsEncryptionKeySource"/> values are the same. </summary>
        public static bool operator ==(EventHubsEncryptionKeySource left, EventHubsEncryptionKeySource right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventHubsEncryptionKeySource"/> values are not the same. </summary>
        public static bool operator !=(EventHubsEncryptionKeySource left, EventHubsEncryptionKeySource right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EventHubsEncryptionKeySource"/>. </summary>
        public static implicit operator EventHubsEncryptionKeySource(string value) => new EventHubsEncryptionKeySource(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventHubsEncryptionKeySource other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventHubsEncryptionKeySource other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
