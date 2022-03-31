// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class RuleManagementEventDataSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EventName))
            {
                writer.WritePropertyName("eventName");
                writer.WriteStringValue(EventName);
            }
            if (Optional.IsDefined(EventSource))
            {
                writer.WritePropertyName("eventSource");
                writer.WriteStringValue(EventSource);
            }
            if (Optional.IsDefined(Level))
            {
                writer.WritePropertyName("level");
                writer.WriteStringValue(Level);
            }
            if (Optional.IsDefined(OperationName))
            {
                writer.WritePropertyName("operationName");
                writer.WriteStringValue(OperationName);
            }
            if (Optional.IsDefined(ResourceGroupName))
            {
                writer.WritePropertyName("resourceGroupName");
                writer.WriteStringValue(ResourceGroupName);
            }
            if (Optional.IsDefined(ResourceProviderName))
            {
                writer.WritePropertyName("resourceProviderName");
                writer.WriteStringValue(ResourceProviderName);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(SubStatus))
            {
                writer.WritePropertyName("subStatus");
                writer.WriteStringValue(SubStatus);
            }
            if (Optional.IsDefined(Claims))
            {
                writer.WritePropertyName("claims");
                writer.WriteObjectValue(Claims);
            }
            writer.WritePropertyName("odata.type");
            writer.WriteStringValue(OdataType);
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId");
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(LegacyResourceId))
            {
                writer.WritePropertyName("legacyResourceId");
                writer.WriteStringValue(LegacyResourceId);
            }
            if (Optional.IsDefined(ResourceLocation))
            {
                writer.WritePropertyName("resourceLocation");
                writer.WriteStringValue(ResourceLocation);
            }
            if (Optional.IsDefined(MetricNamespace))
            {
                writer.WritePropertyName("metricNamespace");
                writer.WriteStringValue(MetricNamespace);
            }
            writer.WriteEndObject();
        }

        internal static RuleManagementEventDataSource DeserializeRuleManagementEventDataSource(JsonElement element)
        {
            Optional<string> eventName = default;
            Optional<string> eventSource = default;
            Optional<string> level = default;
            Optional<string> operationName = default;
            Optional<string> resourceGroupName = default;
            Optional<string> resourceProviderName = default;
            Optional<string> status = default;
            Optional<string> subStatus = default;
            Optional<RuleManagementEventClaimsDataSource> claims = default;
            string odataType = default;
            Optional<string> resourceId = default;
            Optional<string> legacyResourceId = default;
            Optional<string> resourceLocation = default;
            Optional<string> metricNamespace = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventName"))
                {
                    eventName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventSource"))
                {
                    eventSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("level"))
                {
                    level = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationName"))
                {
                    operationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroupName"))
                {
                    resourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceProviderName"))
                {
                    resourceProviderName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subStatus"))
                {
                    subStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("claims"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    claims = RuleManagementEventClaimsDataSource.DeserializeRuleManagementEventClaimsDataSource(property.Value);
                    continue;
                }
                if (property.NameEquals("odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("legacyResourceId"))
                {
                    legacyResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceLocation"))
                {
                    resourceLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricNamespace"))
                {
                    metricNamespace = property.Value.GetString();
                    continue;
                }
            }
            return new RuleManagementEventDataSource(odataType, resourceId.Value, legacyResourceId.Value, resourceLocation.Value, metricNamespace.Value, eventName.Value, eventSource.Value, level.Value, operationName.Value, resourceGroupName.Value, resourceProviderName.Value, status.Value, subStatus.Value, claims.Value);
        }
    }
}
