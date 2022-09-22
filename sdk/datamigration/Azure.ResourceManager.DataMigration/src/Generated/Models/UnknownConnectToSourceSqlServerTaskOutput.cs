// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The UnknownConnectToSourceSqlServerTaskOutput. </summary>
    internal partial class UnknownConnectToSourceSqlServerTaskOutput : ConnectToSourceSqlServerTaskOutput
    {
        /// <summary> Initializes a new instance of UnknownConnectToSourceSqlServerTaskOutput. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Type of result - database level or task level. </param>
        internal UnknownConnectToSourceSqlServerTaskOutput(string id, string resultType) : base(id, resultType)
        {
            ResultType = resultType ?? "Unknown";
        }
    }
}
