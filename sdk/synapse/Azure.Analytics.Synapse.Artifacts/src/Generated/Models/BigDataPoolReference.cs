// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Big data pool reference. </summary>
    public partial class BigDataPoolReference
    {
        /// <summary> Initializes a new instance of BigDataPoolReference. </summary>
        /// <param name="type"> Big data pool reference type. </param>
        /// <param name="referenceName"> Reference big data pool name. </param>
        public BigDataPoolReference(BigDataPoolReferenceType type, string referenceName)
        {
            if (referenceName == null)
            {
                throw new ArgumentNullException(nameof(referenceName));
            }

            Type = type;
            ReferenceName = referenceName;
        }

        /// <summary> Big data pool reference type. </summary>
        public BigDataPoolReferenceType Type { get; set; }
        /// <summary> Reference big data pool name. </summary>
        public string ReferenceName { get; set; }
    }
}
