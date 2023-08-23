// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> Attaches worker selectors to a job when a RouterRule is resolved. </summary>
    public partial class RuleEngineWorkerSelectorAttachment : WorkerSelectorAttachment
    {
        /// <summary> Initializes a new instance of RuleEngineWorkerSelectorAttachment. </summary>
        /// <param name="rule">
        /// A rule of one of the following types:
        ///
        /// StaticRule:  A rule providing static rules that always return the same result, regardless of input.
        /// DirectMapRule:  A rule that return the same labels as the input labels.
        /// ExpressionRule: A rule providing inline expression rules.
        /// AzureFunctionRule: A rule providing a binding to an HTTP Triggered Azure Function.
        /// WebhookRule: A rule providing a binding to a webserver following OAuth2.0 authentication protocol.
        /// Please note <see cref="RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FunctionRouterRule"/>, <see cref="DirectMapRouterRule"/>, <see cref="ExpressionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="WebhookRouterRule"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="rule"/> is null. </exception>
        public RuleEngineWorkerSelectorAttachment(RouterRule rule)
        {
            Argument.AssertNotNull(rule, nameof(rule));

            Rule = rule;
            Kind = "rule-engine";
        }

        /// <summary> Initializes a new instance of RuleEngineWorkerSelectorAttachment. </summary>
        /// <param name="kind"> The type discriminator describing the type of worker selector attachment. </param>
        /// <param name="rule">
        /// A rule of one of the following types:
        ///
        /// StaticRule:  A rule providing static rules that always return the same result, regardless of input.
        /// DirectMapRule:  A rule that return the same labels as the input labels.
        /// ExpressionRule: A rule providing inline expression rules.
        /// AzureFunctionRule: A rule providing a binding to an HTTP Triggered Azure Function.
        /// WebhookRule: A rule providing a binding to a webserver following OAuth2.0 authentication protocol.
        /// Please note <see cref="RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FunctionRouterRule"/>, <see cref="DirectMapRouterRule"/>, <see cref="ExpressionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="WebhookRouterRule"/>.
        /// </param>
        internal RuleEngineWorkerSelectorAttachment(string kind, RouterRule rule) : base(kind)
        {
            Rule = rule;
            Kind = kind ?? "rule-engine";
        }

        /// <summary>
        /// A rule of one of the following types:
        ///
        /// StaticRule:  A rule providing static rules that always return the same result, regardless of input.
        /// DirectMapRule:  A rule that return the same labels as the input labels.
        /// ExpressionRule: A rule providing inline expression rules.
        /// AzureFunctionRule: A rule providing a binding to an HTTP Triggered Azure Function.
        /// WebhookRule: A rule providing a binding to a webserver following OAuth2.0 authentication protocol.
        /// Please note <see cref="RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FunctionRouterRule"/>, <see cref="DirectMapRouterRule"/>, <see cref="ExpressionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="WebhookRouterRule"/>.
        /// </summary>
        public RouterRule Rule { get; set; }
    }
}
