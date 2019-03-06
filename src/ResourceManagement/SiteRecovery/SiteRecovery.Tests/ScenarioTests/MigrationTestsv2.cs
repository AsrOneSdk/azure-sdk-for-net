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
using System.Diagnostics;
using System.Linq;
using Microsoft.Azure.Management.SiteRecovery;
using Microsoft.Azure.Management.SiteRecovery.Models;
using Microsoft.Azure.Test;
using Xunit;


namespace SiteRecovery.Tests.ScenarioTests
{
    public class MigrationTestsv2 : SiteRecoveryTestsBase
    {
        // VMware fabric input
        private const string VMwareFabricName = "lshaimigrationfabric";
        private const string VMwareSiteId = "/subscriptions/8d29733f-80ae-41b5-95d5-de86bb160521/resourceGroups/rohithtest/providers/Microsoft.OffAzure/VMwareSites/site1a5a06f";
        private const string MigrationSolutionId = "/subscriptions/8d29733f-80ae-41b5-95d5-de86bb160521/resourceGroups/rohithtest/providers/Microsoft.Migrate/MigrateProjects/rohithtest-MigrateProject/Solutions/Servers-Migration-ServerMigration";

        // VMware DRA input.
        private const string VMwareDraName = "lshaimigrationdra";
        private const string TenantId = "72f988bf-86f1-41af-91ab-2d7cd011db47";
        private const string ApplicationId = "f66fce08-c0c6-47a1-beeb-0ede5ea94f90";
        private const string ObjectId = "141360b8-5686-4240-a027-5e24e6affeba";
        private const string Audience = "https://microsoft.onmicrosoft.com/cf19e349-644c-4c6a-bcae-9c8f35357874";
        private const string AadAuthority = "https://login.microsoftonline.com";

        // VMware container input.
        private const string VMwareContainerName = "lshaimigrationcontainer";

        // VMware policy input.
        private const string VMwarePolicyName = "vmwaremigrationpolicy1";
        private const int CrashIntervalInMins = 1 * 60;
        private const int AppIntervalInMins = 4 * 60;
        private const int RecoveryPointHistoryInMins = 72 * 60;

        // Container mapping input.
        private const string ContainerMappingName = "lshaimigrationmapping1";
        private const string TargetLocation = "southeastasia";
        private const string KeyVaultId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourceGroups/devbabuova1/providers/Microsoft.KeyVault/vaults/devbabuova1gwykv";
        private const string KeyVaultUri = "https://devbabuova1gwykv.vault.azure.net/";
        private const string StorageAccountId = "/subscriptions/42195872-7e70-4f8a-837f-84b28ecbb78b/resourceGroups/devbabuova1/providers/Microsoft.Storage/storageAccounts/devbabuova1gwysa";
        private const string StorageAccountSasSecretName = "devbabuova1gwysa-devbabuova1gwysasas";
        private const string ServiceBusConnectionStringSecretName = "devbabuova1gwysbus";

        [Fact]
        public void Migrationv2_ListTests()
        {
            using (UndoContext context = UndoContext.Current)
            {
                try
                {
                    context.Start();
                    var client = GetSiteRecoveryClient(CustomHttpHandler, "Migration");

                    var migFabricsInVault = client.MigrationFabric.List(RequestHeaders);

                    var migProvidersInVault = client.MigrationProvider.ListAll(RequestHeaders);
                    var migProvidersInFabric = client.MigrationProvider.List(VMwareFabricName, RequestHeaders);

                    var migContainersInVault = client.MigrationContainer.ListAll(RequestHeaders);
                    var migContainersInFabric = client.MigrationContainer.List(VMwareFabricName, RequestHeaders);

                    var migPoliciesInVault = client.MigrationPolicy.List(RequestHeaders);

                    var migMappingsInVault = client.MigrationContainerMapping.ListAll(RequestHeaders);
                    var migMappingsInFabric = client.MigrationContainerMapping.List(VMwareFabricName, VMwareContainerName, RequestHeaders);
                }
                catch (Exception ex)
                {
                    Debugger.Break();
                    throw ex;
                }
            }
        }

