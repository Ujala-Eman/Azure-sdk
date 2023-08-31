// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Security Settings of the vault. </summary>
    internal partial class SecuritySettings
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SecuritySettings"/>. </summary>
        public SecuritySettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecuritySettings"/>. </summary>
        /// <param name="immutabilitySettings"> Immutability Settings of a vault. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SecuritySettings(ImmutabilitySettings immutabilitySettings, Dictionary<string, BinaryData> rawData)
        {
            ImmutabilitySettings = immutabilitySettings;
            _rawData = rawData;
        }

        /// <summary> Immutability Settings of a vault. </summary>
        internal ImmutabilitySettings ImmutabilitySettings { get; set; }
        /// <summary> Gets or sets the immutability state. </summary>
        public ImmutabilityState? ImmutabilityState
        {
            get => ImmutabilitySettings is null ? default : ImmutabilitySettings.State;
            set
            {
                if (ImmutabilitySettings is null)
                    ImmutabilitySettings = new ImmutabilitySettings();
                ImmutabilitySettings.State = value;
            }
        }
    }
}
