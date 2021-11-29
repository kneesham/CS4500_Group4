#pragma checksum "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/Explanation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05a63088688c646b1720aaa8bc3ff92582d5b714"
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
    public partial class Explanation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "min-height:calc(100vh - 60px);");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row align-items-center justify-content-center explanation-row");
            __builder.AddAttribute(4, "hidden", 
#nullable restore
#line 6 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/Explanation.razor"
                                                                                        Hidden[0]

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "style", "margin-bottom:15px;");
            __builder.AddMarkupContent(6, @"<div class=""col-4""><h1 class=""display-2"">Why you couldn't win.</h1>
            <p class=""explanation-text"">
                It turns out, that that your ability to win depends nearly entirely on whether there
                is an even or odd amount of face up cards. If there are an even amount (like the game
                you just played), then you will be doomed from the beginning. But, if you know the
                correct strategy, you will be able to win if there are an odd number of face up cards.
                This makes the probability of having a winnable game 50%, meaning if you play 1,000
                games, about 500 of them will be a winnable scenerio.
            </p></div>
        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-8");
            __builder.AddMarkupContent(9, @"<div class=""row align-items-center justify-content-center diagram-1""><img src=""../img/remove.png"" width=""50px;"">
                <img src=""../img/cards/bear_card.png"" width=""150px"" style=""margin:8px;"">
                <img src=""../img/cards/back_card.png"" width=""150px"" style=""margin:8px;"">
                <img src=""../img/cards/cat_card.png"" width=""150px"" style=""margin:8px;""></div>
            ");
            __builder.AddMarkupContent(10, @"<div class=""row align-items-center justify-content-center diagram-1""><img src=""../img/check.png"" width=""50px;"">
                <img src=""../img/cards/bear_card.png"" width=""150px"" style=""margin:8px;"">
                <img src=""../img/cards/back_card.png"" width=""150px"" style=""margin:8px;"">
                <img src=""../img/cards/back_card.png"" width=""150px"" style=""margin:8px;""></div>
            ");
            __builder.OpenElement(11, "a");
            __builder.AddAttribute(12, "class", "st-btn btn-fill");
            __builder.AddAttribute(13, "data-toggle", "modal");
            __builder.AddAttribute(14, "data-target", "#");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/Explanation.razor"
                                                                                       () => ShowNext(0)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Continue");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "row align-items-center justify-content-center explanation-row");
            __builder.AddAttribute(20, "hidden", 
#nullable restore
#line 38 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/Explanation.razor"
                                                                                        Hidden[1]

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "style", "margin-bottom:15px;");
            __builder.AddMarkupContent(22, "<div class=\"col-8\"><div class=\"row align-items-center justify-content-center diagram-1\"><h1 style=\"width:200px;\">Face-Up</h1>\n                <div><img src=\"../img/cards/back_card.png\" width=\"150px\" style=\"margin:8px;\">\n                    <p>3</p></div>\n                <div><img src=\"../img/cards/bear_card.png\" width=\"150px\" style=\"margin:8px;\">\n                    <p>1</p></div>\n                <div><img src=\"../img/cards/back_card.png\" width=\"150px\" style=\"margin:8px;\">\n                    <p>2</p></div></div>\n            <div class=\"row align-items-center justify-content-center diagram-1\"><h1 style=\"width:200px;\">Face-Down</h1>\n                <div><img src=\"../img/cards/back_card.png\" width=\"150px\" style=\"margin:8px;\">\n                    <p>3</p></div>\n                <div><img src=\"../img/cards/back_card.png\" width=\"150px\" style=\"margin:8px;\">\n                    <p>2</p></div>\n                <div><img src=\"../img/cards/cat_card.png\" width=\"150px\" style=\"margin:8px;\">\n                    <p>1</p></div></div>\n            <div class=\"row align-items-center justify-content-center diagram-1\"><h1 style=\"width:200px;\">Face-Up End</h1>\n                <div><img src=\"../img/cards/bear_card.png\" width=\"150px\" style=\"margin:8px;\">\n                    <p>1</p></div>\n                <div><img src=\"../img/cards/back_card.png\" width=\"150px\" style=\"margin:8px;\">\n                    <p>2</p></div>\n                <div><img src=\"../img/cards/back_card.png\" width=\"150px\" style=\"margin:8px;\">\n                    <p>3</p></div></div>\n            <div class=\"row align-items-center justify-content-center diagram-1\"><h1 style=\"width:200px;\">Face-Down End</h1>\n                <div><img src=\"../img/cards/back_card.png\" width=\"150px\" style=\"margin:8px;\">\n                    <p>2</p></div>\n                <div><img src=\"../img/cards/bear_card.png\" width=\"150px\" style=\"margin:8px;\">\n                    <p>1</p></div>\n                <div><img src=\"../img/cards/back_card.png\" width=\"150px\" style=\"margin:8px;\">\n                    <p>3</p></div></div></div>\n        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col-4");
            __builder.AddMarkupContent(25, "<h1 class=\"display-3\">A little bit of background knowledge</h1>\n            ");
            __builder.AddMarkupContent(26, @"<p class=""explanation-text"">
                In order to know how to beat a winnable game, you need to know what order to draw the cards
                in. This can be a little tricky if you don't know where to start looking for answers. But,
                if we start looking at the game piece by piece we can figure it out! It turns out, a face up
                card needs to be drawn either before both of its neighbors or after both. This results in the
                card still being face up and allowing you to take it. On the other hand, if the card is face
                down, then the card must be drawn after one of its neighbors (making it face up) and before
                its other one (which would make it face down). These two concepts can also be used to infer
                how we must draw the end cards. A face down end card must be drawn after its neighbor, and a
                face up one must be drawn before its neighbor.
            </p>
            ");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "class", "st-btn btn-fill");
            __builder.AddAttribute(29, "data-toggle", "modal");
            __builder.AddAttribute(30, "data-target", "#");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 114 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/Explanation.razor"
                                                                                       () => ShowNext(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Continue");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n\n    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "row align-items-center justify-content-center explanation-row");
            __builder.AddAttribute(36, "hidden", 
#nullable restore
#line 119 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/Explanation.razor"
                                                                                        Hidden[2]

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(37, "style", "margin-bottom:15px;");
            __builder.AddMarkupContent(38, @"<div class=""col-4""><h1 class=""display-3"">Okay... but how does that help you?</h1>
            <p class=""explanation-text"">
                Well, now that we know the order for drawing each card, we can use inequalities to show it
                graphically. You may be thinking, ""Oh no... not math stuff,"" but I assure you that this will
                make your life a whole lot easier! If we look at the diagrams to the right, we can see the 
                cards that we numbered for each scenerio previously, but will greater than or less than
                symbols in between each.  If you think of the symbols as arrows, then the arrow points to which 
                cards need to be drawn first, second, third, and so on!
            </p></div>
        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col-8");
            __builder.AddMarkupContent(41, @"<div class=""row align-items-center justify-content-center diagram-1""><h1 style=""width:200px;"">Face-Up</h1>
                <div><img src=""../img/cards/back_card.png"" width=""150px"" style=""margin:8px;"">
                    <p>3</p></div>
                <img src=""../img/right-chevron.png"" width=""50px;"" style=""margin:8px;"">
                <div><img src=""../img/cards/bear_card.png"" width=""150px"" style=""margin:8px;"">
                    <p>1</p></div>
                <img src=""../img/left-chevron.png"" width=""50px;"" style=""margin:8px;"">
                <div><img src=""../img/cards/back_card.png"" width=""150px"" style=""margin:8px;"">
                    <p>2</p></div></div>
            ");
            __builder.AddMarkupContent(42, @"<div class=""row align-items-center justify-content-center diagram-1""><h1 style=""width:200px;"">Face-Down</h1>
                <div><img src=""../img/cards/back_card.png"" width=""150px"" style=""margin:8px;"">
                    <p>1</p></div>
                <img src=""../img/right-chevron.png"" width=""50px;"" style=""margin:8px;"">
                <div><img src=""../img/cards/back_card.png"" width=""150px"" style=""margin:8px;"">
                    <p>2</p></div>
                <img src=""../img/right-chevron.png"" width=""50px;"" style=""margin:8px;"">
                <div><img src=""../img/cards/cat_card.png"" width=""150px"" style=""margin:8px;"">
                    <p>3</p></div></div>
            ");
            __builder.AddMarkupContent(43, @"<div class=""row align-items-center justify-content-center diagram-1""><h1 style=""width:200px;"">Face-Up End</h1>
                <div><img src=""../img/cards/bear_card.png"" width=""150px"" style=""margin:8px;"">
                    <p>1</p></div>
                <img src=""../img/left-chevron.png"" width=""50px;"" style=""margin:8px;"">
                <div><img src=""../img/cards/back_card.png"" width=""150px"" style=""margin:8px;"">
                    <p>2</p></div>
                <img src=""../img/left-chevron.png"" width=""50px;"" style=""margin:8px;"">
                <div><img src=""../img/cards/back_card.png"" width=""150px"" style=""margin:8px;"">
                    <p>3</p></div></div>
            ");
            __builder.AddMarkupContent(44, @"<div class=""row align-items-center justify-content-center diagram-1""><h1 style=""width:200px;"">Face-Down End</h1>
                <div><img src=""../img/cards/back_card.png"" width=""150px"" style=""margin:8px;"">
                    <p>2</p></div>
                <img src=""../img/right-chevron.png"" width=""50px;"" style=""margin:8px;"">
                <div><img src=""../img/cards/bear_card.png"" width=""150px"" style=""margin:8px;"">
                    <p>1</p></div>
                <img src=""../img/left-chevron.png"" width=""50px;"" style=""margin:8px;"">
                <div><img src=""../img/cards/back_card.png"" width=""150px"" style=""margin:8px;"">
                    <p>3</p></div></div>
            ");
            __builder.OpenElement(45, "a");
            __builder.AddAttribute(46, "class", "st-btn btn-fill");
            __builder.AddAttribute(47, "data-toggle", "modal");
            __builder.AddAttribute(48, "data-target", "#");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 200 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/Explanation.razor"
                                                                                       () => ShowNext(2)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(50, "Continue");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n\n    ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "row align-items-center justify-content-center explanation-row");
            __builder.AddAttribute(54, "hidden", 
#nullable restore
#line 205 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/Explanation.razor"
                                                                                        Hidden[3]

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(55, "style", "margin-bottom:15px;");
            __builder.AddMarkupContent(56, "<div class=\"col-8\"><div class=\"row align-items-center justify-content-center diagram-1\"><h1 style=\"width:200px;\">Face-Up</h1>\n                <div><img src=\"../img/cards/back_card.png\" width=\"150px\" style=\"margin:8px;\"><br>\n                    <img src=\"../img/puzzlepieces/purple-right.png\" height=\"75px\"></div>\n                <div><img src=\"../img/cards/bear_card.png\" width=\"150px\" style=\"margin:8px;\"><br>\n                    <img src=\"../img/puzzlepieces/yellow-piece.png\" height=\"75px\"></div>\n                <div><img src=\"../img/cards/back_card.png\" width=\"150px\" style=\"margin:8px;\"><br>\n                    <img src=\"../img/puzzlepieces/purple-left.png\" height=\"75px\"></div></div>\n            <div class=\"row align-items-center justify-content-center diagram-1\"><h1 style=\"width:200px;\">Face-Down</h1>\n                <div><img src=\"../img/cards/back_card.png\" width=\"150px\" style=\"margin:8px;\"><br>\n                    <img src=\"../img/puzzlepieces/purple-right.png\" height=\"75px\"></div>\n                <div><img src=\"../img/cards/back_card.png\" width=\"150px\" style=\"margin:8px;\"><br>\n                    <img src=\"../img/puzzlepieces/purple-right.png\" height=\"75px\"></div>\n                <div><img src=\"../img/cards/cat_card.png\" width=\"150px\" style=\"margin:8px;\"><br>\n                    <img src=\"../img/puzzlepieces/purple-right.png\" height=\"75px\"></div></div>\n            <div class=\"row align-items-center justify-content-center diagram-1\"><h1 style=\"width:200px;\">Face-Up End</h1>\n                <div><img src=\"../img/cards/bear_card.png\" width=\"150px\" style=\"margin:8px;\"><br>\n                    <img src=\"../img/puzzlepieces/orange-left.png\" height=\"75px\"></div>\n                <div><img src=\"../img/cards/back_card.png\" width=\"150px\" style=\"margin:8px;\"><br>\n                    <img src=\"../img/puzzlepieces/purple-left.png\" height=\"75px\"></div>\n                <div><img src=\"../img/cards/back_card.png\" width=\"150px\" style=\"margin:8px;\"><br>\n                    <img src=\"../img/puzzlepieces/purple-left.png\" height=\"75px\"></div></div>\n            <div class=\"row align-items-center justify-content-center diagram-1\"><h1 style=\"width:200px;\">Face-Down End</h1>\n                <div><img src=\"../img/cards/back_card.png\" width=\"150px\" style=\"margin:8px;\"><br>\n                    <img src=\"../img/puzzlepieces/green-end-left.png\" height=\"75px\"></div>\n                <div><img src=\"../img/cards/back_card.png\" width=\"150px\" style=\"margin:8px;\"><br>\n                    <img src=\"../img/puzzlepieces/purple-right.png\" height=\"75px\"></div>\n                <div><img src=\"../img/cards/cat_card.png\" width=\"150px\" style=\"margin:8px;\"><br>\n                    <img src=\"../img/puzzlepieces/purple-right.png\" height=\"75px\"></div></div></div>\n        ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "col-4");
            __builder.AddMarkupContent(59, "<h1 class=\"display-2\">PUZZLE PIECES!</h1>\n            ");
            __builder.AddMarkupContent(60, @"<p class=""explanation-text"">
                Now let's wrap this up and get back to playing! There are five different symbols that can be created
                from these inequalities. You can think of them as puzzle pieces! To the right you can see all of them. 
                Please look over the diagram and commit these to memory! You will know exactly how to win each game
                (if it is winnable) if you do this! But, before you continue there is one important thing to note. The 
                yellow and orange puzzle peices must be drawn first (becuase they have the highest precedence)! 
                Click continue when you're ready to start playing again!
            </p>
            ");
            __builder.OpenElement(61, "a");
            __builder.AddAttribute(62, "class", "st-btn btn-fill");
            __builder.AddAttribute(63, "data-toggle", "modal");
            __builder.AddAttribute(64, "data-target", "#");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 278 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/Explanation.razor"
                                                                                       () => ExplanationContinue.InvokeAsync(true)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(66, "Continue");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n");
            __builder.AddMarkupContent(68, "<footer><p style=\"color:black;\">Zoo breakout! - The Flying Purple Monkeys - CS 4500, Fall 2021</p></footer>");
        }
        #pragma warning restore 1998
#nullable restore
#line 286 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/Explanation.razor"
       
    [Parameter]
    public EventCallback<bool> ExplanationContinue { get; set; }
    public bool[] Hidden { get; set; } = new bool[] {       // array to cycle through "pages" of information
        false, true, true, true
    };
    
    public void ShowNext(int i)                             // shows next page on button click
    {
        Hidden[i] = true;
        Hidden[i+1] = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