        [Fact]
        public void Migrationv2_ContainerMapping()
        {
            using (UndoContext context = UndoContext.Current)
            {
                try
                {
                    context.Start();
                    var client = GetSiteRecoveryClient(CustomHttpHandler, "Migration");

                    // Create VMware migration fabric.
                    var vmwareFabricInput = new MigrationFabricCreationInput()
                    {
                        Properties = new MigrationFabricCreationInputProperties()
                        {
                            ProviderSpecificDetails = new VMwareV2MigrationFabricCreationInput()
                            {
                                InstanceType = "VMwareV2",
                                VMwareSiteId = VMwareSiteId,
                                MigrationSolutionId = MigrationSolutionId
                            }
                        }
                    };
                    client.MigrationFabric.Create(VMwareFabricName, vmwareFabricInput, RequestHeaders);

                    var migFabric = client.MigrationFabric.Get(VMwareFabricName, RequestHeaders);

                    // Create VMware migration DRA.
                    var vmwareDraInput = new MigrationProviderCreationInput()
                    {
                        Properties = new MigrationProviderCreationInputProperties()
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
                    client.MigrationProvider.Create(VMwareFabricName, VMwareDraName, vmwareDraInput, RequestHeaders);

                    var migDra = client.MigrationProvider.Get(VMwareFabricName, VMwareDraName, RequestHeaders);

                    // Create VMware migration container.
                    var vmwareContainerInput = new MigrationContainerCreationInput()
                    {
                        Properties = new MigrationContainerCreationInputProperties()
                        {
                        }
                    };
                    client.MigrationContainer.Create(VMwareFabricName, VMwareContainerName, vmwareContainerInput, RequestHeaders);

                    var migContainer = client.MigrationContainer.Get(VMwareFabricName, VMwareContainerName, RequestHeaders);

                    // Create VMware policy.
                    var vmwarePolicyInput = new MigrationPolicyCreationInput()
                    {
                        Properties = new MigrationPolicyCreationInputProperties()
                        {
                            ProviderSpecificDetails = new VMwareCbtMigrationPolicyCreationInput()
                            {
                                RecoveryPointHistoryInMinutes = RecoveryPointHistoryInMins,
                                CrashConsistentFrequencyInMinutes = CrashIntervalInMins,
                                AppConsistentFrequencyInMinutes = AppIntervalInMins
                            }
                        }
                    };
                    client.MigrationPolicy.Create(VMwarePolicyName, vmwarePolicyInput, RequestHeaders);

                    var migPolicy = client.MigrationPolicy.Get(VMwarePolicyName, RequestHeaders);

                    // Create container mappping.
                    var vmwarePolicy = client.MigrationPolicy.List(RequestHeaders).MigrationPolicies
                        .Where(x => x.Name == VMwarePolicyName)
                        .Single();

                    var mappingInput = new MigrationContainerMappingCreationInput
                    {
                        Properties = new MigrationContainerMappingCreationInputProperties()
                        {
                            PolicyName = vmwarePolicy.Id,
                            ProviderSpecificDetails = new VMwareCbtMigrationContainerMappingInput()
                            {
                                KeyVaultId = KeyVaultId,
                                KeyVaultUri = KeyVaultUri,
                                StorageAccountId = StorageAccountId,
                                StorageAccountSasSecretName = StorageAccountSasSecretName,
                                ServiceBusConnectionStringSecretName = ServiceBusConnectionStringSecretName,
                                TargetLocation = TargetLocation
                            }
                        }
                    };
                    client.MigrationContainerMapping.Create(
                        VMwareFabricName,
                        VMwareContainerName,
                        ContainerMappingName,
                        mappingInput,
                        RequestHeaders);

                    var migMapping = client.MigrationContainerMapping.Get(VMwareFabricName, VMwareContainerName, ContainerMappingName, RequestHeaders);
                }
                catch (Exception ex)
                {
                    Debugger.Break();
                    throw ex;
                }
            }
        }
    }
}
