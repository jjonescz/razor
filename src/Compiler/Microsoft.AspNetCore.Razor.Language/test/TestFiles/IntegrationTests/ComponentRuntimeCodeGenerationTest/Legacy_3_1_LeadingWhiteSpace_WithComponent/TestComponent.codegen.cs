﻿// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    #nullable restore
    public partial class TestComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Test.SomeOtherComponent>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    ");
                __builder2.OpenElement(3, "h1");
                __builder2.AddContent(4, "Child content at ");
#nullable restore
#line (2,27)-(2,39) 25 "x:\dir\subdir\Test\TestComponent.cshtml"
__builder2.AddContent(5, DateTime.Now);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "p");
                __builder2.AddContent(8, "Very ");
#nullable restore
#line (3,15)-(3,21) 25 "x:\dir\subdir\Test\TestComponent.cshtml"
__builder2.AddContent(9, "good");

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(10, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.AddMarkupContent(12, "<h1>Hello</h1>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
