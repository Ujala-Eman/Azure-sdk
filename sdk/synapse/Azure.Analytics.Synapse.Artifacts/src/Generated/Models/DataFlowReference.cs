// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Data flow reference type. </summary>
    public partial class DataFlowReference : IDictionary<string, object>
    {
        /// <summary> Initializes a new instance of DataFlowReference. </summary>
        /// <param name="referenceName"> Reference data flow name. </param>
        public DataFlowReference(string referenceName)
        {
            if (referenceName == null)
            {
                throw new ArgumentNullException(nameof(referenceName));
            }

            Type = "DataFlowReference";
            ReferenceName = referenceName;
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of DataFlowReference. </summary>
        /// <param name="type"> Data flow reference type. </param>
        /// <param name="referenceName"> Reference data flow name. </param>
        /// <param name="datasetParameters"> Reference data flow parameters from dataset. </param>
        /// <param name="additionalProperties"> . </param>
        internal DataFlowReference(string type, string referenceName, object datasetParameters, IDictionary<string, object> additionalProperties)
        {
            Type = type;
            ReferenceName = referenceName;
            DatasetParameters = datasetParameters;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Data flow reference type. </summary>
        public string Type { get; set; }
        /// <summary> Reference data flow name. </summary>
        public string ReferenceName { get; set; }
        /// <summary> Reference data flow parameters from dataset. </summary>
        public object DatasetParameters { get; set; }
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
