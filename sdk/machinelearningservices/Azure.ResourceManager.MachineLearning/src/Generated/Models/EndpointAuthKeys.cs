// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Keys for endpoint authentication. </summary>
    public partial class EndpointAuthKeys
    {
        /// <summary> Initializes a new instance of <see cref="EndpointAuthKeys"/>. </summary>
        public EndpointAuthKeys()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EndpointAuthKeys"/>. </summary>
        /// <param name="primaryKey"> The primary key. </param>
        /// <param name="secondaryKey"> The secondary key. </param>
        internal EndpointAuthKeys(string primaryKey, string secondaryKey)
        {
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
        }

        /// <summary> The primary key. </summary>
        public string PrimaryKey { get; set; }
        /// <summary> The secondary key. </summary>
        public string SecondaryKey { get; set; }
    }
}
