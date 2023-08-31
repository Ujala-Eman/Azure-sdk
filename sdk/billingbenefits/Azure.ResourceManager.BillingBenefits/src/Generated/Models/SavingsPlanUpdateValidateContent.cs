// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    /// <summary> The SavingsPlanUpdateValidateContent. </summary>
    public partial class SavingsPlanUpdateValidateContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SavingsPlanUpdateValidateContent"/>. </summary>
        public SavingsPlanUpdateValidateContent()
        {
            Benefits = new ChangeTrackingList<BillingBenefitsSavingsPlanPatchProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="SavingsPlanUpdateValidateContent"/>. </summary>
        /// <param name="benefits"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SavingsPlanUpdateValidateContent(IList<BillingBenefitsSavingsPlanPatchProperties> benefits, Dictionary<string, BinaryData> rawData)
        {
            Benefits = benefits;
            _rawData = rawData;
        }

        /// <summary> Gets the benefits. </summary>
        public IList<BillingBenefitsSavingsPlanPatchProperties> Benefits { get; }
    }
}
