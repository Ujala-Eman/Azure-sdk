// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents ASC (Azure Security Center) data connector. </summary>
    public partial class SecurityInsightsAscDataConnector : SecurityInsightsDataConnectorData
    {
        /// <summary> Initializes a new instance of <see cref="SecurityInsightsAscDataConnector"/>. </summary>
        public SecurityInsightsAscDataConnector()
        {
            Kind = DataConnectorKind.AzureSecurityCenter;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsAscDataConnector"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The data connector kind. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="dataTypes"> The available data types for the connector. </param>
        /// <param name="subscriptionId"> The subscription id to connect to, and get the data from. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsAscDataConnector(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataConnectorKind kind, ETag? etag, SecurityInsightsAlertsDataTypeOfDataConnector dataTypes, string subscriptionId, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, kind, etag, rawData)
        {
            DataTypes = dataTypes;
            SubscriptionId = subscriptionId;
            Kind = kind;
        }

        /// <summary> The available data types for the connector. </summary>
        internal SecurityInsightsAlertsDataTypeOfDataConnector DataTypes { get; set; }
        /// <summary> Describe whether this data type connection is enabled or not. </summary>
        public SecurityInsightsDataTypeConnectionState? AlertsState
        {
            get => DataTypes is null ? default : DataTypes.AlertsState;
            set
            {
                if (DataTypes is null)
                    DataTypes = new SecurityInsightsAlertsDataTypeOfDataConnector();
                DataTypes.AlertsState = value;
            }
        }

        /// <summary> The subscription id to connect to, and get the data from. </summary>
        public string SubscriptionId { get; set; }
    }
}
