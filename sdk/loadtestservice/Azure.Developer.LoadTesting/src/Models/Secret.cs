// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core.Json;

namespace Azure.Developer.LoadTesting.Models
{
    /// <summary> Secret. </summary>
    public partial class Secret
    {
        private MutableJsonElement _element;

        /// <summary> Initializes a new instance of Secret. </summary>
        public Secret()
        {
            _element = MutableJsonDocument.Parse(MutableJsonDocument.EmptyJson).RootElement;
        }

        internal Secret(MutableJsonElement element)
        {
            _element = element;
        }

        /// <summary> The value of the secret for the respective type. </summary>
        public string Value
        {
            get => _element.GetProperty("value").GetString();
            set => _element.SetProperty("value", value);
        }

        /// <summary> Type of secret. </summary>
        public SecretType? Type
        {
            get => _element.GetProperty("type").GetString();
            set => _element.SetProperty("type", value);
        }
    }
}
