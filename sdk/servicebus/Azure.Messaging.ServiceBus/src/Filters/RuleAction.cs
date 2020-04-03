// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Messaging.ServiceBus.Filters
{
    using System;

    /// <summary>
    /// Represents the filter actions which are allowed for the transformation
    /// of a message that have been matched by a filter expression.
    /// </summary>
    /// <remarks>
    /// Filter actions allow for the transformation of a message that have been matched by a filter expression.
    /// The typical use case for filter actions is to append or update the properties that are attached to a message,
    /// for example assigning a group ID based on the correlation ID of a message.
    /// </remarks>
    /// <seealso cref="SqlRuleAction"/>
    internal abstract class RuleAction : IEquatable<RuleAction>
    {
        internal RuleAction()
        {
            // This is intentionally left blank. This constructor exists
            // only to prevent external assemblies inheriting from it.
        }

        /// <inheritdoc/>
        public abstract bool Equals(RuleAction other);
    }
}
