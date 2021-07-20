// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Timezone.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class TimezoneEnumWindow
    {
        /// <summary>
        /// Initializes a new instance of the TimezoneEnumWindow class.
        /// </summary>
        public TimezoneEnumWindow()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TimezoneEnumWindow class.
        /// </summary>
        /// <param name="windowsId">Windows Id property</param>
        /// <param name="territory">Territory property</param>
        /// <param name="ianaIds">IanaIds array</param>
        public TimezoneEnumWindow(string windowsId = default(string), string territory = default(string), IList<string> ianaIds = default(IList<string>))
        {
            WindowsId = windowsId;
            Territory = territory;
            IanaIds = ianaIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets windows Id property
        /// </summary>
        [JsonProperty(PropertyName = "WindowsId")]
        public string WindowsId { get; private set; }

        /// <summary>
        /// Gets territory property
        /// </summary>
        [JsonProperty(PropertyName = "Territory")]
        public string Territory { get; private set; }

        /// <summary>
        /// Gets or sets ianaIds array
        /// </summary>
        [JsonProperty(PropertyName = "IanaIds")]
        public IList<string> IanaIds { get; set; }

    }
}
