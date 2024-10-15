// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Metadata patch request body. </summary>
    public partial class SecurityInsightsMetadataPatch : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsMetadataPatch"/>. </summary>
        public SecurityInsightsMetadataPatch()
        {
            Providers = new ChangeTrackingList<string>();
            ThreatAnalysisTactics = new ChangeTrackingList<string>();
            ThreatAnalysisTechniques = new ChangeTrackingList<string>();
            PreviewImages = new ChangeTrackingList<string>();
            PreviewImagesDark = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsMetadataPatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="contentId"> Static ID for the content.  Used to identify dependencies and content from solutions or community.  Hard-coded/static for out of the box content and solutions. Dynamic for user-created.  This is the resource name. </param>
        /// <param name="parentId"> Full parent resource ID of the content item the metadata is for.  This is the full resource ID including the scope (subscription and resource group). </param>
        /// <param name="version"> Version of the content.  Default and recommended format is numeric (e.g. 1, 1.0, 1.0.0, 1.0.0.0), following ARM template best practices.  Can also be any string, but then we cannot guarantee any version checks. </param>
        /// <param name="kind"> The kind of content the metadata is for. </param>
        /// <param name="source"> Source of the content.  This is where/how it was created. </param>
        /// <param name="author"> The creator of the content item. </param>
        /// <param name="support"> Support information for the metadata - type, name, contact information. </param>
        /// <param name="dependencies"> Dependencies for the content item, what other content items it requires to work.  Can describe more complex dependencies using a recursive/nested structure. For a single dependency an id/kind/version can be supplied or operator/criteria for complex formats. </param>
        /// <param name="categories"> Categories for the solution content item. </param>
        /// <param name="providers"> Providers for the solution content item. </param>
        /// <param name="firstPublishOn"> first publish date solution content item. </param>
        /// <param name="lastPublishOn"> last publish date for the solution content item. </param>
        /// <param name="customVersion"> The custom version of the content. A optional free text. </param>
        /// <param name="contentSchemaVersion"> Schema version of the content. Can be used to distinguish between different flow based on the schema version. </param>
        /// <param name="icon"> the icon identifier. this id can later be fetched from the solution template. </param>
        /// <param name="threatAnalysisTactics"> the tactics the resource covers. </param>
        /// <param name="threatAnalysisTechniques"> the techniques the resource covers, these have to be aligned with the tactics being used. </param>
        /// <param name="previewImages"> preview image file names. These will be taken from the solution artifacts. </param>
        /// <param name="previewImagesDark"> preview image file names. These will be taken from the solution artifacts. used for dark theme support. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsMetadataPatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string contentId, string parentId, string version, string kind, SecurityInsightsMetadataSource source, SecurityInsightsMetadataAuthor author, SecurityInsightsMetadataSupport support, SecurityInsightsMetadataDependencies dependencies, SecurityInsightsMetadataCategories categories, IList<string> providers, DateTimeOffset? firstPublishOn, DateTimeOffset? lastPublishOn, string customVersion, string contentSchemaVersion, string icon, IList<string> threatAnalysisTactics, IList<string> threatAnalysisTechniques, IList<string> previewImages, IList<string> previewImagesDark, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ContentId = contentId;
            ParentId = parentId;
            Version = version;
            Kind = kind;
            Source = source;
            Author = author;
            Support = support;
            Dependencies = dependencies;
            Categories = categories;
            Providers = providers;
            FirstPublishOn = firstPublishOn;
            LastPublishOn = lastPublishOn;
            CustomVersion = customVersion;
            ContentSchemaVersion = contentSchemaVersion;
            Icon = icon;
            ThreatAnalysisTactics = threatAnalysisTactics;
            ThreatAnalysisTechniques = threatAnalysisTechniques;
            PreviewImages = previewImages;
            PreviewImagesDark = previewImagesDark;
            ETag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Static ID for the content.  Used to identify dependencies and content from solutions or community.  Hard-coded/static for out of the box content and solutions. Dynamic for user-created.  This is the resource name. </summary>
        [WirePath("properties.contentId")]
        public string ContentId { get; set; }
        /// <summary> Full parent resource ID of the content item the metadata is for.  This is the full resource ID including the scope (subscription and resource group). </summary>
        [WirePath("properties.parentId")]
        public string ParentId { get; set; }
        /// <summary> Version of the content.  Default and recommended format is numeric (e.g. 1, 1.0, 1.0.0, 1.0.0.0), following ARM template best practices.  Can also be any string, but then we cannot guarantee any version checks. </summary>
        [WirePath("properties.version")]
        public string Version { get; set; }
        /// <summary> The kind of content the metadata is for. </summary>
        [WirePath("properties.kind")]
        public string Kind { get; set; }
        /// <summary> Source of the content.  This is where/how it was created. </summary>
        [WirePath("properties.source")]
        public SecurityInsightsMetadataSource Source { get; set; }
        /// <summary> The creator of the content item. </summary>
        [WirePath("properties.author")]
        public SecurityInsightsMetadataAuthor Author { get; set; }
        /// <summary> Support information for the metadata - type, name, contact information. </summary>
        [WirePath("properties.support")]
        public SecurityInsightsMetadataSupport Support { get; set; }
        /// <summary> Dependencies for the content item, what other content items it requires to work.  Can describe more complex dependencies using a recursive/nested structure. For a single dependency an id/kind/version can be supplied or operator/criteria for complex formats. </summary>
        [WirePath("properties.dependencies")]
        public SecurityInsightsMetadataDependencies Dependencies { get; set; }
        /// <summary> Categories for the solution content item. </summary>
        [WirePath("properties.categories")]
        public SecurityInsightsMetadataCategories Categories { get; set; }
        /// <summary> Providers for the solution content item. </summary>
        [WirePath("properties.providers")]
        public IList<string> Providers { get; }
        /// <summary> first publish date solution content item. </summary>
        [WirePath("properties.firstPublishDate")]
        public DateTimeOffset? FirstPublishOn { get; set; }
        /// <summary> last publish date for the solution content item. </summary>
        [WirePath("properties.lastPublishDate")]
        public DateTimeOffset? LastPublishOn { get; set; }
        /// <summary> The custom version of the content. A optional free text. </summary>
        [WirePath("properties.customVersion")]
        public string CustomVersion { get; set; }
        /// <summary> Schema version of the content. Can be used to distinguish between different flow based on the schema version. </summary>
        [WirePath("properties.contentSchemaVersion")]
        public string ContentSchemaVersion { get; set; }
        /// <summary> the icon identifier. this id can later be fetched from the solution template. </summary>
        [WirePath("properties.icon")]
        public string Icon { get; set; }
        /// <summary> the tactics the resource covers. </summary>
        [WirePath("properties.threatAnalysisTactics")]
        public IList<string> ThreatAnalysisTactics { get; }
        /// <summary> the techniques the resource covers, these have to be aligned with the tactics being used. </summary>
        [WirePath("properties.threatAnalysisTechniques")]
        public IList<string> ThreatAnalysisTechniques { get; }
        /// <summary> preview image file names. These will be taken from the solution artifacts. </summary>
        [WirePath("properties.previewImages")]
        public IList<string> PreviewImages { get; }
        /// <summary> preview image file names. These will be taken from the solution artifacts. used for dark theme support. </summary>
        [WirePath("properties.previewImagesDark")]
        public IList<string> PreviewImagesDark { get; }
        /// <summary> Etag of the azure resource. </summary>
        [WirePath("etag")]
        public ETag? ETag { get; set; }
    }
}
