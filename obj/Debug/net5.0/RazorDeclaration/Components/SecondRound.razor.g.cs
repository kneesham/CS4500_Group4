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
    public partial class SecondRound : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
       
    [Parameter]
    public EventCallback<Tuple<int, int>> SecondRoundComplete { get; set; }
    public int CorrectUnwinnables { get; set; } = 0;
    public int Wins { get; set; } = 0;
    public Deck TheDeck { get; set; }
    public bool UserWon { get; set; } = false;
    public int NumberOfRounds { get; set; } = 0;
    public bool CanStillPlay { get; set; } = true;
    public bool GameWinnable{ get; set; }
    public string[] Chevrons { get; set; } = new string[7];
    string draggableDataA = "left";
    string draggableDataB = "right";
    public string UnwinnableString { get; set; } = "";
    public string[] Cards = new string[] {
        "../img/bear_card.png", "../img/cat_card.png", "../img/flamingo_card.png", "../img/iguana_card.png",
        "../img/jellyfish_card.png", "../img/kangoroo_card.png", "../img/lion_card.png", "../img/owl_card.png"
    };
    public int[] CardFaces = new int[7];
    Random random = new Random(DateTime.Now.Millisecond);
    public bool ButtonDisabled { get; set; } = false;


    protected override void OnInitialized()
    {
        TheDeck = new Deck(2, NumberOfRounds);
        CanStillPlay = true;
        GameWinnable = TheDeck.WinPossible(1);

        for (int i = 0; i < 7; i++)
            CardFaces[i] = random.Next(Cards.Length);

        base.OnInitialized();
    }

    public void CardClicked(int card)
    {
        TheDeck.ChangeCard(card);
        UserWon = TheDeck.CheckWin();
        CanStillPlay = TheDeck.WinPossible(0);
    }

    public void NextGame()
    {
        NumberOfRounds++;
        TheDeck = new Deck(2, NumberOfRounds);
        for (int i = 0; i < 7; i++)
            CardFaces[i] = random.Next(Cards.Length);
        GameWinnable = TheDeck.WinPossible(1);
        UserWon = false;
        CanStillPlay = true;
        ButtonDisabled = false;
        UnwinnableString = "";
    }

    public void OnDrop(Tuple<int, string> data)
    {
        Chevrons[data.Item1] = data.Item2;
    }

    public void Unwinnable()
    {
        if (!GameWinnable)
        {
            UnwinnableString = "You are right! The game is unwinnable";
            UserWon = true;
            CorrectUnwinnables++;
        }
        else
        {
            UnwinnableString = "You are wrong! You can win this game!";
        }
    }

    public void Complete()
    {
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
