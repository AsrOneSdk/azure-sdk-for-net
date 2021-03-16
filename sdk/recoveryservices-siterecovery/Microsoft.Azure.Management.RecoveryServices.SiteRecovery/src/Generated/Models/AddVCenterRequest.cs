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
    /// Input required to add vCenter.
    /// </summary>
    public partial class AddVCenterRequest
    {
        /// <summary>
        /// Initializes a new instance of the AddVCenterRequest class.
        /// </summary>
        public AddVCenterRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AddVCenterRequest class.
        /// </summary>
        /// <param name="properties">The properties of an add vCenter
        /// request.</param>
        public AddVCenterRequest(AddVCenterRequestProperties properties = default(AddVCenterRequestProperties))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the properties of an add vCenter request.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public AddVCenterRequestProperties Properties { get; set; }

    }
}
