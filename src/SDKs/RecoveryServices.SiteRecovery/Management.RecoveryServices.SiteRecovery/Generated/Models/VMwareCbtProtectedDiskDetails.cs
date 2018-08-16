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
    /// VMwareCbt protected disk details.
    /// </summary>
    public partial class VMwareCbtProtectedDiskDetails
    {
        /// <summary>
        /// Initializes a new instance of the VMwareCbtProtectedDiskDetails
        /// class.
        /// </summary>
        public VMwareCbtProtectedDiskDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VMwareCbtProtectedDiskDetails
        /// class.
        /// </summary>
        /// <param name="diskId">The disk id.</param>
        /// <param name="diskName">The disk name.</param>
        /// <param name="isOSDisk">A value indicating whether the disk is the
        /// OS disk.</param>
        /// <param name="capacityInBytes">The disk capacity in bytes.</param>
        /// <param name="logStorageAccountId">The log storage account ARM
        /// Id.</param>
        /// <param name="logStorageAccountSasSecretName">The key vault secret
        /// name of the log storage account.</param>
        /// <param name="seedManagedDiskId">The ARM Id of the seed managed
        /// disk.</param>
        /// <param name="targetManagedDiskId">The ARM Id of the target managed
        /// disk.</param>
        /// <param name="diskType">The disk type.</param>
        public VMwareCbtProtectedDiskDetails(string diskId = default(string), string diskName = default(string), bool? isOSDisk = default(bool?), long? capacityInBytes = default(long?), string logStorageAccountId = default(string), string logStorageAccountSasSecretName = default(string), string seedManagedDiskId = default(string), string targetManagedDiskId = default(string), string diskType = default(string))
        {
            DiskId = diskId;
            DiskName = diskName;
            IsOSDisk = isOSDisk;
            CapacityInBytes = capacityInBytes;
            LogStorageAccountId = logStorageAccountId;
            LogStorageAccountSasSecretName = logStorageAccountSasSecretName;
            SeedManagedDiskId = seedManagedDiskId;
            TargetManagedDiskId = targetManagedDiskId;
            DiskType = diskType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the disk id.
        /// </summary>
        [JsonProperty(PropertyName = "diskId")]
        public string DiskId { get; set; }

        /// <summary>
        /// Gets or sets the disk name.
        /// </summary>
        [JsonProperty(PropertyName = "diskName")]
        public string DiskName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the disk is the OS disk.
        /// </summary>
        [JsonProperty(PropertyName = "isOSDisk")]
        public bool? IsOSDisk { get; set; }

        /// <summary>
        /// Gets or sets the disk capacity in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "capacityInBytes")]
        public long? CapacityInBytes { get; set; }

        /// <summary>
        /// Gets or sets the log storage account ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "logStorageAccountId")]
        public string LogStorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the key vault secret name of the log storage account.
        /// </summary>
        [JsonProperty(PropertyName = "logStorageAccountSasSecretName")]
        public string LogStorageAccountSasSecretName { get; set; }

        /// <summary>
        /// Gets or sets the ARM Id of the seed managed disk.
        /// </summary>
        [JsonProperty(PropertyName = "seedManagedDiskId")]
        public string SeedManagedDiskId { get; set; }

        /// <summary>
        /// Gets or sets the ARM Id of the target managed disk.
        /// </summary>
        [JsonProperty(PropertyName = "targetManagedDiskId")]
        public string TargetManagedDiskId { get; set; }

        /// <summary>
        /// Gets or sets the disk type.
        /// </summary>
        [JsonProperty(PropertyName = "diskType")]
        public string DiskType { get; set; }

    }
}
