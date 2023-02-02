﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

#nullable disable

<<<<<<< HEAD:src/Razor/src/Microsoft.AspNetCore.Razor.ExternalAccess.OmniSharp/Project/OmniSharpProjectSnapshotManagerAccessor.cs
=======
using System;
using System.Collections.Generic;
>>>>>>> 4a4c0187f4aeceb347e3eec4cf8e913b4d1d5b9c:src/Razor/src/Microsoft.AspNetCore.Razor.OmniSharpPlugin.StrongNamed/DefaultOmniSharpProjectSnapshotManagerAccessor.cs
using Microsoft.AspNetCore.Razor.LanguageServer.Common;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Razor;
using Microsoft.CodeAnalysis.Razor.ProjectSystem;

namespace Microsoft.AspNetCore.Razor.ExternalAccess.OmniSharp.Project;

public class OmniSharpProjectSnapshotManagerAccessor
{
    private readonly RemoteTextLoaderFactory _remoteTextLoaderFactory;
    private readonly IEnumerable<AbstractOmniSharpProjectSnapshotManagerChangeTrigger> _projectChangeTriggers;
    private readonly OmniSharpProjectSnapshotManagerDispatcher _projectSnapshotManagerDispatcher;
    private readonly Workspace _workspace;
    private OmniSharpProjectSnapshotManager _instance;

    public OmniSharpProjectSnapshotManagerAccessor(
        RemoteTextLoaderFactory remoteTextLoaderFactory,
        IEnumerable<AbstractOmniSharpProjectSnapshotManagerChangeTrigger> projectChangeTriggers,
        OmniSharpProjectSnapshotManagerDispatcher projectSnapshotManagerDispatcher,
        Workspace workspace)
    {
        if (remoteTextLoaderFactory is null)
        {
            throw new ArgumentNullException(nameof(remoteTextLoaderFactory));
        }

        if (projectChangeTriggers is null)
        {
            throw new ArgumentNullException(nameof(projectChangeTriggers));
        }

        if (projectSnapshotManagerDispatcher is null)
        {
            throw new ArgumentNullException(nameof(projectSnapshotManagerDispatcher));
        }

        if (workspace is null)
        {
            throw new ArgumentNullException(nameof(workspace));
        }

        _remoteTextLoaderFactory = remoteTextLoaderFactory;
        _projectChangeTriggers = projectChangeTriggers;
        _projectSnapshotManagerDispatcher = projectSnapshotManagerDispatcher;
        _workspace = workspace;
    }

    public OmniSharpProjectSnapshotManager Instance
    {
        get
        {
            if (_instance is null)
            {
                var projectSnapshotManager = new DefaultProjectSnapshotManager(
                    _projectSnapshotManagerDispatcher.InternalDispatcher,
                    ErrorReporter.Instance,
                    Array.Empty<ProjectSnapshotChangeTrigger>(),
                    _workspace);

                var instance = new OmniSharpProjectSnapshotManager(projectSnapshotManager, _remoteTextLoaderFactory);
                _instance = instance;
                foreach (var changeTrigger in _projectChangeTriggers)
                {
                    changeTrigger.Initialize(instance);
                }
            }

            return _instance;
        }
    }
}
