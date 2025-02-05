// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> List of regions associated with a managed HSM Pools. </summary>
    internal partial class ManagedHsmRegionsListResult
    {
        /// <summary> Initializes a new instance of ManagedHsmRegionsListResult. </summary>
        internal ManagedHsmRegionsListResult()
        {
            Value = new ChangeTrackingList<ManagedHsmGeoReplicatedRegion>();
        }

        /// <summary> Initializes a new instance of ManagedHsmRegionsListResult. </summary>
        /// <param name="value"> The region associated with a managed HSM Pools. </param>
        /// <param name="nextLink"> The URL to get the next set of managed HSM Pools. </param>
        internal ManagedHsmRegionsListResult(IReadOnlyList<ManagedHsmGeoReplicatedRegion> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The region associated with a managed HSM Pools. </summary>
        public IReadOnlyList<ManagedHsmGeoReplicatedRegion> Value { get; }
        /// <summary> The URL to get the next set of managed HSM Pools. </summary>
        public string NextLink { get; }
    }
}
