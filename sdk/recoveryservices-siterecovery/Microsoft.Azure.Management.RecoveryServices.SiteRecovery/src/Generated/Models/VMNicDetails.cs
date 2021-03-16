// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Hyper V VM network details.
    /// </summary>
    public partial class VMNicDetails
    {
        /// <summary>
        /// Initializes a new instance of the VMNicDetails class.
        /// </summary>
        public VMNicDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VMNicDetails class.
        /// </summary>
        /// <param name="nicId">The nic Id.</param>
        /// <param name="replicaNicId">The replica nic Id.</param>
        /// <param name="sourceNicArmId">The source nic ARM Id.</param>
        /// <param name="vMNetworkName">VM network name.</param>
        /// <param name="recoveryVMNetworkId">Recovery VM network Id.</param>
        /// <param name="ipConfigs">The IP configurations of the NIC.</param>
        /// <param name="selectionType">Selection type for failover.</param>
        /// <param name="recoveryNetworkSecurityGroupId">The id of the NSG
        /// associated with the NIC.</param>
        /// <param name="enableAcceleratedNetworkingOnRecovery">A value
        /// indicating whether the NIC has accelerated networking
        /// enabled.</param>
        /// <param name="tfoVMNetworkId">The network to be used by NIC during
        /// test failover.</param>
        /// <param name="tfoNetworkSecurityGroupId">The NSG to be used by NIC
        /// during test failover.</param>
        /// <param name="enableAcceleratedNetworkingOnTfo">Whether the TFO NIC
        /// has accelerated networking enabled.</param>
        /// <param name="recoveryNicName">The name of the NIC to be used when
        /// creating target NICs.</param>
        /// <param name="recoveryNicResourceGroupName">The resource group of
        /// the NIC to be used when creating target NICs.</param>
        /// <param name="reuseExistingNic">A value indicating whether an
        /// existing NIC is allowed to be reused during failover subject to
        /// availability.</param>
        /// <param name="tfoRecoveryNicName">The name of the NIC to be used
        /// when creating target NICs in TFO.</param>
        /// <param name="tfoRecoveryNicResourceGroupName">The resource group of
        /// the NIC to be used when creating target NICs in TFO.</param>
        /// <param name="tfoReuseExistingNic">A value indicating whether an
        /// existing NIC is allowed to be reused during test failover subject
        /// to availability.</param>
        public VMNicDetails(string nicId = default(string), string replicaNicId = default(string), string sourceNicArmId = default(string), string vMNetworkName = default(string), string recoveryVMNetworkId = default(string), IList<IPConfigDetails> ipConfigs = default(IList<IPConfigDetails>), string selectionType = default(string), string recoveryNetworkSecurityGroupId = default(string), bool? enableAcceleratedNetworkingOnRecovery = default(bool?), string tfoVMNetworkId = default(string), string tfoNetworkSecurityGroupId = default(string), bool? enableAcceleratedNetworkingOnTfo = default(bool?), string recoveryNicName = default(string), string recoveryNicResourceGroupName = default(string), bool? reuseExistingNic = default(bool?), string tfoRecoveryNicName = default(string), string tfoRecoveryNicResourceGroupName = default(string), bool? tfoReuseExistingNic = default(bool?))
        {
            NicId = nicId;
            ReplicaNicId = replicaNicId;
            SourceNicArmId = sourceNicArmId;
            VMNetworkName = vMNetworkName;
            RecoveryVMNetworkId = recoveryVMNetworkId;
            IpConfigs = ipConfigs;
            SelectionType = selectionType;
            RecoveryNetworkSecurityGroupId = recoveryNetworkSecurityGroupId;
            EnableAcceleratedNetworkingOnRecovery = enableAcceleratedNetworkingOnRecovery;
            TfoVMNetworkId = tfoVMNetworkId;
            TfoNetworkSecurityGroupId = tfoNetworkSecurityGroupId;
            EnableAcceleratedNetworkingOnTfo = enableAcceleratedNetworkingOnTfo;
            RecoveryNicName = recoveryNicName;
            RecoveryNicResourceGroupName = recoveryNicResourceGroupName;
            ReuseExistingNic = reuseExistingNic;
            TfoRecoveryNicName = tfoRecoveryNicName;
            TfoRecoveryNicResourceGroupName = tfoRecoveryNicResourceGroupName;
            TfoReuseExistingNic = tfoReuseExistingNic;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the nic Id.
        /// </summary>
        [JsonProperty(PropertyName = "nicId")]
        public string NicId { get; set; }

        /// <summary>
        /// Gets or sets the replica nic Id.
        /// </summary>
        [JsonProperty(PropertyName = "replicaNicId")]
        public string ReplicaNicId { get; set; }

        /// <summary>
        /// Gets or sets the source nic ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "sourceNicArmId")]
        public string SourceNicArmId { get; set; }

        /// <summary>
        /// Gets or sets VM network name.
        /// </summary>
        [JsonProperty(PropertyName = "vMNetworkName")]
        public string VMNetworkName { get; set; }

        /// <summary>
        /// Gets or sets recovery VM network Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryVMNetworkId")]
        public string RecoveryVMNetworkId { get; set; }

        /// <summary>
        /// Gets or sets the IP configurations of the NIC.
        /// </summary>
        [JsonProperty(PropertyName = "ipConfigs")]
        public IList<IPConfigDetails> IpConfigs { get; set; }

        /// <summary>
        /// Gets or sets selection type for failover.
        /// </summary>
        [JsonProperty(PropertyName = "selectionType")]
        public string SelectionType { get; set; }

        /// <summary>
        /// Gets or sets the id of the NSG associated with the NIC.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryNetworkSecurityGroupId")]
        public string RecoveryNetworkSecurityGroupId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the NIC has accelerated
        /// networking enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enableAcceleratedNetworkingOnRecovery")]
        public bool? EnableAcceleratedNetworkingOnRecovery { get; set; }

        /// <summary>
        /// Gets or sets the network to be used by NIC during test failover.
        /// </summary>
        [JsonProperty(PropertyName = "tfoVMNetworkId")]
        public string TfoVMNetworkId { get; set; }

        /// <summary>
        /// Gets or sets the NSG to be used by NIC during test failover.
        /// </summary>
        [JsonProperty(PropertyName = "tfoNetworkSecurityGroupId")]
        public string TfoNetworkSecurityGroupId { get; set; }

        /// <summary>
        /// Gets or sets whether the TFO NIC has accelerated networking
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enableAcceleratedNetworkingOnTfo")]
        public bool? EnableAcceleratedNetworkingOnTfo { get; set; }

        /// <summary>
        /// Gets or sets the name of the NIC to be used when creating target
        /// NICs.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryNicName")]
        public string RecoveryNicName { get; set; }

        /// <summary>
        /// Gets or sets the resource group of the NIC to be used when creating
        /// target NICs.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryNicResourceGroupName")]
        public string RecoveryNicResourceGroupName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether an existing NIC is allowed
        /// to be reused during failover subject to availability.
        /// </summary>
        [JsonProperty(PropertyName = "reuseExistingNic")]
        public bool? ReuseExistingNic { get; set; }

        /// <summary>
        /// Gets or sets the name of the NIC to be used when creating target
        /// NICs in TFO.
        /// </summary>
        [JsonProperty(PropertyName = "tfoRecoveryNicName")]
        public string TfoRecoveryNicName { get; set; }

        /// <summary>
        /// Gets or sets the resource group of the NIC to be used when creating
        /// target NICs in TFO.
        /// </summary>
        [JsonProperty(PropertyName = "tfoRecoveryNicResourceGroupName")]
        public string TfoRecoveryNicResourceGroupName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether an existing NIC is allowed
        /// to be reused during test failover subject to availability.
        /// </summary>
        [JsonProperty(PropertyName = "tfoReuseExistingNic")]
        public bool? TfoReuseExistingNic { get; set; }

    }
}
