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
    /// InMage Azure V2 input to update replication protected item.
    /// </summary>
    [Newtonsoft.Json.JsonObject("InMageAzureV2")]
    public partial class InMageAzureV2UpdateReplicationProtectedItemInput : UpdateReplicationProtectedItemProviderInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// InMageAzureV2UpdateReplicationProtectedItemInput class.
        /// </summary>
        public InMageAzureV2UpdateReplicationProtectedItemInput()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// InMageAzureV2UpdateReplicationProtectedItemInput class.
        /// </summary>
        /// <param name="recoveryAzureV1ResourceGroupId">The recovery Azure
        /// resource group Id for classic deployment.</param>
        /// <param name="recoveryAzureV2ResourceGroupId">The recovery Azure
        /// resource group Id for resource manager deployment.</param>
        /// <param name="useManagedDisks">A value indicating whether managed
        /// disks should be used during failover.</param>
        public InMageAzureV2UpdateReplicationProtectedItemInput(string recoveryAzureV1ResourceGroupId = default(string), string recoveryAzureV2ResourceGroupId = default(string), string useManagedDisks = default(string))
        {
            RecoveryAzureV1ResourceGroupId = recoveryAzureV1ResourceGroupId;
            RecoveryAzureV2ResourceGroupId = recoveryAzureV2ResourceGroupId;
            UseManagedDisks = useManagedDisks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the recovery Azure resource group Id for classic
        /// deployment.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureV1ResourceGroupId")]
        public string RecoveryAzureV1ResourceGroupId { get; set; }

        /// <summary>
        /// Gets or sets the recovery Azure resource group Id for resource
        /// manager deployment.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureV2ResourceGroupId")]
        public string RecoveryAzureV2ResourceGroupId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether managed disks should be
        /// used during failover.
        /// </summary>
        [JsonProperty(PropertyName = "useManagedDisks")]
        public string UseManagedDisks { get; set; }

    }
}
