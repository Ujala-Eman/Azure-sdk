// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class CheckOciDriverTaskOutput
    {
        internal static CheckOciDriverTaskOutput DeserializeCheckOciDriverTaskOutput(JsonElement element)
        {
            Optional<OracleOciDriverInfo> installedDriver = default;
            Optional<IReadOnlyList<ReportableException>> validationErrors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("installedDriver"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    installedDriver = OracleOciDriverInfo.DeserializeOracleOciDriverInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("validationErrors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ReportableException> array = new List<ReportableException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportableException.DeserializeReportableException(item));
                    }
                    validationErrors = array;
                    continue;
                }
            }
            return new CheckOciDriverTaskOutput(installedDriver.Value, Optional.ToList(validationErrors));
        }
    }
}
