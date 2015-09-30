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

                string fabricId = "6adf9420-b02f-4377-8ab7-ff384e6d792f";
                string containerId = "4f94127d-2eb3-449d-a708-250752e93cb4";
                //string peId = "4d63fad7-eb47-4f47-8f2b-c789ec853a58";
                //string peId = "052ca37a-cdca-441f-82ba-55d22de2409e";

                var container = client.ProtectionContainer.Get(fabricId, containerId, RequestHeaders);

                string pairedPolicy = container.ProtectionContainer.Properties.ProtectionConfigurationSettings[0].PolicyId;

                var policies = client.Policies.List(RequestHeaders);

                Policy selectedPolicy = new Policy();

                foreach (var policy in policies.Policies)
                {
                    if (policy.Id == pairedPolicy)
                    {
                        selectedPolicy = policy;
                        break;
                    }
                }

                HyperVReplicaPolicyDetails policyDet = (HyperVReplicaPolicyDetails)selectedPolicy.Properties.ReplicationProviderSettings;

                HyperVReplicaPolicyInput hvrProfileInput = new HyperVReplicaPolicyInput()
                {
                    ApplicationConsistentSnapshotFrequencyInHours = policyDet.ApplicationConsistentSnapshotFrequencyInHours,
                    AllowedAuthenticationType = policyDet.AllowedAuthenticationType,
                    Compression = "Enable",
                    InitialReplicationMethod = "OverNetwork",
                    OnlineReplicationStartTime = null,
                    RecoveryPoints = policyDet.RecoveryPoints,
                    ReplicaDeletion = "Required",
                    ReplicationFrequencyInSeconds = policyDet.ReplicationFrequencyInSeconds,
                    ReplicationPort = policyDet.ReplicationPort
                };

                CreatePolicyInputProperties policyCreationProp = new CreatePolicyInputProperties()
                {
                    ReplicationProvider = selectedPolicy.Properties.ReplicationProvider,
                    ReplicationProviderSettings = hvrProfileInput
                };

                CreatePolicyInput policyCreation = new CreatePolicyInput()
                {
                    Properties = policyCreationProp
                };

                string policyName = "Hydra11" + Guid.NewGuid().ToString();

                var resp = client.Policies.Create(policyName, policyCreation, RequestHeaders);

                policies = client.Policies.List(RequestHeaders);
                Policy newPolicy = new Policy();

                foreach (var policy in policies.Policies)
                {
                    if (policyName == policy.Properties.FriendlyName)
                    {
                        newPolicy = policy;
                        break;
                    }
                }

                string priCld = "85a747d6-03f2-4002-9510-96e10648d484";
                string recCld = "4f9dbf63-3f0c-4dd3-bd0e-9d27e414de8d";

                var reccloud = client.ProtectionContainer.Get(fabricId, recCld, RequestHeaders);

                List<ApplicablePolicy> applicablePolicies = new List<ApplicablePolicy>();

                ApplicablePolicy policy1 = new ApplicablePolicy()
                {
                    PolicyId = newPolicy.Id
                };

                applicablePolicies.Add(policy1);

                ConfigureProtectionInputProperties properties = new ConfigureProtectionInputProperties()
                {
                    TargetProtectionContainerName = reccloud.ProtectionContainer.Id,
                    FabricType = "",
                    ApplicablePolicies = applicablePolicies,
                    ProviderConfigurationSettings = null
                };

                ConfigureProtectionInput inputForPairing = new ConfigureProtectionInput()
                {
                    Properties = properties
                };

                var pairingResp = client.ProtectionContainer.ConfigureProtection(fabricId, priCld, inputForPairing, RequestHeaders);
            }
        }

        [Fact]
        public void UnpairClouds()
        {
            using (UndoContext context = UndoContext.Current)
            {
                context.Start();
                var client = GetSiteRecoveryClient(CustomHttpHandler);

                string fabricId = "6adf9420-b02f-4377-8ab7-ff384e6d792f";
                string policyName = "Hydra11";
                //string peId = "4d63fad7-eb47-4f47-8f2b-c789ec853a58";
                //string peId = "052ca37a-cdca-441f-82ba-55d22de2409e";

                var policies = client.Policies.List(RequestHeaders);
                Policy selectedPolicy = new Policy();

                foreach (var policy in policies.Policies)
                {
                    if (policyName == policy.Properties.FriendlyName)
                    {
                        selectedPolicy = policy;
                        break;
                    }
                }

                string priCld = "85a747d6-03f2-4002-9510-96e10648d484";
                string recCld = "4f9dbf63-3f0c-4dd3-bd0e-9d27e414de8d";

                var reccloud = client.ProtectionContainer.Get(fabricId, recCld, RequestHeaders);

                List<ApplicablePolicy> applicablePolicies = new List<ApplicablePolicy>();

                ApplicablePolicy policy1 = new ApplicablePolicy()
                {
                    PolicyId = selectedPolicy.Id
                };

                applicablePolicies.Add(policy1);

                UnconfigureProtectionInputProperties properties = new UnconfigureProtectionInputProperties()
                {
                    TargetProtectionContainerName = reccloud.ProtectionContainer.Id,
                    FabricType = "",
                    ApplicablePolicies = applicablePolicies,
                    ProviderConfigurationSettings = null
                };

                UnconfigureProtectionInput inputForPairing = new UnconfigureProtectionInput()
                {
                    Properties = properties
                };

                var respUnpairing = client.ProtectionContainer.UnconfigureProtection(fabricId, priCld, inputForPairing, RequestHeaders);
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
