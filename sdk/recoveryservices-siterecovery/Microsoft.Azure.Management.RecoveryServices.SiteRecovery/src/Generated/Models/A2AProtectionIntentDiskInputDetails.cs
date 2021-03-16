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
    /// Azure VM unmanaged disk input details.
    /// </summary>
    public partial class A2AProtectionIntentDiskInputDetails
    {
        /// <summary>
        /// Initializes a new instance of the
        /// A2AProtectionIntentDiskInputDetails class.
        /// </summary>
        public A2AProtectionIntentDiskInputDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// A2AProtectionIntentDiskInputDetails class.
        /// </summary>
        /// <param name="diskUri">The disk Uri.</param>
        /// <param name="recoveryAzureStorageAccountCustomInput">The recovery
        /// VHD storage account input.</param>
        /// <param name="primaryStagingStorageAccountCustomInput">The primary
        /// staging storage account input.</param>
        public A2AProtectionIntentDiskInputDetails(string diskUri, StorageAccountCustomDetails recoveryAzureStorageAccountCustomInput = default(StorageAccountCustomDetails), StorageAccountCustomDetails primaryStagingStorageAccountCustomInput = default(StorageAccountCustomDetails))
        {
            DiskUri = diskUri;
            RecoveryAzureStorageAccountCustomInput = recoveryAzureStorageAccountCustomInput;
            PrimaryStagingStorageAccountCustomInput = primaryStagingStorageAccountCustomInput;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the disk Uri.
        /// </summary>
        [JsonProperty(PropertyName = "diskUri")]
        public string DiskUri { get; set; }

        /// <summary>
        /// Gets or sets the recovery VHD storage account input.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureStorageAccountCustomInput")]
        public StorageAccountCustomDetails RecoveryAzureStorageAccountCustomInput { get; set; }

        /// <summary>
        /// Gets or sets the primary staging storage account input.
        /// </summary>
        [JsonProperty(PropertyName = "primaryStagingStorageAccountCustomInput")]
        public StorageAccountCustomDetails PrimaryStagingStorageAccountCustomInput { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DiskUri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DiskUri");
            }
        }
    }
}
