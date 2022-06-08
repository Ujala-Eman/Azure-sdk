// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Monitor.Query.Models
{
    /// <summary> Application Insights apps that were part of the metadata request and that the user has access to. </summary>
    internal partial class MetadataApplication
    {
        /// <summary> Initializes a new instance of <see cref="MetadataApplication"/>. </summary>
        /// <param name="id"> The ID of the Application Insights app. </param>
        /// <param name="resourceId"> The ARM resource ID of the Application Insights app. </param>
        /// <param name="name"> The name of the Application Insights app. </param>
        /// <param name="region"> The Azure region of the Application Insights app. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="resourceId"/>, <paramref name="name"/> or <paramref name="region"/> is null. </exception>
        internal MetadataApplication(string id, string resourceId, string name, string region)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (resourceId == null)
            {
                throw new ArgumentNullException(nameof(resourceId));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (region == null)
            {
                throw new ArgumentNullException(nameof(region));
            }

            Id = id;
            ResourceId = resourceId;
            Name = name;
            Region = region;
        }

        /// <summary> The ID of the Application Insights app. </summary>
        public string Id { get; }
        /// <summary> The ARM resource ID of the Application Insights app. </summary>
        public string ResourceId { get; }
        /// <summary> The name of the Application Insights app. </summary>
        public string Name { get; }
        /// <summary> The Azure region of the Application Insights app. </summary>
        public string Region { get; }
        /// <summary> The related metadata items for the Application Insights app. </summary>
        public MetadataApplicationRelated Related { get; }
    }
}
