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

using Microsoft.Azure.Management.SiteRecovery.Models;
using Microsoft.Azure.Management.SiteRecovery;
using Microsoft.Azure.Test;
using System.Net;
using Xunit;
using System.Collections.Generic;
using System;


namespace SiteRecovery.Tests
{
    public class PairingTests : SiteRecoveryTestsBase
    {
        [Fact]
        public void PairClouds()
        {
            using (UndoContext context = UndoContext.Current)
            {
                context.Start();
                var client = GetSiteRecoveryClient(CustomHttpHandler);

                string priCld = string.Empty;
                string recCldGuid = string.Empty;
                string recCld = string.Empty;
                string policyName = "Hydra" + (new Random()).Next();
                Fabric selectedFabric = null;
                Policy currentPolicy = null;

                var fabrics = client.Fabrics.List(RequestHeaders);

                foreach (var fabric in fabrics.Fabrics)
                {
                    if (fabric.Properties.FabricType.Contains("VMM"))
                    {
                        selectedFabric = fabric;
                    }
                }

                var containers = client.ProtectionContainer.List(selectedFabric.Name, RequestHeaders);

                foreach (var container in containers.ProtectionContainers)
                {
                    if (client.ProtectionContainerMapping.List(selectedFabric.Name, container.Name, RequestHeaders).ProtectionContainerMappings.Count == 0)
                    {
                        if (string.IsNullOrEmpty(priCld))
                        {
                            priCld = container.Name;
                        }
                        else if (string.IsNullOrEmpty(recCld))
                        {
                            recCld = container.Id;
                            recCldGuid = container.Name;
                        }
                    }
                }

                HyperVReplicaPolicyInput hvrProfileInput = new HyperVReplicaPolicyInput()
                {
                    ApplicationConsistentSnapshotFrequencyInHours = 0,
                    AllowedAuthenticationType = 1,
                    Compression = "Enable",
                    InitialReplicationMethod = "OverNetwork",
                    OnlineReplicationStartTime = null,
                    RecoveryPoints = 0,
                    ReplicaDeletion = "Required",
                    ReplicationFrequencyInSeconds = 30,
                    ReplicationPort = 8083
                };

                CreatePolicyInputProperties policyCreationProp = new CreatePolicyInputProperties()
                {
                    ReplicationProvider = "HyperVReplica",
                    ProviderSpecificInput = hvrProfileInput
                };

                CreatePolicyInput policyCreationInput = new CreatePolicyInput()
                {
                    Properties = policyCreationProp
                };

                var policyCreateResp = client.Policies.Create(policyName, policyCreationInput, RequestHeaders);

                currentPolicy = client.Policies.Get(policyName, RequestHeaders).Policy;

                CreateProtectionContainerMappingInputProperties pairingProps =
                    new CreateProtectionContainerMappingInputProperties()
                {
                    PolicyId = currentPolicy.Id,
                    ProviderSpecificInput = new ReplicationProviderContainerMappingInput(),
                    TargetProtectionContainerId = recCld
                };

                CreateProtectionContainerMappingInput pairingInput = new CreateProtectionContainerMappingInput()
                {
                    Properties = pairingProps
                };

                var pairingResp = client.ProtectionContainerMapping.ConfigureProtection(selectedFabric.Name, priCld, "Mapping01", pairingInput, RequestHeaders);
            }
        }

        [Fact]
        public void UnpairClouds()
        {
            using (UndoContext context = UndoContext.Current)
            {
                context.Start();
                var client = GetSiteRecoveryClient(CustomHttpHandler);
                Fabric selectedFabric = null;

                string fabricName = "Vmm;6adf9420-b02f-4377-8ab7-ff384e6d792f";
                string mappingName = "Mapping01";
                string cloudName = "4f94127d-2eb3-449d-a708-250752e93cb4";

                selectedFabric = client.Fabrics.Get(fabricName, RequestHeaders).Fabric;

                var mapping = client.ProtectionContainerMapping.Get(fabricName, cloudName, mappingName, RequestHeaders);
                var unpairResp = client.ProtectionContainerMapping.UnconfigureProtection(fabricName, cloudName, mappingName, new RemoveProtectionContainerMappingInput(), RequestHeaders);
            }
        }

