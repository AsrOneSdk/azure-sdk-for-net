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
    /// Recovery plan HVR Azure failover input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("HyperVReplicaAzure")]
    public partial class RecoveryPlanHyperVReplicaAzureFailoverInput : RecoveryPlanProviderSpecificFailoverInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanHyperVReplicaAzureFailoverInput class.
        /// </summary>
        public RecoveryPlanHyperVReplicaAzureFailoverInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanHyperVReplicaAzureFailoverInput class.
        /// </summary>
        /// <param name="primaryKekCertificatePfx">The primary KEK certificate
        /// PFX.</param>
        /// <param name="secondaryKekCertificatePfx">The secondary KEK
        /// certificate PFX.</param>
        /// <param name="recoveryPointType">The recovery point type. Possible
        /// values include: 'Latest', 'LatestApplicationConsistent',
        /// 'LatestProcessed'</param>
        public RecoveryPlanHyperVReplicaAzureFailoverInput(string primaryKekCertificatePfx = default(string), string secondaryKekCertificatePfx = default(string), string recoveryPointType = default(string))
        {
            PrimaryKekCertificatePfx = primaryKekCertificatePfx;
            SecondaryKekCertificatePfx = secondaryKekCertificatePfx;
            RecoveryPointType = recoveryPointType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the primary KEK certificate PFX.
        /// </summary>
        [JsonProperty(PropertyName = "primaryKekCertificatePfx")]
        public string PrimaryKekCertificatePfx { get; set; }

        /// <summary>
        /// Gets or sets the secondary KEK certificate PFX.
        /// </summary>
        [JsonProperty(PropertyName = "secondaryKekCertificatePfx")]
        public string SecondaryKekCertificatePfx { get; set; }

        /// <summary>
        /// Gets or sets the recovery point type. Possible values include:
        /// 'Latest', 'LatestApplicationConsistent', 'LatestProcessed'
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointType")]
        public string RecoveryPointType { get; set; }

    }
}
