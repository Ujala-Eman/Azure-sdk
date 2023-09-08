// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> On-demand charges between firstConsumptionDate and lastConsumptionDate that were used for computing benefit recommendations. </summary>
    public partial class RecommendationUsageDetails
    {
        /// <summary> Initializes a new instance of RecommendationUsageDetails. </summary>
        public RecommendationUsageDetails()
        {
            Charges = new ChangeTrackingList<decimal>();
        }

        /// <summary> Initializes a new instance of RecommendationUsageDetails. </summary>
        /// <param name="usageGrain"> The grain of the usage. Supported values: 'Hourly'. </param>
        /// <param name="charges"> On-demand charges for each hour between firstConsumptionDate and lastConsumptionDate that were used for computing benefit recommendations. </param>
        internal RecommendationUsageDetails(BenefitRecommendationUsageGrain? usageGrain, IReadOnlyList<decimal> charges)
        {
            UsageGrain = usageGrain;
            Charges = charges;
        }

        /// <summary> The grain of the usage. Supported values: 'Hourly'. </summary>
        public BenefitRecommendationUsageGrain? UsageGrain { get; set; }
        /// <summary> On-demand charges for each hour between firstConsumptionDate and lastConsumptionDate that were used for computing benefit recommendations. </summary>
        public IReadOnlyList<decimal> Charges { get; }
    }
}
