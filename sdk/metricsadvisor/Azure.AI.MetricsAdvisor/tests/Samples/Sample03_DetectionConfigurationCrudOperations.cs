﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.AI.MetricsAdvisor.Administration;
using Azure.AI.MetricsAdvisor.Models;
using Azure.AI.MetricsAdvisor.Tests;
using NUnit.Framework;

namespace Azure.AI.MetricsAdvisor.Samples
{
    public partial class MetricsAdvisorSamples : MetricsAdvisorTestEnvironment
    {
        [Test]
        public async Task CreateAndDeleteDetectionConfigurationAsync()
        {
            string endpoint = MetricsAdvisorUri;
            string subscriptionKey = MetricsAdvisorSubscriptionKey;
            string apiKey = MetricsAdvisorApiKey;
            var credential = new MetricsAdvisorKeyCredential(subscriptionKey, apiKey);

            var adminClient = new MetricsAdvisorAdministrationClient(new Uri(endpoint), credential);

            #region Snippet:CreateDetectionConfigurationAsync
#if SNIPPET
            string metricId = "<metricId>";
            string configurationName = "<configurationName>";
#else
            string metricId = MetricId;
            string configurationName = GetUniqueName();
#endif

            var detectionConfiguration = new AnomalyDetectionConfiguration()
            {
                MetricId = metricId,
                Name = configurationName,
                WholeSeriesDetectionConditions = new MetricWholeSeriesDetectionCondition()
            };

            var detectCondition = detectionConfiguration.WholeSeriesDetectionConditions;

            var hardSuppress = new SuppressCondition(1, 100);
            detectCondition.HardThresholdCondition = new HardThresholdCondition(AnomalyDetectorDirection.Down, hardSuppress)
            {
                LowerBound = 5.0
            };

            var smartSuppress = new SuppressCondition(4, 50);
            detectCondition.SmartDetectionCondition = new SmartDetectionCondition(10.0, AnomalyDetectorDirection.Up, smartSuppress);

            detectCondition.CrossConditionsOperator = DetectionConditionsOperator.Or;

            Response<AnomalyDetectionConfiguration> response = await adminClient.CreateDetectionConfigurationAsync(detectionConfiguration);

            AnomalyDetectionConfiguration createdDetectionConfiguration = response.Value;

            Console.WriteLine($"Anomaly detection configuration ID: {createdDetectionConfiguration.Id}");
            #endregion

            // Delete the created anomaly detection configuration to clean up the Metrics Advisor resource.
            // Do not perform this step if you intend to keep using the configuration.

            await adminClient.DeleteDetectionConfigurationAsync(createdDetectionConfiguration.Id);
        }

        [Test]
        public async Task GetDetectionConfigurationAsync()
        {
            string endpoint = MetricsAdvisorUri;
            string subscriptionKey = MetricsAdvisorSubscriptionKey;
            string apiKey = MetricsAdvisorApiKey;
            var credential = new MetricsAdvisorKeyCredential(subscriptionKey, apiKey);

            var adminClient = new MetricsAdvisorAdministrationClient(new Uri(endpoint), credential);

            string detectionConfigurationId = DetectionConfigurationId;

            Response<AnomalyDetectionConfiguration> response = await adminClient.GetDetectionConfigurationAsync(detectionConfigurationId);

            AnomalyDetectionConfiguration detectionConfiguration = response.Value;

            Console.WriteLine($"Detection configuration metric ID: {detectionConfiguration.MetricId}");
            Console.WriteLine($"Detection configuration name: {detectionConfiguration.Name}");
            Console.WriteLine($"Detection configuration description: {detectionConfiguration.Description}");
        }

        [Test]
        public async Task UpdateDetectionConfigurationAsync()
        {
            string endpoint = MetricsAdvisorUri;
            string subscriptionKey = MetricsAdvisorSubscriptionKey;
            string apiKey = MetricsAdvisorApiKey;
            var credential = new MetricsAdvisorKeyCredential(subscriptionKey, apiKey);

            var adminClient = new MetricsAdvisorAdministrationClient(new Uri(endpoint), credential);

            string detectionConfigurationId = DetectionConfigurationId;

            Response<AnomalyDetectionConfiguration> response = await adminClient.GetDetectionConfigurationAsync(detectionConfigurationId);
            AnomalyDetectionConfiguration detectionConfiguration = response.Value;

            string originalDescription = detectionConfiguration.Description;
            detectionConfiguration.Description = "This description was generated by a sample.";

            response = await adminClient.UpdateDetectionConfigurationAsync(detectionConfiguration);
            AnomalyDetectionConfiguration updatedDetectionConfiguration = response.Value;

            Console.WriteLine($"Updated description: {updatedDetectionConfiguration.Description}");

            // Undo the changes to leave the detection configuration unaltered. Skip this step if you intend to keep
            // the changes.

            detectionConfiguration.Description = originalDescription;
            await adminClient.UpdateDetectionConfigurationAsync(detectionConfiguration);
        }

        [Test]
        public async Task GetDetectionConfigurationsAsync()
        {
            string endpoint = MetricsAdvisorUri;
            string subscriptionKey = MetricsAdvisorSubscriptionKey;
            string apiKey = MetricsAdvisorApiKey;
            var credential = new MetricsAdvisorKeyCredential(subscriptionKey, apiKey);

            var adminClient = new MetricsAdvisorAdministrationClient(new Uri(endpoint), credential);

            string metricId = MetricId;

            int configCount = 0;

            await foreach (AnomalyDetectionConfiguration detectionConfiguration in adminClient.GetDetectionConfigurationsAsync(metricId))
            {
                Console.WriteLine($"Detection configuration ID: {detectionConfiguration.Id}");
                Console.WriteLine($"Name: {detectionConfiguration.Name}");
                Console.WriteLine($"Description: {detectionConfiguration.Description}");
                Console.WriteLine();

                // Print at most 5 detection configurations.
                if (++configCount >= 5)
                {
                    break;
                }
            }
        }
    }
}
