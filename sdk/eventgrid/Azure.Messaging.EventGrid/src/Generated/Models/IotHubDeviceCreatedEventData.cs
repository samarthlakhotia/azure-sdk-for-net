// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Event data for Microsoft.Devices.DeviceCreated event. </summary>
    public partial class IotHubDeviceCreatedEventData : DeviceLifeCycleEventProperties
    {
        /// <summary> Initializes a new instance of IotHubDeviceCreatedEventData. </summary>
        internal IotHubDeviceCreatedEventData()
        {
        }

        /// <summary> Initializes a new instance of IotHubDeviceCreatedEventData. </summary>
        /// <param name="deviceId"> The unique identifier of the device. This case-sensitive string can be up to 128 characters long, and supports ASCII 7-bit alphanumeric characters plus the following special characters: - : . + % _ &amp;#35; * ? ! ( ) , = @ ; $ '. </param>
        /// <param name="hubName"> Name of the IoT Hub where the device was created or deleted. </param>
        /// <param name="twin"> Information about the device twin, which is the cloud representation of application device metadata. </param>
        internal IotHubDeviceCreatedEventData(string deviceId, string hubName, DeviceTwinInfo twin) : base(deviceId, hubName, twin)
        {
        }
    }
}
