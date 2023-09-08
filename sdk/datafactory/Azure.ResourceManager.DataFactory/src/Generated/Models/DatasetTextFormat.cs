// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The data stored in text format. </summary>
    public partial class DatasetTextFormat : DatasetStorageFormat
    {
        /// <summary> Initializes a new instance of DatasetTextFormat. </summary>
        public DatasetTextFormat()
        {
            DatasetStorageFormatType = "TextFormat";
        }

        /// <summary> Initializes a new instance of DatasetTextFormat. </summary>
        /// <param name="datasetStorageFormatType"> Type of dataset storage format. </param>
        /// <param name="serializer"> Serializer. Type: string (or Expression with resultType string). </param>
        /// <param name="deserializer"> Deserializer. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="columnDelimiter"> The column delimiter. Type: string (or Expression with resultType string). </param>
        /// <param name="rowDelimiter"> The row delimiter. Type: string (or Expression with resultType string). </param>
        /// <param name="escapeChar"> The escape character. Type: string (or Expression with resultType string). </param>
        /// <param name="quoteChar"> The quote character. Type: string (or Expression with resultType string). </param>
        /// <param name="nullValue"> The null value string. Type: string (or Expression with resultType string). </param>
        /// <param name="encodingName"> The code page name of the preferred encoding. If miss, the default value is ΓÇ£utf-8ΓÇ¥, unless BOM denotes another Unicode encoding. Refer to the ΓÇ£NameΓÇ¥ column of the table in the following link to set supported values: https://msdn.microsoft.com/library/system.text.encoding.aspx. Type: string (or Expression with resultType string). </param>
        /// <param name="treatEmptyAsNull"> Treat empty column values in the text file as null. The default value is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="skipLineCount"> The number of lines/rows to be skipped when parsing text files. The default value is 0. Type: integer (or Expression with resultType integer). </param>
        /// <param name="firstRowAsHeader"> When used as input, treat the first row of data as headers. When used as output,write the headers into the output as the first row of data. The default value is false. Type: boolean (or Expression with resultType boolean). </param>
        internal DatasetTextFormat(string datasetStorageFormatType, DataFactoryElement<string> serializer, DataFactoryElement<string> deserializer, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> columnDelimiter, DataFactoryElement<string> rowDelimiter, DataFactoryElement<string> escapeChar, DataFactoryElement<string> quoteChar, DataFactoryElement<string> nullValue, DataFactoryElement<string> encodingName, DataFactoryElement<bool> treatEmptyAsNull, DataFactoryElement<int> skipLineCount, DataFactoryElement<bool> firstRowAsHeader) : base(datasetStorageFormatType, serializer, deserializer, additionalProperties)
        {
            ColumnDelimiter = columnDelimiter;
            RowDelimiter = rowDelimiter;
            EscapeChar = escapeChar;
            QuoteChar = quoteChar;
            NullValue = nullValue;
            EncodingName = encodingName;
            TreatEmptyAsNull = treatEmptyAsNull;
            SkipLineCount = skipLineCount;
            FirstRowAsHeader = firstRowAsHeader;
            DatasetStorageFormatType = datasetStorageFormatType ?? "TextFormat";
        }

        /// <summary> The column delimiter. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ColumnDelimiter { get; set; }
        /// <summary> The row delimiter. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> RowDelimiter { get; set; }
        /// <summary> The escape character. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> EscapeChar { get; set; }
        /// <summary> The quote character. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> QuoteChar { get; set; }
        /// <summary> The null value string. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> NullValue { get; set; }
        /// <summary> The code page name of the preferred encoding. If miss, the default value is ΓÇ£utf-8ΓÇ¥, unless BOM denotes another Unicode encoding. Refer to the ΓÇ£NameΓÇ¥ column of the table in the following link to set supported values: https://msdn.microsoft.com/library/system.text.encoding.aspx. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> EncodingName { get; set; }
        /// <summary> Treat empty column values in the text file as null. The default value is true. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> TreatEmptyAsNull { get; set; }
        /// <summary> The number of lines/rows to be skipped when parsing text files. The default value is 0. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> SkipLineCount { get; set; }
        /// <summary> When used as input, treat the first row of data as headers. When used as output,write the headers into the output as the first row of data. The default value is false. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> FirstRowAsHeader { get; set; }
    }
}
