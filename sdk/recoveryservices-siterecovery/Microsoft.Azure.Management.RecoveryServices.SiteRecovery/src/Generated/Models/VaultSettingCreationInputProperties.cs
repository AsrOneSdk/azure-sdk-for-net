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
    /// Input to create vault setting.
    /// </summary>
    public partial class VaultSettingCreationInputProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VaultSettingCreationInputProperties class.
        /// </summary>
        public VaultSettingCreationInputProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VaultSettingCreationInputProperties class.
        /// </summary>
        /// <param name="migrationSolutionId">The migration solution
        /// Id.</param>
        public VaultSettingCreationInputProperties(string migrationSolutionId)
        {
            MigrationSolutionId = migrationSolutionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the migration solution Id.
        /// </summary>
        [JsonProperty(PropertyName = "migrationSolutionId")]
        public string MigrationSolutionId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MigrationSolutionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MigrationSolutionId");
            }
        }
    }
}
