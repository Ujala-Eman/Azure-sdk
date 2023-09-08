// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Consumption.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption
{
    /// <summary>
    /// A class representing the ConsumptionBudget data model.
    /// A budget resource.
    /// </summary>
    public partial class ConsumptionBudgetData : ResourceData
    {
        /// <summary> Initializes a new instance of ConsumptionBudgetData. </summary>
        public ConsumptionBudgetData()
        {
            Notifications = new ChangeTrackingDictionary<string, BudgetAssociatedNotification>();
        }

        /// <summary> Initializes a new instance of ConsumptionBudgetData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="category"> The category of the budget, whether the budget tracks cost or usage. </param>
        /// <param name="amount"> The total amount of cost to track with the budget. </param>
        /// <param name="timeGrain"> The time covered by a budget. Tracking of the amount will be reset based on the time grain. BillingMonth, BillingQuarter, and BillingAnnual are only supported by WD customers. </param>
        /// <param name="timePeriod"> Has start and end date of the budget. The start date must be first of the month and should be less than the end date. Budget start date must be on or after June 1, 2017. Future start date should not be more than twelve months. Past start date should  be selected within the timegrain period. There are no restrictions on the end date. </param>
        /// <param name="filter"> May be used to filter budgets by user-specified dimensions and/or tags. </param>
        /// <param name="currentSpend"> The current amount of cost which is being tracked for a budget. </param>
        /// <param name="notifications"> Dictionary of notifications associated with the budget. Budget can have up to five notifications. </param>
        /// <param name="forecastSpend"> The forecasted cost which is being tracked for a budget. </param>
        /// <param name="etag"> eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not. </param>
        internal ConsumptionBudgetData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, BudgetCategory? category, decimal? amount, BudgetTimeGrainType? timeGrain, BudgetTimePeriod timePeriod, ConsumptionBudgetFilter filter, BudgetCurrentSpend currentSpend, IDictionary<string, BudgetAssociatedNotification> notifications, BudgetForecastSpend forecastSpend, ETag? etag) : base(id, name, resourceType, systemData)
        {
            Category = category;
            Amount = amount;
            TimeGrain = timeGrain;
            TimePeriod = timePeriod;
            Filter = filter;
            CurrentSpend = currentSpend;
            Notifications = notifications;
            ForecastSpend = forecastSpend;
            ETag = etag;
        }

        /// <summary> The category of the budget, whether the budget tracks cost or usage. </summary>
        public BudgetCategory? Category { get; set; }
        /// <summary> The total amount of cost to track with the budget. </summary>
        public decimal? Amount { get; set; }
        /// <summary> The time covered by a budget. Tracking of the amount will be reset based on the time grain. BillingMonth, BillingQuarter, and BillingAnnual are only supported by WD customers. </summary>
        public BudgetTimeGrainType? TimeGrain { get; set; }
        /// <summary> Has start and end date of the budget. The start date must be first of the month and should be less than the end date. Budget start date must be on or after June 1, 2017. Future start date should not be more than twelve months. Past start date should  be selected within the timegrain period. There are no restrictions on the end date. </summary>
        public BudgetTimePeriod TimePeriod { get; set; }
        /// <summary> May be used to filter budgets by user-specified dimensions and/or tags. </summary>
        public ConsumptionBudgetFilter Filter { get; set; }
        /// <summary> The current amount of cost which is being tracked for a budget. </summary>
        public BudgetCurrentSpend CurrentSpend { get; }
        /// <summary> Dictionary of notifications associated with the budget. Budget can have up to five notifications. </summary>
        public IDictionary<string, BudgetAssociatedNotification> Notifications { get; }
        /// <summary> The forecasted cost which is being tracked for a budget. </summary>
        public BudgetForecastSpend ForecastSpend { get; }
        /// <summary> eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not. </summary>
        public ETag? ETag { get; set; }
    }
}
