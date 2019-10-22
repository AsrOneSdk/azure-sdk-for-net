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
using System.Text;
using Microsoft.Azure.Management.SiteRecovery;
using Microsoft.Azure.Management.SiteRecovery.Models;
using Microsoft.Azure.Test;
using Xunit;


namespace SiteRecovery.Tests.ScenarioTests
{
    public class MigrationTests : SiteRecoveryTestsBase
    {
        // VMware Fabric input.
        private const string VMwareFabricName = "migrationoneboxreplicationfabric";
        private const string VMwareContainerName = "migrationoneboxreplicationcontainer";
        private const string VMwareSiteId = "/subscriptions/8d29733f-80ae-41b5-95d5-de86bb160521/resourceGroups/migrationOneBox/providers/Microsoft.OffAzure/VMwareSites/migrateproject35desite";
        private const string MigrationSolutionId = "/subscriptions/8d29733f-80ae-41b5-95d5-de86bb160521/resourceGroups/migrationOneBox/providers/Microsoft.Migrate/MigrateProjects/migrationOneBox-MigrateProject/Solutions/Servers-Migration-ServerMigration";
        // private const string VMwareFabricName = "hikewalrova1replicationfabric";
        // private const string VMwareContainerName = "hikewalrova1replicationcontainer";
        // private const string VMwareSiteId = "/subscriptions/8d29733f-80ae-41b5-95d5-de86bb160521/resourceGroups/rohithtest/providers/Microsoft.OffAzure/VMwareSites/site1a5a06fd11bsite";
        // private const string MigrationSolutionId = "/subscriptions/8d29733f-80ae-41b5-95d5-de86bb160521/resourceGroups/rohithtest/providers/Microsoft.Migrate/MigrateProjects/rohithtest-MigrateProject/Solutions/Servers-Migration-ServerMigration";
        private const string PhysicalSiteId = "/subscriptions/8d29733f-80ae-41b5-95d5-de86bb160521/resourceGroups/migrationOneBox/providers/Microsoft.OffAzure/ServerSites/physicaltest";

        // VMware DRA input.
        private const string VMwareDraName = "migrationoneboxdra";
        private const string TenantId = "72f988bf-86f1-41af-91ab-2d7cd011db47";
        private const string ApplicationId = "752b7f53-0c05-4c96-9e9f-02d246b20337";
        private const string ObjectId = "c929252a-b077-4c4b-a78a-00ea0a72a377";
        private const string Audience = "https://microsoft.onmicrosoft.com/132b21bd-8853-463f-b7f8-061a44523caf";
        private const string AadAuthority = "https://login.windows.net/72f988bf-86f1-41af-91ab-2d7cd011db47";
        // private const string VMwareDraName = "hikewalrova1dra";
        // private const string ApplicationId = "f66fce08-c0c6-47a1-beeb-0ede5ea94f90";
        // private const string ObjectId = "141360b8-5686-4240-a027-5e24e6affeba";
        // private const string Audience = "https://microsoft.onmicrosoft.com/cf19e349-644c-4c6a-bcae-9c8f35357874";
        // private const string AadAuthority = "https://login.microsoftonline.com";

        // Policy input for Cbt.
        private const string VMwarePolicyName = "vmwarepolicy1";
        private const int CrashIntervalInMins = 1 * 60;
        private const int AppIntervalInMins = 4 * 60;
        private const int RecoveryPointHistoryInMins = 72 * 60;

        // Policy input for IM.
        private const string InMageMigrationPolicyName = "InMageMigration-Profile";

        // Pairing input for Cbt.
        private const string ContainerMappingName = "vmwaremapping1";
        private const string KeyVaultId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourceGroups/lshaisearg/providers/Microsoft.KeyVault/vaults/lshaiseakv";
        private const string KeyVaultUri = "https://lshaiseakv.vault.azure.net/";
        private const string StorageAccountId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourceGroups/lshaisearg/providers/Microsoft.Storage/storageAccounts/lshaiseagwysa";
        private const string StorageAccountSasSecretName = "lshaiseagwysa-lshaisas";
        private const string ServiceBusConnectionStringSecretName = "lshaisbussecret";
        private const string TargetLocation = "southeastasia";

