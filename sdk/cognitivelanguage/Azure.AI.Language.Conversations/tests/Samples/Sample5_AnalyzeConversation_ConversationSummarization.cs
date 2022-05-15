﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Core.TestFramework;

namespace Azure.AI.Language.Conversations.Tests.Samples
{
    public partial class ConversationAnalysisClientSamples
    {
        [SyncOnly]
        [RecordedTest]
        public void AnalyzeConversation_ConversationSummarization()
        {
            ConversationAnalysisClient client = Client;

            List<TextConversationItem> textConversationItems = new List<TextConversationItem>()
            {
                new TextConversationItem("1", "Agent", "Hello, how can I help you?"),
                new TextConversationItem("2", "Customer", "How to upgrade Office? I am getting error messages the whole day."),
                new TextConversationItem("3", "Agent", "Press the upgrade button please. Then sign in and follow the instructions."),
            };

            List<TextConversation> input = new List<TextConversation>()
            {
                new TextConversation("1", "en", textConversationItems)
            };

            ConversationSummarizationTaskParameters conversationSummarizationTaskParameters = new ConversationSummarizationTaskParameters(new List<SummaryAspect>() { SummaryAspect.Summary, SummaryAspect.Resolution });

            var conversationSummarizationTask = new AnalyzeConversationSummarizationTask("1", AnalyzeConversationLROTaskKind.ConversationalSummarizationTask, conversationSummarizationTaskParameters);
            List<AnalyzeConversationLROTask> tasks = new List<AnalyzeConversationLROTask>()
            {
                conversationSummarizationTask
            };

            var analyzeConversationOperation = client.AnalyzeConversation(input, tasks);
            analyzeConversationOperation.WaitForCompletion();

            var jobResults = analyzeConversationOperation.Value;
            foreach (var result in jobResults.Tasks.Items)
            {
                var analyzeConversationSummarization = result as AnalyzeConversationSummarizationResult;

                var results = analyzeConversationSummarization.Results;

                Console.WriteLine("Conversations:");
                foreach (var conversation in results.Conversations)
                {
                    Console.WriteLine($"Conversation #:{conversation.Id}");
                    Console.WriteLine("Summaries:");
                    foreach (var summary in conversation.Summaries)
                    {
                        Console.WriteLine($"Text: {summary.Text}");
                        Console.WriteLine($"Aspect: {summary.Aspect}");
                    }
                    Console.WriteLine();
                }
            }
        }

        [AsyncOnly]
        [RecordedTest]
        public async Task AnalyzeConversationAsync_ConversationSummarization()
        {
            ConversationAnalysisClient client = Client;

            List<TextConversationItem> textConversationItems = new List<TextConversationItem>()
            {
                new TextConversationItem("1", "Agent", "Hello, how can I help you?"),
                new TextConversationItem("2", "Customer", "How to upgrade Office? I am getting error messages the whole day."),
                new TextConversationItem("3", "Agent", "Press the upgrade button please. Then sign in and follow the instructions."),
            };

            List<TextConversation> input = new List<TextConversation>()
            {
                new TextConversation("1", "en", textConversationItems)
            };

            ConversationSummarizationTaskParameters conversationSummarizationTaskParameters = new ConversationSummarizationTaskParameters(new List<SummaryAspect>() { SummaryAspect.Summary, SummaryAspect.Resolution });

            var conversationSummarizationTask = new AnalyzeConversationSummarizationTask("1", AnalyzeConversationLROTaskKind.ConversationalSummarizationTask, conversationSummarizationTaskParameters);
            List<AnalyzeConversationLROTask> tasks = new List<AnalyzeConversationLROTask>()
            {
                conversationSummarizationTask
            };

            var analyzeConversationOperation = await client.AnalyzeConversationAsync(input, tasks);
            await analyzeConversationOperation.WaitForCompletionAsync();

            var jobResults = analyzeConversationOperation.Value;
            foreach (var result in jobResults.Tasks.Items)
            {
                var analyzeConversationSummarization = result as AnalyzeConversationSummarizationResult;

                var results = analyzeConversationSummarization.Results;

                Console.WriteLine("Conversations:");
                foreach (var conversation in results.Conversations)
                {
                    Console.WriteLine($"Conversation #:{conversation.Id}");
                    Console.WriteLine("Summaries:");
                    foreach (var summary in conversation.Summaries)
                    {
                        Console.WriteLine($"Text: {summary.Text}");
                        Console.WriteLine($"Aspect: {summary.Aspect}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
