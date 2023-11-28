// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Transfer offers properties. </summary>
    public partial class TransferOffersContent
    {
        /// <summary> Initializes a new instance of <see cref="TransferOffersContent"/>. </summary>
        public TransferOffersContent()
        {
            TargetCollections = new ChangeTrackingList<string>();
            OfferIdsList = new ChangeTrackingList<string>();
        }

        /// <summary> Target collections ids. </summary>
        public IList<string> TargetCollections { get; }
        /// <summary> Operation to perform (For example: Copy or Move). </summary>
        public string Operation { get; set; }
        /// <summary> Offers ids list to transfer from source collection to target collection(s). </summary>
        public IList<string> OfferIdsList { get; }
    }
}
