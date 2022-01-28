// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.KeyVault.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A class representing the Key data model. </summary>
    public partial class KeyData : KeyVaultResource
    {
        /// <summary> Initializes a new instance of KeyData. </summary>
        public KeyData()
        {
            KeyOps = new ChangeTrackingList<JsonWebKeyOperation>();
        }

        /// <summary> Initializes a new instance of KeyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Azure location of the key vault resource. </param>
        /// <param name="tags"> Tags assigned to the key vault resource. </param>
        /// <param name="attributes"> The attributes of the key. </param>
        /// <param name="kty"> The type of the key. For valid values, see JsonWebKeyType. </param>
        /// <param name="keyOps"></param>
        /// <param name="keySize"> The key size in bits. For example: 2048, 3072, or 4096 for RSA. </param>
        /// <param name="curveName"> The elliptic curve name. For valid values, see JsonWebKeyCurveName. </param>
        /// <param name="keyUri"> The URI to retrieve the current version of the key. </param>
        /// <param name="keyUriWithVersion"> The URI to retrieve the specific version of the key. </param>
        internal KeyData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string location, IReadOnlyDictionary<string, string> tags, KeyAttributes attributes, JsonWebKeyType? kty, IList<JsonWebKeyOperation> keyOps, int? keySize, JsonWebKeyCurveName? curveName, string keyUri, string keyUriWithVersion) : base(id, name, type, systemData, location, tags)
        {
            Attributes = attributes;
            Kty = kty;
            KeyOps = keyOps;
            KeySize = keySize;
            CurveName = curveName;
            KeyUri = keyUri;
            KeyUriWithVersion = keyUriWithVersion;
        }

        /// <summary> The attributes of the key. </summary>
        public KeyAttributes Attributes { get; set; }
        /// <summary> The type of the key. For valid values, see JsonWebKeyType. </summary>
        public JsonWebKeyType? Kty { get; set; }
        /// <summary> Gets the key ops. </summary>
        public IList<JsonWebKeyOperation> KeyOps { get; }
        /// <summary> The key size in bits. For example: 2048, 3072, or 4096 for RSA. </summary>
        public int? KeySize { get; set; }
        /// <summary> The elliptic curve name. For valid values, see JsonWebKeyCurveName. </summary>
        public JsonWebKeyCurveName? CurveName { get; set; }
        /// <summary> The URI to retrieve the current version of the key. </summary>
        public string KeyUri { get; }
        /// <summary> The URI to retrieve the specific version of the key. </summary>
        public string KeyUriWithVersion { get; }
    }
}