        // Cloud pairing input for IM.
        private const string InMageMigrationContainerMappingName = "inMageMigrationmapping1";

        // Enable input for Cbt.
        // private const string VMName = "V2A-w2K12-114";
        // private const string VMwareVmId = "/subscriptions/8d29733f-80ae-41b5-95d5-de86bb160521/resourceGroups/migrationOneBox/providers/Microsoft.OffAzure/VMwareSites/migrateproject35desite/machines/bcdr-vcenter-fareast-corp-micro-cfcc5a24-a40e-56b9-a6af-e206c9ca4f93_501ecb2e-de35-28d2-108f-16adf2cf316d";
        private const string VMName = "V2A-w2K12-501";
        private const string VMwareVmId = "/subscriptions/8d29733f-80ae-41b5-95d5-de86bb160521/resourceGroups/migrationOneBox/providers/Microsoft.OffAzure/VMwareSites/migrateproject35desite/machines/bcdr-vcenter-fareast-corp-micro-cfcc5a24-a40e-56b9-a6af-e206c9ca4f93_500fe09f-36b2-9d3b-1066-793b4f25d06e";
        // private const string VMName = "V2A-w2K12-502";
        // private const string VMwareVmId = "/subscriptions/8d29733f-80ae-41b5-95d5-de86bb160521/resourceGroups/migrationOneBox/providers/Microsoft.OffAzure/VMwareSites/migrateproject35desite/machines/bcdr-vcenter-fareast-corp-micro-cfcc5a24-a40e-56b9-a6af-e206c9ca4f93_500ff428-cf74-c914-a915-11244f17dbfe";
        //private const string VMName = "V2A-w2K12-104";
        //private const string VMwareVmId = "/subscriptions/8d29733f-80ae-41b5-95d5-de86bb160521/resourceGroups/migrationOneBox/providers/Microsoft.OffAzure/VMwareSites/migrateproject35desite/machines/bcdr-vcenter-fareast-corp-micro-cfcc5a24-a40e-56b9-a6af-e206c9ca4f93_501e7ad6-e4c6-0eec-cb2a-6d608a1ba839";

        //private const string VMName = "V2A-W2K12-109";
        //private const string VMwareVmId = "/subscriptions/8d29733f-80ae-41b5-95d5-de86bb160521/resourceGroups/migrationOneBox/providers/Microsoft.OffAzure/VMwareSites/migrateproject35desite/machines/bcdr-vcenter-fareast-corp-micro-cfcc5a24-a40e-56b9-a6af-e206c9ca4f93_500f2423-88d1-9dc1-572b-de175a13e421";

        private const string TargetResourceGroupId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourceGroups/lshaiseatargetrg";
        private const string TargetNetworkId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourceGroups/lshaiseatargetrg/providers/Microsoft.Network/virtualNetworks/lshaiseavnet";
        private const string TargetSubnetName = "default";
        private const string TargetAvailabilitySetId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourceGroups/lshaiseatargetrg/providers/Microsoft.Compute/availabilitySets/lshaiseaavset";
        private const string TargetBootDiagnosticsStorageAccountId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourcegroups/lshaiseatargetrg/providers/Microsoft.Storage/storageAccounts/lshaibootdiagsa";
        private const string ReplicationStorageAccountId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourceGroups/lshaisearg/providers/Microsoft.Storage/storageAccounts/lshaiseareplnsa";
        private const string LogStorageAccountId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourcegroups/lshaisearg/providers/Microsoft.Storage/storageAccounts/lshaisealogsa";
        private const string LogStorageAccountSasSecretName = "lshaisealogsa-lshailogsas";
        private const string DataMoverRunAsAccountId = "/subscriptions/8d29733f-80ae-41b5-95d5-de86bb160521/resourceGroups/migrationOneBox/providers/Microsoft.OffAzure/VMwareSites/migrateproject35desite/runasaccounts/cfcc5a24-a40e-56b9-a6af-e206c9ca4f93";
        private const string SnapshotRunAsAccountId = "/subscriptions/8d29733f-80ae-41b5-95d5-de86bb160521/resourceGroups/migrationOneBox/providers/Microsoft.OffAzure/VMwareSites/migrateproject35desite/runasaccounts/cfcc5a24-a40e-56b9-a6af-e206c9ca4f93";

