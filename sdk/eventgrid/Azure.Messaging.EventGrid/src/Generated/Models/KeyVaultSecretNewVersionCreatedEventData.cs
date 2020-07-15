// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.Models
{
    /// <summary> Schema of the Data property of an EventGridEvent for an SecretNewVersionCreated event. </summary>
    internal partial class KeyVaultSecretNewVersionCreatedEventData
    {
        /// <summary> Initializes a new instance of KeyVaultSecretNewVersionCreatedEventData. </summary>
        internal KeyVaultSecretNewVersionCreatedEventData()
        {
        }

        /// <summary> Initializes a new instance of KeyVaultSecretNewVersionCreatedEventData. </summary>
        /// <param name="id"> The id of the object that triggered this event. </param>
        /// <param name="vaultName"> Key vault name of the object that triggered this event. </param>
        /// <param name="objectType"> The type of the object that triggered this event. </param>
        /// <param name="objectName"> The name of the object that triggered this event. </param>
        /// <param name="version"> The version of the object that triggered this event. </param>
        /// <param name="nbf"> Not before date of the object that triggered this event. </param>
        /// <param name="exp"> The expiration date of the object that triggered this event. </param>
        internal KeyVaultSecretNewVersionCreatedEventData(string id, string vaultName, string objectType, string objectName, string version, float? nbf, float? exp)
        {
            Id = id;
            VaultName = vaultName;
            ObjectType = objectType;
            ObjectName = objectName;
            Version = version;
            Nbf = nbf;
            Exp = exp;
        }

        /// <summary> The id of the object that triggered this event. </summary>
        public string Id { get; }
        /// <summary> Key vault name of the object that triggered this event. </summary>
        public string VaultName { get; }
        /// <summary> The type of the object that triggered this event. </summary>
        public string ObjectType { get; }
        /// <summary> The name of the object that triggered this event. </summary>
        public string ObjectName { get; }
        /// <summary> The version of the object that triggered this event. </summary>
        public string Version { get; }
        /// <summary> Not before date of the object that triggered this event. </summary>
        public float? Nbf { get; }
        /// <summary> The expiration date of the object that triggered this event. </summary>
        public float? Exp { get; }
    }
}
