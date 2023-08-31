// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Description related properties of a product system. </summary>
    public partial class ProductDescription
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ProductDescription"/>. </summary>
        internal ProductDescription()
        {
            Keywords = new ChangeTrackingList<string>();
            Attributes = new ChangeTrackingList<string>();
            Links = new ChangeTrackingList<ProductLink>();
        }

        /// <summary> Initializes a new instance of <see cref="ProductDescription"/>. </summary>
        /// <param name="descriptionType"> Type of description. </param>
        /// <param name="shortDescription"> Short description of the product system. </param>
        /// <param name="longDescription"> Long description of the product system. </param>
        /// <param name="keywords"> Keywords for the product system. </param>
        /// <param name="attributes"> Attributes for the product system. </param>
        /// <param name="links"> Links for the product system. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ProductDescription(ProductDescriptionType? descriptionType, string shortDescription, string longDescription, IReadOnlyList<string> keywords, IReadOnlyList<string> attributes, IReadOnlyList<ProductLink> links, Dictionary<string, BinaryData> rawData)
        {
            DescriptionType = descriptionType;
            ShortDescription = shortDescription;
            LongDescription = longDescription;
            Keywords = keywords;
            Attributes = attributes;
            Links = links;
            _rawData = rawData;
        }

        /// <summary> Type of description. </summary>
        public ProductDescriptionType? DescriptionType { get; }
        /// <summary> Short description of the product system. </summary>
        public string ShortDescription { get; }
        /// <summary> Long description of the product system. </summary>
        public string LongDescription { get; }
        /// <summary> Keywords for the product system. </summary>
        public IReadOnlyList<string> Keywords { get; }
        /// <summary> Attributes for the product system. </summary>
        public IReadOnlyList<string> Attributes { get; }
        /// <summary> Links for the product system. </summary>
        public IReadOnlyList<ProductLink> Links { get; }
    }
}
