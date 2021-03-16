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
    /// Input definition for planned failover.
    /// </summary>
    public partial class PlannedFailoverInput
    {
        /// <summary>
        /// Initializes a new instance of the PlannedFailoverInput class.
        /// </summary>
        public PlannedFailoverInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PlannedFailoverInput class.
        /// </summary>
        /// <param name="properties">Planned failover input properties.</param>
        public PlannedFailoverInput(PlannedFailoverInputProperties properties = default(PlannedFailoverInputProperties))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets planned failover input properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public PlannedFailoverInputProperties Properties { get; set; }

    }
}
