// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    /// <summary> Specifies the set of OAuth 2.0 permission scopes and app roles under the specified resource that an application requires access to. The specified OAuth 2.0 permission scopes may be requested by client applications (through the requiredResourceAccess collection) when calling a resource application. The requiredResourceAccess property of the Application entity is a collection of RequiredResourceAccess. </summary>
    public partial class RequiredResourceAccess : IDictionary<string, object>
    {
        /// <summary> Initializes a new instance of RequiredResourceAccess. </summary>
        /// <param name="resourceAccess"> The list of OAuth2.0 permission scopes and app roles that the application requires from the specified resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceAccess"/> is null. </exception>
        public RequiredResourceAccess(IEnumerable<ResourceAccess> resourceAccess)
        {
            if (resourceAccess == null)
            {
                throw new ArgumentNullException(nameof(resourceAccess));
            }

            ResourceAccess = resourceAccess.ToList();
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of RequiredResourceAccess. </summary>
        /// <param name="resourceAccess"> The list of OAuth2.0 permission scopes and app roles that the application requires from the specified resource. </param>
        /// <param name="resourceAppId"> The unique identifier for the resource that the application requires access to. This should be equal to the appId declared on the target resource application. </param>
        /// <param name="additionalProperties"> . </param>
        internal RequiredResourceAccess(IList<ResourceAccess> resourceAccess, string resourceAppId, IDictionary<string, object> additionalProperties)
        {
            ResourceAccess = resourceAccess;
            ResourceAppId = resourceAppId;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The list of OAuth2.0 permission scopes and app roles that the application requires from the specified resource. </summary>
        public IList<ResourceAccess> ResourceAccess { get; }
        /// <summary> The unique identifier for the resource that the application requires access to. This should be equal to the appId declared on the target resource application. </summary>
        public string ResourceAppId { get; set; }
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
        /// <inheritdoc cref="ICollection{T}.Count"/>
        int ICollection<KeyValuePair<string, object>>.Count => AdditionalProperties.Count;
        /// <inheritdoc />
        public void Add(string key, object value) => AdditionalProperties.Add(key, value);
        /// <inheritdoc />
        public bool Remove(string key) => AdditionalProperties.Remove(key);
        /// <inheritdoc cref="ICollection{T}.IsReadOnly"/>
        bool ICollection<KeyValuePair<string, object>>.IsReadOnly => AdditionalProperties.IsReadOnly;
        /// <inheritdoc cref="ICollection{T}.Add"/>
        void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> value) => AdditionalProperties.Add(value);
        /// <inheritdoc cref="ICollection{T}.Remove"/>
        bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> value) => AdditionalProperties.Remove(value);
        /// <inheritdoc cref="ICollection{T}.Contains"/>
        bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> value) => AdditionalProperties.Contains(value);
        /// <inheritdoc cref="ICollection{T}.CopyTo"/>
        void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] destination, int offset) => AdditionalProperties.CopyTo(destination, offset);
        /// <inheritdoc cref="ICollection{T}.Clear"/>
        void ICollection<KeyValuePair<string, object>>.Clear() => AdditionalProperties.Clear();
        /// <inheritdoc />
        public object this[string key]
        {
            get => AdditionalProperties[key];
            set => AdditionalProperties[key] = value;
        }
    }
}
