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
    /// Input definition for planned failover.
    /// </summary>
    public partial class UnplannedFailoverInput
    {
        /// <summary>
        /// Initializes a new instance of the UnplannedFailoverInput class.
        /// </summary>
        public UnplannedFailoverInput()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UnplannedFailoverInput class.
        /// </summary>
        /// <param name="properties">Planned failover input properties</param>
        public UnplannedFailoverInput(UnplannedFailoverInputProperties properties = default(UnplannedFailoverInputProperties))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets planned failover input properties
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public UnplannedFailoverInputProperties Properties { get; set; }

    }
}
