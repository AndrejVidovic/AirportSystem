#pragma checksum "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a595733a2a5cae54edb48100f33ed2b4fcd4d212"
// <auto-generated/>
#pragma warning disable 1591
namespace FlightManagementBlazorServer.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\_Imports.razor"
using DomainModel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\_Imports.razor"
using ValidationModels;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-px2dkll1ej");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href=\"FlightList\" b-px2dkll1ej>FlightManagement</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-px2dkll1ej");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-px2dkll1ej></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 11 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-px2dkll1ej");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-px2dkll1ej");
#nullable restore
#line 13 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Shared\NavMenu.razor"
          if (AppState.LoggedIn == null)
         {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-px2dkll1ej");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 16 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Shared\NavMenu.razor"
                                                             NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "<span class=\"oi oi-account-login\" aria-hidden=\"true\" b-px2dkll1ej></span> Login\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Shared\NavMenu.razor"
         }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Shared\NavMenu.razor"
             if (AppState.LoggedIn == "Admin" || AppState.LoggedIn == "CheckIn")
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "li");
            __builder.AddAttribute(27, "class", "nav-item px-3");
            __builder.AddAttribute(28, "b-px2dkll1ej");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(29);
            __builder.AddAttribute(30, "class", "nav-link");
            __builder.AddAttribute(31, "href", "FlightList");
            __builder.AddAttribute(32, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 24 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Shared\NavMenu.razor"
                                                                       NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(34, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-px2dkll1ej></span> Flights\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "li");
            __builder.AddAttribute(37, "class", "nav-item px-3");
            __builder.AddAttribute(38, "b-px2dkll1ej");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(39);
            __builder.AddAttribute(40, "class", "nav-link");
            __builder.AddAttribute(41, "href", "PassengersPage");
            __builder.AddAttribute(42, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 29 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Shared\NavMenu.razor"
                                                                           NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(44, "<span class=\"oi oi-people\" aria-hidden=\"true\" b-px2dkll1ej></span> Passengers\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "li");
            __builder.AddAttribute(47, "class", "nav-item px-3");
            __builder.AddAttribute(48, "b-px2dkll1ej");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(49);
            __builder.AddAttribute(50, "class", "nav-link");
            __builder.AddAttribute(51, "href", "CheckInPage");
            __builder.AddAttribute(52, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 34 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Shared\NavMenu.razor"
                                                                        NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(54, "<span class=\"oi oi-check\" aria-hidden=\"true\" b-px2dkll1ej></span> Check In\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.OpenElement(56, "li");
            __builder.AddAttribute(57, "class", "nav-item px-3");
            __builder.AddAttribute(58, "b-px2dkll1ej");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(59);
            __builder.AddAttribute(60, "class", "nav-link");
            __builder.AddAttribute(61, "href", "archivedFlightList");
            __builder.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(63, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-px2dkll1ej></span> Archived Flights\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Shared\NavMenu.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Shared\NavMenu.razor"
             if (AppState.LoggedIn == "Admin")
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(64, "li");
            __builder.AddAttribute(65, "class", "nav-item px-3");
            __builder.AddAttribute(66, "b-px2dkll1ej");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(67);
            __builder.AddAttribute(68, "class", "nav-link");
            __builder.AddAttribute(69, "href", "CarrierList");
            __builder.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(71, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-px2dkll1ej></span> Carriers\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.OpenElement(73, "li");
            __builder.AddAttribute(74, "class", "nav-item px-3");
            __builder.AddAttribute(75, "b-px2dkll1ej");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(76);
            __builder.AddAttribute(77, "class", "nav-link");
            __builder.AddAttribute(78, "href", "AddUser");
            __builder.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(80, "<span class=\"oi oi-person\" aria-hidden=\"true\" b-px2dkll1ej></span> New User\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 55 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Shared\NavMenu.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Shared\NavMenu.razor"
             if (AppState.LoggedIn == "Admin" || AppState.LoggedIn == "CheckIn")
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(81, "li");
            __builder.AddAttribute(82, "class", "nav-item px-3");
            __builder.AddAttribute(83, "b-px2dkll1ej");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(84);
            __builder.AddAttribute(85, "class", "nav-link");
            __builder.AddAttribute(86, "href", "Logout");
            __builder.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(88, "<span class=\"oi oi-account-logout\" aria-hidden=\"true\" b-px2dkll1ej></span> Logout\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 63 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Shared\NavMenu.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }
    protected override void OnInitialized()
    {
        AppState.OnChange += StateHasChanged;
    }

    public void Dispose()
    {
        AppState.OnChange -= StateHasChanged;
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState AppState { get; set; }
    }
}
#pragma warning restore 1591
