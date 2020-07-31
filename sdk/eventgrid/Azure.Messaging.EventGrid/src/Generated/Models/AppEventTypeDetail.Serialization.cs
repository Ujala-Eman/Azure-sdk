// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Messaging.EventGrid.Models;

namespace Azure.Messaging.EventGrid.Models.SystemEvents
{
    public partial class AppEventTypeDetail
    {
        internal static AppEventTypeDetail DeserializeAppEventTypeDetail(JsonElement element)
        {
            Optional<AppAction> action = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("action"))
                {
                    action = new AppAction(property.Value.GetString());
                    continue;
                }
            }
            return new AppEventTypeDetail(Optional.ToNullable(action));
        }
    }
}
