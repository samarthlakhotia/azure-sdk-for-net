// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Workload Identity settings for the security profile. </summary>
    internal partial class ManagedClusterSecurityProfileWorkloadIdentity
    {
        /// <summary> Initializes a new instance of ManagedClusterSecurityProfileWorkloadIdentity. </summary>
        public ManagedClusterSecurityProfileWorkloadIdentity()
        {
        }

        /// <summary> Initializes a new instance of ManagedClusterSecurityProfileWorkloadIdentity. </summary>
        /// <param name="enabled"> Whether to enable Workload Identity. </param>
        internal ManagedClusterSecurityProfileWorkloadIdentity(bool? enabled)
        {
            Enabled = enabled;
        }

        /// <summary> Whether to enable Workload Identity. </summary>
        public bool? Enabled { get; set; }
    }
}
