#pragma checksum "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/FirstRound.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff9dc834d1191c2711cba20a55f6d8ee8d7f1b8b"
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
    public partial class FirstRound : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 1 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/FirstRound.razor"
             backgroundimg

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(2, "<header><div class=\"deck-logo\"><img src=\"../img/deck-logo.png\" alt=\"ZooBreakout!\"></div></header>\n\t\n\t");
            __builder.AddMarkupContent(3, @"<div class=""flex-container""><div class=""flex-row""><span class=""flex-item""> Elapsed time: <b id=""elapsed-time"">00:00</b></span></div>
		<div class=""flex-row""><span class=""flex-item""> Player name: <b id=""player-name"">Demo</b></span></div>
		<div class=""flex-row""><span class=""flex-item""> Round number: <b id=""Round-number"">00</b></span></div></div>

	");
            __builder.OpenElement(4, "section");
            __builder.AddAttribute(5, "id", "game");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "id", "cards");
#nullable restore
#line 22 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/FirstRound.razor"
             if (!UserWon && GamePossibleToWin)
            {
                int count = 0;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/FirstRound.razor"
                 foreach(var card in TheDeck.Cards)
                {
                    int index = count;
                    if (card == 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "src", 
#nullable restore
#line 30 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/FirstRound.razor"
                                  Cards[CardFaces[index]]

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "alt", "card");
            __builder.AddAttribute(11, "width", "150px");
            __builder.AddAttribute(12, "style", "margin:2px;");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/FirstRound.razor"
                                                                                                                 () => CardClicked(index)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 31 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/FirstRound.razor"
                    }
                    else if (card == 1)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "img");
            __builder.AddAttribute(15, "src", "../img/cards/back_card.png");
            __builder.AddAttribute(16, "alt", "card");
            __builder.AddAttribute(17, "width", "150px");
            __builder.AddAttribute(18, "style", "margin:2px;");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/FirstRound.razor"
                                                                                                                     () => CardClicked(index)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 35 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/FirstRound.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "img");
            __builder.AddAttribute(21, "src", "../img/cards/blank_card.png");
            __builder.AddAttribute(22, "alt", "card");
            __builder.AddAttribute(23, "width", "150px");
            __builder.AddAttribute(24, "style", "margin:2px; opacity:0;");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/FirstRound.razor"
                                                                                                                                 () => CardClicked(index)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 39 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/FirstRound.razor"
                    }
                    count++;
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/FirstRound.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/FirstRound.razor"
     if (UserWon || !GamePossibleToWin)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "section");
            __builder.AddAttribute(27, "id", "popup");
            __builder.AddMarkupContent(28, "<div id=\"popup-bg\"></div>\n            ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "id", "popup-box");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "id", "popup-box-content");
#nullable restore
#line 52 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/FirstRound.razor"
                     if (UserWon && NumberOfRounds != 5)
                    {
                        Wins++;

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(33, "<h1 class=\"display-1\">You Won!</h1>\n                        ");
            __builder.OpenElement(34, "a");
            __builder.AddAttribute(35, "class", "st-btn btn-fill");
            __builder.AddAttribute(36, "data-toggle", "modal");
            __builder.AddAttribute(37, "data-target", "#");
            __builder.AddAttribute(38, "style", "margin-top:20px;");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/FirstRound.razor"
                                                                                                                          NextGame

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Next Game!");
            __builder.CloseElement();
#nullable restore
#line 57 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/FirstRound.razor"
                    }
                    else if (!GamePossibleToWin && !UserWon && NumberOfRounds == 4)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(41, "<h1 class=\"display-1\"> You Lost!</h1>\n                        ");
            __builder.AddMarkupContent(42, @"<p style=""font-size: 15px;"">But, why? This last game was actually unwinnable. Even if you played it perfectly, you would not have
                            been able to win. Click next to find out why!
                        </p>
                        ");
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "class", "st-btn btn-fill");
            __builder.AddAttribute(45, "data-toggle", "modal");
            __builder.AddAttribute(46, "data-target", "#");
            __builder.AddAttribute(47, "style", "margin-top:20px;");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/FirstRound.razor"
                                                                                                                          () => FirstRoundComplete.InvokeAsync(Wins)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(49, "Next");
            __builder.CloseElement();
#nullable restore
#line 65 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/FirstRound.razor"
                    }
                    else if (!GamePossibleToWin && !UserWon)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(50, "<h1 class=\"display-1\">You Lost!</h1>\n                        ");
            __builder.OpenElement(51, "a");
            __builder.AddAttribute(52, "class", "st-btn btn-fill");
            __builder.AddAttribute(53, "data-toggle", "modal");
            __builder.AddAttribute(54, "data-target", "#");
            __builder.AddAttribute(55, "style", "margin-top:20px;");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/FirstRound.razor"
                                                                                                                          NextGame

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(57, "Next Game!");
            __builder.CloseElement();
#nullable restore
#line 70 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/FirstRound.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 74 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/FirstRound.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/FirstRound.razor"
       
    [Parameter]
    public EventCallback<int> FirstRoundComplete { get; set; }
    public Deck TheDeck { get; set; }
    public bool UserWon { get; set; } = false;
    public int NumberOfRounds { get; set; } = 0;
    public int Wins { get; set; } = 0;
    public bool GamePossibleToWin { get; set; } = true;
    public string[] Cards = new string[] {
        "../img/cards/bear_card.png", "../img/cards/cat_card.png", "../img/cards/flamingo_card.png", 
        "../img/cards/iguana_card.png", "../img/cards/jellyfish_card.png", "../img/cards/kangoroo_card.png", 
        "../img/cards/lion_card.png", "../img/cards/owl_card.png"
    };
    public int[] CardFaces = new int[5];
    Random random = new Random(DateTime.Now.Millisecond);
    public string backgroundimg { get; set; } = "";

    protected override void OnInitialized()
    {
        // create new game
        TheDeck = new Deck(1, NumberOfRounds);
        GamePossibleToWin = true;

        // pick random card faces
        for (int i = 0; i < 5; i++)
            CardFaces[i] = random.Next(Cards.Length);
        
        // pick random background
        int imagenum = random.Next(0, 3);
        if (imagenum == 0)
            backgroundimg = "image1";
        else if (imagenum == 1)
            backgroundimg = "image2";
        else
            backgroundimg = "image3";
        
        base.OnInitialized();
    }

    public void CardClicked(int card)
    {
        TheDeck.ChangeCard(card);
        UserWon = TheDeck.CheckWin();
        GamePossibleToWin = TheDeck.WinPossible(0);
    }
     
    public void NextGame()
    {
        NumberOfRounds++;
        TheDeck = new Deck(1, NumberOfRounds);
        for (int i = 0; i < 5; i++)
            CardFaces[i] = random.Next(Cards.Length);
        UserWon = false;
        GamePossibleToWin = true;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
