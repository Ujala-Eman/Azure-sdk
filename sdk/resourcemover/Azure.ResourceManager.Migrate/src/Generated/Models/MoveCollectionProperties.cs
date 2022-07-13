// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Defines the move collection properties. </summary>
    public partial class MoveCollectionProperties
    {
        /// <summary> Initializes a new instance of MoveCollectionProperties. </summary>
        /// <param name="sourceRegion"> Gets or sets the source region. </param>
        /// <param name="targetRegion"> Gets or sets the target region. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceRegion"/> or <paramref name="targetRegion"/> is null. </exception>
        public MoveCollectionProperties(string sourceRegion, string targetRegion)
        {
            if (sourceRegion == null)
            {
                throw new ArgumentNullException(nameof(sourceRegion));
            }
            if (targetRegion == null)
            {
                throw new ArgumentNullException(nameof(targetRegion));
            }

            SourceRegion = sourceRegion;
            TargetRegion = targetRegion;
        }

        /// <summary> Initializes a new instance of MoveCollectionProperties. </summary>
        /// <param name="sourceRegion"> Gets or sets the source region. </param>
        /// <param name="targetRegion"> Gets or sets the target region. </param>
        /// <param name="provisioningState"> Defines the provisioning states. </param>
        /// <param name="errors"> Defines the move collection errors. </param>
        internal MoveCollectionProperties(string sourceRegion, string targetRegion, ProvisioningState? provisioningState, MoveCollectionPropertiesErrors errors)
        {
            SourceRegion = sourceRegion;
            TargetRegion = targetRegion;
            ProvisioningState = provisioningState;
            Errors = errors;
        }

        /// <summary> Gets or sets the source region. </summary>
        public string SourceRegion { get; set; }
        /// <summary> Gets or sets the target region. </summary>
        public string TargetRegion { get; set; }
        /// <summary> Defines the provisioning states. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Defines the move collection errors. </summary>
        internal MoveCollectionPropertiesErrors Errors { get; }
        /// <summary> The move resource error body. </summary>
        public ResponseError ErrorsProperties
        {
            get => Errors?.Properties;
        }
    }
}
