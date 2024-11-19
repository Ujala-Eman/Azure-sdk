// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Health.Deidentification.Tests
{
    [TestFixture]
    public class JobOperationsTest : DeidentificationTestBase
    {
        private const string OUTPUT_FOLDER = "_output";

        public JobOperationsTest() : base(true)
        {
        }

        public JobOperationsTest(bool isAsync) : base(isAsync)
        {
        }

        [Test]
        public async Task CreateJobAsync_SucceedsWithExpectedFields()
        {
            DeidentificationClient client = GetDeidClient();

            string jobName = GenerateJobName();
            const string inputPrefix = "example_patient_1";

            DeidentificationJob job = new()
            {
                SourceLocation = new SourceStorageLocation(new Uri(TestEnvironment.GetStorageAccountLocation()), inputPrefix),
                TargetLocation = new TargetStorageLocation(new Uri(TestEnvironment.GetStorageAccountLocation()), OUTPUT_FOLDER),
                Operation = DeidentificationOperationType.Surrogate
            };

            job = (await client.DeidentifyDocumentsAsync(WaitUntil.Started, jobName, job)).Value;

            Assert.IsNotNull(job);
            Assert.AreEqual(jobName, job.Name);
            Assert.IsNotNull(job.CreatedAt);
            Assert.IsNotNull(job.LastUpdatedAt);
            Assert.IsNull(job.StartedAt);
            Assert.AreEqual(DeidentificationJobStatus.NotStarted, job.Status);
            Assert.IsNull(job.Error);
            Assert.AreEqual("en-US", job.Customizations.SurrogateLocale);
            Assert.AreEqual(inputPrefix, job.SourceLocation.Prefix);
            Assert.IsTrue(job.SourceLocation.Location.ToString().Contains("blob.core.windows.net"));
            Assert.AreEqual(OUTPUT_FOLDER, job.TargetLocation.Prefix);
            Assert.IsTrue(job.TargetLocation.Location.ToString().Contains("blob.core.windows.net"));
        }

        [Test]
        public async Task CreateThenList_JobExists_ContainsExpectedFields()
        {
            DeidentificationClient client = GetDeidClient();

            string jobName = GenerateJobName();
            const string inputPrefix = "example_patient_1";

            DeidentificationJob job = new()
            {
                SourceLocation = new SourceStorageLocation(new Uri(TestEnvironment.GetStorageAccountLocation()), inputPrefix),
                TargetLocation = new TargetStorageLocation(new Uri(TestEnvironment.GetStorageAccountLocation()), OUTPUT_FOLDER),
                Operation = DeidentificationOperationType.Surrogate
            };

            job = (await client.DeidentifyDocumentsAsync(WaitUntil.Started, jobName, job)).Value;

            var jobs = client.GetJobsAsync(2).GetAsyncEnumerator();

            bool jobFound = false;
            int jobsToLookThrough = 10;
            while (await jobs.MoveNextAsync())
            {
                if (jobs.Current.Name == jobName)
                {
                    jobFound = true;
                    Assert.IsNotNull(jobs.Current.CreatedAt);
                    Assert.IsNotNull(jobs.Current.LastUpdatedAt);
                    Assert.IsNull(jobs.Current.StartedAt);
                    Assert.AreEqual(DeidentificationJobStatus.NotStarted, jobs.Current.Status);
                    Assert.IsNull(jobs.Current.Error);
                    Assert.AreEqual("en-US", job.Customizations.SurrogateLocale);
                    Assert.IsNull(jobs.Current.Summary);
                    Assert.AreEqual(inputPrefix, jobs.Current.SourceLocation.Prefix);
                    Assert.IsTrue(jobs.Current.SourceLocation.Location.ToString().Contains("blob.core.windows.net"));
                    Assert.AreEqual(OUTPUT_FOLDER, jobs.Current.TargetLocation.Prefix);
                    Assert.IsTrue(jobs.Current.SourceLocation.Location.ToString().Contains("blob.core.windows.net"));
                }

                if (jobFound || --jobsToLookThrough <= 0)
                {
                    break;
                }
            }
            Assert.IsTrue(jobFound, "Job not found in list of jobs.");
        }

        [Test]
        public async Task JobE2E_WaitUntil_Success()
        {
            DeidentificationClient client = GetDeidClient();

            string jobName = GenerateJobName();
            const string inputPrefix = "example_patient_1";
            const int expectedReportCount = 3;
            const int maxPageSize = 2;

            DeidentificationJob job = new()
            {
                SourceLocation = new SourceStorageLocation(new Uri(TestEnvironment.GetStorageAccountLocation()), inputPrefix),
                TargetLocation = new TargetStorageLocation(new Uri(TestEnvironment.GetStorageAccountLocation()), OUTPUT_FOLDER),
                Operation = DeidentificationOperationType.Surrogate
            };

            job = (await client.DeidentifyDocumentsAsync(WaitUntil.Completed, jobName, job)).Value;
            job = await client.GetJobAsync(jobName);

            Assert.AreEqual(DeidentificationJobStatus.Succeeded, job.Status);
            Assert.IsNotNull(job.StartedAt);
            Assert.IsNotNull(job.Summary);
            Assert.AreEqual(expectedReportCount, job.Summary.Total);
            Assert.AreEqual(expectedReportCount, job.Summary.Successful);

            // Check file reports, using maxpagesize parameter to test pagination.
            var reportIds = new List<string>();
            int numPages = 0;
            int maxPages = 10;

            IAsyncEnumerable<Page<DeidentificationDocumentDetails>> pages = client.GetJobDocumentsAsync(jobName, maxPageSize).AsPages();
            IAsyncEnumerator<Page<DeidentificationDocumentDetails>> enumerator = pages.GetAsyncEnumerator();

            while (numPages < maxPages && await enumerator.MoveNextAsync())
            {
                Page<DeidentificationDocumentDetails> page = enumerator.Current;
                numPages++;

                Assert.IsTrue(page.Values.Count <= maxPageSize);
                foreach (DeidentificationDocumentDetails report in page.Values)
                {
                    if (reportIds.Contains(report.Id))
                    {
                        Assert.Fail("Duplicate report ID found.");
                    }
                    reportIds.Add(report.Id);
                    Assert.IsTrue(report.Input.Location.ToString().Contains(inputPrefix),
                                  $"Input location {report.Input.Location.ToString()} does not contain input prefix.");
                    Assert.IsTrue(report.Output.Location.ToString().Contains(OUTPUT_FOLDER));
                    Assert.IsNotNull(report.Input.Etag);
                    Assert.AreEqual(OperationState.Succeeded, report.Status);
                    Assert.IsNotNull(report.Output.Etag);
                    Assert.IsTrue(report.Id.Length == 36); // Is Guid.
                }
            }
            Assert.AreEqual(Math.Ceiling((1.0 * expectedReportCount) / maxPageSize), numPages);
            Assert.AreEqual(expectedReportCount, reportIds.Count);
        }

        [Test]
        public async Task JobE2E_CancelDeleteFlow_DeletesJob()
        {
            DeidentificationClient client = GetDeidClient();

            string jobName = GenerateJobName();
            const string inputPrefix = "example_patient_1";

            DeidentificationJob job = new()
            {
                SourceLocation = new SourceStorageLocation(new Uri(TestEnvironment.GetStorageAccountLocation()), inputPrefix),
                TargetLocation = new TargetStorageLocation(new Uri(TestEnvironment.GetStorageAccountLocation()), OUTPUT_FOLDER),
                Operation = DeidentificationOperationType.Surrogate
            };

            job = (await client.DeidentifyDocumentsAsync(WaitUntil.Started, jobName, job)).Value;

            do
            {
                job = await client.GetJobAsync(jobName);
                if (Mode != RecordedTestMode.Playback)
                {
                    await Task.Delay(1000);
                }
            }
            while (job.Status == DeidentificationJobStatus.NotStarted);

            string errorMessage = job.Error is not null ? job.Error.Message : "No Error Message Available.";
            Assert.AreEqual(DeidentificationJobStatus.Running, job.Status, $"Job should be running. Error: {errorMessage}");

            job = await client.CancelJobAsync(jobName);
            Assert.AreEqual(DeidentificationJobStatus.Canceled, job.Status);

            await client.DeleteJobAsync(jobName);

            Assert.ThrowsAsync<RequestFailedException>(async () => await client.GetJobAsync(jobName));
        }

        [Test]
        public async Task JobE2E_CannotAccessStorage_ThrowsExpectedException()
        {
            DeidentificationClient client = GetDeidClient();

            string jobName = GenerateJobName();
            const string inputPrefix = "example_patient_1";

            string disfunctionalStorageUri = TestEnvironment.GetStorageAccountLocation().Substring(0, TestEnvironment.GetStorageAccountLocation().Length - 5);

            DeidentificationJob job = new()
            {
                SourceLocation = new SourceStorageLocation(new Uri(disfunctionalStorageUri), inputPrefix),
                TargetLocation = new TargetStorageLocation(new Uri(disfunctionalStorageUri), OUTPUT_FOLDER),
                Operation = DeidentificationOperationType.Surrogate
            };

            Type expectedExceptionType = Mode == RecordedTestMode.Playback ? typeof(InvalidOperationException) : typeof(RequestFailedException);
            Assert.ThrowsAsync(expectedExceptionType, async () => await client.DeidentifyDocumentsAsync(WaitUntil.Completed, jobName, job));
            job = await client.GetJobAsync(jobName);

            Assert.AreEqual(DeidentificationJobStatus.Failed, job.Status);
            Assert.IsNotNull(job.Error);
            Assert.AreEqual("StorageAccessDenied", job.Error.Code);
            Assert.IsTrue(job.Error.Message.Length > 10); // Arbitrary length choice.
        }

        private string GenerateJobName()
        {
            if (Mode == RecordedTestMode.Playback)
            {
                return DeidentificationTestEnvironment.FakeJobName;
            }

            string netVersion = Environment.Version.ToString().Replace(".", "_");
            netVersion = netVersion.Length > 7 ? netVersion.Substring(0, 7) : netVersion;
            string jobName = "net-sdk-job-" + Recording.GenerateId() + "-" + netVersion;
            return jobName;
        }
    }
}
