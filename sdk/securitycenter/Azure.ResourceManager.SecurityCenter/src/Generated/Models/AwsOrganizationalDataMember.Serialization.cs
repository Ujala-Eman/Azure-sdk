// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class AwsOrganizationalDataMember : IUtf8JsonSerializable, IModelJsonSerializable<AwsOrganizationalDataMember>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AwsOrganizationalDataMember>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AwsOrganizationalDataMember>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AwsOrganizationalDataMember>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ParentHierarchyId))
            {
                writer.WritePropertyName("parentHierarchyId"u8);
                writer.WriteStringValue(ParentHierarchyId);
            }
            writer.WritePropertyName("organizationMembershipType"u8);
            writer.WriteStringValue(OrganizationMembershipType.ToString());
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static AwsOrganizationalDataMember DeserializeAwsOrganizationalDataMember(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> parentHierarchyId = default;
            OrganizationMembershipType organizationMembershipType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parentHierarchyId"u8))
                {
                    parentHierarchyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("organizationMembershipType"u8))
                {
                    organizationMembershipType = new OrganizationMembershipType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AwsOrganizationalDataMember(organizationMembershipType, parentHierarchyId.Value, rawData);
        }

        AwsOrganizationalDataMember IModelJsonSerializable<AwsOrganizationalDataMember>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AwsOrganizationalDataMember>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAwsOrganizationalDataMember(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AwsOrganizationalDataMember>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AwsOrganizationalDataMember>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AwsOrganizationalDataMember IModelSerializable<AwsOrganizationalDataMember>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AwsOrganizationalDataMember>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAwsOrganizationalDataMember(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AwsOrganizationalDataMember"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AwsOrganizationalDataMember"/> to convert. </param>
        public static implicit operator RequestContent(AwsOrganizationalDataMember model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AwsOrganizationalDataMember"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AwsOrganizationalDataMember(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAwsOrganizationalDataMember(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
