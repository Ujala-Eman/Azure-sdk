// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The expression traces. </summary>
    internal partial class ExpressionTraces
    {
        /// <summary> Initializes a new instance of ExpressionTraces. </summary>
        internal ExpressionTraces()
        {
            Inputs = new ChangeTrackingList<LogicExpressionRoot>();
        }

        /// <summary> Initializes a new instance of ExpressionTraces. </summary>
        /// <param name="inputs"></param>
        internal ExpressionTraces(IReadOnlyList<LogicExpressionRoot> inputs)
        {
            Inputs = inputs;
        }

        /// <summary> Gets the inputs. </summary>
        public IReadOnlyList<LogicExpressionRoot> Inputs { get; }
    }
}
