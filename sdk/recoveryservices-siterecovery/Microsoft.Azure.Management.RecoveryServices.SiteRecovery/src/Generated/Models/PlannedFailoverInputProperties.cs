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
    /// Input definition for planned failover input properties.
    /// </summary>
    public partial class PlannedFailoverInputProperties
    {
        /// <summary>
        /// Initializes a new instance of the PlannedFailoverInputProperties
        /// class.
        /// </summary>
        public PlannedFailoverInputProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PlannedFailoverInputProperties
        /// class.
        /// </summary>
        /// <param name="failoverDirection">Failover direction.</param>
        /// <param name="providerSpecificDetails">Provider specific
        /// settings.</param>
        public PlannedFailoverInputProperties(string failoverDirection = default(string), PlannedFailoverProviderSpecificFailoverInput providerSpecificDetails = default(PlannedFailoverProviderSpecificFailoverInput))
        {
            FailoverDirection = failoverDirection;
            ProviderSpecificDetails = providerSpecificDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets failover direction.
        /// </summary>
        [JsonProperty(PropertyName = "failoverDirection")]
        public string FailoverDirection { get; set; }

        /// <summary>
        /// Gets or sets provider specific settings.
        /// </summary>
        [JsonProperty(PropertyName = "providerSpecificDetails")]
        public PlannedFailoverProviderSpecificFailoverInput ProviderSpecificDetails { get; set; }

    }
}
