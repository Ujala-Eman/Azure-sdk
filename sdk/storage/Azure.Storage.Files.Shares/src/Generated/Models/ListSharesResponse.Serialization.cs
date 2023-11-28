// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Azure.Storage.Files.Shares.Models
{
    internal partial class ListSharesResponse
    {
        internal static ListSharesResponse DeserializeListSharesResponse(XElement element, ModelReaderWriterOptions options = null)
        {
            string serviceEndpoint = default;
            string prefix = default;
            string marker = default;
            int? maxResults = default;
            string nextMarker = default;
            IReadOnlyList<ShareItemInternal> shareItems = default;
            if (element.Attribute("ServiceEndpoint") is XAttribute serviceEndpointAttribute)
            {
                serviceEndpoint = (string)serviceEndpointAttribute;
            }
            if (element.Element("Prefix") is XElement prefixElement)
            {
                prefix = (string)prefixElement;
            }
            if (element.Element("Marker") is XElement markerElement)
            {
                marker = (string)markerElement;
            }
            if (element.Element("MaxResults") is XElement maxResultsElement)
            {
                maxResults = (int?)maxResultsElement;
            }
            if (element.Element("NextMarker") is XElement nextMarkerElement)
            {
                nextMarker = (string)nextMarkerElement;
            }
            if (element.Element("Shares") is XElement sharesElement)
            {
                var array = new List<ShareItemInternal>();
                foreach (var e in sharesElement.Elements("Share"))
                {
                    array.Add(ShareItemInternal.DeserializeShareItemInternal(e));
                }
                shareItems = array;
            }
            return new ListSharesResponse(serviceEndpoint, prefix, marker, maxResults, shareItems, nextMarker);
        }
    }
}
