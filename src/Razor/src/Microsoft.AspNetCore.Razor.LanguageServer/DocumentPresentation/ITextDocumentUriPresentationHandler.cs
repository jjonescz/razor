﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using OmniSharp.Extensions.JsonRpc;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
using VSInternalMethods = Microsoft.VisualStudio.LanguageServer.Protocol.VSInternalMethods;

namespace Microsoft.AspNetCore.Razor.LanguageServer.DocumentPresentation
{
    [Parallel, Method(VSInternalMethods.TextDocumentUriPresentationName)]
    internal interface ITextDocumentUriPresentationHandler : IJsonRpcRequestHandler<UriPresentationParams, WorkspaceEdit?>, IRegistrationExtension
    {
    }
}
