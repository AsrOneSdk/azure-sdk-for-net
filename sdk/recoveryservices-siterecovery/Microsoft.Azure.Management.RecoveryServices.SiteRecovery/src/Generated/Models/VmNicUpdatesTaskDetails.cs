// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// This class represents the vm NicUpdates task details.
    /// </summary>
    public partial class VmNicUpdatesTaskDetails : TaskTypeDetails
    {
        /// <summary>
        /// Initializes a new instance of the VmNicUpdatesTaskDetails class.
        /// </summary>
        public VmNicUpdatesTaskDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VmNicUpdatesTaskDetails class.
        /// </summary>
        /// <param name="vmId">Virtual machine Id.</param>
        /// <param name="nicId">Nic Id.</param>
        /// <param name="name">Name of the Nic.</param>
        public VmNicUpdatesTaskDetails(string vmId = default(string), string nicId = default(string), string name = default(string))
        {
            VmId = vmId;
            NicId = nicId;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets virtual machine Id.
        /// </summary>
        [JsonProperty(PropertyName = "vmId")]
        public string VmId { get; set; }

        /// <summary>
        /// Gets or sets nic Id.
        /// </summary>
        [JsonProperty(PropertyName = "nicId")]
        public string NicId { get; set; }

        /// <summary>
        /// Gets or sets name of the Nic.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
