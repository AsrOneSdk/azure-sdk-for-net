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
    /// Resolve health input.
    /// </summary>
    public partial class ResolveHealthInput
    {
        /// <summary>
        /// Initializes a new instance of the ResolveHealthInput class.
        /// </summary>
        public ResolveHealthInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResolveHealthInput class.
        /// </summary>
        /// <param name="properties">Disable resolve health input
        /// properties.</param>
        public ResolveHealthInput(ResolveHealthInputProperties properties = default(ResolveHealthInputProperties))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets disable resolve health input properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public ResolveHealthInputProperties Properties { get; set; }

    }
}
