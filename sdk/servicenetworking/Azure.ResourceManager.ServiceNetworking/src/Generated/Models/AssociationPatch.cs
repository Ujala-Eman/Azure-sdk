// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ServiceNetworking.Models
{
    /// <summary> The type used for update operations of the Association. </summary>
    public partial class AssociationPatch
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AssociationPatch"/>. </summary>
        public AssociationPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="AssociationPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="associationType"> Association Type. </param>
        /// <param name="subnet"> Association Subnet. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AssociationPatch(IDictionary<string, string> tags, AssociationType? associationType, WritableSubResource subnet, Dictionary<string, BinaryData> rawData)
        {
            Tags = tags;
            AssociationType = associationType;
            Subnet = subnet;
            _rawData = rawData;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Association Type. </summary>
        public AssociationType? AssociationType { get; set; }
        /// <summary> Association Subnet. </summary>
        internal WritableSubResource Subnet { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SubnetId
        {
            get => Subnet is null ? default : Subnet.Id;
            set
            {
                if (Subnet is null)
                    Subnet = new WritableSubResource();
                Subnet.Id = value;
            }
        }
    }
}
