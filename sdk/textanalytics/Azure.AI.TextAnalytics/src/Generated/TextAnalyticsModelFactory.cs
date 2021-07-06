// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class TextAnalyticsModelFactory
    {

        /// <summary> Initializes a new instance of HealthcareEntityAssertion. </summary>
        /// <param name="conditionality"> Describes any conditionality on the entity. </param>
        /// <param name="certainty"> Describes the entities certainty and polarity. </param>
        /// <param name="association"> Describes if the entity is the subject of the text or if it describes someone else. </param>
        /// <returns> A new <see cref="TextAnalytics.HealthcareEntityAssertion"/> instance for mocking. </returns>
        public static HealthcareEntityAssertion HealthcareEntityAssertion(EntityConditionality? conditionality = null, EntityCertainty? certainty = null, EntityAssociation? association = null)
        {
            return new HealthcareEntityAssertion(conditionality, certainty, association);
        }

        /// <summary> Initializes a new instance of EntityDataSource. </summary>
        /// <param name="name"> Entity Catalog. Examples include: UMLS, CHV, MSH, etc. </param>
        /// <param name="entityId"> Entity id in the given source catalog. </param>
        /// <returns> A new <see cref="TextAnalytics.EntityDataSource"/> instance for mocking. </returns>
        public static EntityDataSource EntityDataSource(string name = null, string entityId = null)
        {
            return new EntityDataSource(name, entityId);
        }
    }
}
