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
    /// E2E Network Mapping fabric specific settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("VmmToVmm")]
    public partial class VmmToVmmNetworkMappingSettings : NetworkMappingFabricSpecificSettings
    {
        /// <summary>
        /// Initializes a new instance of the VmmToVmmNetworkMappingSettings
        /// class.
        /// </summary>
        public VmmToVmmNetworkMappingSettings()
        {
          CustomInit();
        }


        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
