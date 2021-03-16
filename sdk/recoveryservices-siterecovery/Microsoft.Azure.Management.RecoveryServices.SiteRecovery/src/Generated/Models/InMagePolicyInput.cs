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
    /// VMWare Azure specific protection profile Input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("InMage")]
    public partial class InMagePolicyInput : PolicyProviderSpecificInput
    {
        /// <summary>
        /// Initializes a new instance of the InMagePolicyInput class.
        /// </summary>
        public InMagePolicyInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InMagePolicyInput class.
        /// </summary>
        /// <param name="multiVmSyncStatus">A value indicating whether multi-VM
        /// sync has to be enabled. Value should be 'Enabled' or 'Disabled'.
        /// Possible values include: 'Enable', 'Disable'</param>
        /// <param name="recoveryPointThresholdInMinutes">The recovery point
        /// threshold in minutes.</param>
        /// <param name="recoveryPointHistory">The duration in minutes until
        /// which the recovery points need to be stored.</param>
        /// <param name="appConsistentFrequencyInMinutes">The app consistent
        /// snapshot frequency (in minutes).</param>
        public InMagePolicyInput(string multiVmSyncStatus, int? recoveryPointThresholdInMinutes = default(int?), int? recoveryPointHistory = default(int?), int? appConsistentFrequencyInMinutes = default(int?))
        {
            RecoveryPointThresholdInMinutes = recoveryPointThresholdInMinutes;
            RecoveryPointHistory = recoveryPointHistory;
            AppConsistentFrequencyInMinutes = appConsistentFrequencyInMinutes;
            MultiVmSyncStatus = multiVmSyncStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the recovery point threshold in minutes.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointThresholdInMinutes")]
        public int? RecoveryPointThresholdInMinutes { get; set; }

        /// <summary>
        /// Gets or sets the duration in minutes until which the recovery
        /// points need to be stored.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointHistory")]
        public int? RecoveryPointHistory { get; set; }

        /// <summary>
        /// Gets or sets the app consistent snapshot frequency (in minutes).
        /// </summary>
        [JsonProperty(PropertyName = "appConsistentFrequencyInMinutes")]
        public int? AppConsistentFrequencyInMinutes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether multi-VM sync has to be
        /// enabled. Value should be 'Enabled' or 'Disabled'. Possible values
        /// include: 'Enable', 'Disable'
        /// </summary>
        [JsonProperty(PropertyName = "multiVmSyncStatus")]
        public string MultiVmSyncStatus { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MultiVmSyncStatus == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MultiVmSyncStatus");
            }
        }
    }
}
