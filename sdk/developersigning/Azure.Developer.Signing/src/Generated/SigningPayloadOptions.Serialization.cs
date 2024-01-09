// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Developer.Signing
{
    public partial class SigningPayloadOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("signatureAlgorithm"u8);
            writer.WriteStringValue(SignatureAlgorithm.ToString());
            writer.WritePropertyName("digest"u8);
            writer.WriteBase64StringValue(Digest.ToArray(), "D");
            if (Optional.IsCollectionDefined(FileHashList))
            {
                writer.WritePropertyName("fileHashList"u8);
                writer.WriteStartArray();
                foreach (var item in FileHashList)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteBase64StringValue(item.ToArray(), "D");
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AuthenticodeHashList))
            {
                writer.WritePropertyName("authenticodeHashList"u8);
                writer.WriteStartArray();
                foreach (var item in AuthenticodeHashList)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteBase64StringValue(item.ToArray(), "D");
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
