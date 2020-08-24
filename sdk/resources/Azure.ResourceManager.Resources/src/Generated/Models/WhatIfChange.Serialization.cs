// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class WhatIfChange
    {
        internal static WhatIfChange DeserializeWhatIfChange(JsonElement element)
        {
            string resourceId = default;
            ChangeType changeType = default;
            Optional<object> before = default;
            Optional<object> after = default;
            Optional<IReadOnlyList<WhatIfPropertyChange>> delta = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("changeType"))
                {
                    changeType = property.Value.GetString().ToChangeType();
                    continue;
                }
                if (property.NameEquals("before"))
                {
                    before = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("after"))
                {
                    after = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("delta"))
                {
                    List<WhatIfPropertyChange> array = new List<WhatIfPropertyChange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WhatIfPropertyChange.DeserializeWhatIfPropertyChange(item));
                    }
                    delta = array;
                    continue;
                }
            }
            return new WhatIfChange(resourceId, changeType, before.Value, after.Value, Optional.ToList(delta));
        }
    }
}
