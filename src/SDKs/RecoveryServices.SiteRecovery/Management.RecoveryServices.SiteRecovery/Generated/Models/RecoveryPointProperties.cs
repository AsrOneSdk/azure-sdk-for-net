// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Recovery point properties.
    /// </summary>
    public partial class RecoveryPointProperties
    {
        /// <summary>
        /// Initializes a new instance of the RecoveryPointProperties class.
        /// </summary>
        public RecoveryPointProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecoveryPointProperties class.
        /// </summary>
        /// <param name="recoveryPointTime">The recovery point time.</param>
        /// <param name="recoveryPointType">The recovery point type:
        /// ApplicationConsistent, CrashConsistent.</param>
        /// <param name="providerSpecificDetails">The provider specific details
        /// for the recovery point.</param>
        public RecoveryPointProperties(System.DateTime? recoveryPointTime = default(System.DateTime?), string recoveryPointType = default(string), ProviderSpecificRecoveryPointDetails providerSpecificDetails = default(ProviderSpecificRecoveryPointDetails))
        {
            RecoveryPointTime = recoveryPointTime;
            RecoveryPointType = recoveryPointType;
            ProviderSpecificDetails = providerSpecificDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the recovery point time.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointTime")]
        public System.DateTime? RecoveryPointTime { get; set; }

        /// <summary>
        /// Gets or sets the recovery point type: ApplicationConsistent,
        /// CrashConsistent.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointType")]
        public string RecoveryPointType { get; set; }

        /// <summary>
        /// Gets or sets the provider specific details for the recovery point.
        /// </summary>
        [JsonProperty(PropertyName = "providerSpecificDetails")]
        public ProviderSpecificRecoveryPointDetails ProviderSpecificDetails { get; set; }

    }
}
