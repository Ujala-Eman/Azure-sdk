// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.BillingBenefits;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    /// <summary> The SavingsPlanPurchaseValidateContent. </summary>
    public partial class SavingsPlanPurchaseValidateContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SavingsPlanPurchaseValidateContent"/>. </summary>
        public SavingsPlanPurchaseValidateContent()
        {
            Benefits = new ChangeTrackingList<BillingBenefitsSavingsPlanOrderAliasData>();
        }

        /// <summary> Initializes a new instance of <see cref="SavingsPlanPurchaseValidateContent"/>. </summary>
        /// <param name="benefits"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SavingsPlanPurchaseValidateContent(IList<BillingBenefitsSavingsPlanOrderAliasData> benefits, Dictionary<string, BinaryData> rawData)
        {
            Benefits = benefits;
            _rawData = rawData;
        }

        /// <summary> Gets the benefits. </summary>
        public IList<BillingBenefitsSavingsPlanOrderAliasData> Benefits { get; }
    }
}
