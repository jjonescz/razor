// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        }
        #pragma warning restore 219
        #pragma warning disable 0414
        private static System.Object __o = null;
        #pragma warning restore 0414
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
  
    RenderFragment<Person> p = (person) => 

#line default
#line hidden
#nullable disable
            (builder2) => {
                __o = Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                                     person.Name

#line default
#line hidden
#nullable disable
                );
                builder2.AddAttribute(-1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder3) => {
                }
                ));
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
__o = typeof(MyComponent);

#line default
#line hidden
#nullable disable
            }
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                                                         ;

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "x:\dir\subdir\Test\TestComponent.cshtml"
            
    class Person
    {
        public string Name { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
