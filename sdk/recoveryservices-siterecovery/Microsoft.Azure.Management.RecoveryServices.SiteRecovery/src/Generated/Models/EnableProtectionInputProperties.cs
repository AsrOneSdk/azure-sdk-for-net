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
    /// Enable protection input properties.
    /// </summary>
    public partial class EnableProtectionInputProperties
    {
        /// <summary>
        /// Initializes a new instance of the EnableProtectionInputProperties
        /// class.
        /// </summary>
        public EnableProtectionInputProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EnableProtectionInputProperties
        /// class.
        /// </summary>
        /// <param name="policyId">The Policy Id.</param>
        /// <param name="protectableItemId">The protectable item Id.</param>
        /// <param name="providerSpecificDetails">The ReplicationProviderInput.
        /// For HyperVReplicaAzure provider, it will be
        /// AzureEnableProtectionInput object. For San provider, it will be
        /// SanEnableProtectionInput object. For HyperVReplicaAzure provider,
        /// it can be null.</param>
        public EnableProtectionInputProperties(string policyId = default(string), string protectableItemId = default(string), EnableProtectionProviderSpecificInput providerSpecificDetails = default(EnableProtectionProviderSpecificInput))
        {
            PolicyId = policyId;
            ProtectableItemId = protectableItemId;
            ProviderSpecificDetails = providerSpecificDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Policy Id.
        /// </summary>
        [JsonProperty(PropertyName = "policyId")]
        public string PolicyId { get; set; }

        /// <summary>
        /// Gets or sets the protectable item Id.
        /// </summary>
        [JsonProperty(PropertyName = "protectableItemId")]
        public string ProtectableItemId { get; set; }

        /// <summary>
        /// Gets or sets the ReplicationProviderInput. For HyperVReplicaAzure
        /// provider, it will be AzureEnableProtectionInput object. For San
        /// provider, it will be SanEnableProtectionInput object. For
        /// HyperVReplicaAzure provider, it can be null.
        /// </summary>
        [JsonProperty(PropertyName = "providerSpecificDetails")]
        public EnableProtectionProviderSpecificInput ProviderSpecificDetails { get; set; }

    }
}
