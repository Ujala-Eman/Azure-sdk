// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    public partial class ListWorkspaceKeysResult
    {
        internal static ListWorkspaceKeysResult DeserializeListWorkspaceKeysResult(JsonElement element)
        {
            Optional<string> userStorageKey = default;
            Optional<string> userStorageResourceId = default;
            Optional<string> appInsightsInstrumentationKey = default;
            Optional<RegistryListCredentialsResult> containerRegistryCredentials = default;
            Optional<ListNotebookKeysResult> notebookAccessKeys = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userStorageKey"))
                {
                    userStorageKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userStorageResourceId"))
                {
                    userStorageResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appInsightsInstrumentationKey"))
                {
                    appInsightsInstrumentationKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerRegistryCredentials"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    containerRegistryCredentials = RegistryListCredentialsResult.DeserializeRegistryListCredentialsResult(property.Value);
                    continue;
                }
                if (property.NameEquals("notebookAccessKeys"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    notebookAccessKeys = ListNotebookKeysResult.DeserializeListNotebookKeysResult(property.Value);
                    continue;
                }
            }
            return new ListWorkspaceKeysResult(userStorageKey.Value, userStorageResourceId.Value, appInsightsInstrumentationKey.Value, containerRegistryCredentials.Value, notebookAccessKeys.Value);
        }
    }
}
