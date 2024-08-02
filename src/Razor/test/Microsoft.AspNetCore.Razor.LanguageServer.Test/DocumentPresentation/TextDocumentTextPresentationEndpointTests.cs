﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.AspNetCore.Razor.LanguageServer.Hosting;
using Microsoft.AspNetCore.Razor.Test.Common.LanguageServer;
using Microsoft.CodeAnalysis.Razor.DocumentMapping;
using Microsoft.CodeAnalysis.Razor.Protocol;
using Microsoft.CodeAnalysis.Razor.Protocol.DocumentPresentation;
using Microsoft.CodeAnalysis.Text;
using Microsoft.VisualStudio.LanguageServer.Protocol;
using Moq;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.AspNetCore.Razor.LanguageServer.DocumentPresentation;

public class TextDocumentTextPresentationEndpointTests(ITestOutputHelper testOutput) : LanguageServerTestBase(testOutput)
{
    [Fact]
    public async Task Handle_Html_MakesRequest()
    {
        // Arrange
        var codeDocument = TestRazorCodeDocument.Create("<div></div>");
        var documentMappingService = Mock.Of<IRazorDocumentMappingService>(
            s => s.GetLanguageKind(codeDocument, It.IsAny<int>(), It.IsAny<bool>()) == RazorLanguageKind.Html, MockBehavior.Strict);

        var uri = new Uri("file://path/test.razor");
        var documentContext = CreateDocumentContext(uri, codeDocument);

        var response = (WorkspaceEdit?)null;

        var clientConnection = new Mock<IClientConnection>(MockBehavior.Strict);
        clientConnection
            .Setup(l => l.SendRequestAsync<IRazorPresentationParams, WorkspaceEdit?>(CustomMessageNames.RazorTextPresentationEndpoint, It.IsAny<IRazorPresentationParams>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(response)
            .Verifiable();

        var endpoint = new TextDocumentTextPresentationEndpoint(
            documentMappingService,
            clientConnection.Object,
            FilePathService,
            LoggerFactory);

        var parameters = new TextPresentationParams()
        {
            TextDocument = new TextDocumentIdentifier
            {
                Uri = uri
            },
            Range = VsLspFactory.CreateSingleLineRange(line: 0, character: 1, length: 1),
            Text = "Hi there"
        };
        var requestContext = CreateRazorRequestContext(documentContext);

        // Act
        var result = await endpoint.HandleRequestAsync(parameters, requestContext, DisposalToken);

        // Assert
        clientConnection.Verify();
    }

    [Fact]
    public async Task Handle_CSharp_DoesNotMakeRequest()
    {
        // Arrange
        var codeDocument = TestRazorCodeDocument.Create("@counter");
        var csharpDocument = codeDocument.GetCSharpDocument();
        var uri = new Uri("file://path/test.razor");
        var documentContext = CreateDocumentContext(uri, codeDocument);
        var projectedRange = It.IsAny<LinePositionSpan>();
        var documentMappingService = Mock.Of<IRazorDocumentMappingService>(
            s => s.GetLanguageKind(codeDocument, It.IsAny<int>(), It.IsAny<bool>()) == RazorLanguageKind.CSharp &&
            s.TryMapToGeneratedDocumentRange(csharpDocument, It.IsAny<LinePositionSpan>(), out projectedRange) == true, MockBehavior.Strict);

        var clientConnection = new Mock<IClientConnection>(MockBehavior.Strict);

        var endpoint = new TextDocumentTextPresentationEndpoint(
            documentMappingService,
            clientConnection.Object,
            FilePathService,
            LoggerFactory);

        var parameters = new TextPresentationParams()
        {
            TextDocument = new TextDocumentIdentifier
            {
                Uri = uri
            },
            Range = VsLspFactory.CreateSingleLineRange(line: 0, character: 1, length: 1),
            Text = "Hi there"
        };
        var requestContext = CreateRazorRequestContext(documentContext);

        // Act
        var result = await endpoint.HandleRequestAsync(parameters, requestContext, DisposalToken);

        // Assert
        clientConnection.Verify();
    }

    [Fact]
    public async Task Handle_DocumentNotFound_ReturnsNull()
    {
        // Arrange
        var codeDocument = TestRazorCodeDocument.Create("<div></div>");
        var uri = new Uri("file://path/test.razor");
        var documentContext = CreateDocumentContext(uri, codeDocument);
        var documentMappingService = Mock.Of<IRazorDocumentMappingService>(
            s => s.GetLanguageKind(codeDocument, It.IsAny<int>(), It.IsAny<bool>()) == RazorLanguageKind.Html, MockBehavior.Strict);

        var response = (WorkspaceEdit?)null;

        var clientConnection = new Mock<IClientConnection>(MockBehavior.Strict);
        clientConnection
            .Setup(l => l.SendRequestAsync<IRazorPresentationParams, WorkspaceEdit?>(CustomMessageNames.RazorTextPresentationEndpoint, It.IsAny<IRazorPresentationParams>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(response);

        var endpoint = new TextDocumentTextPresentationEndpoint(
            documentMappingService,
            clientConnection.Object,
            FilePathService,
            LoggerFactory);

        var parameters = new TextPresentationParams()
        {
            TextDocument = new TextDocumentIdentifier
            {
                Uri = uri
            },
            Range = VsLspFactory.CreateSingleLineRange(line: 0, character: 1, length: 1),
            Text = "Hi there"
        };
        var requestContext = CreateRazorRequestContext(documentContext);

        // Act
        var result = await endpoint.HandleRequestAsync(parameters, requestContext, DisposalToken);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public async Task Handle_UnsupportedCodeDocument_ReturnsNull()
    {
        // Arrange
        var codeDocument = TestRazorCodeDocument.Create("<div></div>");
        codeDocument.SetUnsupported();
        var uri = new Uri("file://path/test.razor");
        var documentContext = CreateDocumentContext(uri, codeDocument);
        var documentMappingService = Mock.Of<IRazorDocumentMappingService>(
            s => s.GetLanguageKind(codeDocument, It.IsAny<int>(), It.IsAny<bool>()) == RazorLanguageKind.Html, MockBehavior.Strict);

        var response = new WorkspaceEdit();

        var clientConnection = new Mock<IClientConnection>(MockBehavior.Strict);
        clientConnection
            .Setup(l => l.SendRequestAsync<IRazorPresentationParams, WorkspaceEdit?>(CustomMessageNames.RazorTextPresentationEndpoint, It.IsAny<IRazorPresentationParams>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(response);

        var endpoint = new TextDocumentTextPresentationEndpoint(
            documentMappingService,
            clientConnection.Object,
            FilePathService,
            LoggerFactory);

        var parameters = new TextPresentationParams()
        {
            TextDocument = new TextDocumentIdentifier
            {
                Uri = uri
            },
            Range = VsLspFactory.CreateSingleLineRange(line: 0, character: 1, length: 1),
            Text = "Hi there"
        };
        var requestContext = CreateRazorRequestContext(documentContext);

        // Act
        var result = await endpoint.HandleRequestAsync(parameters, requestContext, DisposalToken);

        // Assert
        Assert.Null(result);
    }
}
