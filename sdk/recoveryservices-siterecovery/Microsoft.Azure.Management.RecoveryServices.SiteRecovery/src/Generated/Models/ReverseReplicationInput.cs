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
    /// Reverse replication input.
    /// </summary>
    public partial class ReverseReplicationInput
    {
        /// <summary>
        /// Initializes a new instance of the ReverseReplicationInput class.
        /// </summary>
        public ReverseReplicationInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReverseReplicationInput class.
        /// </summary>
        /// <param name="properties">Reverse replication properties.</param>
        public ReverseReplicationInput(ReverseReplicationInputProperties properties = default(ReverseReplicationInputProperties))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets reverse replication properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public ReverseReplicationInputProperties Properties { get; set; }

    }
}
