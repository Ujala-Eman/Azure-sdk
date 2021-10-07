// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Communication.Models
{
    /// <summary> Data POST-ed to the nameAvailability action. </summary>
    public partial class NameAvailabilityParameters
    {
        /// <summary> Initializes a new instance of NameAvailabilityParameters. </summary>
        /// <param name="type"> The resource type. Should be always &quot;Microsoft.Communication/CommunicationServices&quot;. </param>
        /// <param name="name"> The CommunicationService name to validate. e.g.&quot;my-CommunicationService-name-here&quot;. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="type"/> or <paramref name="name"/> is null. </exception>
        public NameAvailabilityParameters(string type, string name)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Type = type;
            Name = name;
        }

        /// <summary> The resource type. Should be always &quot;Microsoft.Communication/CommunicationServices&quot;. </summary>
        public string Type { get; }
        /// <summary> The CommunicationService name to validate. e.g.&quot;my-CommunicationService-name-here&quot;. </summary>
        public string Name { get; }
    }
}
