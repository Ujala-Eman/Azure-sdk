﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text;

namespace Azure.DigitalTwins.Core.QueryBuilder
{
    /// <summary>
    /// Custom object for a FROM clause. Only meant to be used when adding FROM to a query. Hidden from user.
    /// </summary>
    internal class FromClause : ClauseBase
    {
        /// <summary>
        /// Constructor for a FROM clause.
        /// </summary>
        /// <param name="collection"> Enum Collection that can be either a ADT instance or a relationship. </param>
        internal FromClause(AdtCollection collection)
        {
            Type = ClauseType.FROM;
            Collection = collection.ToString();
        }

        internal FromClause(string literalCollection)
        {
            Type = ClauseType.FROM;
            Collection = literalCollection;
        }

        /// <summary>
        /// The collection to query from. Stored in an enum to give user some intellisense since there are only two possible collection types,
        /// ADT instances or relationships.
        /// </summary>
        public string Collection { get; private set; }
    }
}
