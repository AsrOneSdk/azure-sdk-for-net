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
    /// A2A Cross-Cluster Migration enable protection input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("A2ACrossClusterMigration")]
    public partial class A2ACrossClusterMigrationEnableProtectionInput : EnableProtectionProviderSpecificInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// A2ACrossClusterMigrationEnableProtectionInput class.
        /// </summary>
        public A2ACrossClusterMigrationEnableProtectionInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// A2ACrossClusterMigrationEnableProtectionInput class.
        /// </summary>
        /// <param name="fabricObjectId">The fabric specific object Id of the
        /// virtual machine.</param>
        /// <param name="recoveryContainerId">The recovery container
        /// Id.</param>
        public A2ACrossClusterMigrationEnableProtectionInput(string fabricObjectId = default(string), string recoveryContainerId = default(string))
        {
            FabricObjectId = fabricObjectId;
            RecoveryContainerId = recoveryContainerId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the fabric specific object Id of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "fabricObjectId")]
        public string FabricObjectId { get; set; }

        /// <summary>
        /// Gets or sets the recovery container Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryContainerId")]
        public string RecoveryContainerId { get; set; }

    }
}
