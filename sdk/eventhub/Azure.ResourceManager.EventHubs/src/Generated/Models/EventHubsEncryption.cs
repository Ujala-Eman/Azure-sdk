// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Properties to configure Encryption. </summary>
    public partial class EventHubsEncryption
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EventHubsEncryption"/>. </summary>
        public EventHubsEncryption()
        {
            KeyVaultProperties = new ChangeTrackingList<EventHubsKeyVaultProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="EventHubsEncryption"/>. </summary>
        /// <param name="keyVaultProperties"> Properties of KeyVault. </param>
        /// <param name="keySource"> Enumerates the possible value of keySource for Encryption. </param>
        /// <param name="requireInfrastructureEncryption"> Enable Infrastructure Encryption (Double Encryption). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EventHubsEncryption(IList<EventHubsKeyVaultProperties> keyVaultProperties, EventHubsKeySource? keySource, bool? requireInfrastructureEncryption, Dictionary<string, BinaryData> rawData)
        {
            KeyVaultProperties = keyVaultProperties;
            KeySource = keySource;
            RequireInfrastructureEncryption = requireInfrastructureEncryption;
            _rawData = rawData;
        }

        /// <summary> Properties of KeyVault. </summary>
        public IList<EventHubsKeyVaultProperties> KeyVaultProperties { get; }
        /// <summary> Enumerates the possible value of keySource for Encryption. </summary>
        public EventHubsKeySource? KeySource { get; set; }
        /// <summary> Enable Infrastructure Encryption (Double Encryption). </summary>
        public bool? RequireInfrastructureEncryption { get; set; }
    }
}
