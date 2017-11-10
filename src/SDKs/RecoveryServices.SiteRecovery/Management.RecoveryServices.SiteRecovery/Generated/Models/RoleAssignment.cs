// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
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
    /// Azure role assignment details.
    /// </summary>
    public partial class RoleAssignment
    {
        /// <summary>
        /// Initializes a new instance of the RoleAssignment class.
        /// </summary>
        public RoleAssignment()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoleAssignment class.
        /// </summary>
        /// <param name="id">The ARM Id of the role assignment.</param>
        /// <param name="name">The name of the role assignment.</param>
        /// <param name="scope">Role assignment scope.</param>
        /// <param name="principalId">Principal Id.</param>
        /// <param name="roleDefinitionId">Role definition id.</param>
        public RoleAssignment(string id = default(string), string name = default(string), string scope = default(string), string principalId = default(string), string roleDefinitionId = default(string))
        {
            Id = id;
            Name = name;
            Scope = scope;
            PrincipalId = principalId;
            RoleDefinitionId = roleDefinitionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ARM Id of the role assignment.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the role assignment.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets role assignment scope.
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or sets principal Id.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// Gets or sets role definition id.
        /// </summary>
        [JsonProperty(PropertyName = "roleDefinitionId")]
        public string RoleDefinitionId { get; set; }

    }
}
