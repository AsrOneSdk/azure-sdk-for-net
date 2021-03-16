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
    /// InMageRcm failback specific policy details.
    /// </summary>
    [Newtonsoft.Json.JsonObject("InMageRcmFailback")]
    public partial class InMageRcmFailbackPolicyDetails : PolicyProviderSpecificDetails
    {
        /// <summary>
        /// Initializes a new instance of the InMageRcmFailbackPolicyDetails
        /// class.
        /// </summary>
        public InMageRcmFailbackPolicyDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InMageRcmFailbackPolicyDetails
        /// class.
        /// </summary>
        /// <param name="appConsistentFrequencyInMinutes">The app consistent
        /// snapshot frequency in minutes.</param>
        /// <param name="crashConsistentFrequencyInMinutes">The crash
        /// consistent snapshot frequency in minutes.</param>
        public InMageRcmFailbackPolicyDetails(int? appConsistentFrequencyInMinutes = default(int?), int? crashConsistentFrequencyInMinutes = default(int?))
        {
            AppConsistentFrequencyInMinutes = appConsistentFrequencyInMinutes;
            CrashConsistentFrequencyInMinutes = crashConsistentFrequencyInMinutes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the app consistent snapshot frequency in minutes.
        /// </summary>
        [JsonProperty(PropertyName = "appConsistentFrequencyInMinutes")]
        public int? AppConsistentFrequencyInMinutes { get; set; }

        /// <summary>
        /// Gets or sets the crash consistent snapshot frequency in minutes.
        /// </summary>
        [JsonProperty(PropertyName = "crashConsistentFrequencyInMinutes")]
        public int? CrashConsistentFrequencyInMinutes { get; set; }

    }
}
