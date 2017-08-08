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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Azure Fabric Specific Details.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Azure")]
    public partial class AzureFabricSpecificDetails : FabricSpecificDetails
    {
        /// <summary>
        /// Initializes a new instance of the AzureFabricSpecificDetails class.
        /// </summary>
        public AzureFabricSpecificDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureFabricSpecificDetails class.
        /// </summary>
        /// <param name="location">The Location for the Azure fabric.</param>
        /// <param name="containerIds">The container Ids for the Azure
        /// fabric.</param>
        public AzureFabricSpecificDetails(string location = default(string), IList<string> containerIds = default(IList<string>))
        {
            Location = location;
            ContainerIds = containerIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Location for the Azure fabric.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the container Ids for the Azure fabric.
        /// </summary>
        [JsonProperty(PropertyName = "containerIds")]
        public IList<string> ContainerIds { get; set; }

    }
}
