// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> error details. </summary>
    public partial class ExchangePolicyError
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ExchangePolicyError"/>. </summary>
        internal ExchangePolicyError()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExchangePolicyError"/>. </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ExchangePolicyError(string code, string message, Dictionary<string, BinaryData> rawData)
        {
            Code = code;
            Message = message;
            _rawData = rawData;
        }

        /// <summary> Gets the code. </summary>
        public string Code { get; }
        /// <summary> Gets the message. </summary>
        public string Message { get; }
    }
}
