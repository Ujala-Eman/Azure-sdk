// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Used for establishing the purchase context of any 3rd Party artifact through MarketPlace. </summary>
    public partial class DiskPurchasePlan
    {
        /// <summary> Initializes a new instance of <see cref="DiskPurchasePlan"/>. </summary>
        /// <param name="name"> The plan ID. </param>
        /// <param name="publisher"> The publisher ID. </param>
        /// <param name="product"> Specifies the product of the image from the marketplace. This is the same value as Offer under the imageReference element. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="publisher"/> or <paramref name="product"/> is null. </exception>
        public DiskPurchasePlan(string name, string publisher, string product)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (publisher == null)
            {
                throw new ArgumentNullException(nameof(publisher));
            }
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            Name = name;
            Publisher = publisher;
            Product = product;
        }

        /// <summary> Initializes a new instance of <see cref="DiskPurchasePlan"/>. </summary>
        /// <param name="name"> The plan ID. </param>
        /// <param name="publisher"> The publisher ID. </param>
        /// <param name="product"> Specifies the product of the image from the marketplace. This is the same value as Offer under the imageReference element. </param>
        /// <param name="promotionCode"> The Offer Promotion Code. </param>
        internal DiskPurchasePlan(string name, string publisher, string product, string promotionCode)
        {
            Name = name;
            Publisher = publisher;
            Product = product;
            PromotionCode = promotionCode;
        }

        /// <summary> The plan ID. </summary>
        public string Name { get; set; }
        /// <summary> The publisher ID. </summary>
        public string Publisher { get; set; }
        /// <summary> Specifies the product of the image from the marketplace. This is the same value as Offer under the imageReference element. </summary>
        public string Product { get; set; }
        /// <summary> The Offer Promotion Code. </summary>
        public string PromotionCode { get; set; }
    }
}
