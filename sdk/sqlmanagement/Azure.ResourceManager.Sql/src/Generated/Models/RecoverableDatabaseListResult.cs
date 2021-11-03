// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using SqlManagementClient;

namespace SqlManagementClient.Models
{
    /// <summary> The response to a list recoverable databases request. </summary>
    internal partial class RecoverableDatabaseListResult
    {
        /// <summary> Initializes a new instance of RecoverableDatabaseListResult. </summary>
        /// <param name="value"> A list of recoverable databases. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal RecoverableDatabaseListResult(IEnumerable<RecoverableDatabaseData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of RecoverableDatabaseListResult. </summary>
        /// <param name="value"> A list of recoverable databases. </param>
        internal RecoverableDatabaseListResult(IReadOnlyList<RecoverableDatabaseData> value)
        {
            Value = value;
        }

        /// <summary> A list of recoverable databases. </summary>
        public IReadOnlyList<RecoverableDatabaseData> Value { get; }
    }
}
