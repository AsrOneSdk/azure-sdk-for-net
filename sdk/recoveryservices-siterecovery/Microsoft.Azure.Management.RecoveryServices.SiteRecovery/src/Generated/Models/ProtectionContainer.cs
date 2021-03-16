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
    /// Protection container details.
    /// </summary>
    public partial class ProtectionContainer : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ProtectionContainer class.
        /// </summary>
        public ProtectionContainer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProtectionContainer class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource Name</param>
        /// <param name="type">Resource Type</param>
        /// <param name="location">Resource Location</param>
        /// <param name="properties">The custom data.</param>
        public ProtectionContainer(string id = default(string), string name = default(string), string type = default(string), string location = default(string), ProtectionContainerProperties properties = default(ProtectionContainerProperties))
            : base(id, name, type, location)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the custom data.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public ProtectionContainerProperties Properties { get; set; }

    }
}
