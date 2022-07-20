// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    internal partial class AddParticipantsResponseInternal
    {
        internal static AddParticipantsResponseInternal DeserializeAddParticipantsResponseInternal(JsonElement element)
        {
            Optional<IReadOnlyList<AcsCallParticipantDtoInternal>> participants = default;
            Optional<string> operationContext = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("participants"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AcsCallParticipantDtoInternal> array = new List<AcsCallParticipantDtoInternal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AcsCallParticipantDtoInternal.DeserializeAcsCallParticipantDtoInternal(item));
                    }
                    participants = array;
                    continue;
                }
                if (property.NameEquals("operationContext"))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
            }
            return new AddParticipantsResponseInternal(Optional.ToList(participants), operationContext.Value);
        }
    }
}
