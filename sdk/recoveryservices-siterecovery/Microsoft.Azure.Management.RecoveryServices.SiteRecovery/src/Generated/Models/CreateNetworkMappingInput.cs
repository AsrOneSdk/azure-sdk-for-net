// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Create network mappings input.
    /// </summary>
    public partial class CreateNetworkMappingInput
    {
        /// <summary>
        /// Initializes a new instance of the CreateNetworkMappingInput class.
        /// </summary>
        public CreateNetworkMappingInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateNetworkMappingInput class.
        /// </summary>
        /// <param name="properties">Input properties for creating network
        /// mapping.</param>
        public CreateNetworkMappingInput(CreateNetworkMappingInputProperties properties)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets input properties for creating network mapping.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public CreateNetworkMappingInputProperties Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Properties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Properties");
            }
            if (Properties != null)
            {
                Properties.Validate();
            }
        }
    }
}
