// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the request body for resource move operation. </summary>
    public partial class MoverResourceMoveContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MoverResourceMoveContent"/>. </summary>
        /// <param name="moverResources"> Gets or sets the list of resource Id's, by default it accepts move resource id's unless the input type is switched via moveResourceInputType property. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="moverResources"/> is null. </exception>
        public MoverResourceMoveContent(IEnumerable<ResourceIdentifier> moverResources)
        {
            Argument.AssertNotNull(moverResources, nameof(moverResources));

            MoverResources = moverResources.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="MoverResourceMoveContent"/>. </summary>
        /// <param name="validateOnly"> Gets or sets a value indicating whether the operation needs to only run pre-requisite. </param>
        /// <param name="moverResources"> Gets or sets the list of resource Id's, by default it accepts move resource id's unless the input type is switched via moveResourceInputType property. </param>
        /// <param name="moverResourceInputType"> Defines the move resource input type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MoverResourceMoveContent(bool? validateOnly, IList<ResourceIdentifier> moverResources, MoverResourceInputType? moverResourceInputType, Dictionary<string, BinaryData> rawData)
        {
            ValidateOnly = validateOnly;
            MoverResources = moverResources;
            MoverResourceInputType = moverResourceInputType;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="MoverResourceMoveContent"/> for deserialization. </summary>
        internal MoverResourceMoveContent()
        {
        }

        /// <summary> Gets or sets a value indicating whether the operation needs to only run pre-requisite. </summary>
        public bool? ValidateOnly { get; set; }
        /// <summary> Gets or sets the list of resource Id's, by default it accepts move resource id's unless the input type is switched via moveResourceInputType property. </summary>
        public IList<ResourceIdentifier> MoverResources { get; }
        /// <summary> Defines the move resource input type. </summary>
        public MoverResourceInputType? MoverResourceInputType { get; set; }
    }
}
