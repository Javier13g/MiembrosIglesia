<<<<<<< HEAD
#pragma checksum "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DatosMiembros.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaf45c981943b838366e5babf378f54e32bd3f8d"
=======
#pragma checksum "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DatosMiembros.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1faf59e1290eed2dd312c0acec34c55dee126b0"
>>>>>>> master
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
<<<<<<< HEAD
#line 4 "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DatosMiembros.razor"
=======
#line 3 "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DatosMiembros.razor"
>>>>>>> master
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
<<<<<<< HEAD
#line 514 "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DatosMiembros.razor"
=======
#line 40 "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DatosMiembros.razor"
>>>>>>> master
 
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
<<<<<<< HEAD
        AlertBorrarMiembros();
=======
>>>>>>> master
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
<<<<<<< HEAD
    DatosMiembrosIglesia ActualizarMiembros = new DatosMiembrosIglesia();
    
    private void SetM(DatosMiembrosIglesia rv)
    {
        ActualizarMiembros = rv;
    }
    
    private async Task HandleSubmit()
    {
        await IST.EditarMiembros(ActualizarMiembros);
    }
    
    private async Task AlertBorrarMiembros()
    {
        await iJSRuntime.InvokeVoidAsync("AlertBorrarMiembros");
    }
    
    /*LLAMADA FUNCIONES JAVASCRIPT*/
    private async Task MostrarDatosFamiliares()
    {
        await iJSRuntime.InvokeVoidAsync("MostrarDatosFamiliares");
    }

    private async Task MostrarDatosPersonales()
    {
        await iJSRuntime.InvokeVoidAsync("MostrarDatosPersonales");
    }

    private async Task MostrarDatosLaborales()
    {
        await iJSRuntime.InvokeVoidAsync("MostrarDatosLaborales");
    }

    private async Task MostrarDatosEclesiasticos()
    {
        await iJSRuntime.InvokeVoidAsync("MostrarDatosEclesiasticos");
    } /*MostrarDatosAcademicos*/

    private async Task MostrarDatosAcademicos()
    {
        await iJSRuntime.InvokeVoidAsync("MostrarDatosAcademicos");
    }

    private async Task MostrarInputCiudad()
    {
        await iJSRuntime.InvokeVoidAsync("MostrarInputCiudad");
    }

    private async Task MostrarInputCiudadActual()
    {
        await iJSRuntime.InvokeVoidAsync("MostrarInputCiudadActual");
    }

    private async Task MostrarDocumentoID()
    {
        await iJSRuntime.InvokeVoidAsync("MostrarDocumentoID");
    }

    private async Task MostrarInputConyugue() /*MostrarInputDenominacion*/
    {
        await iJSRuntime.InvokeVoidAsync("MostrarInputConyugue");
    }

    private async Task MostrarInputDenominacion()
    {
        await iJSRuntime.InvokeVoidAsync("MostrarInputDenominacion");
    }

    private async Task MostrarInputHijos()
    {
        await iJSRuntime.InvokeVoidAsync("MostrarInputHijos");
    }

    private async Task MostrarInputDisciplina()
    {
        await iJSRuntime.InvokeVoidAsync("MostrarInputDisciplina");
    }

    private async Task MostrarInputCausas()
    {
        await iJSRuntime.InvokeVoidAsync("MostrarInputCausas");
    }
    private async Task Mostrar2() /*MostrarInputDisciplina*/
    {
        await iJSRuntime.InvokeVoidAsync("Mostrar2");

    }
    
    public class NombrePaises
    {
        public string Paises { get; set; }
    }

    List<NombrePaises> ListaPaises = new List<NombrePaises>()
    {
        new NombrePaises() {Paises = "Republica Dominicana"},
        new NombrePaises() {Paises = "Colombia"},
    };
=======
>>>>>>> master

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<Usuarios> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<Usuarios> SignInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime iJSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioIglesia IST { get; set; }
    }
}
#pragma warning restore 1591
