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
    /// Replication protection intent custom data details.
    /// </summary>
    public partial class ReplicationProtectionIntentProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ReplicationProtectionIntentProperties class.
        /// </summary>
        public ReplicationProtectionIntentProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ReplicationProtectionIntentProperties class.
        /// </summary>
        /// <param name="friendlyName">The name.</param>
        /// <param name="jobId">The job Id.</param>
        /// <param name="jobState">The job state.</param>
        /// <param name="isActive">A value indicating whether the intent object
        /// is active.</param>
        /// <param name="creationTimeUTC">The creation time in UTC.</param>
        /// <param name="providerSpecificDetails">The Replication provider
        /// custom settings.</param>
        public ReplicationProtectionIntentProperties(string friendlyName = default(string), string jobId = default(string), string jobState = default(string), bool? isActive = default(bool?), string creationTimeUTC = default(string), ReplicationProtectionIntentProviderSpecificSettings providerSpecificDetails = default(ReplicationProtectionIntentProviderSpecificSettings))
        {
            FriendlyName = friendlyName;
            JobId = jobId;
            JobState = jobState;
            IsActive = isActive;
            CreationTimeUTC = creationTimeUTC;
            ProviderSpecificDetails = providerSpecificDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets the job Id.
        /// </summary>
        [JsonProperty(PropertyName = "jobId")]
        public string JobId { get; private set; }

        /// <summary>
        /// Gets the job state.
        /// </summary>
        [JsonProperty(PropertyName = "jobState")]
        public string JobState { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the intent object is active.
        /// </summary>
        [JsonProperty(PropertyName = "isActive")]
        public bool? IsActive { get; private set; }

        /// <summary>
        /// Gets the creation time in UTC.
        /// </summary>
        [JsonProperty(PropertyName = "creationTimeUTC")]
        public string CreationTimeUTC { get; private set; }

        /// <summary>
        /// Gets or sets the Replication provider custom settings.
        /// </summary>
        [JsonProperty(PropertyName = "providerSpecificDetails")]
        public ReplicationProtectionIntentProviderSpecificSettings ProviderSpecificDetails { get; set; }

    }
}
