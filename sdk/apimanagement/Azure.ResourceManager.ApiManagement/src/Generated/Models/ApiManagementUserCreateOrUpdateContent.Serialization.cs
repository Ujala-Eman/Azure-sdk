// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiManagementUserCreateOrUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state");
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(Note))
            {
                writer.WritePropertyName("note");
                writer.WriteStringValue(Note);
            }
            if (Optional.IsCollectionDefined(Identities))
            {
                writer.WritePropertyName("identities");
                writer.WriteStartArray();
                foreach (var item in Identities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Email))
            {
                writer.WritePropertyName("email");
                writer.WriteStringValue(Email);
            }
            if (Optional.IsDefined(FirstName))
            {
                writer.WritePropertyName("firstName");
                writer.WriteStringValue(FirstName);
            }
            if (Optional.IsDefined(LastName))
            {
                writer.WritePropertyName("lastName");
                writer.WriteStringValue(LastName);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password");
                writer.WriteStringValue(Password);
            }
            if (Optional.IsDefined(AppType))
            {
                writer.WritePropertyName("appType");
                writer.WriteStringValue(AppType.Value.ToString());
            }
            if (Optional.IsDefined(Confirmation))
            {
                writer.WritePropertyName("confirmation");
                writer.WriteStringValue(Confirmation.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
