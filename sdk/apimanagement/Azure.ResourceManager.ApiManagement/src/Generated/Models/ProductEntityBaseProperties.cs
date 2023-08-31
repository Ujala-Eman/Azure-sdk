// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Product Entity Base Parameters. </summary>
    public partial class ProductEntityBaseProperties
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ProductEntityBaseProperties"/>. </summary>
        internal ProductEntityBaseProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProductEntityBaseProperties"/>. </summary>
        /// <param name="description"> Product description. May include HTML formatting tags. </param>
        /// <param name="terms"> Product terms of use. Developers trying to subscribe to the product will be presented and required to accept these terms before they can complete the subscription process. </param>
        /// <param name="isSubscriptionRequired"> Whether a product subscription is required for accessing APIs included in this product. If true, the product is referred to as "protected" and a valid subscription key is required for a request to an API included in the product to succeed. If false, the product is referred to as "open" and requests to an API included in the product can be made without a subscription key. If property is omitted when creating a new product it's value is assumed to be true. </param>
        /// <param name="isApprovalRequired"> whether subscription approval is required. If false, new subscriptions will be approved automatically enabling developers to call the product’s APIs immediately after subscribing. If true, administrators must manually approve the subscription before the developer can any of the product’s APIs. Can be present only if subscriptionRequired property is present and has a value of false. </param>
        /// <param name="subscriptionsLimit"> Whether the number of subscriptions a user can have to this product at the same time. Set to null or omit to allow unlimited per user subscriptions. Can be present only if subscriptionRequired property is present and has a value of false. </param>
        /// <param name="state"> whether product is published or not. Published products are discoverable by users of developer portal. Non published products are visible only to administrators. Default state of Product is notPublished. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ProductEntityBaseProperties(string description, string terms, bool? isSubscriptionRequired, bool? isApprovalRequired, int? subscriptionsLimit, ApiManagementProductState? state, Dictionary<string, BinaryData> rawData)
        {
            Description = description;
            Terms = terms;
            IsSubscriptionRequired = isSubscriptionRequired;
            IsApprovalRequired = isApprovalRequired;
            SubscriptionsLimit = subscriptionsLimit;
            State = state;
            _rawData = rawData;
        }

        /// <summary> Product description. May include HTML formatting tags. </summary>
        public string Description { get; }
        /// <summary> Product terms of use. Developers trying to subscribe to the product will be presented and required to accept these terms before they can complete the subscription process. </summary>
        public string Terms { get; }
        /// <summary> Whether a product subscription is required for accessing APIs included in this product. If true, the product is referred to as "protected" and a valid subscription key is required for a request to an API included in the product to succeed. If false, the product is referred to as "open" and requests to an API included in the product can be made without a subscription key. If property is omitted when creating a new product it's value is assumed to be true. </summary>
        public bool? IsSubscriptionRequired { get; }
        /// <summary> whether subscription approval is required. If false, new subscriptions will be approved automatically enabling developers to call the product’s APIs immediately after subscribing. If true, administrators must manually approve the subscription before the developer can any of the product’s APIs. Can be present only if subscriptionRequired property is present and has a value of false. </summary>
        public bool? IsApprovalRequired { get; }
        /// <summary> Whether the number of subscriptions a user can have to this product at the same time. Set to null or omit to allow unlimited per user subscriptions. Can be present only if subscriptionRequired property is present and has a value of false. </summary>
        public int? SubscriptionsLimit { get; }
        /// <summary> whether product is published or not. Published products are discoverable by users of developer portal. Non published products are visible only to administrators. Default state of Product is notPublished. </summary>
        public ApiManagementProductState? State { get; }
    }
}
