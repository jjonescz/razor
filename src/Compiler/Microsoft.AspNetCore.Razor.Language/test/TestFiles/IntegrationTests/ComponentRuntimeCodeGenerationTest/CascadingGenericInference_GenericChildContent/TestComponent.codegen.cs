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
            {
                global::__Blazor.Test.TestComponent.TypeInference.CreateGrid_0_CaptureParameters(
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
               Array.Empty<DateTime>()

#line default
#line hidden
#nullable disable
                , out var __typeInferenceArg_0___arg0);
                global::__Blazor.Test.TestComponent.TypeInference.CreateGrid_0(__builder, 0, 1, __typeInferenceArg_0___arg0, 2, (__builder2) => {
                    global::__Blazor.Test.TestComponent.TypeInference.CreateColumn_1(__builder2, 3, __typeInferenceArg_0___arg0, 4, (context) => (__builder3) => {
#nullable restore
#line (1,51)-(1,63) 25 "x:\dir\subdir\Test\TestComponent.cshtml"
__builder3.AddContent(5, context.Year);

#line default
#line hidden
#nullable disable
                    }
                    );
                }
                );
                __typeInferenceArg_0___arg0 = default;
            }
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Test.TestComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGrid_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Test.Grid<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }

        public static void CreateGrid_0_CaptureParameters<TItem>(global::System.Collections.Generic.IEnumerable<TItem> __arg0, out global::System.Collections.Generic.IEnumerable<TItem> __arg0_out)
        {
            __arg0_out = __arg0;
        }
        public static void CreateColumn_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, System.Collections.Generic.IEnumerable<TItem> __syntheticArg0, int __seq0, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg0)
        {
        __builder.OpenComponent<global::Test.Column<TItem>>(seq);
        __builder.AddAttribute(__seq0, "ChildContent", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
