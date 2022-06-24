// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class ResponseBasedOriginErrorDetectionSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ResponseBasedDetectedErrorType))
            {
                writer.WritePropertyName("responseBasedDetectedErrorTypes");
                writer.WriteStringValue(ResponseBasedDetectedErrorType.Value.ToSerialString());
            }
            if (Optional.IsDefined(ResponseBasedFailoverThresholdPercentage))
            {
                writer.WritePropertyName("responseBasedFailoverThresholdPercentage");
                writer.WriteNumberValue(ResponseBasedFailoverThresholdPercentage.Value);
            }
            if (Optional.IsCollectionDefined(HttpErrorRanges))
            {
                writer.WritePropertyName("httpErrorRanges");
                writer.WriteStartArray();
                foreach (var item in HttpErrorRanges)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ResponseBasedOriginErrorDetectionSettings DeserializeResponseBasedOriginErrorDetectionSettings(JsonElement element)
        {
            Optional<ResponseBasedDetectedErrorType> responseBasedDetectedErrorTypes = default;
            Optional<int> responseBasedFailoverThresholdPercentage = default;
            Optional<IList<HttpErrorRange>> httpErrorRanges = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("responseBasedDetectedErrorTypes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    responseBasedDetectedErrorTypes = property.Value.GetString().ToResponseBasedDetectedErrorType();
                    continue;
                }
                if (property.NameEquals("responseBasedFailoverThresholdPercentage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    responseBasedFailoverThresholdPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("httpErrorRanges"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<HttpErrorRange> array = new List<HttpErrorRange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HttpErrorRange.DeserializeHttpErrorRange(item));
                    }
                    httpErrorRanges = array;
                    continue;
                }
            }
            return new ResponseBasedOriginErrorDetectionSettings(Optional.ToNullable(responseBasedDetectedErrorTypes), Optional.ToNullable(responseBasedFailoverThresholdPercentage), Optional.ToList(httpErrorRanges));
        }
    }
}
