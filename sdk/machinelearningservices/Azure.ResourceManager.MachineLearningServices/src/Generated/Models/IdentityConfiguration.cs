// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> Base definition for identity configuration. </summary>
    public partial class IdentityConfiguration
    {
        /// <summary> Initializes a new instance of IdentityConfiguration. </summary>
        public IdentityConfiguration()
        {
        }

        /// <summary> Initializes a new instance of IdentityConfiguration. </summary>
        /// <param name="identityType"> Specifies the type of identity framework. </param>
        internal IdentityConfiguration(IdentityConfigurationType identityType)
        {
            IdentityType = identityType;
        }

        /// <summary> Specifies the type of identity framework. </summary>
        internal IdentityConfigurationType IdentityType { get; set; }
    }
}
