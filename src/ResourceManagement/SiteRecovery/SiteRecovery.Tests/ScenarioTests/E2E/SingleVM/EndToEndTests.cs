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
using System;
using System.Collections.Generic;


namespace SiteRecovery.Tests
{
    public class EndToEndTests : SiteRecoveryTestsBase
    {
        [Fact]
        public void EndToEndE2ESingleVM()
        {
            using (UndoContext context = UndoContext.Current)
            {
                context.Start();
                var client = GetSiteRecoveryClient(CustomHttpHandler);

                var fabrics = client.Fabrics.List(RequestHeaders);

                Fabric selectedFabric = null;

                foreach (var fabric in fabrics.Fabrics)
                {
                    if (fabric.Properties.FabricType.Contains("VMM"))
                    {
                        selectedFabric = fabric;
                    }
                }

                string priCld = string.Empty;
                string recCld = string.Empty;
                Policy existingPolicy = null;

                var containers = client.ProtectionContainer.List(selectedFabric.Name, RequestHeaders);
                var policies = client.Policies.List(RequestHeaders);

                foreach (var container in containers.ProtectionContainers)
                {
                    if (container.Properties.ProtectionConfigurationSettings.Count == 0)
                    {
                        if (string.IsNullOrEmpty(priCld))
                        {
                            priCld = container.Name;
                        }
                        else if (string.IsNullOrEmpty(recCld))
                        {
                            recCld = container.Id;
                        }
                    }
                    else
                    {
                        if (existingPolicy == null)
                        {
                            string existingPolicyId = container.Properties.ProtectionConfigurationSettings[0].PolicyId;

                            foreach (var policy in policies.Policies)
                            {
                                if (policy.Properties.ReplicationProvider.ToLower().Equals("hypervreplica")
                                    && policy.Id.Equals(existingPolicyId, StringComparison.InvariantCultureIgnoreCase))
                                {
                                    existingPolicy = policy;
                                }
                            }
                        }
                    }
                }

                HyperVReplicaPolicyDetails policyDet = (HyperVReplicaPolicyDetails)existingPolicy.Properties.ReplicationProviderSettings;

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
                    ReplicationProvider = existingPolicy.Properties.ReplicationProvider,
                    ReplicationProviderSettings = hvrProfileInput
                };

                CreatePolicyInput policyCreationInput = new CreatePolicyInput()
                {
                    Properties = policyCreationProp
                };

                string policyName = "Hydra200" + (new Random()).Next();
                Policy currentPolicy = null;

                var policyCreateResp = client.Policies.Create(policyName, policyCreationInput, RequestHeaders);

                currentPolicy = client.Policies.Get(policyName, RequestHeaders).Policy;

                List<ApplicablePolicy> applicablePolicies = new List<ApplicablePolicy>();

                ApplicablePolicy policy1 = new ApplicablePolicy()
                {
                    PolicyId = currentPolicy.Id
                };

                applicablePolicies.Add(policy1);

                ConfigureProtectionInputProperties properties = new ConfigureProtectionInputProperties()
                {
                    TargetProtectionContainerName = recCld,
                    FabricType = "",
                    ApplicablePolicies = applicablePolicies,
                    ProviderConfigurationSettings = null
                };

                ConfigureProtectionInput inputForPairing = new ConfigureProtectionInput()
                {
                    Properties = properties
                };

                var cloudPairingResp = client.ProtectionContainer.ConfigureProtection(selectedFabric.Name, priCld, inputForPairing, RequestHeaders);

                var protectableItems = client.ProtectableItem.List(selectedFabric.Name, priCld, "Unprotected", RequestHeaders);

                EnableProtectionInputProperties enableDRProp = new EnableProtectionInputProperties()
                {
                    PolicyId = currentPolicy.Id,
                    ProtectableItemId = protectableItems.ProtectableItems[0].Id,
                    ProviderConfigurationSettings = new EnableProtectionProviderSpecificInput()
                };

                EnableProtectionInput enableInput = new EnableProtectionInput()
                {
                    Properties = enableDRProp
                };

                var enableDR = client.ReplicationProtectedItem.EnableProtection(selectedFabric.Name, priCld, "Blah", enableInput, RequestHeaders);

                var replicationProtectedItems = client.ReplicationProtectedItem.List(selectedFabric.Name, priCld, RequestHeaders);

                PlannedFailoverInputProperties plannedFailoverProp = new PlannedFailoverInputProperties()
                {
                    FailoverDirection = "PrimaryToRecovery",
                    ProviderConfigurationSettings = new ProviderSpecificFailoverInput()
                };

                PlannedFailoverInput plannedFailoverInput = new PlannedFailoverInput()
                {
                    Properties = plannedFailoverProp
                };

                var plannedFailover = client.ReplicationProtectedItem.PlannedFailover(selectedFabric.Name, priCld, replicationProtectedItems.ReplicationProtectedItems[0].Name, plannedFailoverInput, RequestHeaders);

                var commitFailover = client.ReplicationProtectedItem.CommitFailover(selectedFabric.Name, priCld, replicationProtectedItems.ReplicationProtectedItems[0].Name, RequestHeaders);

                ReverseReplicationInputProperties rrProp = new ReverseReplicationInputProperties()
                {
                    FailoverDirection = "",
                    ProviderConfigurationSettings = new ReverseReplicationProviderSpecificInput()
                };

                ReverseReplicationInput rrInput = new ReverseReplicationInput()
                {
                    Properties = rrProp
                };

                var rr = client.ReplicationProtectedItem.Reprotect(selectedFabric.Name, priCld, replicationProtectedItems.ReplicationProtectedItems[0].Name, rrInput, RequestHeaders);

                var plannedFailoverReverse = client.ReplicationProtectedItem.PlannedFailover(selectedFabric.Name, priCld, replicationProtectedItems.ReplicationProtectedItems[0].Name, plannedFailoverInput, RequestHeaders);

                var commitFailoverReverse = client.ReplicationProtectedItem.CommitFailover(selectedFabric.Name, priCld, replicationProtectedItems.ReplicationProtectedItems[0].Name, RequestHeaders);

                var rrReverse = client.ReplicationProtectedItem.Reprotect(selectedFabric.Name, priCld, replicationProtectedItems.ReplicationProtectedItems[0].Name, rrInput, RequestHeaders);

                var disableDR = client.ReplicationProtectedItem.DisableProtection(selectedFabric.Name, priCld, replicationProtectedItems.ReplicationProtectedItems[0].Name, new DisableProtectionInput(), RequestHeaders);

                var recoveryCld = client.ProtectionContainer.Get(selectedFabric.Name, recCld, RequestHeaders);

                UnconfigureProtectionInputProperties unpairProp = new UnconfigureProtectionInputProperties()
                {
                    TargetProtectionContainerName = recoveryCld.ProtectionContainer.Id,
                    FabricType = "",
                    ApplicablePolicies = applicablePolicies,
                    ProviderConfigurationSettings = null
                };

                UnconfigureProtectionInput unpairInput = new UnconfigureProtectionInput()
                {
                    Properties = unpairProp
                };

                var unpaiClouds = client.ProtectionContainer.UnconfigureProtection(selectedFabric.Name, priCld, unpairInput, RequestHeaders);

                var policyDeletion = client.Policies.Delete(currentPolicy.Name, RequestHeaders);
            }
        }
    }
}
