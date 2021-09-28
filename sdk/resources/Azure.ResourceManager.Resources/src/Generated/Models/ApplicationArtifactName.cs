// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The managed application artifact name. </summary>
    public readonly partial struct ApplicationArtifactName : IEquatable<ApplicationArtifactName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApplicationArtifactName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApplicationArtifactName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string ViewDefinitionValue = "ViewDefinition";
        private const string AuthorizationsValue = "Authorizations";
        private const string CustomRoleDefinitionValue = "CustomRoleDefinition";

        /// <summary> NotSpecified. </summary>
        public static ApplicationArtifactName NotSpecified { get; } = new ApplicationArtifactName(NotSpecifiedValue);
        /// <summary> ViewDefinition. </summary>
        public static ApplicationArtifactName ViewDefinition { get; } = new ApplicationArtifactName(ViewDefinitionValue);
        /// <summary> Authorizations. </summary>
        public static ApplicationArtifactName Authorizations { get; } = new ApplicationArtifactName(AuthorizationsValue);
        /// <summary> CustomRoleDefinition. </summary>
        public static ApplicationArtifactName CustomRoleDefinition { get; } = new ApplicationArtifactName(CustomRoleDefinitionValue);
        /// <summary> Determines if two <see cref="ApplicationArtifactName"/> values are the same. </summary>
        public static bool operator ==(ApplicationArtifactName left, ApplicationArtifactName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationArtifactName"/> values are not the same. </summary>
        public static bool operator !=(ApplicationArtifactName left, ApplicationArtifactName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApplicationArtifactName"/>. </summary>
        public static implicit operator ApplicationArtifactName(string value) => new ApplicationArtifactName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationArtifactName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationArtifactName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
