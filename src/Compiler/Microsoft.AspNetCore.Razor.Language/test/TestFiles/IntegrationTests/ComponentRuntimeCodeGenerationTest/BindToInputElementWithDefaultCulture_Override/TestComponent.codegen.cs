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
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    #nullable restore
    public partial class TestComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "type", "custom");
            __builder.AddAttribute(2, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                                   ParentValue

#line default
#line hidden
#nullable disable
            , culture: 
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                                                                      CultureInfo.CurrentCulture

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "anotherevent", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ParentValue = __value, ParentValue, culture: CultureInfo.CurrentCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
       
    public int ParentValue { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
