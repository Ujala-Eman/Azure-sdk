// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Represents service-level resource counters and quotas. </summary>
    public partial class SearchServiceCounters
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SearchServiceCounters"/>. </summary>
        /// <param name="documentCounter"> Total number of documents across all indexes in the service. </param>
        /// <param name="indexCounter"> Total number of indexes. </param>
        /// <param name="indexerCounter"> Total number of indexers. </param>
        /// <param name="dataSourceCounter"> Total number of data sources. </param>
        /// <param name="storageSizeCounter"> Total size of used storage in bytes. </param>
        /// <param name="synonymMapCounter"> Total number of synonym maps. </param>
        /// <param name="vectorIndexSizeCounter"> Total memory consumption of all vector indexes within the service, in bytes. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="documentCounter"/>, <paramref name="indexCounter"/>, <paramref name="indexerCounter"/>, <paramref name="dataSourceCounter"/>, <paramref name="storageSizeCounter"/>, <paramref name="synonymMapCounter"/> or <paramref name="vectorIndexSizeCounter"/> is null. </exception>
        internal SearchServiceCounters(SearchResourceCounter documentCounter, SearchResourceCounter indexCounter, SearchResourceCounter indexerCounter, SearchResourceCounter dataSourceCounter, SearchResourceCounter storageSizeCounter, SearchResourceCounter synonymMapCounter, SearchResourceCounter vectorIndexSizeCounter)
        {
            Argument.AssertNotNull(documentCounter, nameof(documentCounter));
            Argument.AssertNotNull(indexCounter, nameof(indexCounter));
            Argument.AssertNotNull(indexerCounter, nameof(indexerCounter));
            Argument.AssertNotNull(dataSourceCounter, nameof(dataSourceCounter));
            Argument.AssertNotNull(storageSizeCounter, nameof(storageSizeCounter));
            Argument.AssertNotNull(synonymMapCounter, nameof(synonymMapCounter));
            Argument.AssertNotNull(vectorIndexSizeCounter, nameof(vectorIndexSizeCounter));

            DocumentCounter = documentCounter;
            IndexCounter = indexCounter;
            IndexerCounter = indexerCounter;
            DataSourceCounter = dataSourceCounter;
            StorageSizeCounter = storageSizeCounter;
            SynonymMapCounter = synonymMapCounter;
            VectorIndexSizeCounter = vectorIndexSizeCounter;
        }

        /// <summary> Initializes a new instance of <see cref="SearchServiceCounters"/>. </summary>
        /// <param name="documentCounter"> Total number of documents across all indexes in the service. </param>
        /// <param name="indexCounter"> Total number of indexes. </param>
        /// <param name="indexerCounter"> Total number of indexers. </param>
        /// <param name="dataSourceCounter"> Total number of data sources. </param>
        /// <param name="storageSizeCounter"> Total size of used storage in bytes. </param>
        /// <param name="synonymMapCounter"> Total number of synonym maps. </param>
        /// <param name="skillsetCounter"> Total number of skillsets. </param>
        /// <param name="vectorIndexSizeCounter"> Total memory consumption of all vector indexes within the service, in bytes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SearchServiceCounters(SearchResourceCounter documentCounter, SearchResourceCounter indexCounter, SearchResourceCounter indexerCounter, SearchResourceCounter dataSourceCounter, SearchResourceCounter storageSizeCounter, SearchResourceCounter synonymMapCounter, SearchResourceCounter skillsetCounter, SearchResourceCounter vectorIndexSizeCounter, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DocumentCounter = documentCounter;
            IndexCounter = indexCounter;
            IndexerCounter = indexerCounter;
            DataSourceCounter = dataSourceCounter;
            StorageSizeCounter = storageSizeCounter;
            SynonymMapCounter = synonymMapCounter;
            SkillsetCounter = skillsetCounter;
            VectorIndexSizeCounter = vectorIndexSizeCounter;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SearchServiceCounters"/> for deserialization. </summary>
        internal SearchServiceCounters()
        {
        }

        /// <summary> Total number of documents across all indexes in the service. </summary>
        public SearchResourceCounter DocumentCounter { get; }
        /// <summary> Total number of indexes. </summary>
        public SearchResourceCounter IndexCounter { get; }
        /// <summary> Total number of indexers. </summary>
        public SearchResourceCounter IndexerCounter { get; }
        /// <summary> Total number of data sources. </summary>
        public SearchResourceCounter DataSourceCounter { get; }
        /// <summary> Total size of used storage in bytes. </summary>
        public SearchResourceCounter StorageSizeCounter { get; }
        /// <summary> Total number of synonym maps. </summary>
        public SearchResourceCounter SynonymMapCounter { get; }
        /// <summary> Total number of skillsets. </summary>
        public SearchResourceCounter SkillsetCounter { get; }
        /// <summary> Total memory consumption of all vector indexes within the service, in bytes. </summary>
        public SearchResourceCounter VectorIndexSizeCounter { get; }
    }
}
