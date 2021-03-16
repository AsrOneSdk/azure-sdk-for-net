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
    /// HyperVReplicaAzureFailback specific planned failover input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("HyperVReplicaAzureFailback")]
    public partial class HyperVReplicaAzureFailbackProviderInput : PlannedFailoverProviderSpecificFailoverInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// HyperVReplicaAzureFailbackProviderInput class.
        /// </summary>
        public HyperVReplicaAzureFailbackProviderInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// HyperVReplicaAzureFailbackProviderInput class.
        /// </summary>
        /// <param name="dataSyncOption">Data sync option.</param>
        /// <param name="recoveryVmCreationOption">ALR options to create
        /// alternate recovery.</param>
        /// <param name="providerIdForAlternateRecovery">Provider Id for
        /// alternate location.</param>
        public HyperVReplicaAzureFailbackProviderInput(string dataSyncOption = default(string), string recoveryVmCreationOption = default(string), string providerIdForAlternateRecovery = default(string))
        {
            DataSyncOption = dataSyncOption;
            RecoveryVmCreationOption = recoveryVmCreationOption;
            ProviderIdForAlternateRecovery = providerIdForAlternateRecovery;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets data sync option.
        /// </summary>
        [JsonProperty(PropertyName = "dataSyncOption")]
        public string DataSyncOption { get; set; }

        /// <summary>
        /// Gets or sets ALR options to create alternate recovery.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryVmCreationOption")]
        public string RecoveryVmCreationOption { get; set; }

        /// <summary>
        /// Gets or sets provider Id for alternate location.
        /// </summary>
        [JsonProperty(PropertyName = "providerIdForAlternateRecovery")]
        public string ProviderIdForAlternateRecovery { get; set; }

    }
}