        [Fact]
        public void CreateProfile()
        {
            using (UndoContext context = UndoContext.Current)
            {
                context.Start();
                var client = GetSiteRecoveryClient(CustomHttpHandler);
                string policyName = "ARMProfile111";
                HyperVReplicaAzurePolicyInput hvrAPolicy = new HyperVReplicaAzurePolicyInput()
                {
                    ApplicationConsistentSnapshotFrequencyInHours = 0,
                    Encryption = "Disable",
                    OnlineIrStartTime = null,
                    RecoveryPointHistoryDuration = 0,
                    ReplicationInterval = 30,
                    StorageAccounts = new List<string>() { "/subscriptions/19b823e2-d1f3-4805-93d7-401c5d8230d5/resourceGroups/Default-Storage-WestUS/providers/Microsoft.ClassicStorage/storageAccounts/bvtmapped2storacc" }
                };

                CreatePolicyInputProperties createInputProp = new CreatePolicyInputProperties()
                {
                    ReplicationProvider = "HyperVReplicaAzure",
                    ProviderSpecificInput = hvrAPolicy
                };

                CreatePolicyInput policyInput = new CreatePolicyInput()
                {
                    Properties = createInputProp
                };

                var policy = client.Policies.Create(policyName, policyInput, RequestHeaders);

                //var selectedPolicy = (client.Policies.Create(policyName, policyInput, RequestHeaders) as CreatePolicyOperationResponse).Policy;
            }
        }

        [Fact]
        public void PairNetworks()
        {
            using (UndoContext context = UndoContext.Current)
            {
                context.Start();
                var client = GetSiteRecoveryClient(CustomHttpHandler);

                const string fabricName = "Vmm;f0632449-effd-4858-a210-4ea15756e4b7";
                const string primaryNetworkName = "399137cc-f0de-4a3f-b961-fd0892d8ebc4";
                const string networkMappingName = "Test";
                CreateNetworkMappingInput input = new CreateNetworkMappingInput()
                {
                    RecoveryFabricName = "Vmm;f0632449-effd-4858-a210-4ea15756e4b7",
                    RecoveryNetworkId = "/Subscriptions/19b823e2-d1f3-4805-93d7-401c5d8230d5/resourceGroups/Default-Storage-WestUS/providers/Microsoft.SiteRecovery/SiteRecoveryVault/testVault/replicationFabrics/Vmm;f0632449-effd-4858-a210-4ea15756e4b7/replicationNetworks/15e1a665-e184-4da0-8e9d-0de72a7d8fa9"
                };

                var response = client.NetworkMapping.Create(
                    fabricName,
                    primaryNetworkName,
                    networkMappingName,
                    input,
                    RequestHeaders);
            }
        }

        [Fact]
        public void UnPairNetworks()
        {
            using (UndoContext context = UndoContext.Current)
            {
                context.Start();
                var client = GetSiteRecoveryClient(CustomHttpHandler);

                const string fabricName = "Vmm;f0632449-effd-4858-a210-4ea15756e4b7";
                const string primaryNetworkName = "399137cc-f0de-4a3f-b961-fd0892d8ebc4";
                const string networkMappingName = "VMNetworkPair;f0632449-effd-4858-a210-4ea15756e4b7_399137cc-f0de-4a3f-b961-fd0892d8ebc4_21a9403c-6ec1-44f2-b744-b4e50b792387";

                var response = client.NetworkMapping.Delete(
                    fabricName,
                    primaryNetworkName,
                    networkMappingName,
                    RequestHeaders);
            }
        }
    }
}
