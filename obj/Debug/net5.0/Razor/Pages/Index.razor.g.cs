#pragma checksum "/Users/anthony/Documents/GitHub/CS4500_Group4/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eea7f9382144f48cc4d984465685f6bc330ebae2"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container border border-3 border-dark rounded p-5 shadow");
            __builder.AddAttribute(2, "style", "height: 600px;");
            __builder.AddAttribute(3, "hidden", 
#nullable restore
#line 3 "/Users/anthony/Documents/GitHub/CS4500_Group4/Pages/Index.razor"
                                                                                                      MainMenuHidden

#line default
#line hidden
#nullable disable
            );
            __builder.OpenComponent<ZooBreakout.Components.MainMenu>(4);
            __builder.AddAttribute(5, "StoryChosen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 4 "/Users/anthony/Documents/GitHub/CS4500_Group4/Pages/Index.razor"
                           StoryChosen

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "InfiniteChosen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 4 "/Users/anthony/Documents/GitHub/CS4500_Group4/Pages/Index.razor"
                                                        InfiniteChosen

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "AboutChosen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 4 "/Users/anthony/Documents/GitHub/CS4500_Group4/Pages/Index.razor"
                                                                                     AboutChosen

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "container border border-3 border-dark rounded p-5 shadow");
            __builder.AddAttribute(11, "hidden", 
#nullable restore
#line 6 "/Users/anthony/Documents/GitHub/CS4500_Group4/Pages/Index.razor"
                                                                               TutorialHidden

#line default
#line hidden
#nullable disable
            );
            __builder.OpenComponent<ZooBreakout.Components.Tutorial>(12);
            __builder.AddAttribute(13, "TutorialContinue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 7 "/Users/anthony/Documents/GitHub/CS4500_Group4/Pages/Index.razor"
                                TutorialContinue

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "container border border-3 border-dark rounded p-5 shadow");
            __builder.AddAttribute(17, "style", "height: 600px;");
            __builder.AddAttribute(18, "hidden", 
#nullable restore
#line 9 "/Users/anthony/Documents/GitHub/CS4500_Group4/Pages/Index.razor"
                                                                                                      FirstRoundHidden

#line default
#line hidden
#nullable disable
            );
            __builder.OpenComponent<ZooBreakout.Components.FirstRound>(19);
            __builder.AddAttribute(20, "FirstRoundComplete", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 10 "/Users/anthony/Documents/GitHub/CS4500_Group4/Pages/Index.razor"
                                    FirstRoundComplete

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "container border border-3 border-dark rounded p-5 shadow");
            __builder.AddAttribute(24, "hidden", 
#nullable restore
#line 12 "/Users/anthony/Documents/GitHub/CS4500_Group4/Pages/Index.razor"
                                                                               ExplanationHidden

#line default
#line hidden
#nullable disable
            );
            __builder.OpenComponent<ZooBreakout.Components.Explanation>(25);
            __builder.AddAttribute(26, "ExplanationContinue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 13 "/Users/anthony/Documents/GitHub/CS4500_Group4/Pages/Index.razor"
                                      ExplanationContinue

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "container border border-3 border-dark rounded p-5 shadow");
            __builder.AddAttribute(30, "style", "height: 600px;");
            __builder.AddAttribute(31, "hidden", 
#nullable restore
#line 15 "/Users/anthony/Documents/GitHub/CS4500_Group4/Pages/Index.razor"
                                                                                                      SecondRoundHidden

#line default
#line hidden
#nullable disable
            );
            __builder.OpenComponent<ZooBreakout.Components.SecondRound>(32);
            __builder.AddAttribute(33, "SecondRoundComplete", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Tuple<System.Int32, System.Int32>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Tuple<System.Int32, System.Int32>>(this, 
#nullable restore
#line 16 "/Users/anthony/Documents/GitHub/CS4500_Group4/Pages/Index.razor"
                                      SecondRoundComplete

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "container border border-3 border-dark rounded p-5 shadow");
            __builder.AddAttribute(37, "hidden", 
#nullable restore
#line 18 "/Users/anthony/Documents/GitHub/CS4500_Group4/Pages/Index.razor"
                                                                               SummaryHidden

#line default
#line hidden
#nullable disable
            );
            __builder.OpenComponent<ZooBreakout.Components.Summary>(38);
            __builder.AddAttribute(39, "SummaryContinue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 19 "/Users/anthony/Documents/GitHub/CS4500_Group4/Pages/Index.razor"
                              SummaryContinue

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(40, "Wins", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 19 "/Users/anthony/Documents/GitHub/CS4500_Group4/Pages/Index.razor"
                                                     Wins

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "CorrectUnwinnables", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 19 "/Users/anthony/Documents/GitHub/CS4500_Group4/Pages/Index.razor"
                                                                               CorrectUnwinnables

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
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
