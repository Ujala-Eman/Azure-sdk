// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Configuration object. </summary>
    public partial class ProductConfiguration
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ProductConfiguration"/>. </summary>
        internal ProductConfiguration()
        {
            ImageInformation = new ChangeTrackingList<EdgeOrderProductImageInformation>();
            FilterableProperties = new ChangeTrackingList<FilterableProperty>();
            Specifications = new ChangeTrackingList<ProductSpecification>();
        }

        /// <summary> Initializes a new instance of <see cref="ProductConfiguration"/>. </summary>
        /// <param name="displayName"> Display Name for the product system. </param>
        /// <param name="description"> Description related to the product system. </param>
        /// <param name="imageInformation"> Image information for the product system. </param>
        /// <param name="costInformation"> Cost information for the product system. </param>
        /// <param name="availabilityInformation"> Availability information of the product system. </param>
        /// <param name="hierarchyInformation"> Hierarchy information of a product. </param>
        /// <param name="filterableProperties"> list of filters supported for a product. </param>
        /// <param name="specifications"> Specifications of the configuration. </param>
        /// <param name="dimensions"> Dimensions of the configuration. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ProductConfiguration(string displayName, ProductDescription description, IReadOnlyList<EdgeOrderProductImageInformation> imageInformation, EdgeOrderProductCostInformation costInformation, ProductAvailabilityInformation availabilityInformation, HierarchyInformation hierarchyInformation, IReadOnlyList<FilterableProperty> filterableProperties, IReadOnlyList<ProductSpecification> specifications, ProductDimensions dimensions, Dictionary<string, BinaryData> rawData)
        {
            DisplayName = displayName;
            Description = description;
            ImageInformation = imageInformation;
            CostInformation = costInformation;
            AvailabilityInformation = availabilityInformation;
            HierarchyInformation = hierarchyInformation;
            FilterableProperties = filterableProperties;
            Specifications = specifications;
            Dimensions = dimensions;
            _rawData = rawData;
        }

        /// <summary> Display Name for the product system. </summary>
        public string DisplayName { get; }
        /// <summary> Description related to the product system. </summary>
        public ProductDescription Description { get; }
        /// <summary> Image information for the product system. </summary>
        public IReadOnlyList<EdgeOrderProductImageInformation> ImageInformation { get; }
        /// <summary> Cost information for the product system. </summary>
        public EdgeOrderProductCostInformation CostInformation { get; }
        /// <summary> Availability information of the product system. </summary>
        public ProductAvailabilityInformation AvailabilityInformation { get; }
        /// <summary> Hierarchy information of a product. </summary>
        public HierarchyInformation HierarchyInformation { get; }
        /// <summary> list of filters supported for a product. </summary>
        public IReadOnlyList<FilterableProperty> FilterableProperties { get; }
        /// <summary> Specifications of the configuration. </summary>
        public IReadOnlyList<ProductSpecification> Specifications { get; }
        /// <summary> Dimensions of the configuration. </summary>
        public ProductDimensions Dimensions { get; }
    }
}
