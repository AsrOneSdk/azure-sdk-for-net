// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SparkLinkedServiceConverter))]
    public partial class SparkLinkedService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia");
                writer.WriteObjectValue(ConnectVia);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations");
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            writer.WritePropertyName("host");
            writer.WriteObjectValue(Host);
            writer.WritePropertyName("port");
            writer.WriteObjectValue(Port);
            if (Optional.IsDefined(ServerType))
            {
                writer.WritePropertyName("serverType");
                writer.WriteStringValue(ServerType.Value.ToString());
            }
            if (Optional.IsDefined(ThriftTransportProtocol))
            {
                writer.WritePropertyName("thriftTransportProtocol");
                writer.WriteStringValue(ThriftTransportProtocol.Value.ToString());
            }
            writer.WritePropertyName("authenticationType");
            writer.WriteStringValue(AuthenticationType.ToString());
            if (Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username");
                writer.WriteObjectValue(Username);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password");
                writer.WriteObjectValue(Password);
            }
            if (Optional.IsDefined(HttpPath))
            {
                writer.WritePropertyName("httpPath");
                writer.WriteObjectValue(HttpPath);
            }
            if (Optional.IsDefined(EnableSsl))
            {
                writer.WritePropertyName("enableSsl");
                writer.WriteObjectValue(EnableSsl);
            }
            if (Optional.IsDefined(TrustedCertPath))
            {
                writer.WritePropertyName("trustedCertPath");
                writer.WriteObjectValue(TrustedCertPath);
            }
            if (Optional.IsDefined(UseSystemTrustStore))
            {
                writer.WritePropertyName("useSystemTrustStore");
                writer.WriteObjectValue(UseSystemTrustStore);
            }
            if (Optional.IsDefined(AllowHostNameCNMismatch))
            {
                writer.WritePropertyName("allowHostNameCNMismatch");
                writer.WriteObjectValue(AllowHostNameCNMismatch);
            }
            if (Optional.IsDefined(AllowSelfSignedServerCert))
            {
                writer.WritePropertyName("allowSelfSignedServerCert");
                writer.WriteObjectValue(AllowSelfSignedServerCert);
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential");
                writer.WriteObjectValue(EncryptedCredential);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static SparkLinkedService DeserializeSparkLinkedService(JsonElement element)
        {
            string type = default;
            Optional<IntegrationRuntimeReference> connectVia = default;
            Optional<string> description = default;
            Optional<IDictionary<string, ParameterSpecification>> parameters = default;
            Optional<IList<object>> annotations = default;
            object host = default;
            object port = default;
            Optional<SparkServerType> serverType = default;
            Optional<SparkThriftTransportProtocol> thriftTransportProtocol = default;
            SparkAuthenticationType authenticationType = default;
            Optional<object> username = default;
            Optional<SecretBase> password = default;
            Optional<object> httpPath = default;
            Optional<object> enableSsl = default;
            Optional<object> trustedCertPath = default;
            Optional<object> useSystemTrustStore = default;
            Optional<object> allowHostNameCNMismatch = default;
            Optional<object> allowSelfSignedServerCert = default;
            Optional<object> encryptedCredential = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ParameterSpecification.DeserializeParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetObject());
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("host"))
                        {
                            host = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("port"))
                        {
                            port = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("serverType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            serverType = new SparkServerType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("thriftTransportProtocol"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            thriftTransportProtocol = new SparkThriftTransportProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("authenticationType"))
                        {
                            authenticationType = new SparkAuthenticationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("username"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            username = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("password"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            password = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("httpPath"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            httpPath = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("enableSsl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableSsl = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("trustedCertPath"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            trustedCertPath = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("useSystemTrustStore"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            useSystemTrustStore = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("allowHostNameCNMismatch"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowHostNameCNMismatch = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("allowSelfSignedServerCert"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowSelfSignedServerCert = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            encryptedCredential = property0.Value.GetObject();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SparkLinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), Optional.ToList(annotations), additionalProperties, host, port, Optional.ToNullable(serverType), Optional.ToNullable(thriftTransportProtocol), authenticationType, username.Value, password.Value, httpPath.Value, enableSsl.Value, trustedCertPath.Value, useSystemTrustStore.Value, allowHostNameCNMismatch.Value, allowSelfSignedServerCert.Value, encryptedCredential.Value);
        }

        internal partial class SparkLinkedServiceConverter : JsonConverter<SparkLinkedService>
        {
            public override void Write(Utf8JsonWriter writer, SparkLinkedService model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SparkLinkedService Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSparkLinkedService(document.RootElement);
            }
        }
    }
}
