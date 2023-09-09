#pragma checksum "D:\WebServer\WebServer\BlazorApp\BlazorApp\Pages\User.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5415c392c6f92bf131be07080c1a5cd20d6af866"
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
#line 1 "D:\WebServer\WebServer\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WebServer\WebServer\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WebServer\WebServer\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\WebServer\WebServer\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\WebServer\WebServer\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\WebServer\WebServer\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\WebServer\WebServer\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\WebServer\WebServer\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\WebServer\WebServer\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WebServer\WebServer\BlazorApp\BlazorApp\Pages\User.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/user")]
    public partial class User : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Online Users</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n\tUsers : ");
            __builder.OpenElement(3, "b");
#nullable restore
#line 8 "D:\WebServer\WebServer\BlazorApp\BlazorApp\Pages\User.razor"
__builder.AddContent(4, _users.Count());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n<br>\r\n\r\n");
            __builder.OpenElement(7, "ul");
            __builder.AddAttribute(8, "class", "list-group");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 14 "D:\WebServer\WebServer\BlazorApp\BlazorApp\Pages\User.razor"
     foreach(UserData user in _users )
	{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "\t\t");
            __builder.OpenElement(11, "li");
            __builder.AddAttribute(12, "class", "list-group-item");
            __builder.SetKey(
#nullable restore
#line 16 "D:\WebServer\WebServer\BlazorApp\BlazorApp\Pages\User.razor"
                  user

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, "\r\n\t\t\t");
            __builder.OpenElement(14, "label");
#nullable restore
#line 17 "D:\WebServer\WebServer\BlazorApp\BlazorApp\Pages\User.razor"
__builder.AddContent(15, user.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 19 "D:\WebServer\WebServer\BlazorApp\BlazorApp\Pages\User.razor"
	}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n<br>\r\n\r\n");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "container");
            __builder.AddMarkupContent(21, "\r\n\t");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "row");
            __builder.AddMarkupContent(24, "\r\n\t\t");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col");
            __builder.AddMarkupContent(27, "\r\n\t\t\t");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "class", "fomr-control");
            __builder.AddAttribute(30, "placeholder", "Add User");
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "D:\WebServer\WebServer\BlazorApp\BlazorApp\Pages\User.razor"
                                                                            _inputName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _inputName = __value, _inputName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\t\t");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "col");
            __builder.AddMarkupContent(37, "\r\n\t\t\t");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "class", "btn btn-primary");
            __builder.AddAttribute(40, "type", "button");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "D:\WebServer\WebServer\BlazorApp\BlazorApp\Pages\User.razor"
                                                                    AddUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "Add a User");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "D:\WebServer\WebServer\BlazorApp\BlazorApp\Pages\User.razor"
       
	List<UserData> _users = new List<UserData>();

	string _inputName;

	protected override void OnInitialized()
	{
		_users.Add(new UserData() { Name = "Floyd" });
		_users.Add(new UserData() { Name = "Faker" });
		_users.Add(new UserData() { Name = "Deft" });
	}

	void AddUser() {
		_users.Add(new UserData() {Name = _inputName});
		_inputName = "";
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
