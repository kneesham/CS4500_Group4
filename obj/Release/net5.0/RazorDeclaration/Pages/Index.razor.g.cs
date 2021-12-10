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
#line 33 "/Users/anthony/Documents/GitHub/CS4500_Group4/Pages/Index.razor"
       
    public bool MainMenuHidden { get; set; } = false;
    public bool TutorialHidden { get; set; } = true;
    public bool FirstRoundHidden { get; set; } = true;
    public bool ExplanationHidden { get; set; } = true;
    public bool SecondRoundHidden { get; set; } = true;
    public bool SummaryHidden { get; set; } = true;
    public bool InfiniteHidden { get; set; } = true;
    public bool AboutHidden { get; set; } = true;
    public int Wins { get; set; } = 0;
    public int TotalGames { get; set; } = 0;
    public int CorrectUnwinnables { get; set; } = 0;
    public int TotalUnWins { get; set; } = 0;
    public string Name { get; set; } = "";


    

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "/Users/anthony/Documents/GitHub/CS4500_Group4/Pages/Index.razor"
        
    
    // called when story mode is chosen
    public void StoryChosen(string name) 
    {
        Name = name;
        if (Name == "")
            Name = "Guest";
        MainMenuHidden = true;
        TutorialHidden = false;
    }

    // called when infinite mode is chosen
    public void InfiniteChosen(string name) 
    {
        Name = name;
        if (Name == "")
            Name = "Guest";
        MainMenuHidden = true;
        InfiniteHidden = false;
    }

    // called when about us is chosen
    public void AboutChosen(bool about) 
    {
        Console.WriteLine($"about: {about}");
        MainMenuHidden = true;
        AboutHidden = false;
    }

    // called when tutorial is finished
    public void TutorialContinue(bool continued) 
    {
        Console.WriteLine($"coninued: {continued}");
        TutorialHidden = true;
        FirstRoundHidden = false;
    }

    // called when round one is finished
    public void FirstRoundComplete(int wins) 
    {
        Console.WriteLine($"complete: {wins}");
        FirstRoundHidden = true;
        ExplanationHidden = false;
        Wins += wins;
        TotalGames += 4;
    }

    // called when explanation page is finished
    public void ExplanationContinue(bool continued)
    {
        Console.WriteLine($"continued: {continued}");
        ExplanationHidden = true;
        SecondRoundHidden = false;
    }

    // called when second rounds is finished
    public void SecondRoundComplete(Tuple<int, int, int> tuple)
    {
        Console.WriteLine($"second complete: {tuple.Item1} {tuple.Item2}");
        Wins += tuple.Item1;
        CorrectUnwinnables += tuple.Item2;
        TotalGames += 7;
        TotalUnWins += tuple.Item3;
        SecondRoundHidden = true;
        SummaryHidden = false;
    }

    // called when infinite is finished
    public void InfiniteComplete(Tuple<int, int, int, int> tuple)
    {
        Console.WriteLine($"infinite complete: {tuple.Item1} {tuple.Item2}");
        Wins += tuple.Item1;
        CorrectUnwinnables += tuple.Item2;
        TotalGames += tuple.Item3;
        TotalUnWins += tuple.Item4;
        InfiniteHidden = true;
        SummaryHidden = false;
    }

    // called when summary is finished
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
    
    // called when about us page is finished
    public void Back(bool back)
    {
        Console.WriteLine($"back: {back}");
        AboutHidden = true;
        MainMenuHidden = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
