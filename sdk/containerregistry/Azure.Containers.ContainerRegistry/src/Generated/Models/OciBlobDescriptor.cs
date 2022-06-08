// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.Specialized
{
    /// <summary> Docker V2 image layer descriptor including config and layers. </summary>
    public partial class OciBlobDescriptor
    {
        /// <summary> Initializes a new instance of <see cref="OciBlobDescriptor"/>. </summary>
        public OciBlobDescriptor()
        {
            Urls = new ChangeTrackingList<Uri>();
        }

        /// <summary> Initializes a new instance of <see cref="OciBlobDescriptor"/>. </summary>
        /// <param name="mediaType"> Layer media type. </param>
        /// <param name="size"> Layer size. </param>
        /// <param name="digest"> Layer digest. </param>
        /// <param name="urls"> Specifies a list of URIs from which this object may be downloaded. </param>
        /// <param name="annotations"> Additional information provided through arbitrary metadata. </param>
        internal OciBlobDescriptor(string mediaType, long? size, string digest, IList<Uri> urls, OciAnnotations annotations)
        {
            MediaType = mediaType;
            Size = size;
            Digest = digest;
            Urls = urls;
            Annotations = annotations;
        }
    }
}
