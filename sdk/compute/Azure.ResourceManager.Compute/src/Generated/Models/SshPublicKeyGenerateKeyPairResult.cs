// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Response from generation of an SSH key pair. </summary>
    public partial class SshPublicKeyGenerateKeyPairResult
    {
        /// <summary> Initializes a new instance of <see cref="SshPublicKeyGenerateKeyPairResult"/>. </summary>
        /// <param name="privateKey"> Private key portion of the key pair used to authenticate to a virtual machine through ssh. The private key is returned in RFC3447 format and should be treated as a secret. </param>
        /// <param name="publicKey"> Public key portion of the key pair used to authenticate to a virtual machine through ssh. The public key is in ssh-rsa format. </param>
        /// <param name="id"> The ARM resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/sshPublicKeys/{SshPublicKeyName}. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateKey"/>, <paramref name="publicKey"/> or <paramref name="id"/> is null. </exception>
        internal SshPublicKeyGenerateKeyPairResult(string privateKey, string publicKey, ResourceIdentifier id)
        {
            if (privateKey == null)
            {
                throw new ArgumentNullException(nameof(privateKey));
            }
            if (publicKey == null)
            {
                throw new ArgumentNullException(nameof(publicKey));
            }
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            PrivateKey = privateKey;
            PublicKey = publicKey;
            Id = id;
        }

        /// <summary> Private key portion of the key pair used to authenticate to a virtual machine through ssh. The private key is returned in RFC3447 format and should be treated as a secret. </summary>
        public string PrivateKey { get; }
        /// <summary> Public key portion of the key pair used to authenticate to a virtual machine through ssh. The public key is in ssh-rsa format. </summary>
        public string PublicKey { get; }
        /// <summary> The ARM resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/sshPublicKeys/{SshPublicKeyName}. </summary>
        public ResourceIdentifier Id { get; }
    }
}
