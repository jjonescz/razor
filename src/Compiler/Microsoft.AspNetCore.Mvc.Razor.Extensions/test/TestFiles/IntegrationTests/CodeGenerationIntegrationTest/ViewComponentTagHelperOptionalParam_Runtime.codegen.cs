﻿#pragma checksum "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ViewComponentTagHelperOptionalParam.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "83aa72bbe254ff67d9ee42878d80c6403361bcbb777a50d8b3d718cba176d15c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_ViewComponentTagHelperOptionalParam), @"mvc.1.0.view", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ViewComponentTagHelperOptionalParam.cshtml")]
namespace AspNetCore
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"83aa72bbe254ff67d9ee42878d80c6403361bcbb777a50d8b3d718cba176d15c", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ViewComponentTagHelperOptionalParam.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("Identifier", "/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ViewComponentTagHelperOptionalParam.cshtml")]
    [global::System.Runtime.CompilerServices.CreateNewOnMetadataUpdateAttribute]
    #nullable restore
    public class TestFiles_IntegrationTests_CodeGenerationIntegrationTest_ViewComponentTagHelperOptionalParam : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::AspNetCore.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_ViewComponentTagHelperOptionalParam.__Generated__OptionalTestViewComponentTagHelper __OptionalTestViewComponentTagHelper;
        private global::AspNetCore.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_ViewComponentTagHelperOptionalParam.__Generated__OptionalTestWithParamViewComponentTagHelper __OptionalTestWithParamViewComponentTagHelper;
        private global::AspNetCore.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_ViewComponentTagHelperOptionalParam.__Generated__OptionalWithMultipleTypesViewComponentTagHelper __OptionalWithMultipleTypesViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:optional-test", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "test", async() => {
            }
            );
            __OptionalTestViewComponentTagHelper = CreateTagHelper<global::AspNetCore.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_ViewComponentTagHelperOptionalParam.__Generated__OptionalTestViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__OptionalTestViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:optional-test", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "test", async() => {
            }
            );
            __OptionalTestViewComponentTagHelper = CreateTagHelper<global::AspNetCore.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_ViewComponentTagHelperOptionalParam.__Generated__OptionalTestViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__OptionalTestViewComponentTagHelper);
            __OptionalTestViewComponentTagHelper.showSecret = 
#nullable restore
#line (4,33)-(4,37) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ViewComponentTagHelperOptionalParam.cshtml"
true

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("show-secret", __OptionalTestViewComponentTagHelper.showSecret, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:optional-test-with-param", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "test", async() => {
            }
            );
            __OptionalTestWithParamViewComponentTagHelper = CreateTagHelper<global::AspNetCore.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_ViewComponentTagHelperOptionalParam.__Generated__OptionalTestWithParamViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__OptionalTestWithParamViewComponentTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("mysecret");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __OptionalTestWithParamViewComponentTagHelper.secret = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("secret", __OptionalTestWithParamViewComponentTagHelper.secret, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:optional-test-with-param", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "test", async() => {
            }
            );
            __OptionalTestWithParamViewComponentTagHelper = CreateTagHelper<global::AspNetCore.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_ViewComponentTagHelperOptionalParam.__Generated__OptionalTestWithParamViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__OptionalTestWithParamViewComponentTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("mysecret");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __OptionalTestWithParamViewComponentTagHelper.secret = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("secret", __OptionalTestWithParamViewComponentTagHelper.secret, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __OptionalTestWithParamViewComponentTagHelper.showSecret = 
#nullable restore
#line (7,62)-(7,66) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ViewComponentTagHelperOptionalParam.cshtml"
true

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("show-secret", __OptionalTestWithParamViewComponentTagHelper.showSecret, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:optional-with-multiple-types", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "test", async() => {
            }
            );
            __OptionalWithMultipleTypesViewComponentTagHelper = CreateTagHelper<global::AspNetCore.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_ViewComponentTagHelperOptionalParam.__Generated__OptionalWithMultipleTypesViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__OptionalWithMultipleTypesViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:optional-with-multiple-types", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "test", async() => {
            }
            );
            __OptionalWithMultipleTypesViewComponentTagHelper = CreateTagHelper<global::AspNetCore.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_ViewComponentTagHelperOptionalParam.__Generated__OptionalWithMultipleTypesViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__OptionalWithMultipleTypesViewComponentTagHelper);
            __OptionalWithMultipleTypesViewComponentTagHelper.age = 
#nullable restore
#line (10,39)-(10,41) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ViewComponentTagHelperOptionalParam.cshtml"
12

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("age", __OptionalWithMultipleTypesViewComponentTagHelper.age, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __OptionalWithMultipleTypesViewComponentTagHelper.favoriteDecimal = 
#nullable restore
#line (10,61)-(10,65) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ViewComponentTagHelperOptionalParam.cshtml"
10.8

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("favorite-decimal", __OptionalWithMultipleTypesViewComponentTagHelper.favoriteDecimal, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __OptionalWithMultipleTypesViewComponentTagHelper.favoriteLetter = 
#nullable restore
#line (10,84)-(10,87) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ViewComponentTagHelperOptionalParam.cshtml"
'a'

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("favorite-letter", __OptionalWithMultipleTypesViewComponentTagHelper.favoriteLetter, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:optional-with-multiple-types", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "test", async() => {
            }
            );
            __OptionalWithMultipleTypesViewComponentTagHelper = CreateTagHelper<global::AspNetCore.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_ViewComponentTagHelperOptionalParam.__Generated__OptionalWithMultipleTypesViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__OptionalWithMultipleTypesViewComponentTagHelper);
            __OptionalWithMultipleTypesViewComponentTagHelper.age = 