        // Enable input for IM.
        // private const string VMName = "hikewalrVm";
        // private const string VMwareVmId = "/subscriptions/8d29733f-80ae-41b5-95d5-de86bb160521/resourceGroups/rohithtest/providers/Microsoft.OffAzure/VMwareSites/site1a5a06fd11bsite/machines/gqlvcenter-f53bc2e3-cfe8-573f-b904-d1dd8d679ca4_50020746-95dd-af13-7694-80ab17f00ad4";
        private const string PhysicalMachineName = "hikewalrPhysicalMachine";
        private const string PhysicalMachineId = "/subscriptions/8d29733f-80ae-41b5-95d5-de86bb160521/resourceGroups/migrationOneBox/providers/Microsoft.OffAzure/ServerSites/physicaltest/machines/machine33";
        private const string InMageMigrationVmName = "hikewalrVM";
        // private const string TargetResourceGroupId = "/subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/Hitesh-TFO-Test-RG";
        // private const string TargetNetworkId = "/subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/Hitesh-TFO-Test-RG/providers/Microsoft.Network/virtualNetworks/Hitesh-TFO-Test";
        // private const string ReplicationStorageAccountId = "/subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/default-storage-southeastasia/providers/Microsoft.Storage/storageAccounts/hikewalrragrs";

        // Test migrate input.
        private const string TfoNetworkId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourceGroups/lshaiseatargetrg/providers/Microsoft.Network/virtualNetworks/lshaiseavnet";

