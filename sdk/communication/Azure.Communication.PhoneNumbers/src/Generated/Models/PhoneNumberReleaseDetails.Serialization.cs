// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers.Models
{
    public partial class PhoneNumberReleaseDetails
    {
        internal static PhoneNumberReleaseDetails DeserializePhoneNumberReleaseDetails(JsonElement element)
        {
            Optional<PhoneNumberReleaseStatus> status = default;
            Optional<int> errorCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new PhoneNumberReleaseStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errorCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    errorCode = property.Value.GetInt32();
                    continue;
                }
            }
            return new PhoneNumberReleaseDetails(Optional.ToNullable(status), Optional.ToNullable(errorCode));
        }
    }
}
