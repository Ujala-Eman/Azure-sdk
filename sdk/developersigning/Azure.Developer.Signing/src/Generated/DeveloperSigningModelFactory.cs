// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;

namespace Azure.Developer.Signing
{
    /// <summary> Model factory for models. </summary>
    public static partial class DeveloperSigningModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Signing.OperationStatusSignResultError"/>. </summary>
        /// <param name="id"> The unique ID of the operation. </param>
        /// <param name="status"> The status of the operation. </param>
        /// <param name="error"> Error object that describes the error when status is "Failed". </param>
        /// <param name="result"> The result of the operation. </param>
        /// <returns> A new <see cref="Signing.OperationStatusSignResultError"/> instance for mocking. </returns>
        public static OperationStatusSignResultError OperationStatusSignResultError(string id = null, OperationState status = default, ResponseError error = null, SignResult result = null)
        {
            return new OperationStatusSignResultError(id, status, error, result);
        }

        /// <summary> Initializes a new instance of <see cref="Signing.SignResult"/>. </summary>
        /// <param name="signature"> Digital signature of the requested content digest. </param>
        /// <param name="signingCertificate">
        /// Signing certificate corresponding to the private key used to sign the requested
        /// digest.
        /// </param>
        /// <returns> A new <see cref="Signing.SignResult"/> instance for mocking. </returns>
        public static SignResult SignResult(BinaryData signature = null, BinaryData signingCertificate = null)
        {
            return new SignResult(signature, signingCertificate);
        }

        /// <summary> Initializes a new instance of <see cref="Signing.ExtendedKeyUsage"/>. </summary>
        /// <param name="eku"> An oid string that represents an eku. </param>
        /// <returns> A new <see cref="Signing.ExtendedKeyUsage"/> instance for mocking. </returns>
        public static ExtendedKeyUsage ExtendedKeyUsage(string eku = null)
        {
            return new ExtendedKeyUsage(eku);
        }
    }
}
