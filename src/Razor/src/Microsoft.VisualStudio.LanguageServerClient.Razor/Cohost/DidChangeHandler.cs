﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using System;
using System.Composition;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.LanguageServer.ProjectSystem;
using Microsoft.CodeAnalysis.ExternalAccess.Razor.Cohost;
using Microsoft.CodeAnalysis.Razor;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.VisualStudio.LanguageServerClient.Razor.Cohost;

[Export(typeof(IRazorCohostDidChangeHandler))]
[method: ImportingConstructor]
internal class DidChangeHandler(ProjectSnapshotManagerDispatcher projectSnapshotManagerDispatcher, RazorProjectService razorProjectService) : IRazorCohostDidChangeHandler
{
    private readonly ProjectSnapshotManagerDispatcher _projectSnapshotManagerDispatcher = projectSnapshotManagerDispatcher;
    private readonly RazorProjectService _razorProjectService = razorProjectService;

    public Task HandleAsync(Uri uri, int version, SourceText sourceText, CancellationToken cancellationToken)
    {
        return _projectSnapshotManagerDispatcher.RunOnDispatcherThreadAsync(
            () => _razorProjectService.UpdateDocument(uri.GetAbsoluteOrUNCPath(), sourceText, version),
            cancellationToken);
    }
}
