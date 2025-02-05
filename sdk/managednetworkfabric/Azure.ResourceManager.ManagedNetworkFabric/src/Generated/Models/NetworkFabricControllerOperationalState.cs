// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Operational state for the resource. </summary>
    public readonly partial struct NetworkFabricControllerOperationalState : IEquatable<NetworkFabricControllerOperationalState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkFabricControllerOperationalState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkFabricControllerOperationalState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ConfiguringValue = "Configuring";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";

        /// <summary> Configuring. </summary>
        public static NetworkFabricControllerOperationalState Configuring { get; } = new NetworkFabricControllerOperationalState(ConfiguringValue);
        /// <summary> Succeeded. </summary>
        public static NetworkFabricControllerOperationalState Succeeded { get; } = new NetworkFabricControllerOperationalState(SucceededValue);
        /// <summary> Failed. </summary>
        public static NetworkFabricControllerOperationalState Failed { get; } = new NetworkFabricControllerOperationalState(FailedValue);
        /// <summary> Determines if two <see cref="NetworkFabricControllerOperationalState"/> values are the same. </summary>
        public static bool operator ==(NetworkFabricControllerOperationalState left, NetworkFabricControllerOperationalState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkFabricControllerOperationalState"/> values are not the same. </summary>
        public static bool operator !=(NetworkFabricControllerOperationalState left, NetworkFabricControllerOperationalState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NetworkFabricControllerOperationalState"/>. </summary>
        public static implicit operator NetworkFabricControllerOperationalState(string value) => new NetworkFabricControllerOperationalState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkFabricControllerOperationalState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkFabricControllerOperationalState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
