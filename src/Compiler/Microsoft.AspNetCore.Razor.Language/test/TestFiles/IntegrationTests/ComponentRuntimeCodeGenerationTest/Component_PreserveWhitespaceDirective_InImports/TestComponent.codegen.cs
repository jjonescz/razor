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
            __builder.OpenElement(0, "parent");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "child");
            __builder.AddContent(3, " ");
#nullable restore
#line (2,14)-(2,26) 24 "x:\dir\subdir\Test\TestComponent.cshtml"
__builder.AddContent(4, DateTime.Now);

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
