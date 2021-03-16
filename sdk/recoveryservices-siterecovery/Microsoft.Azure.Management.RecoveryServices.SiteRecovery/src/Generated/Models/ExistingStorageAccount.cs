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
    /// Existing storage account input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Existing")]
    public partial class ExistingStorageAccount : StorageAccountCustomDetails
    {
        /// <summary>
        /// Initializes a new instance of the ExistingStorageAccount class.
        /// </summary>
        public ExistingStorageAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExistingStorageAccount class.
        /// </summary>
        /// <param name="azureStorageAccountId">The storage account Arm Id.
        /// Throw error, if resource does not exists.</param>
        public ExistingStorageAccount(string azureStorageAccountId)
        {
            AzureStorageAccountId = azureStorageAccountId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the storage account Arm Id. Throw error, if resource
        /// does not exists.
        /// </summary>
        [JsonProperty(PropertyName = "azureStorageAccountId")]
        public string AzureStorageAccountId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AzureStorageAccountId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AzureStorageAccountId");
            }
        }
    }
}
