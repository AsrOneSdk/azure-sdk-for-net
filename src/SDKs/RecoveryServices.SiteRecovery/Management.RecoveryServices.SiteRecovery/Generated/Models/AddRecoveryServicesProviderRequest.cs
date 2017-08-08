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
    /// Input required to add a provider.
    /// </summary>
    public partial class AddRecoveryServicesProviderRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AddRecoveryServicesProviderRequest class.
        /// </summary>
        public AddRecoveryServicesProviderRequest()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AddRecoveryServicesProviderRequest class.
        /// </summary>
        /// <param name="properties">The properties of an add provider
        /// request.</param>
        public AddRecoveryServicesProviderRequest(AddRecoveryServicesProviderRequestProperties properties = default(AddRecoveryServicesProviderRequestProperties))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the properties of an add provider request.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public AddRecoveryServicesProviderRequestProperties Properties { get; set; }

    }
}
