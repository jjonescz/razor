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
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        }
        #pragma warning restore 219
        #pragma warning disable 0414
        private static object __o = null;
        #pragma warning restore 0414
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __o = global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                       Increment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(-1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
            }
            ));
            __o = ((global::Test.MyComponent)default).
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
             OnClick

#line default
#line hidden
#nullable disable
            ;
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
__o = typeof(global::Test.MyComponent);

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
       
    private int counter;
    private void Increment() {
        counter++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
