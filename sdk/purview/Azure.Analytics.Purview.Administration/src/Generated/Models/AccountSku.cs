// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Purview.Administration.Models
{
    /// <summary> The Sku. </summary>
    public partial class AccountSku
    {
        /// <summary> Initializes a new instance of AccountSku. </summary>
        internal AccountSku()
        {
        }

        /// <summary> Initializes a new instance of AccountSku. </summary>
        /// <param name="capacity"> Gets or sets the sku capacity. Possible values include: 4, 16. </param>
        /// <param name="name"> Gets or sets the sku name. </param>
        internal AccountSku(int? capacity, Name? name)
        {
            Capacity = capacity;
            Name = name;
        }

        /// <summary> Gets or sets the sku capacity. Possible values include: 4, 16. </summary>
        public int? Capacity { get; }
        /// <summary> Gets or sets the sku name. </summary>
        public Name? Name { get; }
    }
}