#nullable restore
#line (11,39)-(11,41) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ViewComponentTagHelperOptionalParam.cshtml"
12

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("age", __OptionalWithMultipleTypesViewComponentTagHelper.age, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __OptionalWithMultipleTypesViewComponentTagHelper.favoriteDecimal = 
#nullable restore
#line (11,61)-(11,65) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ViewComponentTagHelperOptionalParam.cshtml"
10.8

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("favorite-decimal", __OptionalWithMultipleTypesViewComponentTagHelper.favoriteDecimal, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:optional-with-multiple-types", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "test", async() => {
            }
            );
            __OptionalWithMultipleTypesViewComponentTagHelper = CreateTagHelper<global::AspNetCore.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_ViewComponentTagHelperOptionalParam.__Generated__OptionalWithMultipleTypesViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__OptionalWithMultipleTypesViewComponentTagHelper);
            __OptionalWithMultipleTypesViewComponentTagHelper.age = 
#nullable restore
#line (12,39)-(12,41) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ViewComponentTagHelperOptionalParam.cshtml"
12

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("age", __OptionalWithMultipleTypesViewComponentTagHelper.age, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __OptionalWithMultipleTypesViewComponentTagHelper.favoriteDecimal = 
#nullable restore
#line (12,61)-(12,65) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ViewComponentTagHelperOptionalParam.cshtml"
10.8

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("favorite-decimal", __OptionalWithMultipleTypesViewComponentTagHelper.favoriteDecimal, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __OptionalWithMultipleTypesViewComponentTagHelper.birthDate = 
#nullable restore
#line (12,79)-(12,91) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ViewComponentTagHelperOptionalParam.cshtml"
DateTime.Now

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("birth-date", __OptionalWithMultipleTypesViewComponentTagHelper.birthDate, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:optional-with-multiple-types", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "test", async() => {
            }
            );
            __OptionalWithMultipleTypesViewComponentTagHelper = CreateTagHelper<global::AspNetCore.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_ViewComponentTagHelperOptionalParam.__Generated__OptionalWithMultipleTypesViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__OptionalWithMultipleTypesViewComponentTagHelper);
            __OptionalWithMultipleTypesViewComponentTagHelper.age = 
#nullable restore
#line (13,39)-(13,41) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ViewComponentTagHelperOptionalParam.cshtml"
12

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("age", __OptionalWithMultipleTypesViewComponentTagHelper.age, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __OptionalWithMultipleTypesViewComponentTagHelper.favoriteDecimal = 
#nullable restore
#line (13,61)-(13,65) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ViewComponentTagHelperOptionalParam.cshtml"
10.8

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("favorite-decimal", __OptionalWithMultipleTypesViewComponentTagHelper.favoriteDecimal, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __OptionalWithMultipleTypesViewComponentTagHelper.birthDate = 
#nullable restore
#line (13,79)-(13,91) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ViewComponentTagHelperOptionalParam.cshtml"
DateTime.Now

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("birth-date", __OptionalWithMultipleTypesViewComponentTagHelper.birthDate, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:optional-test")]
        public class __Generated__OptionalTestViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__OptionalTestViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public System.Boolean showSecret { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("OptionalTest", ProcessInvokeAsyncArgs(__context));
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
            private Dictionary<string, object> ProcessInvokeAsyncArgs(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context)
            {
                Dictionary<string, object> args = new Dictionary<string, object>();
                if (__context.AllAttributes.ContainsName("show-secret"))
                {
                    args[nameof(showSecret)] = showSecret;
                }
                return args;
            }
        }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:optional-test-with-param")]
        public class __Generated__OptionalTestWithParamViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__OptionalTestWithParamViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public System.String secret { get; set; }
            public System.Boolean showSecret { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("OptionalTestWithParam", ProcessInvokeAsyncArgs(__context));
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
            private Dictionary<string, object> ProcessInvokeAsyncArgs(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context)
            {
                Dictionary<string, object> args = new Dictionary<string, object>();
                if (__context.AllAttributes.ContainsName("secret"))
                {
                    args[nameof(secret)] = secret;
                }
                if (__context.AllAttributes.ContainsName("show-secret"))
                {
                    args[nameof(showSecret)] = showSecret;
                }
                return args;
            }
        }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:optional-with-multiple-types")]
        public class __Generated__OptionalWithMultipleTypesViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__OptionalWithMultipleTypesViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public System.Int32 age { get; set; }
            public System.Double favoriteDecimal { get; set; }
            public System.Char favoriteLetter { get; set; }
            public System.DateTime? birthDate { get; set; }
            public System.String anotherOne { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("OptionalWithMultipleTypes", ProcessInvokeAsyncArgs(__context));
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
            private Dictionary<string, object> ProcessInvokeAsyncArgs(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context)
            {
                Dictionary<string, object> args = new Dictionary<string, object>();
                if (__context.AllAttributes.ContainsName("age"))
                {
                    args[nameof(age)] = age;
                }
                if (__context.AllAttributes.ContainsName("favorite-decimal"))
                {
                    args[nameof(favoriteDecimal)] = favoriteDecimal;
                }
                if (__context.AllAttributes.ContainsName("favorite-letter"))
                {
                    args[nameof(favoriteLetter)] = favoriteLetter;
                }
                if (__context.AllAttributes.ContainsName("birth-date"))
                {
                    args[nameof(birthDate)] = birthDate;
                }
                if (__context.AllAttributes.ContainsName("another-one"))
                {
                    args[nameof(anotherOne)] = anotherOne;
                }
                return args;
            }
        }
    }
}
#pragma warning restore 1591
