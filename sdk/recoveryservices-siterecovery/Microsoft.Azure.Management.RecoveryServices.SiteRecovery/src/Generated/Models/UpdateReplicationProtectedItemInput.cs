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
    /// Update replication protected item input.
    /// </summary>
    public partial class UpdateReplicationProtectedItemInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// UpdateReplicationProtectedItemInput class.
        /// </summary>
        public UpdateReplicationProtectedItemInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// UpdateReplicationProtectedItemInput class.
        /// </summary>
        /// <param name="properties">Update replication protected item
        /// properties.</param>
        public UpdateReplicationProtectedItemInput(UpdateReplicationProtectedItemInputProperties properties = default(UpdateReplicationProtectedItemInputProperties))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets update replication protected item properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public UpdateReplicationProtectedItemInputProperties Properties { get; set; }

    }
}
