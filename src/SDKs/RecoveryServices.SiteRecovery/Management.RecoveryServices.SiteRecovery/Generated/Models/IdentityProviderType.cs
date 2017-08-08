// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for IdentityProviderType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IdentityProviderType
    {
        [EnumMember(Value = "RecoveryServicesActiveDirectory")]
        RecoveryServicesActiveDirectory,
        [EnumMember(Value = "CustomerActiveDirectory")]
        CustomerActiveDirectory
    }
    internal static class IdentityProviderTypeEnumExtension
    {
        internal static string ToSerializedValue(this IdentityProviderType? value)  =>
            value == null ? null : ((IdentityProviderType)value).ToSerializedValue();

        internal static string ToSerializedValue(this IdentityProviderType value)
        {
            switch( value )
            {
                case IdentityProviderType.RecoveryServicesActiveDirectory:
                    return "RecoveryServicesActiveDirectory";
                case IdentityProviderType.CustomerActiveDirectory:
                    return "CustomerActiveDirectory";
            }
            return null;
        }

        internal static IdentityProviderType? ParseIdentityProviderType(this string value)
        {
            switch( value )
            {
                case "RecoveryServicesActiveDirectory":
                    return IdentityProviderType.RecoveryServicesActiveDirectory;
                case "CustomerActiveDirectory":
                    return IdentityProviderType.CustomerActiveDirectory;
            }
            return null;
        }
    }
}
