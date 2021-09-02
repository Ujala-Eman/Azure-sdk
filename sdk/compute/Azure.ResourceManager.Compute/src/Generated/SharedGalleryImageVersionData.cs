// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing the SharedGalleryImageVersion data model. </summary>
    public partial class SharedGalleryImageVersionData : PirSharedGalleryResource
    {
        /// <summary> Initializes a new instance of SharedGalleryImageVersionData. </summary>
        internal SharedGalleryImageVersionData()
        {
        }

        /// <summary> Initializes a new instance of SharedGalleryImageVersionData. </summary>
        /// <param name="name"> Resource name. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="uniqueId"> The unique id of this shared gallery. </param>
        /// <param name="publishedDate"> The published date of the gallery image version Definition. This property can be used for decommissioning purposes. This property is updatable. </param>
        /// <param name="endOfLifeDate"> The end of life date of the gallery image version Definition. This property can be used for decommissioning purposes. This property is updatable. </param>
        internal SharedGalleryImageVersionData(string name, string location, string uniqueId, DateTimeOffset? publishedDate, DateTimeOffset? endOfLifeDate) : base(name, location, uniqueId)
        {
            PublishedDate = publishedDate;
            EndOfLifeDate = endOfLifeDate;
        }

        /// <summary> The published date of the gallery image version Definition. This property can be used for decommissioning purposes. This property is updatable. </summary>
        public DateTimeOffset? PublishedDate { get; }
        /// <summary> The end of life date of the gallery image version Definition. This property can be used for decommissioning purposes. This property is updatable. </summary>
        public DateTimeOffset? EndOfLifeDate { get; }
    }
}
