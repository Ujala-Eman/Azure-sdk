// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.FormRecognizerReceipt.Models
{
    using Microsoft.Rest;

    /// <summary>
    /// Exception thrown for an invalid response with ComputerVisionError
    /// information.
    /// </summary>
    public partial class ComputerVisionErrorException : RestException
    {
        /// <summary>
        /// Gets information about the associated HTTP request.
        /// </summary>
        public HttpRequestMessageWrapper Request { get; set; }

        /// <summary>
        /// Gets information about the associated HTTP response.
        /// </summary>
        public HttpResponseMessageWrapper Response { get; set; }

        /// <summary>
        /// Gets or sets the body object.
        /// </summary>
        public ComputerVisionError Body { get; set; }

        /// <summary>
        /// Initializes a new instance of the ComputerVisionErrorException class.
        /// </summary>
        public ComputerVisionErrorException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ComputerVisionErrorException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public ComputerVisionErrorException(string message)
            : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ComputerVisionErrorException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public ComputerVisionErrorException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
