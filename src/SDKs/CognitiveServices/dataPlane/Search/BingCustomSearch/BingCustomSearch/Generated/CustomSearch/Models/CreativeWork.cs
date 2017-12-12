// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Search.CustomSearch.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class CreativeWork : Thing
    {
        /// <summary>
        /// Initializes a new instance of the CreativeWork class.
        /// </summary>
        public CreativeWork()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreativeWork class.
        /// </summary>
        /// <param name="id">A String identifier.</param>
        /// <param name="webSearchUrl">The URL To Bing's search result for this
        /// item.</param>
        /// <param name="name">The name of the thing represented by this
        /// object.</param>
        /// <param name="url">The URL to get more information about the thing
        /// represented by this object.</param>
        /// <param name="description">A short description of the item.</param>
        /// <param name="bingId">An ID that uniquely identifies this
        /// item.</param>
        /// <param name="thumbnailUrl">The URL to a thumbnail of the
        /// item.</param>
        /// <param name="provider">The source of the creative work.</param>
        public CreativeWork(string id = default(string), string webSearchUrl = default(string), string name = default(string), string url = default(string), string description = default(string), string bingId = default(string), string thumbnailUrl = default(string), IList<Thing> provider = default(IList<Thing>), string text = default(string))
            : base(id, webSearchUrl, name, url, description, bingId)
        {
            ThumbnailUrl = thumbnailUrl;
            Provider = provider;
            Text = text;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the URL to a thumbnail of the item.
        /// </summary>
        [JsonProperty(PropertyName = "thumbnailUrl")]
        public string ThumbnailUrl { get; private set; }

        /// <summary>
        /// Gets the source of the creative work.
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public IList<Thing> Provider { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; private set; }

    }
}
