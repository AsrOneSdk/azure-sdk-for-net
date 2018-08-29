﻿//
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
        private const string VMwareFabricName = "devbabuova1replicationfabric";
        private const string VMwareContainerName = "devbabuova1replicationcontainer";
        private const string VMwareSiteId = "/subscriptions/2a57d0a2-0955-4d1e-aa87-a0dbb87cbcab/resourceGroups/lshaibvtrg/providers/Microsoft.OffAzure/VMwareSites/lshaibvtsite";

        // Azure fabric input.
        private const string AzureFabricName = "azurefabric1";
        private const string AzureContainerName = "azurefabriccloud1";
        private const string AzureFabricLocation = "southeastasia";

        // VMware DRA input.
        private const string VMwareDraName = "devbabuova1dra";
        private const string TenantId = "72f988bf-86f1-41af-91ab-2d7cd011db47";
        private const string ApplicationId = "f66fce08-c0c6-47a1-beeb-0ede5ea94f90";
        private const string ObjectId = "141360b8-5686-4240-a027-5e24e6affeba";
        private const string Audience = "https://microsoft.onmicrosoft.com/cf19e349-644c-4c6a-bcae-9c8f35357874";
        private const string AadAuthority = "https://login.microsoftonline.com";

        // VMware policy input.
        private const string VMwarePolicyName = "vmwarepolicy1";
        private const int CrashInterval = 15;
        private const int AppInterval = 60;
        private const int RecoveryPointHistory = 60 * 24;

        // Cloud pairing input.
        private const string ContainerMappingName = "vmwaremapping1";
        private const string KeyVaultId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourceGroups/devbabuova1/providers/Microsoft.KeyVault/vaults/devbabuova1gwykv";
        private const string KeyVaultUri = "https://devbabuova1gwykv.vault.azure.net/";
        private const string StorageAccountId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourceGroups/devbabuova1/providers/Microsoft.Storage/storageAccounts/devbabuova1gwysa";
        private const string StorageAccountSasSecretName = "devbabuova1gwysa-devbabuova1gwysasas";
        private const string ServiceBusConnectionStringSecretName = "devbabuova1gwysbus";

        // Enable input.
        private const string VMName = "lshai929MigVm";
        private const string VMwareVmId = "/subscriptions/2a57d0a2-0955-4d1e-aa87-a0dbb87cbcab/resourceGroups/lshaibvtrg/providers/Microsoft.OffAzure/VMwareSites/lshaibvtsite/machines/10-150-209-216-a9f67797-bc63-5bf3-b8fe-9ffcc50402af_501e77b4-0b34-8aa9-d5bc-d3ae94ee52ea"; //lshai-0929-1
        // private const string VMwareVmId = "/subscriptions/2a57d0a2-0955-4d1e-aa87-a0dbb87cbcab/resourceGroups/lshaibvtrg/providers/Microsoft.OffAzure/VMwareSites/lshaibvtsite/machines/10-150-209-216-a9f67797-bc63-5bf3-b8fe-9ffcc50402af_500f866c-d415-1d0e-7186-7c58b0c5ec28"; //lshai-0520-2
        // private const string VMwareVmId = "/subscriptions/2a57d0a2-0955-4d1e-aa87-a0dbb87cbcab/resourceGroups/lshaibvtrg/providers/Microsoft.OffAzure/VMwareSites/lshaibvtsite/machines/10-150-209-216-a9f67797-bc63-5bf3-b8fe-9ffcc50402af_500ff837-eb79-11ee-b445-bb044d4aa2aa"; //lshai-0520-1
        // private const string VMwareVmId = "/subscriptions/2a57d0a2-0955-4d1e-aa87-a0dbb87cbcab/resourceGroups/lshaibvtrg/providers/Microsoft.OffAzure/VMwareSites/lshaibvtsite/machines/10-150-209-216-a9f67797-bc63-5bf3-b8fe-9ffcc50402af_501e9205-b7ec-fb40-60dc-2b1c5a57b64b"; //lshai-0814-1
        // private const string VMwareVmId = "/subscriptions/2a57d0a2-0955-4d1e-aa87-a0dbb87cbcab/resourceGroups/lshaibvtrg/providers/Microsoft.OffAzure/VMwareSites/lshaibvtsite/machines/10-150-209-216-a9f67797-bc63-5bf3-b8fe-9ffcc50402af_501ec323-1268-ab57-199c-5d665f74f66d"; //lshai-1023-1
        // private const string VMwareVmId = "/subscriptions/2a57d0a2-0955-4d1e-aa87-a0dbb87cbcab/resourceGroups/lshaibvtrg/providers/Microsoft.OffAzure/VMwareSites/lshaibvtsite/machines/10-150-209-216-a9f67797-bc63-5bf3-b8fe-9ffcc50402af_500f4bb0-62b8-6ab9-4a2d-1949b90119f5"; //lshai-0419-1
        // private const string VMwareVmId = "/subscriptions/2a57d0a2-0955-4d1e-aa87-a0dbb87cbcab/resourceGroups/hprabhtestdfsite1/providers/Microsoft.OffAzure/VMwareSites/hprabhtestdfsite1site/machines/hprabhtestdfsite1vcenter_500ff837-eb79-11ee-b445-bb044d4aa2aa";
        // private const string VMwareVmId = "/subscriptions/2a57d0a2-0955-4d1e-aa87-a0dbb87cbcab/resourceGroups/hprabhtestdfsite1/providers/Microsoft.OffAzure/VMwareSites/hprabhtestdfsite1site/machines/hprabhtestdfsite1vcenter_500f866c-d415-1d0e-7186-7c58b0c5ec28";
        // private const string VMwareVmId = "/subscriptions/2a57d0a2-0955-4d1e-aa87-a0dbb87cbcab/resourceGroups/hprabhtestdfsite1/providers/Microsoft.OffAzure/VMwareSites/hprabhtestdfsite1site/machines/hprabhtestdfsite1vcenter_500f209b-f475-ce88-1399-1e0591e4a836";
        private const string TargetResourceGroupId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourceGroups/devbaburg1";
        private const string TargetNetworkId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourceGroups/devbaburg1/providers/Microsoft.Network/virtualNetworks/devbabuvn1";
        private const string TargetSubnetName = "default";
        private const string ReplicationStorageAccountId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourceGroups/devbabuova1/providers/Microsoft.Storage/storageAccounts/devbabuova1replsa";
        private const string LogStorageAccountId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourceGroups/devbabuova1/providers/Microsoft.Storage/storageAccounts/devbabuova1logsa";
        private const string LogStorageAccountSasSecretName = "devbabuova1logsa-devbabuova1logsasas";
        private const string DataMoverRunAsAccountId = "/subscriptions/2a57d0a2-0955-4d1e-aa87-a0dbb87cbcab/resourceGroups/lshaibvtrg/providers/Microsoft.OffAzure/VMwareSites/lshaibvtsite/runasaccounts/a9f67797-bc63-5bf3-b8fe-9ffcc50402af";
        private const string SnapshotRunAsAccountId = "/subscriptions/2a57d0a2-0955-4d1e-aa87-a0dbb87cbcab/resourceGroups/lshaibvtrg/providers/Microsoft.OffAzure/VMwareSites/lshaibvtsite/runasaccounts/a9f67797-bc63-5bf3-b8fe-9ffcc50402af";
        private const string TargetAvailabilitySetId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourceGroups/devbaburg1/providers/Microsoft.Compute/availabilitySets/devbabuova1avset";
        private const string TargetBootDiagnosticsStorageAccountId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourcegroups/devbabuova1/providers/Microsoft.Storage/storageAccounts/devbabuova1bootdiagsa";

        // Test migrate input.
        private const string TfoNetworkId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourceGroups/devbaburg1/providers/Microsoft.Network/virtualNetworks/devbabuvn1";

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
        public void Migration_RecoveryPoints()
        {
            using (UndoContext context = UndoContext.Current)
            {
                try
                {
                    context.Start();
                    var client = GetSiteRecoveryClient(CustomHttpHandler, "Migration");

                    var pits = client.MigrationItem.RecoveryPointList(
                        VMwareFabricName,
                        VMwareContainerName,
                        VMName,
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
        public void Migration_List()
        {
            using (UndoContext context = UndoContext.Current)
            {
                try
                {
                    context.Start();
                    var client = GetSiteRecoveryClient(CustomHttpHandler, "Migration");

                    // Should get mig items in mig fabric.
                    string vmwfabric11 = "vmwarefabric1";
                    string vmwcloud11 = "cloud_22c36ac9-9e41-51b7-b95f-87367a66b149";
                    var migItemsInContainer = client.MigrationItem.List(
                        vmwfabric11,
                        vmwcloud11,
                        RequestHeaders);

                    // Should get only mig items in the vault.
                    List<MigrationItem> migItemsList = new List<MigrationItem>();
                    var migItemsInVault = client.MigrationItem.ListAll(
                        null,
                        null,
                        RequestHeaders);
                    migItemsList.AddRange(migItemsInVault.MigrationItems);
                    while (migItemsInVault.NextLink != null)
                    {
                        migItemsInVault = client.MigrationItem.ListAllNext(
                            migItemsInVault.NextLink,
                            RequestHeaders);
                        migItemsList.AddRange(migItemsInVault.MigrationItems);
                    }

                    // Should get only repln items in the vault. Fails at ReplicationProviderSpecificSettings not set.
                    List<ReplicationProtectedItem> itemsList = new List<ReplicationProtectedItem>();
                    var protectedItemsResponse = client.ReplicationProtectedItem.ListAll(
                        null,
                        null,
                        RequestHeaders);
                    itemsList.AddRange(protectedItemsResponse.ReplicationProtectedItems);
                    while (protectedItemsResponse.NextLink != null)
                    {
                        protectedItemsResponse = client.ReplicationProtectedItem.ListAllNext(
                            protectedItemsResponse.NextLink,
                            RequestHeaders);

                        itemsList.AddRange(protectedItemsResponse.ReplicationProtectedItems);
                    }

                    // Should get repln items in repln fabric.
                    string v2afabric = "16233b02d363a5e94dbb699ca43e59faf17330579c7b6135dc1a835edd4c48ac";
                    // string b2afabric = "site1";
                    string v2acloud = "cloud_28a8b10c-f9b2-45a7-b63b-04520910ceeb";
                    // string b2acloud = "cloud_321b8f74-dec2-56ef-ad43-2e8c8253a1e9";
                    var protectedItemsInContainer = client.ReplicationProtectedItem.List(
                        v2afabric,
                        v2acloud,
                        RequestHeaders);

                    // Should get 0 mig items in repln fabric.
                    var migItemsInReplnContainer = client.MigrationItem.List(
                        v2afabric,
                        v2acloud,
                        RequestHeaders);

                    // Should get 0 repln items in migration fabric.
                    var protectedItemsInMigContainer = client.ReplicationProtectedItem.List(
                        vmwfabric11,
                        vmwcloud11,
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
        public void Migration_Get()
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
                        VMName,
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
        public void RestartJob()
        {
            using (UndoContext context = UndoContext.Current)
            {
                try
                {
                    context.Start();
                    var client = GetSiteRecoveryClient(CustomHttpHandler, "Migration");

                    string wfId = "005562a0-67f0-4ae5-9eba-fb5506d7b9fd";
                    var response = client.Jobs.Restart(
                        wfId,
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
                            DiskId = "6000C29f-d758-53ff-e901-b6967d59565d",
                            IsOSDisk = "true",
                            StorageAccountId = ReplicationStorageAccountId,
                            LogStorageAccountId = LogStorageAccountId,
                            LogStorageAccountSasSecretName = LogStorageAccountSasSecretName,
                            DiskType = "Standard_LRS"
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
                                TargetVmName = VMName,
                                TargetVmSize = "Standard_A4",
                                TargetResourceGroupId = TargetResourceGroupId,
                                TargetNetworkId = TargetNetworkId,
                                TargetSubnetName = TargetSubnetName,
                                TargetAvailabilitySetId = string.Empty,
                                DataMoverRunAsAccountId = DataMoverRunAsAccountId,
                                SnapshotRunAsAccountId = SnapshotRunAsAccountId
                            }
                        }
                    };

                    var response = client.MigrationItem.EnableMigration(
                        VMwareFabricName,
                        vmwareContainer.Name,
                        VMName,
                        enableMigrationInput,
                        RequestHeaders);

                    // Get single migration item.
                    var migItem = client.MigrationItem.Get(
                        VMwareFabricName,
                        VMwareContainerName,
                        VMName,
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
                        VMName,
                        RequestHeaders);

                    var response = client.MigrationItem.DisableMigration(
                        VMwareFabricName,
                        VMwareContainerName,
                        VMName,
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
                                RecoveryPointId = "/Subscriptions/cb53d0c3-bd59-4721-89bc-06916a9147ef/resourceGroups/hydratestrg/providers/Microsoft.RecoveryServicesBVTD2/Vaults/hydratest/replicationFabrics/devbabuova1replicationfabric/replicationProtectionContainers/cloud_66739b5b-32bf-5afa-9657-8bf9fbd21269/replicationMigrationItems/lshai929MigVm/migrationRecoveryPoints/95bc66c5-d94a-47a3-859d-076f330c417d"
                            }
                        }
                    };

                    var response = client.MigrationItem.Migrate(
                        VMwareFabricName,
                        VMwareContainerName,
                        VMName,
                        migrateInput,
                        RequestHeaders);

                    // Get the item.
                    var migItem = client.MigrationItem.Get(
                        VMwareFabricName,
                        VMwareContainerName,
                        VMName,
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
                        VMName,
                        RequestHeaders);

                    // Get the item.
                    var migItem = client.MigrationItem.Get(
                        VMwareFabricName,
                        VMwareContainerName,
                        VMName,
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
                                RecoveryPointId = "/Subscriptions/cb53d0c3-bd59-4721-89bc-06916a9147ef/resourceGroups/hydratestrg/providers/Microsoft.RecoveryServicesBVTD2/Vaults/hydratest/replicationFabrics/devbabuova1replicationfabric/replicationProtectionContainers/cloud_66739b5b-32bf-5afa-9657-8bf9fbd21269/replicationMigrationItems/lshai929MigVm/migrationRecoveryPoints/95bc66c5-d94a-47a3-859d-076f330c417d",
                                NetworkId = TfoNetworkId
                            }
                        }
                    };

                    var response = client.MigrationItem.TestMigrate(
                        VMwareFabricName,
                        VMwareContainerName,
                        VMName,
                        testMigrateInput,
                        RequestHeaders);

                    // Get the item.
                    var migItem = client.MigrationItem.Get(
                        VMwareFabricName,
                        VMwareContainerName,
                        VMName,
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
                        VMName,
                        testMigrateCleanupInput,
                        RequestHeaders);

                    // Get the item.
                    var migItem = client.MigrationItem.Get(
                        VMwareFabricName,
                        VMwareContainerName,
                        VMName,
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
        public void Migration_UpdateMigrationItem()
        {
            using (UndoContext context = UndoContext.Current)
            {
                try
                {
                    context.Start();
                    var client = GetSiteRecoveryClient(CustomHttpHandler, "Migration");

                    // Get the original item.
                    var migItem = client.MigrationItem.Get(
                        VMwareFabricName,
                        VMwareContainerName,
                        VMName,
                        RequestHeaders);

                    var nicsInput = new List<VMwareCbtNicInput>
                    {
                        new VMwareCbtNicInput
                        {
                            NicId = "4000",
                            IsPrimaryNic = "true",
                            TargetSubnetName = "subnet-1",
                            TargetStaticIPAddress = "10.2.1.13",
                            IsSelectedForMigration = "true"
                        },
                        new VMwareCbtNicInput
                        {
                            NicId = "4001",
                            IsPrimaryNic = "false",
                            TargetSubnetName = "subnet-1",
                            IsSelectedForMigration = "true"
                        }
                    };

                    var input = new UpdateMigrationItemInput
                    {
                        Properties = new UpdateMigrationItemInputProperties
                        {
                            ProviderSpecificDetails = new VMwareCbtUpdateMigrationItemInput()
                            {
                                TargetVmName = "929updatedname",
                                TargetVmSize = "Standard_A7",
                                TargetAvailabilitySetId = TargetAvailabilitySetId,
                                TargetBootDiagnosticsStorageAccountId = TargetBootDiagnosticsStorageAccountId,
                                VmNics = nicsInput,
                                TargetNetworkId = TargetNetworkId
                            }
                        }
                    };

                    // Update the item.
                    var response = client.MigrationItem.UpdateMigrationItem(
                        VMwareFabricName,
                        VMwareContainerName,
                        VMName,
                        input,
                        RequestHeaders);

                    // Get the updated item.
                    var migItemUpd = client.MigrationItem.Get(
                        VMwareFabricName,
                        VMwareContainerName,
                        VMName,
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
