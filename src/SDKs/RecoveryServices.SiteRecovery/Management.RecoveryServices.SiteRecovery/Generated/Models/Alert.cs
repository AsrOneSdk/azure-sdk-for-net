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
    /// Implements the Alert class.
    /// </summary>
    public partial class Alert : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Alert class.
        /// </summary>
        public Alert()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Alert class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource Name</param>
        /// <param name="type">Resource Type</param>
        /// <param name="location">Resource Location</param>
        /// <param name="properties">Alert related data.</param>
        public Alert(string id = default(string), string name = default(string), string type = default(string), string location = default(string), AlertProperties properties = default(AlertProperties))
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
        /// Gets or sets alert related data.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public AlertProperties Properties { get; set; }

    }
}
