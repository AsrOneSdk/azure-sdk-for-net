// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A2A managed disk input details.
    /// </summary>
    public partial class A2AVmManagedDiskInputDetails
    {
        /// <summary>
        /// Initializes a new instance of the A2AVmManagedDiskInputDetails
        /// class.
        /// </summary>
        public A2AVmManagedDiskInputDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the A2AVmManagedDiskInputDetails
        /// class.
        /// </summary>
        /// <param name="diskId">The disk Id.</param>
        /// <param name="primaryStagingAzureStorageAccountId">The primary
        /// staging storage account Arm Id.</param>
        /// <param name="recoveryResourceGroupId">The target resource group Arm
        /// Id.</param>
        /// <param name="recoveryReplicaDiskAccountType">The replica disk type.
        /// Its an optional value and will be same as source disk type if not
        /// user provided.</param>
        /// <param name="recoveryTargetDiskAccountType">The target disk type
        /// after failover. Its an optional value and will be same as source
        /// disk type if not user provided.</param>
        /// <param name="recoveryDiskEncryptionSetId">The recovery disk
        /// encryption set Id.</param>
        /// <param name="diskEncryptionInfo">The recovery disk encryption
        /// information (for one / single pass flows).</param>
        public A2AVmManagedDiskInputDetails(string diskId, string primaryStagingAzureStorageAccountId, string recoveryResourceGroupId, string recoveryReplicaDiskAccountType = default(string), string recoveryTargetDiskAccountType = default(string), string recoveryDiskEncryptionSetId = default(string), DiskEncryptionInfo diskEncryptionInfo = default(DiskEncryptionInfo))
        {
            DiskId = diskId;
            PrimaryStagingAzureStorageAccountId = primaryStagingAzureStorageAccountId;
            RecoveryResourceGroupId = recoveryResourceGroupId;
            RecoveryReplicaDiskAccountType = recoveryReplicaDiskAccountType;
            RecoveryTargetDiskAccountType = recoveryTargetDiskAccountType;
            RecoveryDiskEncryptionSetId = recoveryDiskEncryptionSetId;
            DiskEncryptionInfo = diskEncryptionInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the disk Id.
        /// </summary>
        [JsonProperty(PropertyName = "diskId")]
        public string DiskId { get; set; }

        /// <summary>
        /// Gets or sets the primary staging storage account Arm Id.
        /// </summary>
        [JsonProperty(PropertyName = "primaryStagingAzureStorageAccountId")]
        public string PrimaryStagingAzureStorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the target resource group Arm Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryResourceGroupId")]
        public string RecoveryResourceGroupId { get; set; }

        /// <summary>
        /// Gets or sets the replica disk type. Its an optional value and will
        /// be same as source disk type if not user provided.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryReplicaDiskAccountType")]
        public string RecoveryReplicaDiskAccountType { get; set; }

        /// <summary>
        /// Gets or sets the target disk type after failover. Its an optional
        /// value and will be same as source disk type if not user provided.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryTargetDiskAccountType")]
        public string RecoveryTargetDiskAccountType { get; set; }

        /// <summary>
        /// Gets or sets the recovery disk encryption set Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryDiskEncryptionSetId")]
        public string RecoveryDiskEncryptionSetId { get; set; }

        /// <summary>
        /// Gets or sets the recovery disk encryption information (for one /
        /// single pass flows).
        /// </summary>
        [JsonProperty(PropertyName = "diskEncryptionInfo")]
        public DiskEncryptionInfo DiskEncryptionInfo { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DiskId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DiskId");
            }
            if (PrimaryStagingAzureStorageAccountId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PrimaryStagingAzureStorageAccountId");
            }
            if (RecoveryResourceGroupId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RecoveryResourceGroupId");
            }
        }
    }
}
