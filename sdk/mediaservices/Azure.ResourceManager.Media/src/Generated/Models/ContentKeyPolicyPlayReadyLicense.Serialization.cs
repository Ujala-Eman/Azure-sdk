// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class ContentKeyPolicyPlayReadyLicense : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("allowTestDevices");
            writer.WriteBooleanValue(AllowTestDevices);
            if (Optional.IsDefined(BeginOn))
            {
                writer.WritePropertyName("beginDate");
                writer.WriteStringValue(BeginOn.Value, "O");
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationDate");
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (Optional.IsDefined(RelativeBeginDate))
            {
                writer.WritePropertyName("relativeBeginDate");
                writer.WriteStringValue(RelativeBeginDate.Value, "P");
            }
            if (Optional.IsDefined(RelativeExpirationDate))
            {
                writer.WritePropertyName("relativeExpirationDate");
                writer.WriteStringValue(RelativeExpirationDate.Value, "P");
            }
            if (Optional.IsDefined(GracePeriod))
            {
                writer.WritePropertyName("gracePeriod");
                writer.WriteStringValue(GracePeriod.Value, "P");
            }
            if (Optional.IsDefined(PlayRight))
            {
                writer.WritePropertyName("playRight");
                writer.WriteObjectValue(PlayRight);
            }
            writer.WritePropertyName("licenseType");
            writer.WriteStringValue(LicenseType.ToString());
            writer.WritePropertyName("contentKeyLocation");
            writer.WriteObjectValue(ContentKeyLocation);
            writer.WritePropertyName("contentType");
            writer.WriteStringValue(ContentType.ToString());
            writer.WriteEndObject();
        }

        internal static ContentKeyPolicyPlayReadyLicense DeserializeContentKeyPolicyPlayReadyLicense(JsonElement element)
        {
            bool allowTestDevices = default;
            Optional<DateTimeOffset> beginDate = default;
            Optional<DateTimeOffset> expirationDate = default;
            Optional<TimeSpan> relativeBeginDate = default;
            Optional<TimeSpan> relativeExpirationDate = default;
            Optional<TimeSpan> gracePeriod = default;
            Optional<ContentKeyPolicyPlayReadyPlayRight> playRight = default;
            ContentKeyPolicyPlayReadyLicenseType licenseType = default;
            ContentKeyPolicyPlayReadyContentKeyLocation contentKeyLocation = default;
            ContentKeyPolicyPlayReadyContentType contentType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowTestDevices"))
                {
                    allowTestDevices = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("beginDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    beginDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expirationDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expirationDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("relativeBeginDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    relativeBeginDate = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("relativeExpirationDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    relativeExpirationDate = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("gracePeriod"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    gracePeriod = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("playRight"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    playRight = ContentKeyPolicyPlayReadyPlayRight.DeserializeContentKeyPolicyPlayReadyPlayRight(property.Value);
                    continue;
                }
                if (property.NameEquals("licenseType"))
                {
                    licenseType = new ContentKeyPolicyPlayReadyLicenseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("contentKeyLocation"))
                {
                    contentKeyLocation = ContentKeyPolicyPlayReadyContentKeyLocation.DeserializeContentKeyPolicyPlayReadyContentKeyLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("contentType"))
                {
                    contentType = new ContentKeyPolicyPlayReadyContentType(property.Value.GetString());
                    continue;
                }
            }
            return new ContentKeyPolicyPlayReadyLicense(allowTestDevices, Optional.ToNullable(beginDate), Optional.ToNullable(expirationDate), Optional.ToNullable(relativeBeginDate), Optional.ToNullable(relativeExpirationDate), Optional.ToNullable(gracePeriod), playRight.Value, licenseType, contentKeyLocation, contentType);
        }
    }
}
