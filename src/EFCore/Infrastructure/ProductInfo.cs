// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Reflection;

namespace Microsoft.EntityFrameworkCore.Infrastructure
{
    /// <summary>
    ///     Helper class for finding the version of Entity Framework Core being used.
    /// </summary>
    public static class ProductInfo
    {
        /// <summary>
        ///     Gets the value of the <see cref="AssemblyInformationalVersionAttribute.InformationalVersion" />
        ///     for the EntityFrameworkCore assembly.
        /// </summary>
        /// <returns> The EF Core version being used. </returns>
        public static string GetVersion()
            => typeof(ProductInfo).Assembly
                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()!.InformationalVersion;
    }
}
