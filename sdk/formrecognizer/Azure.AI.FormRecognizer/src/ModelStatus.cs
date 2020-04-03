﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.


using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Training
{

    /// <summary>
    /// </summary>
    [CodeGenModel("ModelStatus")]
#pragma warning disable CA1717 // Only FlagsAttribute enums should have plural names
    public enum CustomFormModelStatus
#pragma warning restore CA1717 // Only FlagsAttribute enums should have plural names
    {
        /// <summary>
        /// </summary>
        [CodeGenMember("creating")]
        Training,

        /// <summary>
        /// </summary>
        Copying,

        /// <summary>
        /// </summary>
        Ready,

        /// <summary>
        /// </summary>
        Invalid
    }
}
