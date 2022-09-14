// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents OfficeATP (Office 365 Advanced Threat Protection) data connector. </summary>
    public partial class OfficeATPDataConnector : DataConnectorData
    {
        /// <summary> Initializes a new instance of OfficeATPDataConnector. </summary>
        public OfficeATPDataConnector()
        {
            Kind = DataConnectorKind.OfficeATP;
        }

        /// <summary> Initializes a new instance of OfficeATPDataConnector. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The data connector kind. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="tenantId"> The tenant id to connect to, and get the data from. </param>
        /// <param name="alerts"> Alerts data type connection. </param>
        internal OfficeATPDataConnector(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataConnectorKind kind, ETag? etag, Guid? tenantId, DataConnectorDataTypeCommon alerts) : base(id, name, resourceType, systemData, kind, etag)
        {
            TenantId = tenantId;
            Alerts = alerts;
            Kind = kind;
        }

        /// <summary> The tenant id to connect to, and get the data from. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> Alerts data type connection. </summary>
        internal DataConnectorDataTypeCommon Alerts { get; set; }
        /// <summary> Describe whether this data type connection is enabled or not. </summary>
        public DataTypeState? AlertsState
        {
            get => Alerts is null ? default(DataTypeState?) : Alerts.State;
            set
            {
                Alerts = value.HasValue ? new DataConnectorDataTypeCommon(value.Value) : null;
            }
        }
    }
}
