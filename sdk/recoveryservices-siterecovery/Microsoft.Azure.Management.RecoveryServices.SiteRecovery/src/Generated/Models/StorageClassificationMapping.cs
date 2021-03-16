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
    /// Storage mapping object.
    /// </summary>
    public partial class StorageClassificationMapping : Resource
    {
        /// <summary>
        /// Initializes a new instance of the StorageClassificationMapping
        /// class.
        /// </summary>
        public StorageClassificationMapping()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageClassificationMapping
        /// class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource Name</param>
        /// <param name="type">Resource Type</param>
        /// <param name="location">Resource Location</param>
        /// <param name="properties">Properties of the storage mapping
        /// object.</param>
        public StorageClassificationMapping(string id = default(string), string name = default(string), string type = default(string), string location = default(string), StorageClassificationMappingProperties properties = default(StorageClassificationMappingProperties))
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
        /// Gets or sets properties of the storage mapping object.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public StorageClassificationMappingProperties Properties { get; set; }

    }
}
