﻿#pragma checksum "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4c214203eb338caf0f877accd57cbda70c9002c9f35b3b48b9bdecc4811fdc6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_DynamicAttributeTagHelpers), @"mvc.1.0.view", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4c214203eb338caf0f877accd57cbda70c9002c9f35b3b48b9bdecc4811fdc6b", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("Identifier", "/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml")]
    [global::System.Runtime.CompilerServices.CreateNewOnMetadataUpdateAttribute]
    #nullable restore
    internal sealed class TestFiles_IntegrationTests_CodeGenerationIntegrationTest_DynamicAttributeTagHelpers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::TestNamespace.InputTagHelper __TestNamespace_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "__UniqueIdSuppressedForTesting__", async() => {
            }
            );
            __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "unbound", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 51, "prefix", 51, 6, true);
            AddHtmlAttributeValue(" ", 57, 
#nullable restore
#line (3,25)-(3,37) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
DateTime.Now

#line default
#line hidden
#nullable disable
            , 58, 13, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "__UniqueIdSuppressedForTesting__", async() => {
            }
            );
            __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "unbound", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 95, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line (5,18)-(5,30) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
if (true) { 

#line default
#line hidden
#nullable disable
                Write(
#nullable restore
#line (5,31)-(5,43) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
string.Empty

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line (5,43)-(5,53) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
 } else { 

#line default
#line hidden
#nullable disable
                Write(
#nullable restore
#line (5,54)-(5,59) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
false

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line (5,59)-(5,61) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
 }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 95, 44, false);
            AddHtmlAttributeValue(" ", 139, "suffix", 140, 7, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "__UniqueIdSuppressedForTesting__", async() => {
            }
            );
            __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("prefix ");
            WriteLiteral(
#nullable restore
#line (7,23)-(7,35) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
DateTime.Now

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" suffix");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __TestNamespace_InputTagHelper.Bound = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("bound", __TestNamespace_InputTagHelper.Bound, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "unbound", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 206, "prefix", 206, 6, true);
            AddHtmlAttributeValue(" ", 212, 
#nullable restore
#line (7,61)-(7,73) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
DateTime.Now

#line default
#line hidden
#nullable disable
            , 213, 13, false);
            AddHtmlAttributeValue(" ", 226, "suffix", 227, 7, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "__UniqueIdSuppressedForTesting__", async() => {
            }
            );
            __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line (9,16)-(9,29) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
long.MinValue

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" ");
#nullable restore
#line (9,31)-(9,43) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
if (true) { 

#line default
#line hidden
#nullable disable

            WriteLiteral(
#nullable restore
#line (9,44)-(9,56) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
string.Empty

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line (9,56)-(9,66) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
 } else { 

#line default
#line hidden
#nullable disable

            WriteLiteral(
#nullable restore
#line (9,67)-(9,72) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
false

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line (9,72)-(9,74) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
 }

#line default
#line hidden
#nullable disable

            WriteLiteral(" ");
            WriteLiteral(
#nullable restore
#line (9,76)-(9,88) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
int.MaxValue

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __TestNamespace_InputTagHelper.Bound = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("bound", __TestNamespace_InputTagHelper.Bound, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "unbound", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 347, 
#nullable restore
#line (10,18)-(10,31) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
long.MinValue

#line default
#line hidden
#nullable disable
            , 347, 14, false);
            AddHtmlAttributeValue(" ", 361, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line (10,33)-(10,45) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
if (true) { 

#line default
#line hidden
#nullable disable
                Write(
#nullable restore
#line (10,46)-(10,58) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
string.Empty

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line (10,58)-(10,68) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
 } else { 

#line default
#line hidden
#nullable disable
                Write(
#nullable restore
#line (10,69)-(10,74) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
false

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line (10,74)-(10,76) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
 }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 362, 44, false);
            AddHtmlAttributeValue(" ", 406, 
#nullable restore
#line (10,78)-(10,90) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
int.MaxValue

#line default
#line hidden
#nullable disable
            , 407, 13, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "__UniqueIdSuppressedForTesting__", async() => {
            }
            );
            __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "unbound", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 444, 
#nullable restore
#line (12,18)-(12,31) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
long.MinValue

#line default
#line hidden
#nullable disable
            , 444, 14, false);
            AddHtmlAttributeValue(" ", 458, 
#nullable restore
#line (12,33)-(12,45) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
DateTime.Now

#line default
#line hidden
#nullable disable
            , 459, 13, false);
            AddHtmlAttributeValue(" ", 472, "static", 473, 7, true);
            AddHtmlAttributeValue("    ", 479, "content", 483, 11, true);
            AddHtmlAttributeValue(" ", 490, 
#nullable restore
#line (12,65)-(12,77) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
int.MaxValue

#line default
#line hidden
#nullable disable
            , 491, 13, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "__UniqueIdSuppressedForTesting__", async() => {
            }
            );
            __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "unbound", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 528, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line (14,18)-(14,30) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
if (true) { 

#line default
#line hidden
#nullable disable
                Write(
#nullable restore
#line (14,31)-(14,43) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
string.Empty

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line (14,43)-(14,53) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
 } else { 

#line default
#line hidden
#nullable disable
                Write(
#nullable restore
#line (14,54)-(14,59) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
false

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line (14,59)-(14,61) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/DynamicAttributeTagHelpers.cshtml"
 }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 528, 44, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
