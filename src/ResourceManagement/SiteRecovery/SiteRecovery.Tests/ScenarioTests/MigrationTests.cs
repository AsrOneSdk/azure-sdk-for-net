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
using System.Diagnostics;
using System.Linq;
using Microsoft.Azure.Management.SiteRecovery;
using Microsoft.Azure.Management.SiteRecovery.Models;
using Microsoft.Azure.Test;
using Xunit;


namespace SiteRecovery.Tests.ScenarioTests
{
    public class MigrationTests : SiteRecoveryTestsBase
    {
        // VMware fabric input
        private const string VMwareFabricName = "vmwarefabric1";
        private const string VMwareContainerName = "vmwarefabric1-cloud";
        private const string VMwareSiteId = "/subscriptions/sub123/resourceGroups/rg123/providers/Microsoft.VMware/sites/site123";

        // Azure fabric input.
        private const string AzureFabricName = "azurefabric-sea";
        private const string AzureContainerName = "azurefabric-sea-cloud";
        private const string AzureFabricLocation = "Southeast Asia";

        // VMware DRA input.
        private const string VMwareDraName = "vmwaredra1";
        private const string TenantId = "72f988bf-86f1-41af-91ab-2d7cd011db47";
        private const string ApplicationId = "6d3522b5-e5ee-429d-ba62-0c0866bbc6f2";
        private const string ObjectId = "771b8f96-a189-40b6-a7a0-bca3db0e76d1";
        private const string Audience = "https://GSINHA-Z230";
        private const string AadAuthority = "https://login.microsoftonline.com";

        // VMware policy input.
        private const string VMwarePolicyName = "vmwarepolicy1";
        private const int CrashInterval = 15;
        private const int AppInterval = 60;
        private const int RecoveryPointHistory = 60 * 24;

        // Cloud pairing input.
        private const string ContainerMappingName = "vmwaremapping1";
        private const string KeyVaultArmId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourceGroups/TestRG1/providers/Microsoft.KeyVault/vaults/TestKV1";
        private const string KeyVaultUri = "https://%COMPUTERNAME%-targetkv.vault.azure.net";
        private const string StorageAccountArmId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourceGroups/TestRG1/providers/Microsoft.Storage/storageAccounts/TestSA1";
        private const string StorageAccountSasSecretName = "something";
        private const string ServiceBusConnectionStringSecretName = "SBusRootManageSharedAccessKey";


