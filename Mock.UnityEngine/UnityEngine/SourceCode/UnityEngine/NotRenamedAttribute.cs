namespace UnityEngine
{
    using System;

    [NotConverted, Obsolete("NotRenamedAttribute was used for the Flash buildtarget, which is not supported anymore starting Unity 5.0", true), AttributeUsage(AttributeTargets.Interface | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Struct | AttributeTargets.Class)]
    public sealed class NotRenamedAttribute : Attribute
    {
    }
}

