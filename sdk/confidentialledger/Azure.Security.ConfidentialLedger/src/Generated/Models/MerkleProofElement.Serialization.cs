// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Security.ConfidentialLedger.Models
{
    public partial class MerkleProofElement
    {
        internal static MerkleProofElement DeserializeMerkleProofElement(JsonElement element)
        {
            Optional<string> left = default;
            Optional<string> right = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("left"))
                {
                    left = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("right"))
                {
                    right = property.Value.GetString();
                    continue;
                }
            }
            return new MerkleProofElement(left.Value, right.Value);
        }
    }
}
