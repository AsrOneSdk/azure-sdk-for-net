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
    /// Guest disk signature based disk exclusion option when doing enable
    /// protection of virtual machine in InMage provider.
    /// </summary>
    public partial class InMageVolumeExclusionOptions
    {
        /// <summary>
        /// Initializes a new instance of the InMageVolumeExclusionOptions
        /// class.
        /// </summary>
        public InMageVolumeExclusionOptions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InMageVolumeExclusionOptions
        /// class.
        /// </summary>
        /// <param name="volumeLabel">The volume label. The disk having any
        /// volume with this label will be excluded from replication.</param>
        /// <param name="onlyExcludeIfSingleVolume">The value indicating
        /// whether to exclude multi volume disk or not. If a disk has multiple
        /// volumes and one of the volume has label matching with VolumeLabel
        /// this disk will be excluded from replication if
        /// OnlyExcludeIfSingleVolume is false.</param>
        public InMageVolumeExclusionOptions(string volumeLabel = default(string), string onlyExcludeIfSingleVolume = default(string))
        {
            VolumeLabel = volumeLabel;
            OnlyExcludeIfSingleVolume = onlyExcludeIfSingleVolume;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the volume label. The disk having any volume with this
        /// label will be excluded from replication.
        /// </summary>
        [JsonProperty(PropertyName = "volumeLabel")]
        public string VolumeLabel { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to exclude multi volume
        /// disk or not. If a disk has multiple volumes and one of the volume
        /// has label matching with VolumeLabel this disk will be excluded from
        /// replication if OnlyExcludeIfSingleVolume is false.
        /// </summary>
        [JsonProperty(PropertyName = "onlyExcludeIfSingleVolume")]
        public string OnlyExcludeIfSingleVolume { get; set; }

    }
}
