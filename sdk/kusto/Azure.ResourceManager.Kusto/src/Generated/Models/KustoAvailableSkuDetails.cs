// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> Azure resource SKU definition. </summary>
    public partial class KustoAvailableSkuDetails
    {
        /// <summary> Initializes a new instance of KustoAvailableSkuDetails. </summary>
        internal KustoAvailableSkuDetails()
        {
        }

        /// <summary> Initializes a new instance of KustoAvailableSkuDetails. </summary>
        /// <param name="resourceType"> Resource Namespace and Type. </param>
        /// <param name="sku"> The SKU details. </param>
        /// <param name="capacity"> The number of instances of the cluster. </param>
        internal KustoAvailableSkuDetails(string resourceType, KustoSku sku, KustoCapacity capacity)
        {
            ResourceType = resourceType;
            Sku = sku;
            Capacity = capacity;
        }

        /// <summary> Resource Namespace and Type. </summary>
        public string ResourceType { get; }
        /// <summary> The SKU details. </summary>
        public KustoSku Sku { get; }
        /// <summary> The number of instances of the cluster. </summary>
        public KustoCapacity Capacity { get; }
    }
}
