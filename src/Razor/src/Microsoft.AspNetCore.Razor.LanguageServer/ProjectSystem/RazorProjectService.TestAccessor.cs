﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Razor.LanguageServer.ProjectSystem;

internal partial class RazorProjectService
{
    internal TestAccessor GetTestAccessor() => new(this);

    internal readonly struct TestAccessor(RazorProjectService instance)
    {
        public ValueTask WaitForInitializationAsync()
            => instance.WaitForInitializationAsync();
    }
}
