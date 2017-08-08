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
    /// Identity provider specific settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("RecoveryServicesActiveDirectory")]
    public partial class RecoveryServicesAadIdentityProviderInput : IdentityProviderInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryServicesAadIdentityProviderInput class.
        /// </summary>
        public RecoveryServicesAadIdentityProviderInput()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryServicesAadIdentityProviderInput class.
        /// </summary>
        /// <param name="rawCertData">The raw certificate data (no private
        /// key).</param>
        public RecoveryServicesAadIdentityProviderInput(string rawCertData = default(string))
        {
            RawCertData = rawCertData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the raw certificate data (no private key).
        /// </summary>
        [JsonProperty(PropertyName = "rawCertData")]
        public string RawCertData { get; set; }

    }
}
