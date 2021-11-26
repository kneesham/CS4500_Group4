#pragma checksum "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd6b4a264289743bbeb7f1e2e351faef00a84b1a"
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
    public partial class SecondRound : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 1 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
             backgroundimg

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "style", "height:100%");
            __builder.AddMarkupContent(3, "<header><div class=\"deck-logo\"><img src=\"../img/deck-logo.png\" alt=\"ZooBreakout!\"></div></header>\n\t\n\t");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "flex-container");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "flex-row");
            __builder.OpenElement(8, "span");
            __builder.AddAttribute(9, "class", "flex-item");
            __builder.AddContent(10, " Player name: ");
            __builder.OpenElement(11, "b");
            __builder.AddAttribute(12, "id", "player-name");
            __builder.AddContent(13, 
#nullable restore
#line 10 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                                                       Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n\t\t");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "flex-row");
            __builder.OpenElement(17, "span");
            __builder.AddAttribute(18, "class", "flex-item");
            __builder.AddContent(19, " Round number: ");
            __builder.OpenElement(20, "b");
            __builder.AddAttribute(21, "id", "Round-number");
            __builder.AddContent(22, 
#nullable restore
#line 13 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                                                          NumberOfRounds+1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n\n\t");
            __builder.OpenElement(24, "section");
            __builder.AddAttribute(25, "id", "game1");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "id", "cards1");
            __builder.AddContent(28, 
#nullable restore
#line 19 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
             UnwinnableString

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 20 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
             if (!UserWon && NumberOfRounds != 5 && CanStillPlay)
            {
                int count = 0;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "row");
#nullable restore
#line 24 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                     foreach(var card in TheDeck.Cards)
                    {
                        int index = count;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col justify-content-center");
#nullable restore
#line 28 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                             if (card == 0)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "img");
            __builder.AddAttribute(34, "src", 
#nullable restore
#line 30 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                          Cards[CardFaces[index]]

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(35, "alt", "card");
            __builder.AddAttribute(36, "width", "100%");
            __builder.AddAttribute(37, "style", "margin:2px;max-width:200px;");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                                                                                                                        () => CardClicked(index)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 31 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                            }
                            else if (card == 1)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "img");
            __builder.AddAttribute(40, "src", "../img/cards/back_card.png");
            __builder.AddAttribute(41, "alt", "card");
            __builder.AddAttribute(42, "width", "100%");
            __builder.AddAttribute(43, "style", "margin:2px;max-width:200px;");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                                                                                                                            () => CardClicked(index)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 35 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "img");
            __builder.AddAttribute(46, "src", "../img/cards/blank_card.png");
            __builder.AddAttribute(47, "alt", "card");
            __builder.AddAttribute(48, "width", "100%");
            __builder.AddAttribute(49, "style", "margin:2px;opacity:0;max-width:200px;");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                                                                                                                                       () => CardClicked(index)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 39 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ZooBreakout.Components.DropTarget<String>>(51);
            __builder.AddAttribute(52, "Drop", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Tuple<System.Int32, System.String>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Tuple<System.Int32, System.String>>(this, 
#nullable restore
#line 40 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                                          OnDrop

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(53, "DropTargetNumber", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 40 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                                                                     index

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "drop-target");
#nullable restore
#line 42 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                         switch(Chevrons[index])
                                        {
                                            case "greenleft":

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(57, "<img src=\"../img/puzzlepieces/green-end-left.png\" alt=\"chevron\" height=\"75px\">");
#nullable restore
#line 45 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                                                                                                               break;
                                            case "greenright":

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(58, "<img src=\"../img/puzzlepieces/green-end-right.png\" alt=\"chevron\" height=\"75px\">");
#nullable restore
#line 47 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                                                                                                                break;
                                            case "orangeleft":

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(59, "<img src=\"../img/puzzlepieces/orange-left.png\" alt=\"chevron\" height=\"75px\">");
#nullable restore
#line 49 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                                                                                                            break;
                                            case "orangeright":

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(60, "<img src=\"../img/puzzlepieces/orange-right.png\" alt=\"chevron\" height=\"75px\">");
#nullable restore
#line 51 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                                                                                                             break;
                                            case "purpleleft":

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(61, "<img src=\"../img/puzzlepieces/purple-left.png\" alt=\"chevron\" height=\"75px\">");
#nullable restore
#line 53 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                                                                                                            break;
                                            case "purpleright":

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(62, "<img src=\"../img/puzzlepieces/purple-right.png\" alt=\"chevron\" height=\"75px\">");
#nullable restore
#line 55 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                                                                                                             break;
                                            case "blue":

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(63, "<img src=\"../img/puzzlepieces/blue-outward.png\" alt=\"chevron\" height=\"60px\">");
#nullable restore
#line 57 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                                                                                                             break;
                                            case "yellow":

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(64, "<img src=\"../img/puzzlepieces/yellow-piece.png\" alt=\"chevron\" height=\"75px\">");
#nullable restore
#line 59 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                                                                                                             break;
                                            default:

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(65, "<img src=\"../img/puzzlepieces/green-end-left.png\" alt=\"chevron\" height=\"75px\" style=\"opacity:0;\">");
#nullable restore
#line 61 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                                                                                                                                  break;
                                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 66 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                        count++;
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\n                ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "row");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "col-2");
            __Blazor.ZooBreakout.Components.SecondRound.TypeInference.CreateDraggable_0(__builder, 71, 72, 
#nullable restore
#line 71 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                          Draggables[0]

#line default
#line hidden
#nullable disable
            , 73, (__builder2) => {
                __builder2.AddMarkupContent(74, "<div class=\"draggable\"><img src=\"../img/puzzlepieces/green-end-left.png\" alt=\"chevron\" height=\"75px\"></div>");
            }
            );
            __builder.AddMarkupContent(75, "\n                        ");
            __Blazor.ZooBreakout.Components.SecondRound.TypeInference.CreateDraggable_1(__builder, 76, 77, 
#nullable restore
#line 76 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                          Draggables[1]

#line default
#line hidden
#nullable disable
            , 78, (__builder2) => {
                __builder2.AddMarkupContent(79, "<div class=\"draggable\"><img src=\"../img//puzzlepieces/green-end-right.png\" alt=\"chevron\" height=\"75px\"></div>");
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\n                    ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "col-2");
            __Blazor.ZooBreakout.Components.SecondRound.TypeInference.CreateDraggable_2(__builder, 83, 84, 
#nullable restore
#line 83 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                          Draggables[2]

#line default
#line hidden
#nullable disable
            , 85, (__builder2) => {
                __builder2.AddMarkupContent(86, "<div class=\"draggable\"><img src=\"../img//puzzlepieces/orange-left.png\" alt=\"chevron\" height=\"75px\"></div>");
            }
            );
            __builder.AddMarkupContent(87, "\n                        ");
            __Blazor.ZooBreakout.Components.SecondRound.TypeInference.CreateDraggable_3(__builder, 88, 89, 
#nullable restore
#line 88 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                          Draggables[3]

#line default
#line hidden
#nullable disable
            , 90, (__builder2) => {
                __builder2.AddMarkupContent(91, "<div class=\"draggable\"><img src=\"../img//puzzlepieces/orange-right.png\" alt=\"chevron\" height=\"75px\"></div>");
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\n                    ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "col-2");
            __Blazor.ZooBreakout.Components.SecondRound.TypeInference.CreateDraggable_4(__builder, 95, 96, 
#nullable restore
#line 95 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                          Draggables[4]

#line default
#line hidden
#nullable disable
            , 97, (__builder2) => {
                __builder2.AddMarkupContent(98, "<div class=\"draggable\"><img src=\"../img//puzzlepieces/purple-left.png\" alt=\"chevron\" height=\"75px\"></div>");
            }
            );
            __builder.AddMarkupContent(99, "\n                        ");
            __Blazor.ZooBreakout.Components.SecondRound.TypeInference.CreateDraggable_5(__builder, 100, 101, 
#nullable restore
#line 100 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                          Draggables[5]

#line default
#line hidden
#nullable disable
            , 102, (__builder2) => {
                __builder2.AddMarkupContent(103, "<div class=\"draggable\"><img src=\"../img//puzzlepieces/purple-right.png\" alt=\"chevron\" height=\"75px\"></div>");
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\n                    ");
            __builder.OpenElement(105, "div");
            __builder.AddAttribute(106, "class", "col-2");
            __Blazor.ZooBreakout.Components.SecondRound.TypeInference.CreateDraggable_6(__builder, 107, 108, 
#nullable restore
#line 107 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                          Draggables[6]

#line default
#line hidden
#nullable disable
            , 109, (__builder2) => {
                __builder2.AddMarkupContent(110, "<div class=\"draggable\"><img src=\"../img/puzzlepieces/blue-outward.png\" alt=\"chevron\" height=\"75px\"></div>");
            }
            );
            __builder.AddMarkupContent(111, "\n                        ");
            __Blazor.ZooBreakout.Components.SecondRound.TypeInference.CreateDraggable_7(__builder, 112, 113, 
#nullable restore
#line 112 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                          Draggables[7]

#line default
#line hidden
#nullable disable
            , 114, (__builder2) => {
                __builder2.AddMarkupContent(115, "<div class=\"draggable\"><img src=\"../img/puzzlepieces/yellow-piece.png\" alt=\"chevron\" height=\"75px\"></div>");
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\n                    ");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "class", "col-4 d-flex align-items-center justify-content-center");
            __builder.OpenElement(119, "a");
            __builder.AddAttribute(120, "class", "st-btn btn-fill");
            __builder.AddAttribute(121, "data-toggle", "modal");
            __builder.AddAttribute(122, "data-target", "#");
            __builder.AddAttribute(123, "style", "margin-top:20px;");
            __builder.AddAttribute(124, "disabled", 
#nullable restore
#line 120 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                   ButtonDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(125, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 120 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                                             Unwinnable

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(126, "Unwinnable!");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\n                        ");
            __builder.OpenElement(128, "a");
            __builder.AddAttribute(129, "class", "st-btn btn-fill");
            __builder.AddAttribute(130, "data-toggle", "modal");
            __builder.AddAttribute(131, "data-target", "#");
            __builder.AddAttribute(132, "style", "margin-top:20px;");
            __builder.AddAttribute(133, "disabled", 
#nullable restore
#line 122 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                   ButtonDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(134, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 122 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                                             () => TheDeck.UndoLastMove()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(135, "Undo");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\n                        ");
            __builder.OpenElement(137, "a");
            __builder.AddAttribute(138, "class", "st-btn btn-fill");
            __builder.AddAttribute(139, "data-toggle", "modal");
            __builder.AddAttribute(140, "data-target", "#");
            __builder.AddAttribute(141, "style", "margin-top:20px;");
            __builder.AddAttribute(142, "disabled", 
#nullable restore
#line 124 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                   ButtonDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(143, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 124 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                                             () => TheDeck.ResetDeck()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(144, "Reset");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 127 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 131 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
     if (UserWon || (!CanStillPlay && !UserWon) || NumberOfRounds == 5)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(145, "section");
            __builder.AddAttribute(146, "id", "popup");
            __builder.AddMarkupContent(147, "<div id=\"popup-bg\"></div>\n            ");
            __builder.OpenElement(148, "div");
            __builder.AddAttribute(149, "id", "popup-box");
            __builder.OpenElement(150, "div");
            __builder.AddAttribute(151, "id", "popup-box-content");
#nullable restore
#line 137 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                     if (UserWon && NumberOfRounds != 5)
                    {
                        Wins++;

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(152, "<h1 class=\"display-1\">You Won!</h1>\n                        ");
            __builder.OpenElement(153, "p");
            __builder.AddContent(154, 
#nullable restore
#line 141 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                            UnwinnableString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\n                        ");
            __builder.OpenElement(156, "a");
            __builder.AddAttribute(157, "class", "st-btn btn-fill");
            __builder.AddAttribute(158, "data-toggle", "modal");
            __builder.AddAttribute(159, "data-target", "#");
            __builder.AddAttribute(160, "style", "margin-top:20px;");
            __builder.AddAttribute(161, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 142 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                                                                                                          NextGame

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(162, "Next Game!");
            __builder.CloseElement();
#nullable restore
#line 143 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                    }
                    else if (!CanStillPlay && !UserWon)
                    {
                        ButtonDisabled = true;

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(163, "<h1 class=\"display-1\">You Lost!</h1>\n                        ");
            __builder.OpenElement(164, "a");
            __builder.AddAttribute(165, "class", "st-btn btn-fill");
            __builder.AddAttribute(166, "data-toggle", "modal");
            __builder.AddAttribute(167, "data-target", "#");
            __builder.AddAttribute(168, "style", "margin-top:20px;");
            __builder.AddAttribute(169, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 148 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                                                                                                          NextGame

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(170, "Next Game!");
            __builder.CloseElement();
#nullable restore
#line 149 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                    }
                    else if (NumberOfRounds == 5)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(171, "<h1 class=\"display-4\">Second Round Complete!</h1>\n                        ");
            __builder.OpenElement(172, "a");
            __builder.AddAttribute(173, "class", "st-btn btn-fill");
            __builder.AddAttribute(174, "data-toggle", "modal");
            __builder.AddAttribute(175, "data-target", "#");
            __builder.AddAttribute(176, "style", "margin-top:20px;");
            __builder.AddAttribute(177, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 154 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                                  () => SecondRoundComplete.InvokeAsync(Tuple.Create(Wins, CorrectUnwinnables, TotalUnwinnables))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(178, "Summary!");
            __builder.CloseElement();
#nullable restore
#line 155 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 159 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 162 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/SecondRound.razor"
       
    [Parameter]
    public EventCallback<Tuple<int, int, int>> SecondRoundComplete { get; set; }
    [Parameter]
    public string Name { get; set; } = "";
    public int CorrectUnwinnables { get; set; } = 0;
    public int Wins { get; set; } = 0;
    public Deck TheDeck { get; set; }
    public bool UserWon { get; set; } = false;
    public int NumberOfRounds { get; set; } = 0;
    public bool CanStillPlay { get; set; } = true;
    public bool GameWinnable{ get; set; }
    public string[] Chevrons { get; set; } = new string[7];
    public string[] Draggables { get; set; } = new string[] {
        "greenleft", "greenright", "orangeleft", "orangeright",
        "purpleleft", "purpleright", "blue", "yellow"
    };
    public string UnwinnableString { get; set; } = "";
    public string[] Cards = new string[] {
        "../img/cards/bear_card.png", "../img/cards/cat_card.png", "../img/cards/flamingo_card.png", 
        "../img/cards/iguana_card.png", "../img/cards/jellyfish_card.png", "../img/cards/kangoroo_card.png", 
        "../img/cards/lion_card.png", "../img/cards/owl_card.png"
    };
    public int[] CardFaces = new int[7];
    Random random = new Random(DateTime.Now.Millisecond);
    public bool ButtonDisabled { get; set; } = false;
    public string backgroundimg { get; set; } = "";
    public int TotalUnwinnables { get; set; } = 0;


    protected override void OnInitialized()
    {
        // setup game
        TheDeck = new Deck(2, NumberOfRounds);
        CanStillPlay = true;
        GameWinnable = TheDeck.WinPossible(1);
        if (!GameWinnable)
            TotalUnwinnables++;

        // pick random card faces
        for (int i = 0; i < 7; i++)
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
        CanStillPlay = TheDeck.WinPossible(0);
    }

    public void NextGame()
    {
        NumberOfRounds++;
        TheDeck = new Deck(2, NumberOfRounds);
        for (int i = 0; i < 7; i++)
            CardFaces[i] = random.Next(Cards.Length);
        Chevrons = new string[7];
        GameWinnable = TheDeck.WinPossible(1);
        if (!GameWinnable)
            TotalUnwinnables++;
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

    public void ResetDeck()
    {
        
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.ZooBreakout.Components.SecondRound
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateDraggable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::ZooBreakout.Components.Draggable<T>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateDraggable_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::ZooBreakout.Components.Draggable<T>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateDraggable_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::ZooBreakout.Components.Draggable<T>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateDraggable_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::ZooBreakout.Components.Draggable<T>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateDraggable_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::ZooBreakout.Components.Draggable<T>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateDraggable_5<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::ZooBreakout.Components.Draggable<T>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateDraggable_6<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::ZooBreakout.Components.Draggable<T>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateDraggable_7<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::ZooBreakout.Components.Draggable<T>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
