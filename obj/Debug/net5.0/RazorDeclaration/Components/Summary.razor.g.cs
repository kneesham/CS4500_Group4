// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class Summary : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/Summary.razor"
       
    [Parameter]
    public EventCallback<bool> SummaryContinue { get; set; }
    [Parameter]
    public int Wins { get; set; }
    [Parameter]
    public int CorrectUnwinnables { get; set; }
    [Parameter]
    public int TotalGames { get; set; }
    [Parameter]
    public int TotalUnWins { get; set; }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
