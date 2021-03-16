// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Disk details for E2A provider.
    /// </summary>
    public partial class AzureVmDiskDetails
    {
        /// <summary>
        /// Initializes a new instance of the AzureVmDiskDetails class.
        /// </summary>
        public AzureVmDiskDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureVmDiskDetails class.
        /// </summary>
        /// <param name="vhdType">VHD type.</param>
        /// <param name="vhdId">The VHD id.</param>
        /// <param name="diskId">The disk resource id.</param>
        /// <param name="vhdName">VHD name.</param>
        /// <param name="maxSizeMB">Max side in MB.</param>
        /// <param name="targetDiskLocation">Blob uri of the Azure
        /// disk.</param>
        /// <param name="targetDiskName">The target Azure disk name.</param>
        /// <param name="lunId">Ordinal\LunId of the disk for the Azure
        /// VM.</param>
        /// <param name="diskEncryptionSetId">The DiskEncryptionSet ARM
        /// ID.</param>
        public AzureVmDiskDetails(string vhdType = default(string), string vhdId = default(string), string diskId = default(string), string vhdName = default(string), string maxSizeMB = default(string), string targetDiskLocation = default(string), string targetDiskName = default(string), string lunId = default(string), string diskEncryptionSetId = default(string))
        {
            VhdType = vhdType;
            VhdId = vhdId;
            DiskId = diskId;
            VhdName = vhdName;
            MaxSizeMB = maxSizeMB;
            TargetDiskLocation = targetDiskLocation;
            TargetDiskName = targetDiskName;
            LunId = lunId;
            DiskEncryptionSetId = diskEncryptionSetId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets VHD type.
        /// </summary>
        [JsonProperty(PropertyName = "vhdType")]
        public string VhdType { get; set; }

        /// <summary>
        /// Gets or sets the VHD id.
        /// </summary>
        [JsonProperty(PropertyName = "vhdId")]
        public string VhdId { get; set; }

        /// <summary>
        /// Gets or sets the disk resource id.
        /// </summary>
        [JsonProperty(PropertyName = "diskId")]
        public string DiskId { get; set; }

        /// <summary>
        /// Gets or sets VHD name.
        /// </summary>
        [JsonProperty(PropertyName = "vhdName")]
        public string VhdName { get; set; }

        /// <summary>
        /// Gets or sets max side in MB.
        /// </summary>
        [JsonProperty(PropertyName = "maxSizeMB")]
        public string MaxSizeMB { get; set; }

        /// <summary>
        /// Gets or sets blob uri of the Azure disk.
        /// </summary>
        [JsonProperty(PropertyName = "targetDiskLocation")]
        public string TargetDiskLocation { get; set; }

        /// <summary>
        /// Gets or sets the target Azure disk name.
        /// </summary>
        [JsonProperty(PropertyName = "targetDiskName")]
        public string TargetDiskName { get; set; }

        /// <summary>
        /// Gets or sets ordinal\LunId of the disk for the Azure VM.
        /// </summary>
        [JsonProperty(PropertyName = "lunId")]
        public string LunId { get; set; }

        /// <summary>
        /// Gets or sets the DiskEncryptionSet ARM ID.
        /// </summary>
        [JsonProperty(PropertyName = "diskEncryptionSetId")]
        public string DiskEncryptionSetId { get; set; }

    }
}
