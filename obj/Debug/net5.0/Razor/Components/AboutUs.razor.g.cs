#pragma checksum "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/AboutUs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88cd5728e0b41a1488a52b3c1ebbedfcf6b7cd97"
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
    public partial class AboutUs : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "width:99%;");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col");
            __builder.AddMarkupContent(6, @"<div class=""about-div""><h1 class=""display-3"">About Us</h1><br>
                <p>
                    We are a collection of students from the University of Missouri - St. Louis who are 
                    passionate about software development. Our team had to decide between ## different 
                    game ideas for our final project. We ended up choosing to develop ""The Card Flipping Game"", 
                    because we felt that it was possible to make this game both fun and educational.
                    Please check out the original video <a href=""https://www.numberphile.com/videos/card-flipping-proof?rq=game"">here.</a></p></div>
            ");
            __builder.AddMarkupContent(7, @"<div class=""about-div""><h1 class=""display-3"">Credit and References</h1><br>
                <p>
                    Sound effects:<br>
                    <a href=""https://www.fiftysounds.com/"">sfx-paperflip1.mp3</a><br>
                    <a href=""https://www.fiftysounds.com/"">sfx-victory5.mp3</a><br>
                    <a href=""https://www.fiftysounds.com/"">sfx-defeat4.mp3</a><br><br>
                    Graphics:<br>
                    <a href=""https://www.flaticon.com/authors/pixel-perfect"">Remove image</a><br>
                    <a href=""https://www.flaticon.com/authors/alfredo-hernandez"">Check mark image</a><br>
                    <a href=""https://www.flaticon.com/free-icon/down-arrow_892629?term=arrow%20down&page=2&position=66&page=2&position=66&related_id=892629&origin=search"">Down Arrow</a><br></p></div>
            ");
            __builder.OpenElement(8, "a");
            __builder.AddAttribute(9, "style", "margin:15px;");
            __builder.AddAttribute(10, "class", "st-btn btn-fill");
            __builder.AddAttribute(11, "data-toggle", "modal");
            __builder.AddAttribute(12, "data-target", "#");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/AboutUs.razor"
                            () => Back.InvokeAsync(true)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Back");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n        ");
            __builder.AddMarkupContent(16, "<div class=\"col\"><img src=\"../img/bg.png\" alt=\"Infographic\" width=\"60%\"></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/AboutUs.razor"
       
    [Parameter]
    public EventCallback<bool> Back { get; set; }   // returns true on button click

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
