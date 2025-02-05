// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ResourceHealth.Models;

namespace Azure.ResourceManager.ResourceHealth
{
    /// <summary>
    /// A class representing the ServiceEmergingIssue data model.
    /// The Get EmergingIssues operation response.
    /// </summary>
    public partial class ServiceEmergingIssueData : ResourceData
    {
        /// <summary> Initializes a new instance of ServiceEmergingIssueData. </summary>
        internal ServiceEmergingIssueData()
        {
            StatusBanners = new ChangeTrackingList<EmergingIssueBannerType>();
            StatusActiveEvents = new ChangeTrackingList<EmergingIssueActiveEventType>();
        }

        /// <summary> Initializes a new instance of ServiceEmergingIssueData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="refreshedOn"> Timestamp for when last time refreshed for ongoing emerging issue. </param>
        /// <param name="statusBanners"> The list of emerging issues of banner type. </param>
        /// <param name="statusActiveEvents"> The list of emerging issues of active event type. </param>
        internal ServiceEmergingIssueData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? refreshedOn, IReadOnlyList<EmergingIssueBannerType> statusBanners, IReadOnlyList<EmergingIssueActiveEventType> statusActiveEvents) : base(id, name, resourceType, systemData)
        {
            RefreshedOn = refreshedOn;
            StatusBanners = statusBanners;
            StatusActiveEvents = statusActiveEvents;
        }

        /// <summary> Timestamp for when last time refreshed for ongoing emerging issue. </summary>
        public DateTimeOffset? RefreshedOn { get; }
        /// <summary> The list of emerging issues of banner type. </summary>
        public IReadOnlyList<EmergingIssueBannerType> StatusBanners { get; }
        /// <summary> The list of emerging issues of active event type. </summary>
        public IReadOnlyList<EmergingIssueActiveEventType> StatusActiveEvents { get; }
    }
}
