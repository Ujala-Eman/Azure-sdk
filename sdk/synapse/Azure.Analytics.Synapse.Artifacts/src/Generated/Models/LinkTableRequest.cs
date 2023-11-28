// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The LinkTableRequest. </summary>
    public partial class LinkTableRequest
    {
        /// <summary> Initializes a new instance of <see cref="LinkTableRequest"/>. </summary>
        public LinkTableRequest()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LinkTableRequest"/>. </summary>
        /// <param name="id"> Link table id. </param>
        /// <param name="source"> Source table properties for link table request. </param>
        /// <param name="target"> Target table properties for link table request. </param>
        /// <param name="operationType"> Link table operation type. </param>
        internal LinkTableRequest(string id, LinkTableRequestSource source, LinkTableRequestTarget target, string operationType)
        {
            Id = id;
            Source = source;
            Target = target;
            OperationType = operationType;
        }

        /// <summary> Link table id. </summary>
        public string Id { get; set; }
        /// <summary> Source table properties for link table request. </summary>
        public LinkTableRequestSource Source { get; set; }
        /// <summary> Target table properties for link table request. </summary>
        public LinkTableRequestTarget Target { get; set; }
        /// <summary> Link table operation type. </summary>
        public string OperationType { get; set; }
    }
}
