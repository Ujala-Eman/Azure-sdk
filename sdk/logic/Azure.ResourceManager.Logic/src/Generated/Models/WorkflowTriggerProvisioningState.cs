// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The workflow trigger provisioning state. </summary>
    public readonly partial struct WorkflowTriggerProvisioningState : IEquatable<WorkflowTriggerProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WorkflowTriggerProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WorkflowTriggerProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string AcceptedValue = "Accepted";
        private const string RunningValue = "Running";
        private const string ReadyValue = "Ready";
        private const string CreatingValue = "Creating";
        private const string CreatedValue = "Created";
        private const string DeletingValue = "Deleting";
        private const string DeletedValue = "Deleted";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";
        private const string SucceededValue = "Succeeded";
        private const string MovingValue = "Moving";
        private const string UpdatingValue = "Updating";
        private const string RegisteringValue = "Registering";
        private const string RegisteredValue = "Registered";
        private const string UnregisteringValue = "Unregistering";
        private const string UnregisteredValue = "Unregistered";
        private const string CompletedValue = "Completed";

        /// <summary> NotSpecified. </summary>
        public static WorkflowTriggerProvisioningState NotSpecified { get; } = new WorkflowTriggerProvisioningState(NotSpecifiedValue);
        /// <summary> Accepted. </summary>
        public static WorkflowTriggerProvisioningState Accepted { get; } = new WorkflowTriggerProvisioningState(AcceptedValue);
        /// <summary> Running. </summary>
        public static WorkflowTriggerProvisioningState Running { get; } = new WorkflowTriggerProvisioningState(RunningValue);
        /// <summary> Ready. </summary>
        public static WorkflowTriggerProvisioningState Ready { get; } = new WorkflowTriggerProvisioningState(ReadyValue);
        /// <summary> Creating. </summary>
        public static WorkflowTriggerProvisioningState Creating { get; } = new WorkflowTriggerProvisioningState(CreatingValue);
        /// <summary> Created. </summary>
        public static WorkflowTriggerProvisioningState Created { get; } = new WorkflowTriggerProvisioningState(CreatedValue);
        /// <summary> Deleting. </summary>
        public static WorkflowTriggerProvisioningState Deleting { get; } = new WorkflowTriggerProvisioningState(DeletingValue);
        /// <summary> Deleted. </summary>
        public static WorkflowTriggerProvisioningState Deleted { get; } = new WorkflowTriggerProvisioningState(DeletedValue);
        /// <summary> Canceled. </summary>
        public static WorkflowTriggerProvisioningState Canceled { get; } = new WorkflowTriggerProvisioningState(CanceledValue);
        /// <summary> Failed. </summary>
        public static WorkflowTriggerProvisioningState Failed { get; } = new WorkflowTriggerProvisioningState(FailedValue);
        /// <summary> Succeeded. </summary>
        public static WorkflowTriggerProvisioningState Succeeded { get; } = new WorkflowTriggerProvisioningState(SucceededValue);
        /// <summary> Moving. </summary>
        public static WorkflowTriggerProvisioningState Moving { get; } = new WorkflowTriggerProvisioningState(MovingValue);
        /// <summary> Updating. </summary>
        public static WorkflowTriggerProvisioningState Updating { get; } = new WorkflowTriggerProvisioningState(UpdatingValue);
        /// <summary> Registering. </summary>
        public static WorkflowTriggerProvisioningState Registering { get; } = new WorkflowTriggerProvisioningState(RegisteringValue);
        /// <summary> Registered. </summary>
        public static WorkflowTriggerProvisioningState Registered { get; } = new WorkflowTriggerProvisioningState(RegisteredValue);
        /// <summary> Unregistering. </summary>
        public static WorkflowTriggerProvisioningState Unregistering { get; } = new WorkflowTriggerProvisioningState(UnregisteringValue);
        /// <summary> Unregistered. </summary>
        public static WorkflowTriggerProvisioningState Unregistered { get; } = new WorkflowTriggerProvisioningState(UnregisteredValue);
        /// <summary> Completed. </summary>
        public static WorkflowTriggerProvisioningState Completed { get; } = new WorkflowTriggerProvisioningState(CompletedValue);
        /// <summary> Determines if two <see cref="WorkflowTriggerProvisioningState"/> values are the same. </summary>
        public static bool operator ==(WorkflowTriggerProvisioningState left, WorkflowTriggerProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WorkflowTriggerProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(WorkflowTriggerProvisioningState left, WorkflowTriggerProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WorkflowTriggerProvisioningState"/>. </summary>
        public static implicit operator WorkflowTriggerProvisioningState(string value) => new WorkflowTriggerProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WorkflowTriggerProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WorkflowTriggerProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
