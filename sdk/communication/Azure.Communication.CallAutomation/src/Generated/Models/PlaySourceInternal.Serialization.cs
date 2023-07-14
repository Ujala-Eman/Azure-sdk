// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    internal partial class PlaySourceInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(PlaySourceCacheId))
            {
                writer.WritePropertyName("playSourceCacheId"u8);
                writer.WriteStringValue(PlaySourceCacheId);
            }
            if (Optional.IsDefined(File))
            {
                writer.WritePropertyName("file"u8);
                writer.WriteObjectValue(File);
            }
            if (Optional.IsDefined(TextSource))
            {
                writer.WritePropertyName("textSource"u8);
                writer.WriteObjectValue(TextSource);
            }
            if (Optional.IsDefined(SsmlSource))
            {
                writer.WritePropertyName("ssmlSource"u8);
                writer.WriteObjectValue(SsmlSource);
            }
            writer.WriteEndObject();
        }
    }
}
