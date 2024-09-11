﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.AspNetCore.Razor.Test.Common;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.Razor;

public abstract class TagHelperDescriptorProviderTestBase
{
    static TagHelperDescriptorProviderTestBase()
    {
        CSharpParseOptions = new CSharpParseOptions(LanguageVersion.CSharp7_3);
        var testTagHelpers = CSharpCompilation.Create(
            assemblyName: "Microsoft.CodeAnalysis.Razor.Test",
            syntaxTrees: [Parse(TagHelperDescriptorFactoryTagHelpers.Code)],
            references: ReferenceUtil.AspNetLatestAll,
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
        BaseCompilation = TestCompilation.Create(
            syntaxTrees: [],
            references: [testTagHelpers.VerifyDiagnostics().EmitToImageReference()]);
    }

    protected static Compilation BaseCompilation { get; }

    protected static CSharpParseOptions CSharpParseOptions { get; }

    protected static CSharpSyntaxTree Parse(string text)
    {
        return (CSharpSyntaxTree)CSharpSyntaxTree.ParseText(text, CSharpParseOptions);
    }

    // For simplicity in testing, exclude the built-in components. We'll add more and we
    // don't want to update the tests when that happens.
    protected static TagHelperDescriptor[] ExcludeBuiltInComponents(TagHelperDescriptorProviderContext context)
    {
        var results =
         context.Results
            .Where(c => !c.DisplayName.StartsWith("Microsoft.AspNetCore.Components.", StringComparison.Ordinal))
            .OrderBy(c => c.Name)
            .ToArray();

        return results;
    }

    protected static TagHelperDescriptor[] AssertAndExcludeFullyQualifiedNameMatchComponents(
        TagHelperDescriptor[] components,
        int expectedCount)
    {
        var componentLookup = new Dictionary<string, List<TagHelperDescriptor>>();
        var fullyQualifiedNameMatchComponents = components.Where(c => c.IsComponentFullyQualifiedNameMatch).ToArray();
        Assert.Equal(expectedCount, fullyQualifiedNameMatchComponents.Length);

        var shortNameMatchComponents = components.Where(c => !c.IsComponentFullyQualifiedNameMatch).ToArray();

        // For every fully qualified name component, we want to make sure we have a corresponding short name component.
        foreach (var fullNameComponent in fullyQualifiedNameMatchComponents)
        {
            Assert.Contains(shortNameMatchComponents, component =>
            {
                return component.Name == fullNameComponent.Name &&
                    component.Kind == fullNameComponent.Kind &&
                    component.BoundAttributes.SequenceEqual(fullNameComponent.BoundAttributes);
            });
        }

        return shortNameMatchComponents;
    }
}
