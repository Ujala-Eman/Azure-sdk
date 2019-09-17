﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Text.Json;

//namespace Azure.AI.InkRecognizer
namespace Azure.Data.InkRecognizer
{
    public class InkRecognitionRequest
    {
        private ApplicationKind ApplicationType { get; set; }

        private string Language { get; set; }

        private InkPointUnit InkPointUnit { get; set; }

        private float UnitMultiple { get; set; }

        private IEnumerable<InkStroke> _strokes { get; set; }

        internal InkRecognitionRequest(IEnumerable<InkStroke> strokes,
            ApplicationKind applicationType,
            string language,
            InkPointUnit inkPointUnit,
            float unitMultiple)
        {
            _strokes = strokes;
            ApplicationType = applicationType;
            Language = language;
            InkPointUnit = inkPointUnit;
            UnitMultiple = unitMultiple;
        }

        internal string ToJson()
        {
            MemoryStream jsonStream = new MemoryStream();
            var jsonWriter = new Utf8JsonWriter(jsonStream);

            jsonWriter.WriteStartObject();

            jsonWriter.WriteString("applicationType", _getApplicationTypeString());
            jsonWriter.WriteString("language", Language);
            jsonWriter.WriteString("unit", GetInkPointUnitString());
            jsonWriter.WriteNumber("unitMultiple", UnitMultiple);

            jsonWriter.WriteStartArray("strokes");
            foreach (var stroke in _strokes)
            {
                jsonWriter.WriteStartObject();
                jsonWriter.WriteNumber("id", stroke.Id);
                if (stroke.Kind != InkStrokeKind.Unknown)
                {
                    jsonWriter.WriteString("kind", GetStrokeKindString(stroke.Kind));
                }

                jsonWriter.WriteStartArray("points");
                foreach (var point in stroke.GetInkPoints())
                {
                    jsonWriter.WriteStartObject();
                    jsonWriter.WriteNumber("x", point.X);
                    jsonWriter.WriteNumber("y", point.Y);
                    jsonWriter.WriteEndObject();
                }
                jsonWriter.WriteEndArray();

                if (stroke.Language != null)
                {
                    jsonWriter.WriteString("language", stroke.Language);
                }
                jsonWriter.WriteEndObject();
            }
            jsonWriter.WriteEndArray();

            jsonWriter.WriteEndObject();
            jsonWriter.Flush();
            return Encoding.UTF8.GetString(jsonStream.ToArray());
        }

        private string GetInkPointUnitString()
        {
            switch (InkPointUnit)
            {
                case InkPointUnit.Inch:
                    return "in";
                case InkPointUnit.Cm:
                    return "cm";
                case InkPointUnit.Mm:
                    return "mm";
                default:
                    throw new InvalidEnumArgumentException("Invalid value for InkPointUnit");
            }
        }

        private string _getApplicationTypeString()
        {
            switch (ApplicationType)
            {
                case ApplicationKind.Writing:
                    return "writing";
                case ApplicationKind.Drawing:
                    return "drawing";
                case ApplicationKind.Mixed:
                    return "mixed";
                default:
                    throw new InvalidEnumArgumentException("Invalid value for ApplicationKind");
            }
        }

        private static string GetStrokeKindString(InkStrokeKind strokeKind)
        {
            switch (strokeKind)
            {
                case InkStrokeKind.InkWriting:
                    return "inkWriting";
                case InkStrokeKind.InkDrawing:
                    return "inkDrawing";
                default:
                    throw new InvalidEnumArgumentException("Invalid value for Stroke Kind");
            }
        }
    }
}
