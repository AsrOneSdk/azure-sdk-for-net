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
    /// Wrapper model for OSVersion to include version and service pack info.
    /// </summary>
    public partial class OSVersionWrapper
    {
        /// <summary>
        /// Initializes a new instance of the OSVersionWrapper class.
        /// </summary>
        public OSVersionWrapper()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OSVersionWrapper class.
        /// </summary>
        /// <param name="version">The version.</param>
        /// <param name="servicePack">The service pack.</param>
        public OSVersionWrapper(string version = default(string), string servicePack = default(string))
        {
            Version = version;
            ServicePack = servicePack;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the service pack.
        /// </summary>
        [JsonProperty(PropertyName = "servicePack")]
        public string ServicePack { get; set; }

    }
}
