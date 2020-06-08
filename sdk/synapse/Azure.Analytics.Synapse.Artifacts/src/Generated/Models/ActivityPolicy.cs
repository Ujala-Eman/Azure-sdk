// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Execution policy for an activity. </summary>
    public partial class ActivityPolicy : IDictionary<string, object>
    {
        /// <summary> Initializes a new instance of ActivityPolicy. </summary>
        public ActivityPolicy()
        {
            AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary> Initializes a new instance of ActivityPolicy. </summary>
        /// <param name="timeout"> Specifies the timeout for the activity to run. The default timeout is 7 days. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="retry"> Maximum ordinary retry attempts. Default is 0. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="retryIntervalInSeconds"> Interval between each retry attempt (in seconds). The default is 30 sec. </param>
        /// <param name="secureInput"> When set to true, Input from activity is considered as secure and will not be logged to monitoring. </param>
        /// <param name="secureOutput"> When set to true, Output from activity is considered as secure and will not be logged to monitoring. </param>
        /// <param name="additionalProperties"> . </param>
        internal ActivityPolicy(object timeout, object retry, int? retryIntervalInSeconds, bool? secureInput, bool? secureOutput, IDictionary<string, object> additionalProperties)
        {
            Timeout = timeout;
            Retry = retry;
            RetryIntervalInSeconds = retryIntervalInSeconds;
            SecureInput = secureInput;
            SecureOutput = secureOutput;
            AdditionalProperties = additionalProperties ?? new Dictionary<string, object>();
        }

        /// <summary> Specifies the timeout for the activity to run. The default timeout is 7 days. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </summary>
        public object Timeout { get; set; }
        /// <summary> Maximum ordinary retry attempts. Default is 0. Type: integer (or Expression with resultType integer), minimum: 0. </summary>
        public object Retry { get; set; }
        /// <summary> Interval between each retry attempt (in seconds). The default is 30 sec. </summary>
        public int? RetryIntervalInSeconds { get; set; }
        /// <summary> When set to true, Input from activity is considered as secure and will not be logged to monitoring. </summary>
        public bool? SecureInput { get; set; }
        /// <summary> When set to true, Output from activity is considered as secure and will not be logged to monitoring. </summary>
        public bool? SecureOutput { get; set; }
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
