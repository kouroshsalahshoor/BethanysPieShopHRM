#pragma checksum "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\Pages\Employees\EmployeeSelection.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8220264fec8b6dad60b5f2e4809c03372aa2bead"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BethanysPieShopHRM.Pages.Employees
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using BethanysPieShopHRM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using BethanysPieShopHRM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using BethanysPieShopHRM.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using BethanysPieShopHRM.Infrastructure;

#line default
#line hidden
#nullable disable
    public partial class EmployeeSelection : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\k.salahshoor\Desktop\BethanysPieShopHRM\BethanysPieShopHRM\Pages\Employees\EmployeeSelection.razor"
       
    public Employee _recievedItem { get; set; }
    [Parameter] public EventCallback<Employee> SelectionCallBack { get; set; }

    private async Task RecieverAsync(Employee recievedItem)
    {
        _recievedItem = recievedItem;

        await closeAsync();
    }

    private bool _show { get; set; }

    public void Show()
    {
        _show = true;
        StateHasChanged();
    }
    private async Task closeAsync()
    {
        await SelectionCallBack.InvokeAsync(_recievedItem);

        _show = false;
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
