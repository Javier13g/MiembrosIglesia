#pragma checksum "/home/javi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DatosMiembros.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3d42c9fa5217d5b4bea0f2869391ae9997ebd63"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MiembrosIglesia.Pages.PaginasMiembros
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/javi/Documentos/GitHub/MiembrosIglesia/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/javi/Documentos/GitHub/MiembrosIglesia/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/javi/Documentos/GitHub/MiembrosIglesia/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/javi/Documentos/GitHub/MiembrosIglesia/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/javi/Documentos/GitHub/MiembrosIglesia/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/javi/Documentos/GitHub/MiembrosIglesia/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/javi/Documentos/GitHub/MiembrosIglesia/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/javi/Documentos/GitHub/MiembrosIglesia/_Imports.razor"
using MiembrosIglesia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/javi/Documentos/GitHub/MiembrosIglesia/_Imports.razor"
using MiembrosIglesia.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/javi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DatosMiembros.razor"
using MiembrosIglesia.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/javi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DatosMiembros.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    public partial class DatosMiembros : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "/home/javi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DatosMiembros.razor"
 
    [Parameter]
    public Guid Uid { get; set; }

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    private string bColor = "#ffffff";

    private Usuarios user = new Usuarios();

    protected override async Task OnInitializedAsync()
    {
        var authState = await authenticationStateTask;
        user = await UserManager.GetUserAsync(authState.User);
        Uid = user.Id_Usuario;
        bColor = user.Color_Usuario;
    }

    List<DatosMiembrosIglesia> miembrosIglesias = new List<DatosMiembrosIglesia>();
    DatosMiembrosIglesia ModalT = new DatosMiembrosIglesia();
    private string modalId = "MiembroModalDetalle";
    private void SetMiembrosModal(DatosMiembrosIglesia t)
    {
        ModalT = t;
    }
    protected override async Task OnParametersSetAsync()
    {
        await Load();
        StateHasChanged();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        //if(firstRender)
        StateHasChanged();
        await Load();
    }

    private async Task Load()
    {
        if (Uid != null)
            miembrosIglesias = await IST.GetAllMiembros(Uid);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<Usuarios> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<Usuarios> SignInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioIglesia IST { get; set; }
    }
}
#pragma warning restore 1591
