// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    /// <summary> Request parameters for the GetObjectsByObjectIds API. </summary>
    public partial class GetObjectsParameters : IDictionary<string, object>
    {
        /// <summary> Initializes a new instance of GetObjectsParameters. </summary>
        public GetObjectsParameters()
        {
            ObjectIds = new ChangeTrackingList<string>();
            Types = new ChangeTrackingList<string>();
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of GetObjectsParameters. </summary>
        /// <param name="objectIds"> The requested object IDs. </param>
        /// <param name="types"> The requested object types. </param>
        /// <param name="includeDirectoryObjectReferences"> If true, also searches for object IDs in the partner tenant. </param>
        /// <param name="additionalProperties"> . </param>
        internal GetObjectsParameters(IList<string> objectIds, IList<string> types, bool? includeDirectoryObjectReferences, IDictionary<string, object> additionalProperties)
        {
            ObjectIds = objectIds;
            Types = types;
            IncludeDirectoryObjectReferences = includeDirectoryObjectReferences;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The requested object IDs. </summary>
        public IList<string> ObjectIds { get; }
        /// <summary> The requested object types. </summary>
        public IList<string> Types { get; }
        /// <summary> If true, also searches for object IDs in the partner tenant. </summary>
        public bool? IncludeDirectoryObjectReferences { get; set; }
        internal IDictionary<string, object> AdditionalProperties { get; }
        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        public bool TryGetValue(string key, out object value) => AdditionalProperties.TryGetValue(key, out value);
        /// <inheritdoc />
        public bool ContainsKey(string key) => AdditionalProperties.ContainsKey(key);
        /// <inheritdoc />
        public ICollection<string> Keys => AdditionalProperties.Keys;
        /// <inheritdoc />
        public ICollection<object> Values => AdditionalProperties.Values;
        /// <inheritdoc />
        int ICollection<KeyValuePair<string, object>>.Count => AdditionalProperties.Count;
        /// <inheritdoc />
        public void Add(string key, object value) => AdditionalProperties.Add(key, value);
        /// <inheritdoc />
        public bool Remove(string key) => AdditionalProperties.Remove(key);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.IsReadOnly => AdditionalProperties.IsReadOnly;
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> value) => AdditionalProperties.Add(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> value) => AdditionalProperties.Remove(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> value) => AdditionalProperties.Contains(value);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] destination, int offset) => AdditionalProperties.CopyTo(destination, offset);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.Clear() => AdditionalProperties.Clear();
        /// <inheritdoc />
        public object this[string key]
        {
            get => AdditionalProperties[key];
            set => AdditionalProperties[key] = value;
        }
    }
}
