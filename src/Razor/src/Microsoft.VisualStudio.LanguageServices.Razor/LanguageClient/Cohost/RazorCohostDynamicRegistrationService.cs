﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.PooledObjects;
using Microsoft.CodeAnalysis.ExternalAccess.Razor.Cohost;
using Microsoft.CodeAnalysis.Razor.Workspaces;
using Microsoft.VisualStudio.LanguageServer.Protocol;

namespace Microsoft.VisualStudio.Razor.LanguageClient.Cohost;

[Export(typeof(IRazorCohostDynamicRegistrationService))]
[method: ImportingConstructor]
internal class RazorCohostDynamicRegistrationService(
    LanguageServerFeatureOptions languageServerFeatureOptions,
    [ImportMany] IEnumerable<Lazy<IDynamicRegistrationProvider>> lazyRegistrationProviders,
    Lazy<RazorCohostClientCapabilitiesService> lazyRazorCohostClientCapabilitiesService)
    : IRazorCohostDynamicRegistrationService
{
    private readonly DocumentFilter[] _filter = [new DocumentFilter()
    {
        Language = Constants.RazorLanguageName,
        Pattern = "**/*.{razor,cshtml}"
    }];

    private readonly LanguageServerFeatureOptions _languageServerFeatureOptions = languageServerFeatureOptions;
    private readonly IEnumerable<Lazy<IDynamicRegistrationProvider>> _lazyRegistrationProviders = lazyRegistrationProviders;
    private readonly Lazy<RazorCohostClientCapabilitiesService> _lazyRazorCohostClientCapabilitiesService = lazyRazorCohostClientCapabilitiesService;

    public async Task RegisterAsync(string clientCapabilitiesString, RazorCohostRequestContext requestContext, CancellationToken cancellationToken)
    {
        if (!_languageServerFeatureOptions.UseRazorCohostServer)
        {
            return;
        }

        var clientCapabilities = JsonSerializer.Deserialize<VSInternalClientCapabilities>(clientCapabilitiesString) ?? new();

        _lazyRazorCohostClientCapabilitiesService.Value.SetCapabilities(clientCapabilities);

        // We assume most registration providers will just return one, so whilst this isn't completely accurate, it's a
        // reasonable starting point
        _lazyRegistrationProviders.TryGetCount(out var providerCount);
        using var registrations = new PooledArrayBuilder<Registration>(providerCount);

        foreach (var provider in _lazyRegistrationProviders)
        {
            foreach (var registration in provider.Value.GetRegistrations(clientCapabilities, _filter, requestContext))
            {
                // We don't unregister anything, so we don't need to do anything interesting with Ids
                registration.Id = Guid.NewGuid().ToString();
                registrations.Add(registration);
            }
        }

        var razorCohostClientLanguageServerManager = requestContext.GetRequiredService<IRazorCohostClientLanguageServerManager>();

        await razorCohostClientLanguageServerManager.SendRequestAsync(
            Methods.ClientRegisterCapabilityName,
            new RegistrationParams()
            {
                Registrations = registrations.ToArray()
            },
            cancellationToken).ConfigureAwait(false);
    }
}
