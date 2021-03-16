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
    /// Enable migration input properties.
    /// </summary>
    public partial class EnableMigrationInputProperties
    {
        /// <summary>
        /// Initializes a new instance of the EnableMigrationInputProperties
        /// class.
        /// </summary>
        public EnableMigrationInputProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EnableMigrationInputProperties
        /// class.
        /// </summary>
        /// <param name="policyId">The policy Id.</param>
        /// <param name="providerSpecificDetails">The provider specific
        /// details.</param>
        public EnableMigrationInputProperties(string policyId, EnableMigrationProviderSpecificInput providerSpecificDetails)
        {
            PolicyId = policyId;
            ProviderSpecificDetails = providerSpecificDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the policy Id.
        /// </summary>
        [JsonProperty(PropertyName = "policyId")]
        public string PolicyId { get; set; }

        /// <summary>
        /// Gets or sets the provider specific details.
        /// </summary>
        [JsonProperty(PropertyName = "providerSpecificDetails")]
        public EnableMigrationProviderSpecificInput ProviderSpecificDetails { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PolicyId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PolicyId");
            }
            if (ProviderSpecificDetails == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProviderSpecificDetails");
            }
        }
    }
}
