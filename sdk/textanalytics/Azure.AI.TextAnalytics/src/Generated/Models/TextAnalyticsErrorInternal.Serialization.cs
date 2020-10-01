// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class TextAnalyticsErrorInternal
    {
        internal static TextAnalyticsErrorInternal DeserializeTextAnalyticsErrorInternal(JsonElement element)
        {
            string code = default;
            string message = default;
            Optional<string> target = default;
            Optional<InnerError> innererror = default;
            Optional<IReadOnlyList<TextAnalyticsErrorInternal>> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("innererror"))
                {
                    innererror = InnerError.DeserializeInnerError(property.Value);
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    List<TextAnalyticsErrorInternal> array = new List<TextAnalyticsErrorInternal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeTextAnalyticsErrorInternal(item));
                    }
                    details = array;
                    continue;
                }
            }
            return new TextAnalyticsErrorInternal(code, message, target.Value, innererror.Value, Optional.ToList(details));
        }
    }
}
