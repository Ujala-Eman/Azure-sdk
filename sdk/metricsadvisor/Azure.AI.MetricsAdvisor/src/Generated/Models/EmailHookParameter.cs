// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The EmailHookParameter. </summary>
    public partial class EmailHookParameter
    {
        /// <summary> Initializes a new instance of EmailHookParameter. </summary>
        /// <param name="toList"> Email TO: list. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="toList"/> is null. </exception>
        public EmailHookParameter(IEnumerable<string> toList)
        {
            if (toList == null)
            {
                throw new ArgumentNullException(nameof(toList));
            }

            ToList = toList.ToList();
        }

        /// <summary> Initializes a new instance of EmailHookParameter. </summary>
        /// <param name="toList"> Email TO: list. </param>
        internal EmailHookParameter(IList<string> toList)
        {
            ToList = toList;
        }

        /// <summary> Email TO: list. </summary>
        public IList<string> ToList { get; }
    }
}
