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
        private const string VMwareSiteId = "/subscriptions/2a57d0a2-0955-4d1e-aa87-a0dbb87cbcab/resourceGroups/amit636640800574045018rg/providers/Microsoft.OffAzure/VMwareSites/amit636640800574045018Site";

        // Azure fabric input.
        private const string AzureFabricName = "azurefabric1";
        private const string AzureContainerName = "azurefabriccloud1";
        private const string AzureFabricLocation = "eastus";

        // VMware DRA input.
        private const string VMwareDraName = "vmwaredra1";
        private const string TenantId = "72f988bf-86f1-41af-91ab-2d7cd011db47";
        private const string ApplicationId = "c7e42964-c7e3-403e-b10d-5fcf32b04488";
        private const string ObjectId = "facfb768-c11c-42b3-b8c4-c63de2909c76";
        private const string Audience = "http://admi636639380186746585adappspnsvcagt";
        private const string AadAuthority = "https://login.microsoftonline.com";

        // VMware policy input.
        private const string VMwarePolicyName = "vmwarepolicy1";
        private const int CrashInterval = 60;
        private const int AppInterval = 60;
        private const int RecoveryPointHistory = 60 * 24;

        // Cloud pairing input.
        private const string ContainerMappingName = "vmwaremapping1";
        private const string KeyVaultId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourceGroups/Admi636639380186746585RG/providers/Microsoft.KeyVault/vaults/Admi636639380186746585KV";
        private const string KeyVaultUri = "https://admi636639380186746585kv.vault.azure.net/";
        private const string StorageAccountId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourceGroups/Admi636639380186746585RG/providers/Microsoft.Storage/storageAccounts/admi636639380186746585sa";
        private const string StorageAccountSasSecretName = "admi636639380186746585sa-admi636639380186746585sasas";
        private const string ServiceBusConnectionStringSecretName = "Admi636639380186746585sbus-secret";

        // Enable input.
        private const string VMwareVmId = "/subscriptions/2a57d0a2-0955-4d1e-aa87-a0dbb87cbcab/resourceGroups/amit636640800574045018rg/providers/Microsoft.OffAzure/VMwareSites/amit636640800574045018Site/machines/amit636640800574045018vcenter_421e73ad-0574-b763-e92a-832f9c522241";
        private const string TargetResourceGroupId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourceGroups/Admi636639380186746585RG";
        private const string TargetNetworkId = null;
        private const string TargetSubnetId = null;
        private const string ReplicationStorageAccountId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourceGroups/Admi636639380186746585RG/providers/Microsoft.Storage/storageAccounts/gwyreplicationsa";
        private const string LogStorageAccountId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourceGroups/Admi636639380186746585RG/providers/Microsoft.Storage/storageAccounts/gwylogsa";
        private const string LogStorageAccountSasSecretName = "gwylogsa-gwylogsasas";
        private const string DataMoverRunAsAccountId = "/subscriptions/2a57d0a2-0955-4d1e-aa87-a0dbb87cbcab/resourceGroups/amit636640800574045018rg/providers/Microsoft.OffAzure/VMwareSites/amit636640800574045018Site/runasaccounts/account1";
        private const string SnapshotRunAsAccountId = "/subscriptions/2a57d0a2-0955-4d1e-aa87-a0dbb87cbcab/resourceGroups/amit636640800574045018rg/providers/Microsoft.OffAzure/VMwareSites/amit636640800574045018Site/runasaccounts/account1";
        private const string TargetAvailabilitySetId = null;

        // Test migrate input.
        private const string TfoNetworkId = "/subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/MPK-V2A/providers/Microsoft.Network/virtualNetworks/liangnetwork";

        [Fact]
        public void Migration_ContainerPairing()
        {
            using (UndoContext context = UndoContext.Current)
            {
                try
                {
                    // Ensure DRA is running and the VMware cloud entity is created before running
                    // this test.
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
                                VMwareSiteId = VMwareSiteId
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
                                KeyVaultId = KeyVaultId,
                                KeyVaultUri = KeyVaultUri,
                                StorageAccountId = StorageAccountId,
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
                }
                catch (Exception)
                {
                    Debugger.Break();
                    throw;
                }
            }
        }

        [Fact]
        public void Migration_ContainerUnpairing()
        {
            using (UndoContext context = UndoContext.Current)
            {
                try
                {
                    context.Start();
                    var client = GetSiteRecoveryClient(CustomHttpHandler, "Migration");

                    // Delete container mappping.
                    client.ProtectionContainerMapping.UnconfigureProtection(
                        VMwareFabricName,
                        VMwareContainerName,
                        ContainerMappingName,
                        new RemoveProtectionContainerMappingInput()
                        {
                            Properties = new RemoveProtectionContainerMappingInputProperties()
                            {
                                ProviderSpecificInput = new ReplicationProviderContainerUnmappingInput()
                            }
                        },
                        RequestHeaders);

                    // Delete VMware policy.
                    client.Policies.Delete(VMwarePolicyName, RequestHeaders);

                    // Delete Azure container/fabric.
                    client.ProtectionContainer.Delete(AzureFabricName, AzureContainerName, RequestHeaders);
                    client.Fabrics.Delete(AzureFabricName, RequestHeaders);

                    // Delete VMware container/DRA/fabric.
                    client.ProtectionContainer.Delete(VMwareFabricName, VMwareContainerName, RequestHeaders);
                    client.RecoveryServicesProvider.Delete(VMwareFabricName, VMwareDraName, RequestHeaders);
                    client.Fabrics.Delete(VMwareFabricName, RequestHeaders);
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

                    // List all fabric entites.
                    var fabrics = client.Fabrics.List(RequestHeaders).Fabrics.ToList();
                    var policies = client.Policies.List(RequestHeaders).Policies.ToList();
                    var vmwareDras = client.RecoveryServicesProvider
                        .List(VMwareFabricName, RequestHeaders)
                        .RecoveryServicesProviders
                        .ToList();
                    var vmwareContainers = client.ProtectionContainer
                        .List(VMwareFabricName, RequestHeaders)
                        .ProtectionContainers
                        .ToList();
                    var azureContainers = client.ProtectionContainer
                        .List(AzureFabricName, RequestHeaders)
                        .ProtectionContainers
                        .ToList();
                    var mappings = client.ProtectionContainerMapping
                        .List(VMwareFabricName, VMwareContainerName, RequestHeaders)
                        .ProtectionContainerMappings
                        .ToList();

                    // Get all migration items.
                    var items = client.MigrationItem.List(
                        VMwareFabricName,
                        VMwareContainerName,
                        RequestHeaders);

                    // Get single migration item.
                    var migItem = client.MigrationItem.Get(
                        VMwareFabricName,
                        VMwareContainerName,
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

                    var disksInput = new List<VMwareCbtDiskInput>
                    {
                        new VMwareCbtDiskInput
                        {
                            DiskId = "2d259366-fabc-4d46-9389-36f4d9c49c56",
                            IsOSDisk = "true",
                            StorageAccountId = ReplicationStorageAccountId,
                            LogStorageAccountId = LogStorageAccountId,
                            LogStorageAccountSasSecretName = LogStorageAccountSasSecretName
                        }
                    };

                    var enableMigrationInput = new EnableMigrationInput
                    {
                        Properties = new EnableMigrationInputProperties
                        {
                            PolicyId = vmwarePolicy.Id,
                            ProviderSpecificDetails = new VMwareCbtEnableMigrationInput
                            {
                                VMwareMachineId = VMwareVmId,
                                DisksToInclude = disksInput,
                                LicenseType = "WindowsServer",
                                TargetAzureVmName = "migVm1",
                                TargetAzureVmSize = "Standard_A4",
                                TargetResourceGroupId = TargetResourceGroupId,
                                TargetAzureNetworkId = TargetNetworkId,
                                TargetAzureSubnetName = TargetSubnetId,
                                TargetAvailabilitySetId = TargetAvailabilitySetId,
                                DataMoverRunAsAccountId = DataMoverRunAsAccountId,
                                SnapshotRunAsAccountId = SnapshotRunAsAccountId
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

        [Fact]
        public void Migration_Disable()
        {
            using (UndoContext context = UndoContext.Current)
            {
                try
                {
                    context.Start();
                    var client = GetSiteRecoveryClient(CustomHttpHandler, "Migration");

                    // Get single migration item.
                    var migItem = client.MigrationItem.Get(
                        VMwareFabricName,
                        VMwareContainerName,
                        "vmwareMigItem1",
                        RequestHeaders);

                    var response = client.MigrationItem.DisableMigration(
                        VMwareFabricName,
                        VMwareContainerName,
                        "vmwareMigItem1",
                        RequestHeaders);

                    // Get all items.
                    var items = client.MigrationItem.List(
                        VMwareFabricName,
                        VMwareContainerName,
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
        public void Migration_Migrate()
        {
            using (UndoContext context = UndoContext.Current)
            {
                try
                {
                    context.Start();
                    var client = GetSiteRecoveryClient(CustomHttpHandler, "Migration");

                    var migrateInput = new MigrateInput
                    {
                        Properties = new MigrateInputProperties
                        {
                            ProviderSpecificDetails = new VMwareCbtMigrateInput
                            {
                                RecoveryPointId = null
                            }
                        }
                    };

                    var response = client.MigrationItem.Migrate(
                        VMwareFabricName,
                        VMwareContainerName,
                        "vmwareMigItem1",
                        migrateInput,
                        RequestHeaders);

                    // Get the item.
                    var migItem = client.MigrationItem.Get(
                        VMwareFabricName,
                        VMwareContainerName,
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
        public void Migration_CompleteMigration()
        {
            using (UndoContext context = UndoContext.Current)
            {
                try
                {
                    context.Start();
                    var client = GetSiteRecoveryClient(CustomHttpHandler, "Migration");

                    var response = client.MigrationItem.CompleteMigration(
                        VMwareFabricName,
                        VMwareContainerName,
                        "vmwareMigItem1",
                        RequestHeaders);

                    // Get the item.
                    var migItem = client.MigrationItem.Get(
                        VMwareFabricName,
                        VMwareContainerName,
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
        public void Migration_TestMigrate()
        {
            using (UndoContext context = UndoContext.Current)
            {
                try
                {
                    context.Start();
                    var client = GetSiteRecoveryClient(CustomHttpHandler, "Migration");

                    var testMigrateInput = new TestMigrateInput
                    {
                        Properties = new TestMigrateInputProperties
                        {
                            ProviderSpecificDetails = new VMwareCbtTestMigrateInput
                            {
                                RecoveryPointId = null,
                                NetworkId = TfoNetworkId
                            }
                        }
                    };

                    var response = client.MigrationItem.TestMigrate(
                        VMwareFabricName,
                        VMwareContainerName,
                        "vmwareMigItem1",
                        testMigrateInput,
                        RequestHeaders);

                    // Get the item.
                    var migItem = client.MigrationItem.Get(
                        VMwareFabricName,
                        VMwareContainerName,
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
        public void Migration_TestMigrateCleanup()
        {
            using (UndoContext context = UndoContext.Current)
            {
                try
                {
                    context.Start();
                    var client = GetSiteRecoveryClient(CustomHttpHandler, "Migration");

                    var testMigrateCleanupInput = new TestMigrateCleanupInput
                    {
                        Properties = new TestMigrateCleanupInputProperties
                        {
                            Comments = "Goodbye!"
                        }
                    };

                    var response = client.MigrationItem.TestMigrateCleanup(
                        VMwareFabricName,
                        VMwareContainerName,
                        "vmwareMigItem1",
                        testMigrateCleanupInput,
                        RequestHeaders);

                    // Get the item.
                    var migItem = client.MigrationItem.Get(
                        VMwareFabricName,
                        VMwareContainerName,
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
    }
}
