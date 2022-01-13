// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Represents the activity on an elastic pool. </summary>
    public partial class ElasticPoolDatabaseActivity : Resource
    {
        /// <summary> Initializes a new instance of ElasticPoolDatabaseActivity. </summary>
        public ElasticPoolDatabaseActivity()
        {
        }

        /// <summary> Initializes a new instance of ElasticPoolDatabaseActivity. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="databaseName"> The database name. </param>
        /// <param name="endTime"> The time the operation finished (ISO8601 format). </param>
        /// <param name="errorCode"> The error code if available. </param>
        /// <param name="errorMessage"> The error message if available. </param>
        /// <param name="errorSeverity"> The error severity if available. </param>
        /// <param name="operation"> The operation name. </param>
        /// <param name="operationId"> The unique operation ID. </param>
        /// <param name="percentComplete"> The percentage complete if available. </param>
        /// <param name="requestedElasticPoolName"> The name for the elastic pool the database is moving into if available. </param>
        /// <param name="currentElasticPoolName"> The name of the current elastic pool the database is in if available. </param>
        /// <param name="currentServiceObjective"> The name of the current service objective if available. </param>
        /// <param name="requestedServiceObjective"> The name of the requested service objective if available. </param>
        /// <param name="serverName"> The name of the server the elastic pool is in. </param>
        /// <param name="startTime"> The time the operation started (ISO8601 format). </param>
        /// <param name="state"> The current state of the operation. </param>
        internal ElasticPoolDatabaseActivity(ResourceIdentifier id, string name, ResourceType type, string location, string databaseName, DateTimeOffset? endTime, int? errorCode, string errorMessage, int? errorSeverity, string operation, Guid? operationId, int? percentComplete, string requestedElasticPoolName, string currentElasticPoolName, string currentServiceObjective, string requestedServiceObjective, string serverName, DateTimeOffset? startTime, string state) : base(id, name, type)
        {
            Location = location;
            DatabaseName = databaseName;
            EndTime = endTime;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            ErrorSeverity = errorSeverity;
            Operation = operation;
            OperationId = operationId;
            PercentComplete = percentComplete;
            RequestedElasticPoolName = requestedElasticPoolName;
            CurrentElasticPoolName = currentElasticPoolName;
            CurrentServiceObjective = currentServiceObjective;
            RequestedServiceObjective = requestedServiceObjective;
            ServerName = serverName;
            StartTime = startTime;
            State = state;
        }

        /// <summary> The geo-location where the resource lives. </summary>
        public string Location { get; set; }
        /// <summary> The database name. </summary>
        public string DatabaseName { get; }
        /// <summary> The time the operation finished (ISO8601 format). </summary>
        public DateTimeOffset? EndTime { get; }
        /// <summary> The error code if available. </summary>
        public int? ErrorCode { get; }
        /// <summary> The error message if available. </summary>
        public string ErrorMessage { get; }
        /// <summary> The error severity if available. </summary>
        public int? ErrorSeverity { get; }
        /// <summary> The operation name. </summary>
        public string Operation { get; }
        /// <summary> The unique operation ID. </summary>
        public Guid? OperationId { get; }
        /// <summary> The percentage complete if available. </summary>
        public int? PercentComplete { get; }
        /// <summary> The name for the elastic pool the database is moving into if available. </summary>
        public string RequestedElasticPoolName { get; }
        /// <summary> The name of the current elastic pool the database is in if available. </summary>
        public string CurrentElasticPoolName { get; }
        /// <summary> The name of the current service objective if available. </summary>
        public string CurrentServiceObjective { get; }
        /// <summary> The name of the requested service objective if available. </summary>
        public string RequestedServiceObjective { get; }
        /// <summary> The name of the server the elastic pool is in. </summary>
        public string ServerName { get; }
        /// <summary> The time the operation started (ISO8601 format). </summary>
        public DateTimeOffset? StartTime { get; }
        /// <summary> The current state of the operation. </summary>
        public string State { get; }
    }
}
