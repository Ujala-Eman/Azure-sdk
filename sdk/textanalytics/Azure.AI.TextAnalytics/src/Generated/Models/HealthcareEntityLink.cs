// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The HealthcareEntityLink. </summary>
    internal partial class HealthcareEntityLink
    {
        /// <summary> Initializes a new instance of HealthcareEntityLink. </summary>
        /// <param name="dataSource"> Entity Catalog. Examples include: UMLS, CHV, MSH, etc. </param>
        /// <param name="id"> Entity id in the given source catalog. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSource"/> or <paramref name="id"/> is null. </exception>
        internal HealthcareEntityLink(string dataSource, string id)
        {
            if (dataSource == null)
            {
                throw new ArgumentNullException(nameof(dataSource));
            }
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            DataSource = dataSource;
            Id = id;
        }

        /// <summary> Entity Catalog. Examples include: UMLS, CHV, MSH, etc. </summary>
        public string DataSource { get; }
        /// <summary> Entity id in the given source catalog. </summary>
        public string Id { get; }
    }
}