        [Fact]
        public void Migration_Initialize()
        {
            using (UndoContext context = UndoContext.Current)
            {
                try
                {
                    context.Start();
                    var client = GetSiteRecoveryClient(CustomHttpHandler, "Migration");

                    // Create VMware fabric.
                    var vmwareFabricInput = new FabricCreationInput()
                    {
                        Properties = new FabricCreationInputProperties()
                        {
                            CustomDetails = new VMwareV2FabricCreationInput()
                            {
                                InstanceType = "VMwareV2",
                                VMwareSiteArmId = VMwareSiteId
                            }
                        }
                    };
                    client.Fabrics.Create(VMwareFabricName, vmwareFabricInput, RequestHeaders);

                    // Create VMware DRA.
                    var vmwareDraInput = new RecoveryServicesProviderCreationInput()
                    {
                        Properties = new RecoveryServicesProviderCreationInputProperties()
                        {
                            MachineName = VMwareDraName,
                            AuthenticationIdentityInput = new IdentityProviderDetails()
                            {
                                TenantId = TenantId,
                                ApplicationId = ApplicationId,
                                ObjectId = ObjectId,
                                Audience = Audience,
                                AadAuthority = AadAuthority
                            },
                            ResourceAccessIdentityInput = new IdentityProviderDetails()
                            {
                                TenantId = TenantId,
                                ApplicationId = ApplicationId,
                                ObjectId = ObjectId,
                                Audience = Audience,
                                AadAuthority = AadAuthority
                            }
                        }
                    };
                    client.RecoveryServicesProvider.Create(VMwareFabricName, VMwareDraName, vmwareDraInput, RequestHeaders);

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
                    client.ProtectionContainer.Create(VMwareFabricName, VMwareContainerName, vmwareContainerInput, RequestHeaders);
                }
                catch (Exception)
                {
                    Debugger.Break();
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
                    var client = GetSiteRecoveryClient(CustomHttpHandler, "Migration");

                    // Create Azure fabric.
                    var azureFabricInput = new FabricCreationInput()
                    {
                        Properties = new FabricCreationInputProperties()
                        {
                            CustomDetails = new AzureFabricCreationInput()
                            {
                                InstanceType = "Azure",
                                Location = AzureFabricLocation
                            }
                        }
                    };
                    client.Fabrics.Create(AzureFabricName, azureFabricInput, RequestHeaders);

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
                    client.ProtectionContainer.Create(AzureFabricName, AzureContainerName, azureContainerInput, RequestHeaders);

                    // Create VMware policy.
                    var vmwarePolicyInput = new CreatePolicyInput()
                    {
                        Properties = new CreatePolicyInputProperties()
                        {
                            ProviderSpecificInput = new VMwareCbtPolicyCreationInput()
                            {
                                RecoveryPointHistoryInMinutes = RecoveryPointHistory,
                                CrashConsistentFrequencyInMinutes = CrashInterval,
                                AppConsistentFrequencyInMinutes = AppInterval
                            }
                        }
                    };
                    client.Policies.Create(VMwarePolicyName, vmwarePolicyInput, RequestHeaders);

                    // Get the required entities.
                    var fabrics = client.Fabrics.List(RequestHeaders).Fabrics.ToList();
                    var vmwareContainer = client.ProtectionContainer.List(VMwareFabricName, RequestHeaders).ProtectionContainers.Single();
                    var azureContainer = client.ProtectionContainer.List(AzureFabricName, RequestHeaders).ProtectionContainers.Single();
                    var vmwarePolicy = client.Policies.List(RequestHeaders).Policies.Where(x => x.Name == VMwarePolicyName).Single();

                    // Create container mappping.
                    var mappingInput = new CreateProtectionContainerMappingInput
                    {
                        Properties = new CreateProtectionContainerMappingInputProperties()
                        {
                            PolicyId = vmwarePolicy.Id,
                            TargetProtectionContainerId = azureContainer.Id,
                            ProviderSpecificInput = new VMwareCbtPolicyContainerMappingInput()
                            {
                                KeyVaultArmId = KeyVaultArmId,
                                KeyVaultUri = KeyVaultUri,
                                StorageAccountArmId = StorageAccountArmId,
                                StorageAccountSasSecretName = StorageAccountSasSecretName,
                                ServiceBusConnectionStringSecretName = ServiceBusConnectionStringSecretName
                            }
                        }
                    };
                    client.ProtectionContainerMapping.ConfigureProtection(
                        VMwareFabricName,
                        VMwareContainerName,
                        ContainerMappingName,
                        mappingInput,
                        RequestHeaders);

                    // Get all mapings.
                    var mappings = client.ProtectionContainerMapping.List(VMwareFabricName, AzureContainerName, RequestHeaders);
                }
                catch (Exception)
                {
                    Debugger.Break();
                    throw;
                }
            }
        }

        [Fact]
        public void Migration_Get()
        {
            using (UndoContext context = UndoContext.Current)
            {
                try
                {
                    context.Start();
                    var client = GetSiteRecoveryClient(CustomHttpHandler, "Migration");
                    var vmwareContainer = client.ProtectionContainer
                        .List(VMwareFabricName, RequestHeaders)
                        .ProtectionContainers
                        .Single();

                    // Get all items.
                    var items = client.MigrationItem.List(
                        VMwareFabricName,
                        vmwareContainer.Name,
                        RequestHeaders);

                    // Get single item.
                    var migItem = client.MigrationItem.Get(
                        VMwareFabricName,
                        vmwareContainer.Name,
                        "vmwareMigItem1",
                        RequestHeaders);
                }
                catch (Exception)
                {
                    Debugger.Break();
                    throw;
                }
            }
        }

        [Fact]
        public void Migration_Enable()
        {
            using (UndoContext context = UndoContext.Current)
            {
                try
                {
                    context.Start();
                    var client = GetSiteRecoveryClient(CustomHttpHandler, "Migration");

                    var vmwareContainer = client.ProtectionContainer
                        .List(VMwareFabricName, RequestHeaders)
                        .ProtectionContainers
                        .Single();
                    var vmwarePolicy = client.Policies
                        .List(RequestHeaders)
                        .Policies
                        .Where(x => x.Name == VMwarePolicyName)
                        .Single();

                    var enableMigrationInput = new EnableMigrationInput
                    {
                        Properties = new EnableMigrationInputProperties
                        {
                            PolicyId = vmwarePolicy.Id,
                            ProviderSpecificDetails = new VMwareCbtEnableMigrationInput
                            {
                                VMwareMachineArmId = "1234",
                                VCenterArmId = "1234"
                            }
                        }
                    };

                    var response = client.MigrationItem.EnableMigration(
                        VMwareFabricName,
                        vmwareContainer.Name,
                        "vmwareMigItem1",
                        enableMigrationInput,
                        RequestHeaders);

                    // Get all items.
                    var items = client.MigrationItem.List(
                        VMwareFabricName,
                        vmwareContainer.Name,
                        RequestHeaders);
                }
                catch (Exception)
                {
                    Debugger.Break();
                    throw;
                }
            }
        }
    }
}
