#pragma checksum "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Pages\PassengerFields.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "142ab744406bba92482c8ac91007e2264f7c0a95"
// <auto-generated/>
#pragma warning disable 1591
namespace FlightManagementBlazorServer.Pages
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
    public partial class PassengerFields : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "passengerFields");
            __builder.AddMarkupContent(2, "<label for=\"passengerName\">Name</label>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(3);
            __builder.AddAttribute(4, "id", "passengerName");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Pages\PassengerFields.razor"
                                                Passenger.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Passenger.Name = __value, Passenger.Name))));
            __builder.AddAttribute(8, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Passenger.Name));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n\r\n    ");
            __builder.AddMarkupContent(10, "<label for=\"passengerSurname\">Surname</label>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
            __builder.AddAttribute(12, "id", "passengerSurname");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Pages\PassengerFields.razor"
                                                   Passenger.Surname

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Passenger.Surname = __value, Passenger.Surname))));
            __builder.AddAttribute(16, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Passenger.Surname));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n\r\n    ");
            __builder.AddMarkupContent(18, "<label for=\"gender\">Gender</label>\r\n    ");
            __Blazor.FlightManagementBlazorServer.Pages.PassengerFields.TypeInference.CreateInputSelect_0(__builder, 19, 20, "gender", 21, "form-control", 22, 
#nullable restore
#line 9 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Pages\PassengerFields.razor"
                                           Passenger.Gender

#line default
#line hidden
#nullable disable
            , 23, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Passenger.Gender = __value, Passenger.Gender)), 24, () => Passenger.Gender, 25, (__builder2) => {
                __builder2.AddMarkupContent(26, "<option value>Select...</option>");
#nullable restore
#line 11 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Pages\PassengerFields.razor"
         foreach(var gender in genders)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(27, "option");
                __builder2.AddAttribute(28, "value", 
#nullable restore
#line 13 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Pages\PassengerFields.razor"
                            gender

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 13 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Pages\PassengerFields.razor"
__builder2.AddContent(29, gender);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 14 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Pages\PassengerFields.razor"
        }

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\andre\Desktop\JuniorDEV\Projekt\FlightManagementBlazorServer\Pages\PassengerFields.razor"
       

    [Parameter]
    public Passenger Passenger { get; set; }
    public string[] genders = { "Male", "Female" };


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.FlightManagementBlazorServer.Pages.PassengerFields
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
