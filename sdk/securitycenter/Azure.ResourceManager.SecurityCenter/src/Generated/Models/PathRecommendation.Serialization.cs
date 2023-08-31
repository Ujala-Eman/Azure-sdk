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
    public partial class PathRecommendation : IUtf8JsonSerializable, IModelJsonSerializable<PathRecommendation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PathRecommendation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PathRecommendation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action"u8);
                writer.WriteStringValue(Action.Value.ToString());
            }
            if (Optional.IsDefined(IotSecurityRecommendationType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(IotSecurityRecommendationType.Value.ToString());
            }
            if (Optional.IsDefined(PublisherInfo))
            {
                writer.WritePropertyName("publisherInfo"u8);
                if (PublisherInfo is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SecurityCenterPublisherInfo>)PublisherInfo).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(IsCommon))
            {
                writer.WritePropertyName("common"u8);
                writer.WriteBooleanValue(IsCommon.Value);
            }
            if (Optional.IsCollectionDefined(UserSids))
            {
                writer.WritePropertyName("userSids"u8);
                writer.WriteStartArray();
                foreach (var item in UserSids)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Usernames))
            {
                writer.WritePropertyName("usernames"u8);
                writer.WriteStartArray();
                foreach (var item in Usernames)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<UserRecommendation>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FileType))
            {
                writer.WritePropertyName("fileType"u8);
                writer.WriteStringValue(FileType.Value.ToString());
            }
            if (Optional.IsDefined(ConfigurationStatus))
            {
                writer.WritePropertyName("configurationStatus"u8);
                writer.WriteStringValue(ConfigurationStatus.Value.ToString());
            }
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

        internal static PathRecommendation DeserializePathRecommendation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> path = default;
            Optional<RecommendationAction> action = default;
            Optional<IotSecurityRecommendationType> type = default;
            Optional<SecurityCenterPublisherInfo> publisherInfo = default;
            Optional<bool> common = default;
            Optional<IList<string>> userSids = default;
            Optional<IList<UserRecommendation>> usernames = default;
            Optional<PathRecommendationFileType> fileType = default;
            Optional<SecurityCenterConfigurationStatus> configurationStatus = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    action = new RecommendationAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new IotSecurityRecommendationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publisherInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publisherInfo = SecurityCenterPublisherInfo.DeserializeSecurityCenterPublisherInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("common"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    common = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("userSids"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    userSids = array;
                    continue;
                }
                if (property.NameEquals("usernames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UserRecommendation> array = new List<UserRecommendation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UserRecommendation.DeserializeUserRecommendation(item));
                    }
                    usernames = array;
                    continue;
                }
                if (property.NameEquals("fileType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileType = new PathRecommendationFileType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("configurationStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configurationStatus = new SecurityCenterConfigurationStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PathRecommendation(path.Value, Optional.ToNullable(action), Optional.ToNullable(type), publisherInfo.Value, Optional.ToNullable(common), Optional.ToList(userSids), Optional.ToList(usernames), Optional.ToNullable(fileType), Optional.ToNullable(configurationStatus), rawData);
        }

        PathRecommendation IModelJsonSerializable<PathRecommendation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePathRecommendation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PathRecommendation>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PathRecommendation IModelSerializable<PathRecommendation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePathRecommendation(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PathRecommendation"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PathRecommendation"/> to convert. </param>
        public static implicit operator RequestContent(PathRecommendation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PathRecommendation"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PathRecommendation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePathRecommendation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
