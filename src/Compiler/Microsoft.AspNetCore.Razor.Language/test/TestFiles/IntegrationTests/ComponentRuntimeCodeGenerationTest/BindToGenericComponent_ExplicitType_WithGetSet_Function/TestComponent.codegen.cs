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
            __builder.OpenComponent<global::Test.MyComponent<CustomValue>>(0);
            __builder.AddAttribute(1, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<CustomValue>(
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                   ParentValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<CustomValue>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CustomValue>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, UpdateValue, ParentValue))));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
       
    public CustomValue ParentValue { get; set; } = new CustomValue();

        public Task UpdateValue(CustomValue value) { ParentValue = value; return Task.CompletedTask; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
