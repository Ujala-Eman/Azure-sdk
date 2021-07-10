// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    public partial class DatastoreContents : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("contentsType");
            writer.WriteStringValue(ContentsType.ToString());
            writer.WriteEndObject();
        }

        internal static DatastoreContents DeserializeDatastoreContents(JsonElement element)
        {
            if (element.TryGetProperty("contentsType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureBlob": return AzureBlobContents.DeserializeAzureBlobContents(element);
                    case "AzureDataLakeGen1": return AzureDataLakeGen1Contents.DeserializeAzureDataLakeGen1Contents(element);
                    case "AzureDataLakeGen2": return AzureDataLakeGen2Contents.DeserializeAzureDataLakeGen2Contents(element);
                    case "AzureFile": return AzureFileContents.DeserializeAzureFileContents(element);
                    case "AzurePostgreSql": return AzurePostgreSqlContents.DeserializeAzurePostgreSqlContents(element);
                    case "AzureSqlDatabase": return AzureSqlDatabaseContents.DeserializeAzureSqlDatabaseContents(element);
                    case "GlusterFs": return GlusterFsContents.DeserializeGlusterFsContents(element);
                }
            }
            ContentsType contentsType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contentsType"))
                {
                    contentsType = new ContentsType(property.Value.GetString());
                    continue;
                }
            }
            return new DatastoreContents(contentsType);
        }
    }
}
