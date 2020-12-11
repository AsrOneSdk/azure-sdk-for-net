// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// InMageRcmFailback protected disk details.
    /// </summary>
    public partial class InMageRcmFailbackProtectedDiskDetails
    {
        /// <summary>
        /// Initializes a new instance of the
        /// InMageRcmFailbackProtectedDiskDetails class.
        /// </summary>
        public InMageRcmFailbackProtectedDiskDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// InMageRcmFailbackProtectedDiskDetails class.
        /// </summary>
        /// <param name="diskId">The disk Id (reported by source
        /// agent).</param>
        /// <param name="diskName">The disk name.</param>
        /// <param name="isOSDisk">A value indicating whether the disk is the
        /// OS disk.</param>
        /// <param name="capacityInBytes">The disk capacity in bytes.</param>
        /// <param name="diskUuid">The disk Uuid (reported by vCenter).</param>
        /// <param name="dataPendingInLogDataStoreInMB">The data pending in log
        /// data store in MB.</param>
        /// <param name="dataPendingAtSourceAgentInMB">The data pending at
        /// source agent in MB.</param>
        /// <param name="isInitialReplicationComplete">A value indicating
        /// whether initial replication is complete or not.</param>
        /// <param name="irDetails">The initial replication details.</param>
        /// <param name="resyncDetails">The resync details.</param>
        public InMageRcmFailbackProtectedDiskDetails(string diskId = default(string), string diskName = default(string), string isOSDisk = default(string), long? capacityInBytes = default(long?), string diskUuid = default(string), double? dataPendingInLogDataStoreInMB = default(double?), double? dataPendingAtSourceAgentInMB = default(double?), string isInitialReplicationComplete = default(string), InMageRcmFailbackSyncDetails irDetails = default(InMageRcmFailbackSyncDetails), InMageRcmFailbackSyncDetails resyncDetails = default(InMageRcmFailbackSyncDetails))
        {
            DiskId = diskId;
            DiskName = diskName;
            IsOSDisk = isOSDisk;
            CapacityInBytes = capacityInBytes;
            DiskUuid = diskUuid;
            DataPendingInLogDataStoreInMB = dataPendingInLogDataStoreInMB;
            DataPendingAtSourceAgentInMB = dataPendingAtSourceAgentInMB;
            IsInitialReplicationComplete = isInitialReplicationComplete;
            IrDetails = irDetails;
            ResyncDetails = resyncDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the disk Id (reported by source agent).
        /// </summary>
        [JsonProperty(PropertyName = "diskId")]
        public string DiskId { get; private set; }

        /// <summary>
        /// Gets the disk name.
        /// </summary>
        [JsonProperty(PropertyName = "diskName")]
        public string DiskName { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the disk is the OS disk.
        /// </summary>
        [JsonProperty(PropertyName = "isOSDisk")]
        public string IsOSDisk { get; private set; }

        /// <summary>
        /// Gets the disk capacity in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "capacityInBytes")]
        public long? CapacityInBytes { get; private set; }

        /// <summary>
        /// Gets the disk Uuid (reported by vCenter).
        /// </summary>
        [JsonProperty(PropertyName = "diskUuid")]
        public string DiskUuid { get; private set; }

        /// <summary>
        /// Gets the data pending in log data store in MB.
        /// </summary>
        [JsonProperty(PropertyName = "dataPendingInLogDataStoreInMB")]
        public double? DataPendingInLogDataStoreInMB { get; private set; }

        /// <summary>
        /// Gets the data pending at source agent in MB.
        /// </summary>
        [JsonProperty(PropertyName = "dataPendingAtSourceAgentInMB")]
        public double? DataPendingAtSourceAgentInMB { get; private set; }

        /// <summary>
        /// Gets a value indicating whether initial replication is complete or
        /// not.
        /// </summary>
        [JsonProperty(PropertyName = "isInitialReplicationComplete")]
        public string IsInitialReplicationComplete { get; private set; }

        /// <summary>
        /// Gets or sets the initial replication details.
        /// </summary>
        [JsonProperty(PropertyName = "irDetails")]
        public InMageRcmFailbackSyncDetails IrDetails { get; set; }

        /// <summary>
        /// Gets or sets the resync details.
        /// </summary>
        [JsonProperty(PropertyName = "resyncDetails")]
        public InMageRcmFailbackSyncDetails ResyncDetails { get; set; }

    }
}
