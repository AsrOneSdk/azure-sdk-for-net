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
    /// Details of the OS Disk.
    /// </summary>
    public partial class OSDiskDetails
    {
        /// <summary>
        /// Initializes a new instance of the OSDiskDetails class.
        /// </summary>
        public OSDiskDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OSDiskDetails class.
        /// </summary>
        /// <param name="osVhdId">The id of the disk containing the OS.</param>
        /// <param name="osType">The type of the OS on the VM.</param>
        /// <param name="vhdName">The OS disk VHD name.</param>
        public OSDiskDetails(string osVhdId = default(string), string osType = default(string), string vhdName = default(string))
        {
            OsVhdId = osVhdId;
            OsType = osType;
            VhdName = vhdName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of the disk containing the OS.
        /// </summary>
        [JsonProperty(PropertyName = "osVhdId")]
        public string OsVhdId { get; set; }

        /// <summary>
        /// Gets or sets the type of the OS on the VM.
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; set; }

        /// <summary>
        /// Gets or sets the OS disk VHD name.
        /// </summary>
        [JsonProperty(PropertyName = "vhdName")]
        public string VhdName { get; set; }

    }
}
