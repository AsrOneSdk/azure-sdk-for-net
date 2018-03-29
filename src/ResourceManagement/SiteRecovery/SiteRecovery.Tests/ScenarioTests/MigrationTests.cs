//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Management.SiteRecovery;
using Microsoft.Azure.Management.SiteRecovery.Models;
using Microsoft.Azure.Test;
using Xunit;


namespace SiteRecovery.Tests.ScenarioTests
{
    public class MigrationTests : SiteRecoveryTestsBase
    {
        private string vmwareFabricName = "vmwarefabric1";
        private string vmwareContainerName = "vmwarefabric1-cloud";
        private string azureFabricName = "azurefabric-we";
        private string azureContainerName = "azurefabric-we-cloud";

        private string draName = "vmwaredra1";
        private string policyName = "vmwarepolicy1";
        private string containerMappingName = "vmwaremapping1";

        [Fact]
        public void Migration_Initialize()
        {
            using (UndoContext context = UndoContext.Current)
            {
                try
                {
                    context.Start();
                    var client = GetSiteRecoveryClient(CustomHttpHandler);

                    // Create VMware fabric.
                    var vmwareFabricInput = new FabricCreationInput()
                    {
                        Properties = new FabricCreationInputProperties()
                        {
                            CustomDetails = new VMwareV2FabricCreationInput()
                            {
                                InstanceType = "VMwareV2"
                            }
                        }
                    };
                    client.Fabrics.Create(vmwareFabricName, vmwareFabricInput, RequestHeaders);

                    // Create VMware container.
                    var vmwareContainerInput = new CreateProtectionContainerInput()
                    {
                        Properties = new CreateProtectionContainerInputProperties()
                        {
                            ProviderSpecificInputs = new List<ReplicationProviderSpecificContainerCreationInput>()
                            {
                                new VMwareCbtContainerCreationInput()
                                {
                                    InstanceType = "VMwareCbt"
                                }
                            }
                        }
                    };
                    client.ProtectionContainer.Create(vmwareFabricName, vmwareContainerName, vmwareContainerInput, RequestHeaders);

                    // Create VMware DRA.
                    var draInput = new RecoveryServicesProviderCreationInput()
                    {
                        Properties = new RecoveryServicesProviderCreationInputProperties()
                        {
                            MachineName = draName,
                            CustomDetails = new VMwareV2RecoveryServicesProviderCreationInput()
                            {
                                VMwareSiteArmId = "randomsiteid",
                                InstanceType = "VMwareV2"

                            }
                        }
                    };
                    client.RecoveryServicesProvider.Create(vmwareFabricName, draName, draInput, RequestHeaders);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        [Fact]
        public void Migration_ContainerMapping()
        {
            using (UndoContext context = UndoContext.Current)
            {
                try
                {
                    // Ensure DRA is running and the VMware cloud entity is created before running
                    // this test.
                    context.Start();
                    var client = GetSiteRecoveryClient(CustomHttpHandler);

                    // Create Azure fabric.
                    var azureFabricInput = new FabricCreationInput()
                    {
                        Properties = new FabricCreationInputProperties()
                        {
                            CustomDetails = new AzureFabricCreationInput()
                            {
                                InstanceType = "Azure",
                                Location = "West Europe"
                            }
                        }
                    };
                    client.Fabrics.Create(azureFabricName, azureFabricInput, RequestHeaders);

                    // Create Azure container.
                    var azureContainerInput = new CreateProtectionContainerInput()
                    {
                        Properties = new CreateProtectionContainerInputProperties()
                        {
                            ProviderSpecificInputs = new List<ReplicationProviderSpecificContainerCreationInput>()
                            {
                                new VMwareCbtContainerCreationInput()
                                {
                                    InstanceType = "VMwareCbt"
                                }
                            }
                        }
                    };
                    client.ProtectionContainer.Create(azureFabricName, azureContainerName, azureContainerInput, RequestHeaders);

                    // Create VMware policy.
                    var policyInput = new CreatePolicyInput()
                    {
                        Properties = new CreatePolicyInputProperties()
                        {
                            ProviderSpecificInput = new VMwareCbtPolicyCreationInput()
                            {
                                RecoveryPointHistoryInMinutes = 24 * 60,
                                CrashConsistentFrequencyInMinutes = 60,
                                AppConsistentFrequencyInMinutes = 60
                            }
                        }
                    };
                    client.Policies.Create(policyName, policyInput, RequestHeaders);

                    // Get the required entities.
                    var fabrics = client.Fabrics.List(RequestHeaders).Fabrics.ToList();
                    var vmwareContainer = client.ProtectionContainer.List(vmwareFabricName, RequestHeaders).ProtectionContainers.Single();
                    var azureContainer = client.ProtectionContainer.List(azureFabricName, RequestHeaders).ProtectionContainers.Single();
                    var vmwarePolicy = client.Policies.List(RequestHeaders).Policies.Where(x => x.Name == policyName).Single();

                    // Create container mappping.
                    var mappingInput = new CreateProtectionContainerMappingInput
                    {
                        Properties = new CreateProtectionContainerMappingInputProperties()
                        {
                            PolicyId = vmwarePolicy.Id,
                            TargetProtectionContainerId = azureContainer.Id,
                            ProviderSpecificInput = new VMwareCbtPolicyContainerMappingInput()
                            {
                                KeyVaultArmId = "KVARMID",
                                KeyVaultUrl =
                                    Environment.ExpandEnvironmentVariables("https://%COMPUTERNAME%-targetkv.vault.azure.net"),
                                ServiceBusConnectionStringSecretName = "SBusRootManageSharedAccessKey",
                                StorageAccountSasSecretName = "something"
                            }
                        }
                    };
                    client.ProtectionContainerMapping.ConfigureProtection(
                        vmwareFabricName,
                        vmwareContainerName,
                        containerMappingName,
                        mappingInput,
                        RequestHeaders);

                    // Get all mapings.
                    var mappings = client.ProtectionContainerMapping.List(vmwareFabricName, azureContainerName, RequestHeaders);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
