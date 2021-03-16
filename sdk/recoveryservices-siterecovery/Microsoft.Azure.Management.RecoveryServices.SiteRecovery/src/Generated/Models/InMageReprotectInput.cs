// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// InMageAzureV2 specific provider input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("InMage")]
    public partial class InMageReprotectInput : ReverseReplicationProviderSpecificInput
    {
        /// <summary>
        /// Initializes a new instance of the InMageReprotectInput class.
        /// </summary>
        public InMageReprotectInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InMageReprotectInput class.
        /// </summary>
        /// <param name="masterTargetId">The Master Target Id.</param>
        /// <param name="processServerId">The Process Server Id.</param>
        /// <param name="retentionDrive">The retention drive to use on the
        /// MT.</param>
        /// <param name="profileId">The Policy Id.</param>
        /// <param name="runAsAccountId">The CS account Id.</param>
        /// <param name="datastoreName">The target datastore name.</param>
        /// <param name="diskExclusionInput">The enable disk exclusion
        /// input.</param>
        /// <param name="disksToInclude">The disks to include list.</param>
        public InMageReprotectInput(string masterTargetId, string processServerId, string retentionDrive, string profileId, string runAsAccountId = default(string), string datastoreName = default(string), InMageDiskExclusionInput diskExclusionInput = default(InMageDiskExclusionInput), IList<string> disksToInclude = default(IList<string>))
        {
            MasterTargetId = masterTargetId;
            ProcessServerId = processServerId;
            RetentionDrive = retentionDrive;
            RunAsAccountId = runAsAccountId;
            DatastoreName = datastoreName;
            DiskExclusionInput = diskExclusionInput;
            ProfileId = profileId;
            DisksToInclude = disksToInclude;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Master Target Id.
        /// </summary>
        [JsonProperty(PropertyName = "masterTargetId")]
        public string MasterTargetId { get; set; }

        /// <summary>
        /// Gets or sets the Process Server Id.
        /// </summary>
        [JsonProperty(PropertyName = "processServerId")]
        public string ProcessServerId { get; set; }

        /// <summary>
        /// Gets or sets the retention drive to use on the MT.
        /// </summary>
        [JsonProperty(PropertyName = "retentionDrive")]
        public string RetentionDrive { get; set; }

        /// <summary>
        /// Gets or sets the CS account Id.
        /// </summary>
        [JsonProperty(PropertyName = "runAsAccountId")]
        public string RunAsAccountId { get; set; }

        /// <summary>
        /// Gets or sets the target datastore name.
        /// </summary>
        [JsonProperty(PropertyName = "datastoreName")]
        public string DatastoreName { get; set; }

        /// <summary>
        /// Gets or sets the enable disk exclusion input.
        /// </summary>
        [JsonProperty(PropertyName = "diskExclusionInput")]
        public InMageDiskExclusionInput DiskExclusionInput { get; set; }

        /// <summary>
        /// Gets or sets the Policy Id.
        /// </summary>
        [JsonProperty(PropertyName = "profileId")]
        public string ProfileId { get; set; }

        /// <summary>
        /// Gets or sets the disks to include list.
        /// </summary>
        [JsonProperty(PropertyName = "disksToInclude")]
        public IList<string> DisksToInclude { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MasterTargetId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MasterTargetId");
            }
            if (ProcessServerId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProcessServerId");
            }
            if (RetentionDrive == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RetentionDrive");
            }
            if (ProfileId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProfileId");
            }
        }
    }
}
