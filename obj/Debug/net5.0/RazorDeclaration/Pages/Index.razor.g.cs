// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ZooBreakout.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "/Users/anthony/Documents/GitHub/CS4500_Group4/Pages/Index.razor"
       
    public bool MainMenuHidden { get; set; } = false;
    public bool TutorialHidden { get; set; } = true;
    public bool FirstRoundHidden { get; set; } = true;
    public bool ExplanationHidden { get; set; } = true;
    public bool SecondRoundHidden { get; set; } = true;
    public bool SummaryHidden { get; set; } = true;
    public bool InfiniteHidden { get; set; } = true;
    public int Wins { get; set; } = 0;
    public int CorrectUnwinnables { get; set; } = 0;


    public void StoryChosen(bool story) 
    {
        Console.WriteLine($"story: {story}");
        MainMenuHidden = true;
        TutorialHidden = false;
    }

    public void InfiniteChosen(bool infinite) 
    {
        Console.WriteLine($"infinite: {infinite}");
    }

    public void AboutChosen(bool about) 
    {
        Console.WriteLine($"about: {about}");
    }

    public void TutorialContinue(bool continued) 
    {
        Console.WriteLine($"coninued: {continued}");
        TutorialHidden = true;
        FirstRoundHidden = false;
    }

    public void FirstRoundComplete(int wins) 
    {
        Console.WriteLine($"complete: {wins}");
        FirstRoundHidden = true;
        ExplanationHidden = false;
        Wins += wins;
    }

    public void ExplanationContinue(bool continued)
    {
        Console.WriteLine($"continued: {continued}");
        ExplanationHidden = true;
        SecondRoundHidden = false;
    }

    public void SecondRoundComplete(Tuple<int, int> tuple)
    {
        Console.WriteLine($"complete: {tuple.Item1} {tuple.Item2}");
        SecondRoundHidden = true;
        SummaryHidden = false;
        Wins += tuple.Item1;
        CorrectUnwinnables += tuple.Item2;
    }

    public void SummaryContinue(bool continued)
    {
        Console.WriteLine($"continued: {continued}");
        SummaryHidden = true;
        if (continued)
        {
            MainMenuHidden = false;
        }
        else
        {
            InfiniteHidden = false;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
