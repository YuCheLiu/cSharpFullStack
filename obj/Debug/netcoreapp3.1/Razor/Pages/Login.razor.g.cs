#pragma checksum "K:\full-structure\BlazorApp\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c2b3e1e490925a9940829811318e131e09b9c63"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "K:\full-structure\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "K:\full-structure\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "K:\full-structure\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "K:\full-structure\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "K:\full-structure\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "K:\full-structure\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "K:\full-structure\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "K:\full-structure\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "K:\full-structure\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "K:\full-structure\BlazorApp\Pages\Login.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#nullable restore
#line 6 "K:\full-structure\BlazorApp\Pages\Login.razor"
     change

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "p");
            __builder.AddContent(4, "hello ");
            __builder.AddContent(5, 
#nullable restore
#line 7 "K:\full-structure\BlazorApp\Pages\Login.razor"
          db.connectDB()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
#nullable restore
#line 9 "K:\full-structure\BlazorApp\Pages\Login.razor"
 if (@change==1)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.OpenElement(8, "p");
            __builder.AddContent(9, "Welcome member ");
            __builder.AddContent(10, 
#nullable restore
#line 11 "K:\full-structure\BlazorApp\Pages\Login.razor"
                       member.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, "~~");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "p");
            __builder.AddContent(14, " You have ");
            __builder.AddContent(15, 
#nullable restore
#line 12 "K:\full-structure\BlazorApp\Pages\Login.razor"
                  member.Order

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "K:\full-structure\BlazorApp\Pages\Login.razor"
                      logout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "Logout ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 14 "K:\full-structure\BlazorApp\Pages\Login.razor"
}
else{

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "    ");
            __builder.AddMarkupContent(23, "<label for=\"fname\">Account:</label>\r\n    ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "text");
            __builder.AddAttribute(26, "id", "account");
            __builder.AddAttribute(27, "name", "account");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "K:\full-structure\BlazorApp\Pages\Login.razor"
                               account

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => account = __value, account));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "<br><br>\r\n    ");
            __builder.AddMarkupContent(31, "<label for=\"lname\">Password:</label>\r\n    ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "type", "text");
            __builder.AddAttribute(34, "id", "password");
            __builder.AddAttribute(35, "name", "password");
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "K:\full-structure\BlazorApp\Pages\Login.razor"
                               password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "<br><br>\r\n    ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "class", "btn btn-primary");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "K:\full-structure\BlazorApp\Pages\Login.razor"
                                              login

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 21 "K:\full-structure\BlazorApp\Pages\Login.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "K:\full-structure\BlazorApp\Pages\Login.razor"
       
    private string account;
    private string password;

    private int change { get; set; } = 1;

    private MemberData member;

    
    async Task login()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "K:\full-structure\BlazorApp\Pages\Login.razor"
                                             
        lo.setlogin(1);
        change= lo.getlogin();
        this.member = await db.querymember();
    }
    
    protected override async Task OnInitializedAsync()
    {
    
        db.connectDB();
        db.createDB();
        db.createNewMember();
        this.change = await lo.GetLoginAsync();        
    }
    void logout(){
        lo.setlogin(0);
        change= lo.getlogin();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SqliteService db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LoginService lo { get; set; }
    }
}
#pragma warning restore 1591
