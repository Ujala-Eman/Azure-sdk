// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.Specialized
{
    internal partial class OciManifestAnnotations
    {
        internal static OciManifestAnnotations DeserializeOciManifestAnnotations(JsonElement element)
        {
            Optional<DateTimeOffset> orgOpencontainersImageCreated = default;
            Optional<string> orgOpencontainersImageAuthors = default;
            Optional<string> orgOpencontainersImageUrl = default;
            Optional<string> orgOpencontainersImageDocumentation = default;
            Optional<string> orgOpencontainersImageSource = default;
            Optional<string> orgOpencontainersImageVersion = default;
            Optional<string> orgOpencontainersImageRevision = default;
            Optional<string> orgOpencontainersImageVendor = default;
            Optional<string> orgOpencontainersImageLicenses = default;
            Optional<string> orgOpencontainersImageRefName = default;
            Optional<string> orgOpencontainersImageTitle = default;
            Optional<string> orgOpencontainersImageDescription = default;
            IReadOnlyDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("org.opencontainers.image.created"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    orgOpencontainersImageCreated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("org.opencontainers.image.authors"))
                {
                    orgOpencontainersImageAuthors = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("org.opencontainers.image.url"))
                {
                    orgOpencontainersImageUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("org.opencontainers.image.documentation"))
                {
                    orgOpencontainersImageDocumentation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("org.opencontainers.image.source"))
                {
                    orgOpencontainersImageSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("org.opencontainers.image.version"))
                {
                    orgOpencontainersImageVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("org.opencontainers.image.revision"))
                {
                    orgOpencontainersImageRevision = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("org.opencontainers.image.vendor"))
                {
                    orgOpencontainersImageVendor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("org.opencontainers.image.licenses"))
                {
                    orgOpencontainersImageLicenses = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("org.opencontainers.image.ref.name"))
                {
                    orgOpencontainersImageRefName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("org.opencontainers.image.title"))
                {
                    orgOpencontainersImageTitle = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("org.opencontainers.image.description"))
                {
                    orgOpencontainersImageDescription = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new OciManifestAnnotations(Optional.ToNullable(orgOpencontainersImageCreated), orgOpencontainersImageAuthors.Value, orgOpencontainersImageUrl.Value, orgOpencontainersImageDocumentation.Value, orgOpencontainersImageSource.Value, orgOpencontainersImageVersion.Value, orgOpencontainersImageRevision.Value, orgOpencontainersImageVendor.Value, orgOpencontainersImageLicenses.Value, orgOpencontainersImageRefName.Value, orgOpencontainersImageTitle.Value, orgOpencontainersImageDescription.Value, additionalProperties);
        }
    }
}
