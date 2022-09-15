﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics;
using NUnit.Framework;

namespace Azure.AI.TextAnalytics.Tests
{
    /// <summary>
    /// The suite of tests for the <see cref="TextAnalyticsModelFactory"/> class.
    /// </summary>
    public class TextAnalyticsModelFactoryTests
    {
        #region Action Result Models

        [Test]
        public void AnalyzeActionsResult()
        {
            var extractKeyPhrasesActionResults = new List<ExtractKeyPhrasesActionResult>()
            {
                TextAnalyticsModelFactory.ExtractKeyPhrasesActionResult(default, default),
                TextAnalyticsModelFactory.ExtractKeyPhrasesActionResult(default, default)
            };

            var recognizeEntitiesActionResults = new List<RecognizeEntitiesActionResult>()
            {
                TextAnalyticsModelFactory.RecognizeEntitiesActionResult(default, default),
                TextAnalyticsModelFactory.RecognizeEntitiesActionResult(default, default)
            };

            var recognizePiiEntitiesActionResults = new List<RecognizePiiEntitiesActionResult>()
            {
                TextAnalyticsModelFactory.RecognizePiiEntitiesActionResult(default, default),
                TextAnalyticsModelFactory.RecognizePiiEntitiesActionResult(default, default)
            };

            var recognizeLinkedEntitiesActionResults = new List<RecognizeLinkedEntitiesActionResult>()
            {
                TextAnalyticsModelFactory.RecognizeLinkedEntitiesActionResult(default, default),
                TextAnalyticsModelFactory.RecognizeLinkedEntitiesActionResult(default, default)
            };

            var analyzeSentimentActionResults = new List<AnalyzeSentimentActionResult>()
            {
                TextAnalyticsModelFactory.AnalyzeSentimentActionResult(default, default),
                TextAnalyticsModelFactory.AnalyzeSentimentActionResult(default, default)
            };

            var recognizeCustomEntitiesActionResults = new List<RecognizeCustomEntitiesActionResult>()
            {
                TextAnalyticsModelFactory.RecognizeCustomEntitiesActionResult(default, default),
                TextAnalyticsModelFactory.RecognizeCustomEntitiesActionResult(default, default)
            };

            var singleLabelClassifyActionResults = new List<SingleLabelClassifyActionResult>()
            {
                TextAnalyticsModelFactory.SingleLabelClassifyActionResult(default, default),
                TextAnalyticsModelFactory.SingleLabelClassifyActionResult(default, default)
            };

            var multiLabelClassifyActionResults = new List<MultiLabelClassifyActionResult>()
            {
                TextAnalyticsModelFactory.MultiLabelClassifyActionResult(default, default),
                TextAnalyticsModelFactory.MultiLabelClassifyActionResult(default, default)
            };

            var actionsResult = TextAnalyticsModelFactory.AnalyzeActionsResult(
                extractKeyPhrasesActionResults,
                recognizeEntitiesActionResults,
                recognizePiiEntitiesActionResults,
                recognizeLinkedEntitiesActionResults,
                analyzeSentimentActionResults);

            CollectionAssert.AreEquivalent(extractKeyPhrasesActionResults, actionsResult.ExtractKeyPhrasesResults);
            CollectionAssert.AreEquivalent(recognizeEntitiesActionResults, actionsResult.RecognizeEntitiesResults);
            CollectionAssert.AreEquivalent(recognizePiiEntitiesActionResults, actionsResult.RecognizePiiEntitiesResults);
            CollectionAssert.AreEquivalent(recognizeLinkedEntitiesActionResults, actionsResult.RecognizeLinkedEntitiesResults);
            CollectionAssert.AreEquivalent(analyzeSentimentActionResults, actionsResult.AnalyzeSentimentResults);

            actionsResult = TextAnalyticsModelFactory.AnalyzeActionsResult(
                extractKeyPhrasesActionResults,
                recognizeEntitiesActionResults,
                recognizePiiEntitiesActionResults,
                recognizeLinkedEntitiesActionResults,
                analyzeSentimentActionResults,
                recognizeCustomEntitiesActionResults,
                singleLabelClassifyActionResults,
                multiLabelClassifyActionResults);

            CollectionAssert.AreEquivalent(extractKeyPhrasesActionResults, actionsResult.ExtractKeyPhrasesResults);
            CollectionAssert.AreEquivalent(recognizeEntitiesActionResults, actionsResult.RecognizeEntitiesResults);
            CollectionAssert.AreEquivalent(recognizePiiEntitiesActionResults, actionsResult.RecognizePiiEntitiesResults);
            CollectionAssert.AreEquivalent(recognizeLinkedEntitiesActionResults, actionsResult.RecognizeLinkedEntitiesResults);
            CollectionAssert.AreEquivalent(analyzeSentimentActionResults, actionsResult.AnalyzeSentimentResults);
            CollectionAssert.AreEquivalent(recognizeCustomEntitiesActionResults, actionsResult.RecognizeCustomEntitiesResults);
            CollectionAssert.AreEquivalent(singleLabelClassifyActionResults, actionsResult.SingleLabelClassifyResults);
            CollectionAssert.AreEquivalent(multiLabelClassifyActionResults, actionsResult.MultiLabelClassifyResults);
        }
        #endregion Action Result Models
    }
}
