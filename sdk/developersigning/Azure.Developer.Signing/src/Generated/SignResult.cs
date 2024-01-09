// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Developer.Signing
{
    /// <summary> The sign status model. </summary>
    public partial class SignResult
    {
        /// <summary> Initializes a new instance of <see cref="SignResult"/>. </summary>
        internal SignResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SignResult"/>. </summary>
        /// <param name="signature"> Digital signature of the requested content digest. </param>
        /// <param name="signingCertificate">
        /// Signing certificate corresponding to the private key used to sign the requested
        /// digest.
        /// </param>
        internal SignResult(BinaryData signature, BinaryData signingCertificate)
        {
            Signature = signature;
            SigningCertificate = signingCertificate;
        }

        /// <summary>
        /// Digital signature of the requested content digest.
        /// <para>
        /// To assign a byte[] to this property use <see cref="BinaryData.FromBytes(byte[])"/>.
        /// The byte[] will be serialized to a Base64 encoded string.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromBytes(new byte[] { 1, 2, 3 })</term>
        /// <description>Creates a payload of "AQID".</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Signature { get; }
        /// <summary>
        /// Signing certificate corresponding to the private key used to sign the requested
        /// digest.
        /// <para>
        /// To assign a byte[] to this property use <see cref="BinaryData.FromBytes(byte[])"/>.
        /// The byte[] will be serialized to a Base64 encoded string.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromBytes(new byte[] { 1, 2, 3 })</term>
        /// <description>Creates a payload of "AQID".</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData SigningCertificate { get; }
    }
}
