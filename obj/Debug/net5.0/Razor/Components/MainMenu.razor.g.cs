#pragma checksum "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/MainMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "521388ffc07265d90c49950cfa5b472d41dc6153"
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
    public partial class MainMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "main-wrapper");
            __builder.AddAttribute(2, "class", "split-container abs-fs");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "side-left bg-cover");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "id", "intro-content");
            __builder.AddAttribute(11, "class", "col-lg-6 vflow bg-cover");
            __builder.AddMarkupContent(12, "<div class=\"st-logo\"><img src=\"../img/logo.png\" alt=\"ZooBreakout!\"></div>\n\n\t\t\t\t\t\t");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "st-desc");
            __builder.AddMarkupContent(15, "<h2 class=\"fw600\">CS 4500, Fall 2021</h2>\n\t\t\t\t\t\t\t");
            __builder.AddMarkupContent(16, @"<p><b>GROUP NAME:</b> The Flying Purple Monkeys<br>
                                <b>GROUP MEMBERS:</b> Tony Urschler, Tyler Ziggas, Andrew Ziggas, Theodore Nesham, Ahmed Aljorani<br>
                                <b>TEAM LEADER:</b> Tony Urschler<br></p>");
#nullable restore
#line 20 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/MainMenu.razor"
                             if (PopupHidden)
							{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "p");
            __builder.OpenElement(18, "a");
            __builder.AddAttribute(19, "class", "st-btn btn-fill");
            __builder.AddAttribute(20, "data-toggle", "modal");
            __builder.AddAttribute(21, "data-target", "#");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/MainMenu.razor"
                                                    () => ShowPopup(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Story Mode");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n\t\t\t\t\t\t\t\t\t");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "class", "st-btn btn-fill");
            __builder.AddAttribute(27, "data-toggle", "modal");
            __builder.AddAttribute(28, "data-target", "#");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/MainMenu.razor"
                                                    () => ShowPopup(2)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Infinite Mode");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n\t\t\t\t\t\t\t\t\t");
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "class", "st-btn btn-fill");
            __builder.AddAttribute(34, "data-toggle", "modal");
            __builder.AddAttribute(35, "data-target", "#");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/MainMenu.razor"
                                                    () => AboutChosen.InvokeAsync(true)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "About Us");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/MainMenu.razor"
							}
							else
							{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "main-menu-input align-content-start align-content align-middle");
            __builder.AddMarkupContent(40, "<h4 class=\"display-5\" style=\"margin:auto;padding-right:15px;\">Please Enter your name!</h4>\n\t\t\t\t\t\t\t\t\t");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "input-group mb-3");
            __builder.AddAttribute(43, "style", "width:20em;margin:auto;");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "style", "width:20em;");
            __builder.AddAttribute(46, "type", "text");
            __builder.AddAttribute(47, "class", "form-control");
            __builder.AddAttribute(48, "placeholder", "Name");
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/MainMenu.razor"
                                                   Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Name = __value, Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/MainMenu.razor"
                                     if (Decision == 1)
									{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "type", "button");
            __builder.AddAttribute(53, "class", "btn btn-light");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/MainMenu.razor"
                                                      () => StoryChosen.InvokeAsync(Name)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(55, "Continue");
            __builder.CloseElement();
#nullable restore
#line 43 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/MainMenu.razor"
									}
									else
									{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(56, "button");
            __builder.AddAttribute(57, "type", "button");
            __builder.AddAttribute(58, "class", "btn btn-light");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/MainMenu.razor"
                                                      () => InfiniteChosen.InvokeAsync(Name)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(60, "Continue");
            __builder.CloseElement();
#nullable restore
#line 48 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/MainMenu.razor"
									}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 50 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/MainMenu.razor"
							}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n\n\t\t\t\t\t\t<div class=\"st-footer\"></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "/Users/anthony/Documents/GitHub/CS4500_Group4/Components/MainMenu.razor"
       
    [Parameter]
    public EventCallback<string> StoryChosen { get; set; }
    [Parameter]
    public EventCallback<string> InfiniteChosen { get; set; }
    [Parameter]
    public EventCallback<bool> AboutChosen { get; set; }
	public bool PopupHidden { get; set; } = true;
	public string Name { get; set; } = "";
	public int Decision { get; set; }

	public void ShowPopup(int option)
	{
		Decision = option;
		PopupHidden = false;
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
