﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace Azure.AI.Inference.Telemetry
{
    internal class StreamingRecordedResponse : AbstractRecordedResponse
    {
        private readonly StringBuilder _contents = new();
        private readonly bool _traceContent;
        private readonly List<ToolCall?> _toolCalls = new();
        private List<string> _finishReasons = new(4);

        /// <summary>
        /// Construct the streaming response based on first returned item.
        /// <param name="traceContent">If true the messages and function names will be recorded.</param>
        /// </summary>
        public StreamingRecordedResponse(bool traceContent)
        {
            _traceContent = traceContent;
        }

        public override string[] FinishReasons { get { return _finishReasons.ToArray(); } }

        private struct ToolCall
        {
            public string Name { get; set; }
            public string Id { get; set; }
            public StringBuilder Content { get; set; }

            public ToolCall(string name, string id, bool traceContent)
            {
                Name = name;
                Id = id;
                Content = traceContent ? new StringBuilder() : null;
            }
        }

        public void Update(StreamingChatCompletionsUpdate item)
        {
            Model = item.Model;
            Id = item.Id;

            if (item.Choices != null)
            {
                foreach (var choice in item.Choices)
                {
                    if (choice.FinishReason != null)
                    {
                        SetFinishReason(choice.Index, choice.FinishReason.ToString());
                    }
                }
            }
            else if (item.FinishReason != null)
            {
                SetFinishReason(0, item.FinishReason.ToString());
            }

            if (item.Usage != null)
            {
                CompletionTokens = item.Usage.CompletionTokens;
                PromptTokens = item.Usage.PromptTokens;
            }

            if (_traceContent && item.ContentUpdate != null)
            {
                _contents.Append(item.ContentUpdate);
            }

            if (item.ToolCallUpdate != null)
            {
                var toolCall = GetOrCreateToolCall(item.ToolCallUpdate);

                if (item.ToolCallUpdate is StreamingFunctionToolCallUpdate functionCall)
                {
                    toolCall.Content?.Append(functionCall.ArgumentsUpdate);
                }
            }
        }

        private object[] GetToolCalls()
        {
            if (_toolCalls.Any())
            {
                return _toolCalls.Select(c => new
                {
                    id = c?.Id,
                    type = "function",
                    function = new
                    {
                        name = c?.Name,
                        arguments = c?.Content?.ToString()
                    }
                }).ToArray();
            }

            return null;
        }

        public override string[] GetSerializedCompletions() {

            var choiceEvent = new {
                finish_reason = _finishReasons.Count > 0 ? _finishReasons[0].ToString() : null,
                index = 0,
                message = new {
                    content = _traceContent ? _contents.ToString() : null,
                    tool_calls = GetToolCalls()
                }
            };
            return new string[] { JsonSerializer.Serialize(choiceEvent) };
        }

        private void SetFinishReason(int index, string value)
        {
            while (_finishReasons.Count <= index)
            {
                _finishReasons.Add(null);
            }
            _finishReasons[index] = value;
        }

        private ToolCall GetOrCreateToolCall(StreamingToolCallUpdate call)
        {
            while (_toolCalls.Count <= call.ToolCallIndex)
            {
                _toolCalls.Add(null);
            }

            if (_toolCalls[call.ToolCallIndex] == null)
            {
                _toolCalls[call.ToolCallIndex] = new ToolCall(call is StreamingFunctionToolCallUpdate funcCall ? funcCall.Name : null, call.Id, _traceContent);
            }

            return _toolCalls[call.ToolCallIndex].Value;
        }
    }
}
