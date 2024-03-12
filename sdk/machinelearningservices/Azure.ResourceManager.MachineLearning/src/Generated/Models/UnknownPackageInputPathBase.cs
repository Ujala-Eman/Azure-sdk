// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Unknown version of PackageInputPathBase. </summary>
    internal partial class UnknownPackageInputPathBase : PackageInputPathBase
    {
        /// <summary> Initializes a new instance of <see cref="UnknownPackageInputPathBase"/>. </summary>
        /// <param name="inputPathType"> [Required] Input path type for package inputs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownPackageInputPathBase(InputPathType inputPathType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(inputPathType, serializedAdditionalRawData)
        {
            InputPathType = inputPathType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownPackageInputPathBase"/> for deserialization. </summary>
        internal UnknownPackageInputPathBase()
        {
        }
    }
}
