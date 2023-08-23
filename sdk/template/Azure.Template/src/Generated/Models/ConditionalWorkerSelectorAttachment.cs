// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> Describes a set of worker selectors that will be attached if the given condition resolves to true. </summary>
    public partial class ConditionalWorkerSelectorAttachment : WorkerSelectorAttachment
    {
        /// <summary> Initializes a new instance of ConditionalWorkerSelectorAttachment. </summary>
        /// <param name="condition">
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
        /// <param name="workerSelectors"> The worker selectors to attach. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="condition"/> or <paramref name="workerSelectors"/> is null. </exception>
        public ConditionalWorkerSelectorAttachment(RouterRule condition, IEnumerable<RouterWorkerSelector> workerSelectors)
        {
            Argument.AssertNotNull(condition, nameof(condition));
            Argument.AssertNotNull(workerSelectors, nameof(workerSelectors));

            Condition = condition;
            WorkerSelectors = workerSelectors.ToList();
            Kind = "conditional";
        }

        /// <summary> Initializes a new instance of ConditionalWorkerSelectorAttachment. </summary>
        /// <param name="kind"> The type discriminator describing the type of worker selector attachment. </param>
        /// <param name="condition">
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
        /// <param name="workerSelectors"> The worker selectors to attach. </param>
        internal ConditionalWorkerSelectorAttachment(string kind, RouterRule condition, IList<RouterWorkerSelector> workerSelectors) : base(kind)
        {
            Condition = condition;
            WorkerSelectors = workerSelectors;
            Kind = kind ?? "conditional";
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
        public RouterRule Condition { get; set; }
        /// <summary> The worker selectors to attach. </summary>
        public IList<RouterWorkerSelector> WorkerSelectors { get; }
    }
}
