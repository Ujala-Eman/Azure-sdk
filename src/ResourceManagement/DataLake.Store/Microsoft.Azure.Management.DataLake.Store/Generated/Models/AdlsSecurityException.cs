// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using System.Linq;

    /// <summary>
    /// A WebHDFS exception thrown indicating that access is denied. Thrown
    /// when a 401 error response code is returned (Unauthorized).
    /// </summary>
    [Newtonsoft.Json.JsonObject("SecurityException")]
    public partial class AdlsSecurityException : AdlsRemoteException
    {
        /// <summary>
        /// Initializes a new instance of the AdlsSecurityException class.
        /// </summary>
        public AdlsSecurityException() { }

        /// <summary>
        /// Initializes a new instance of the AdlsSecurityException class.
        /// </summary>
        /// <param name="javaClassName">the full class package name for the
        /// exception thrown, such as
        /// 'java.lang.IllegalArgumentException'.</param>
        /// <param name="message">the message associated with the exception
        /// that was thrown, such as 'Invalid value for webhdfs parameter
        /// "permission":...'.</param>
        public AdlsSecurityException(string javaClassName = default(string), string message = default(string))
            : base(javaClassName, message)
        {
        }

    }
}
