﻿// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
    #line default
    #line hidden
    #nullable restore
    public partial class TestComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            global::__Blazor.Test.TestComponent.TypeInference.CreateMyComponent_0(__builder, 0, 1, 
#nullable restore
#line (1,20)-(1,36) "x:\dir\subdir\Test\TestComponent.cshtml"
new CustomType()

#line default
#line hidden
#nullable disable
            , 2, (context) => (__builder2) => {
                __builder2.AddContent(3, 
#nullable restore
#line (1,39)-(1,57) "x:\dir\subdir\Test\TestComponent.cshtml"
context.ToString()

#line default
#line hidden
#nullable disable
                );
            }
            );
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Test.TestComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMyComponent_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TItem __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<global::Test.CustomType> __arg1)
        {
        __builder.OpenComponent<global::Test.MyComponent<TItem>>(seq);
        __builder.AddComponentParameter(__seq0, nameof(global::Test.MyComponent<TItem>.
#nullable restore
#line (1,14)-(1,18) "x:\dir\subdir\Test\TestComponent.cshtml"
Item

#line default
#line hidden
#nullable disable
        ), __arg0);
        __builder.AddComponentParameter(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
