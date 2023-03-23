﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using System;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Razor.Test.Common;
using Microsoft.CommonLanguageServerProtocol.Framework;
using Nerdbank.Streams;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.AspNetCore.Razor.LanguageServer.Test;

public class RazorLanguageServerTest : TestBase
{
    public RazorLanguageServerTest(ITestOutputHelper testOutput)
        : base(testOutput)
    {
    }

    [Fact]
    public void AllHandlersRegisteredAsync()
    {
        var (clientStream, serverStream) = FullDuplexStream.CreatePair();
        using var server = RazorLanguageServerWrapper.Create(serverStream, serverStream, Logger);

        var innerServer = server.GetInnerLanguageServerForTesting();
        var handlerProvider = innerServer.GetTestAccessor().GetHandlerProvider();

        var registeredMethods = handlerProvider.GetRegisteredMethods();
        var handlerTypes = typeof(RazorLanguageServerWrapper).Assembly.GetTypes()
            .Where(t => typeof(IMethodHandler).IsAssignableFrom(t) && !t.IsAbstract && !t.IsInterface);

        // We turn this into a Set to handle cases like Completion where we have two handlers, only one of which will be registered
        // CLaSP will throw if two handlers register for the same method, so if THAT doesn't hold it's a CLaSP bug, not a Razor bug.
        var typeMethods = handlerTypes.Select(t => GetMethodFromType(t)).ToHashSet();

        if (registeredMethods.Length != typeMethods.Count)
        {
            var unregisteredHandlers = typeMethods.Where(t => !registeredMethods.Any(m => m.MethodName == t));
            Assert.True(false, $"Unregistered handlers: {string.Join(";", unregisteredHandlers.Select(t => t))}");
        }

        static string GetMethodFromType(Type t)
        {
            var attribute = t.GetCustomAttribute<LanguageServerEndpointAttribute>();
            if (attribute is null)
            {
                foreach (var inter in t.GetInterfaces())
                {
                    attribute = inter.GetCustomAttribute<LanguageServerEndpointAttribute>();

                    if (attribute is not null)
                    {
                        break;
                    }
                }
            }

            if (attribute is null)
            {
                throw new NotImplementedException();
            }

            return attribute.Method;
        }
    }
}
