#pragma checksum "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/Draggable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4032cd97f56fa3ef334da8fe17c0168dfd3b1b6"
// <auto-generated/>
#pragma warning disable 1591
namespace ZooBreakout.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/anthony/Documents/GitHub/CS4500_Group4/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/anthony/Documents/GitHub/CS4500_Group4/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/anthony/Documents/GitHub/CS4500_Group4/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/anthony/Documents/GitHub/CS4500_Group4/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/anthony/Documents/GitHub/CS4500_Group4/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/anthony/Documents/GitHub/CS4500_Group4/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/anthony/Documents/GitHub/CS4500_Group4/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/anthony/Documents/GitHub/CS4500_Group4/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/anthony/Documents/GitHub/CS4500_Group4/_Imports.razor"
using ZooBreakout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/anthony/Documents/GitHub/CS4500_Group4/_Imports.razor"
using ZooBreakout.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/anthony/Documents/GitHub/CS4500_Group4/_Imports.razor"
using ZooBreakout.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/anthony/Documents/GitHub/CS4500_Group4/_Imports.razor"
using ZooBreakout.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/anthony/Documents/GitHub/CS4500_Group4/_Imports.razor"
using ZooBreakout.Data;

#line default
#line hidden
#nullable disable
    public partial class Draggable<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "draggable", "true");
            __builder.AddAttribute(2, "ondragstart", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 5 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/Draggable.razor"
                                     OnDragStart

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, 
#nullable restore
#line 6 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/Draggable.razor"
     ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/Draggable.razor"
       
    [Parameter]
    public RenderFragment ChildContent { get; set; }
    [Parameter]
    public string Zone { get; set; }
    [Parameter]
    public T Data { get; set; }

    public void OnDragStart()
    {
        DragAndDropService.StartDrag(Data, Zone);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DragAndDropService DragAndDropService { get; set; }
    }
}
#pragma warning restore 1591