        [Fact]
        public void Migration_ContainerPairing()
        {
            using (UndoContext context = UndoContext.Current)
            {
                try
                {
                    context.Start();
                    var client = GetSiteRecoveryClient(CustomHttpHandler, "Migration");

                    // Creates fabric and dra.
                    /*CreateVMwareFabric(client);

                    // Create VMware policy.
                    var vmwarePolicyInput = new VMwareCbtPolicyCreationInput()
                    {
                        RecoveryPointHistoryInMinutes = RecoveryPointHistoryInMins,
                        CrashConsistentFrequencyInMinutes = CrashIntervalInMins,
                        AppConsistentFrequencyInMinutes = AppIntervalInMins
                    };
                    CreatePolicy(VMwarePolicyName, vmwarePolicyInput, client);*/

                    // Create container mappping.
                    var vmwareContainerMappingInput = new VMwareCbtPolicyContainerMappingInput()
                    {
                        KeyVaultId = KeyVaultId,
                        KeyVaultUri = KeyVaultUri,
                        StorageAccountId = StorageAccountId,
                        StorageAccountSasSecretName = StorageAccountSasSecretName,
                        ServiceBusConnectionStringSecretName = ServiceBusConnectionStringSecretName,
                        TargetLocation = TargetLocation
                    };
                    CreateProtectionContainerMapping(
                        VMwarePolicyName,
                        ContainerMappingName,
                        vmwareContainerMappingInput,
                        client);
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

                    // Should get only repln items in the vault.
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
        public void Migration_GetJobs()
        {
            using (UndoContext context = UndoContext.Current)
            {
                try
                {
                    context.Start();
                    var client = GetSiteRecoveryClient(CustomHttpHandler, "Migration");

                    var str = new StringBuilder();
                    var jobs = client.Jobs.List(new JobQueryParameter(), RequestHeaders).Jobs.Reverse().ToList();

                    foreach (var job in jobs)
                    {
                        str.AppendLine(job.Properties.ScenarioName);

                        var extJob = client.Jobs.Get(job.Name, RequestHeaders).Job;
                        for (int i = 0; i < extJob.Properties.Tasks.Count; i++)
                        {
                            var task = extJob.Properties.Tasks[i];
                            str.AppendLine("\t\t\t\t" + i + ":" + task.Name + ":\t\t\t\t\t\t\t\t\t\t\t\t" + task.TaskFriendlyName);
                        }
                    }
                }
                catch (Exception)
                {
                    Debugger.Break();
                    throw;
                }
            }
        }

        [Fact]
        public void Migration_RestartJob()
        {
            using (UndoContext context = UndoContext.Current)
            {
                try
                {
                    context.Start();
                    var client = GetSiteRecoveryClient(CustomHttpHandler, "Migration");

                    string wfId = "6d457634-361b-45d2-8c04-9e2480870ba6";
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

                    // For 114.
                    /*var disksInput = new List<VMwareCbtDiskInput>
                    {
                        new VMwareCbtDiskInput
                        {
                            DiskId = "6000C29d-4659-f85b-d5e6-febc49af7e0f",
                            IsOSDisk = "true",
                            LogStorageAccountId = LogStorageAccountId,
                            LogStorageAccountSasSecretName = LogStorageAccountSasSecretName,
                            DiskType = "Standard_LRS"
                        },
                        new VMwareCbtDiskInput
                        {
                            DiskId = "6000C294-9542-5223-b6f9-e3d84e9ec4fb",
                            IsOSDisk = "false",
                            LogStorageAccountId = LogStorageAccountId,
                            LogStorageAccountSasSecretName = LogStorageAccountSasSecretName,
                            DiskType = "Standard_LRS"
                        }
                    };*/

                    // For 123.
                    /*var disksInput = new List<VMwareCbtDiskInput>
                    {
                        new VMwareCbtDiskInput
                        {
                            DiskId = "6000C294-6fa1-61d5-6c96-3f5ff071d872",
                            IsOSDisk = "true",
                            LogStorageAccountId = LogStorageAccountId,
                            LogStorageAccountSasSecretName = LogStorageAccountSasSecretName,
                            DiskType = "Standard_LRS"
                        },
                        new VMwareCbtDiskInput
                        {
                            DiskId = "6000C292-f087-42f2-e3fd-3ba0566777ef",
                            IsOSDisk = "false",
                            LogStorageAccountId = LogStorageAccountId,
                            LogStorageAccountSasSecretName = LogStorageAccountSasSecretName,
                            DiskType = "Standard_LRS"
                        }
                    };*/

                    // For 501.
                    var disksInput = new List<VMwareCbtDiskInput>
                    {
                        new VMwareCbtDiskInput
                        {
                            DiskId = "6000C295-a41c-49ef-06ea-5d85a05c2948",
                            IsOSDisk = "true",
                            LogStorageAccountId = LogStorageAccountId,
                            LogStorageAccountSasSecretName = LogStorageAccountSasSecretName,
                            DiskType = "Standard_LRS"
                        },
                        new VMwareCbtDiskInput
                        {
                            DiskId = "6000C292-e32c-7c61-1c28-e45f207c7700",
                            IsOSDisk = "false",
                            LogStorageAccountId = LogStorageAccountId,
                            LogStorageAccountSasSecretName = LogStorageAccountSasSecretName,
                            DiskType = "Standard_LRS"
                        }
                    };

                    // For 104
                    /*var disksInput = new List<VMwareCbtDiskInput>
                    {
                        new VMwareCbtDiskInput
                        {
                            DiskId = "6000C299-c1c4-a2d4-3f55-d9d2dbcdb5ee",
                            IsOSDisk = "true",
                            LogStorageAccountId = LogStorageAccountId,
                            LogStorageAccountSasSecretName = LogStorageAccountSasSecretName,
                            DiskType = "Standard_LRS"
                        },
                        new VMwareCbtDiskInput
                        {
                            DiskId = "6000C296-efaa-1c84-737f-27a7bfdb68fb",
                            IsOSDisk = "false",
                            LogStorageAccountId = LogStorageAccountId,
                            LogStorageAccountSasSecretName = LogStorageAccountSasSecretName,
                            DiskType = "Standard_LRS"
                        }
                    };*/

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
                                StorageAccountId = ReplicationStorageAccountId,
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
                        null,
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
        public void Migration_Purge()
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
                        "Purge",
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

                    var cbtMigrateInput = new VMwareCbtMigrateInput
                    {
                        PerformShutdown = "true"
                    };

                    this.Migrate(cbtMigrateInput, client);
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

                    var response = client.MigrationItem.DisableMigration(
                        VMwareFabricName,
                        VMwareContainerName,
                        VMName,
                        "Complete",
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
                    string pitId = "/Subscriptions/cb53d0c3-bd59-4721-89bc-06916a9147ef/resourceGroups/hydratestrg/providers/Microsoft.RecoveryServicesBVTD2/Vaults/hydratest/replicationFabrics/migrationoneboxreplicationfabric/replicationProtectionContainers/cloud_64264558-0517-5350-93e1-030c8b35cdfc/replicationMigrationItems/V2A-w2K12-114/migrationRecoveryPoints/64f81b39-7cc0-47a4-a02b-91e2de437aae";
                    var pits = client.MigrationItem.RecoveryPointList(
                        VMwareFabricName,
                        VMwareContainerName,
                        VMName,
                        RequestHeaders);
                    var cbtTestMigrateInput = new VMwareCbtTestMigrateInput
                    {
                        RecoveryPointId =  pitId,//pits.MigrationRecoveryPoints.ToList().Last().Id,
                        NetworkId = TfoNetworkId
                    };

                    this.TestMigrate(cbtTestMigrateInput, client);
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
                            TargetSubnetName = "default",
                            TargetStaticIPAddress = "172.20.0.6",
                            IsSelectedForMigration = "true"
                        }
                    };

                    var input = new UpdateMigrationItemInput
                    {
                        Properties = new UpdateMigrationItemInputProperties
                        {
                            ProviderSpecificDetails = new VMwareCbtUpdateMigrationItemInput()
                            {
                                TargetVmName = "1234566",
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

        [Fact]
        public void Migration_GetEvents()
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

                    var events = client.Events.List(new EventQueryParameter(), RequestHeaders);

                    var eventQueryParam = new EventQueryParameter
                    {
                        AffectedObjectCorrelationId = migItem.MigrationItem.Properties.EventCorrelationId
                    };
                    var filteredEvents = client.Events.List(eventQueryParam, RequestHeaders);

                }
                catch (Exception)
                {
                    Debugger.Break();
                    throw;
                }
            }
        }

        [Fact]
        public void InMageMigration_ContainerPairing()
        {
            using (UndoContext context = UndoContext.Current)
            {
                try
                {
                    context.Start();
                    var client = GetSiteRecoveryClient(CustomHttpHandler, "Migration");

                    CreateVMwareFabric(client);

                    //Create InMage migration policy.
                    var policyInput = new InMageMigrationPolicyCreationInput()
                    {
                        AppConsistentFrequencyInMinutes = AppIntervalInMins,
                        CrashConsistentFrequencyInMinutes = CrashIntervalInMins,
                        RecoveryPointHistoryInMinutes = RecoveryPointHistoryInMins
                    };
                    CreatePolicy(InMageMigrationPolicyName, policyInput, client);

                    // Create container mappping.
                    var containerMappingInput = new InMageMigrationContainerMappingInput()
                    {
                        TargetLocation = TargetLocation
                    };
                    CreateProtectionContainerMapping(
                        InMageMigrationPolicyName,
                        InMageMigrationContainerMappingName,
                        containerMappingInput,
                        client);
                }
                catch (Exception)
                {
                    Debugger.Break();
                    throw;
                }
            }
        }

        [Fact]
        public void PhysicalMigration_ContainerUnpairing()
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
                        InMageMigrationContainerMappingName,
                        new RemoveProtectionContainerMappingInput()
                        {
                            Properties = new RemoveProtectionContainerMappingInputProperties()
                            {
                                ProviderSpecificInput = new ReplicationProviderContainerUnmappingInput()
                            }
                        },
                        RequestHeaders);

                    // Delete InMage migration policy.
                    client.Policies.Delete(InMageMigrationPolicyName, RequestHeaders);

                    // Delete InMage migration container/DRA/fabric.
                    client.ProtectionContainer.Delete(
                        VMwareFabricName,
                        VMwareContainerName,
                        RequestHeaders);
                    client.RecoveryServicesProvider.Delete(
                        VMwareFabricName,
                        VMwareDraName,
                        RequestHeaders);
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
        public void InMageMigration_EnableVMwareMachine()
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
                        .Where(x => x.Name == InMageMigrationPolicyName)
                        .Single();

                    var enableMigrationInput = new EnableMigrationInput
                    {
                        Properties = new EnableMigrationInputProperties
                        {
                            PolicyId = vmwarePolicy.Id,
                            ProviderSpecificDetails = new InMageMigrationEnableMigrationInput
                            {
                                FabricDiscoveryMachineId = VMwareVmId,
                                LicenseType = "WindowsServer",
                                LogStorageAccountId = ReplicationStorageAccountId,
                                StorageAccountId = ReplicationStorageAccountId,
                                TargetVmName = VMName,
                                TargetVmSize = "Standard_A4",
                                TargetResourceGroupId = TargetResourceGroupId,
                                TargetNetworkId = TargetNetworkId,
                                TargetSubnetName = TargetSubnetName,
                                TargetAvailabilitySetId = string.Empty,
                                DiskType = "Standard_LRS",
                                ProcessServerId = Guid.NewGuid().ToString()
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
        public void InMageMigration_EnablePhysicalMachine()
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
                        .Where(x => x.Name == InMageMigrationPolicyName)
                        .Single();

                    var enableMigrationInput = new EnableMigrationInput
                    {
                        Properties = new EnableMigrationInputProperties
                        {
                            PolicyId = vmwarePolicy.Id,
                            ProviderSpecificDetails = new InMageMigrationEnableMigrationInput
                            {
                                FabricDiscoveryMachineId = PhysicalMachineId,
                                LicenseType = "WindowsServer",
                                LogStorageAccountId = ReplicationStorageAccountId,
                                StorageAccountId = ReplicationStorageAccountId,
                                TargetVmName = VMName,
                                TargetVmSize = "Standard_A4",
                                TargetResourceGroupId = TargetResourceGroupId,
                                TargetNetworkId = TargetNetworkId,
                                TargetSubnetName = TargetSubnetName,
                                TargetAvailabilitySetId = string.Empty,
                                DiskType = "Standard_LRS",
                                ProcessServerId = Guid.NewGuid().ToString()
                            }
                        }
                    };

                    var response = client.MigrationItem.EnableMigration(
                        VMwareFabricName,
                        vmwareContainer.Name,
                        PhysicalMachineName,
                        enableMigrationInput,
                        RequestHeaders);

                    // Get single migration item.
                    var migItem = client.MigrationItem.Get(
                        VMwareFabricName,
                        VMwareContainerName,
                        PhysicalMachineName,
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
        public void InMageMigration_UpdateVMwareMigrationItem()
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

                    var nicsInput = new List<InMageMigrationUpdateNicInput>
                    {
                        new InMageMigrationUpdateNicInput
                        {
                            NicId = "4000",
                            IsPrimaryNic = "true",
                            TargetSubnetName = "subnet-1",
                            TargetStaticIPAddress = "10.2.1.14",
                            IsSelectedForMigration = "true"
                        }
                    };

                    var input = new UpdateMigrationItemInput
                    {
                        Properties = new UpdateMigrationItemInputProperties
                        {
                            ProviderSpecificDetails = new InMageMigrationUpdateMigrationItemInput()
                            {
                                TargetVmName = "522updatedname",
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

        [Fact]
        public void InMageMigration_DisableVMwareMachine()
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
                        null,
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
        public void InMageMigration_DisablePhysicalMachine()
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
                        PhysicalMachineName,
                        RequestHeaders);

                    var response = client.MigrationItem.DisableMigration(
                        VMwareFabricName,
                        VMwareContainerName,
                        PhysicalMachineName,
                        null,
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
        public void InMageMigration_TestMigrate()
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

                    var inMageMigrationTestMigrateInput = new InMageMigrationTestMigrateInput
                    {
                        RecoveryPointId = "/Subscriptions/cb53d0c3-bd59-4721-89bc-06916a9147ef/resourceGroups/hydratestrg/providers/Microsoft.RecoveryServicesBVTD2/Vaults/hydratest/replicationFabrics/migrationoneboxreplicationfabric/replicationProtectionContainers/cloud_64264558-0517-5350-93e1-030c8b35cdfc/replicationMigrationItems/V2A-w2K12-114/migrationRecoveryPoints/64f81b39-7cc0-47a4-a02b-91e2de437aae", //pits.MigrationRecoveryPoints.ToList().Last().Id,
                        NetworkId = TfoNetworkId
                    };

                    this.TestMigrate(inMageMigrationTestMigrateInput, client);
                }
                catch (Exception)
                {
                    Debugger.Break();
                    throw;
                }
            }
        }

        [Fact]
        public void InMageMigration_Migrate()
        {
            using (UndoContext context = UndoContext.Current)
            {
                try
                {
                    context.Start();
                    var client = GetSiteRecoveryClient(CustomHttpHandler, "Migration");

                    var inMageMigrationMigrateInput = new InMageMigrationMigrateInput
                    {
                        PerformShutdown = "true"
                    };

                    this.Migrate(inMageMigrationMigrateInput, client);
                }
                catch (Exception)
                {
                    Debugger.Break();
                    throw;
                }
            }
        }


        #region Private methods

        private void CreateVMwareFabric(SiteRecoveryManagementClient client)
        {
            // Create VMware fabric.
            var vmwareFabricInput = new FabricCreationInput()
            {
                Properties = new FabricCreationInputProperties()
                {
                    CustomDetails = new VMwareV2FabricCreationInput()
                    {
                        InstanceType = "VMwareV2",
                        VMwareSiteId = VMwareSiteId,
                        MigrationSolutionId = MigrationSolutionId,
                        PhysicalSiteId = PhysicalSiteId
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
            client.RecoveryServicesProvider.Create(
                VMwareFabricName,
                VMwareDraName,
                vmwareDraInput,
                RequestHeaders);

            // Create both VMwareCbt and InMageMigration PUs.
            var containerInput = new CreateProtectionContainerInput()
            {
                Properties = new CreateProtectionContainerInputProperties()
                {
                    ProviderSpecificInputs = new List<ReplicationProviderSpecificContainerCreationInput>()
                }
            };
            client.ProtectionContainer.Create(
                VMwareFabricName,
                VMwareContainerName,
                containerInput,
                RequestHeaders);
        }

        private void CreateProtectionContainerMapping<T>(
            string policyName,
            string containerMappingName,
            T providerSpecificContainerMappingInput,
            SiteRecoveryManagementClient client) where T : ReplicationProviderContainerMappingInput
        {
            var vmwarePolicy = client.Policies.List(RequestHeaders).Policies
                .Where(x => x.Name == policyName)
                .Single();

            var mappingInput = new CreateProtectionContainerMappingInput
            {
                Properties = new CreateProtectionContainerMappingInputProperties()
                {
                    PolicyId = vmwarePolicy.Id,
                    TargetProtectionContainerId = "Microsoft Azure",
                    ProviderSpecificInput = providerSpecificContainerMappingInput
                }
            };
            client.ProtectionContainerMapping.ConfigureProtection(
                VMwareFabricName,
                VMwareContainerName,
                containerMappingName,
                mappingInput,
                RequestHeaders);
        }

        private void CreatePolicy<T>(
            string policyName,
            T providerSpecificPolicyInput,
            SiteRecoveryManagementClient client) where T : PolicyProviderSpecificInput
        {
            var policyInput = new CreatePolicyInput()
            {
                Properties = new CreatePolicyInputProperties()
                {
                    ProviderSpecificInput = providerSpecificPolicyInput
                }
            };
            client.Policies.Create(policyName, policyInput, RequestHeaders);
        }

        private void TestMigrate<T>(
            T providerSpecificTestMigrateInput,
            SiteRecoveryManagementClient client) where T : TestMigrateProviderSpecificInput
        {
            var testMigrateInput = new TestMigrateInput
            {
                Properties = new TestMigrateInputProperties
                {
                    ProviderSpecificDetails = providerSpecificTestMigrateInput
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

        private void Migrate<T>(
            T providerSpecificMigrateInput,
            SiteRecoveryManagementClient client) where T : MigrateProviderSpecificInput
        {
            var migrateInput = new MigrateInput
            {
                Properties = new MigrateInputProperties
                {
                    ProviderSpecificDetails = providerSpecificMigrateInput
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

        #endregion Private methods
    }
}
