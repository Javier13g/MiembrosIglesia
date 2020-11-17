#pragma checksum "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DatosMiembros.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1faf59e1290eed2dd312c0acec34c55dee126b0"
// <auto-generated/>
#pragma warning disable 1591
namespace MiembrosIglesia.Pages.PaginasMiembros
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/itachi/Documentos/GitHub/MiembrosIglesia/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/itachi/Documentos/GitHub/MiembrosIglesia/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/itachi/Documentos/GitHub/MiembrosIglesia/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/itachi/Documentos/GitHub/MiembrosIglesia/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/itachi/Documentos/GitHub/MiembrosIglesia/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/itachi/Documentos/GitHub/MiembrosIglesia/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/itachi/Documentos/GitHub/MiembrosIglesia/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/itachi/Documentos/GitHub/MiembrosIglesia/_Imports.razor"
using MiembrosIglesia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/itachi/Documentos/GitHub/MiembrosIglesia/_Imports.razor"
using MiembrosIglesia.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DatosMiembros.razor"
using MiembrosIglesia.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DatosMiembros.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    public partial class DatosMiembros : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\n    ");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "\n        ");
            __builder.AddMarkupContent(5, "<thead>\n            <th>Id miembro</th>\n        <th>Datos</th>\n        <th>Opciones</th>\n        </thead>\n        ");
            __builder.OpenElement(6, "tbody");
            __builder.AddMarkupContent(7, "\n");
#nullable restore
#line 15 "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DatosMiembros.razor"
             if(miembrosIglesias.Count > 0){
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DatosMiembros.razor"
                 foreach (DatosMiembrosIglesia T in miembrosIglesias)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "                ");
            __builder.OpenElement(9, "tr");
            __builder.AddMarkupContent(10, "\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 19 "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DatosMiembros.razor"
                         T.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n                    ");
            __builder.OpenElement(14, "td");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "data-toggle", "modal");
            __builder.AddAttribute(17, "data-target", "#MiembroModalDetalle");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DatosMiembros.razor"
                                          (() => SetMiembrosModal(T))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "class", "btn btn-link");
            __builder.AddContent(20, "Informacion Miembros");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                    ");
            __builder.OpenElement(22, "td");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", "btn btn-danger");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DatosMiembros.razor"
                                                                 (() => BorrarMiembros2(T))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Borrar Miembro");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "   \n");
#nullable restore
#line 26 "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DatosMiembros.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DatosMiembros.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n\n\n");
            __builder.OpenComponent<MiembrosIglesia.Pages.PaginasMiembros.DetallesModal>(33);
            __builder.AddAttribute(34, "Id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DatosMiembros.razor"
                    modalId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "ts", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MiembrosIglesia.Data.DatosMiembrosIglesia>(
#nullable restore
#line 33 "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DatosMiembros.razor"
                                  ModalT

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DatosMiembros.razor"
 
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
    
    
    private async Task BorrarMiembros2(DatosMiembrosIglesia ReporteD )
    {
        await IST.DeleteMiembros(ReporteD);
    }

    private DatosMiembrosIglesia datos = new DatosMiembrosIglesia();
    private async Task BorrarMiembros(DatosMiembrosIglesia t)
    {
        Console.WriteLine("Se Inicio El borrado");
        var status = await IST.DeleteMiembros(datos);
        
        if (status)
        {
            StateHasChanged();
        }
        Console.WriteLine(status)
            ; Console.WriteLine("Finalizo El Guardado");

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
