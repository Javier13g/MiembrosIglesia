#pragma checksum "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/AggMiembros.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8eab9a1908b9c60685c3c0cc8b9b36dcedc594c"
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
#line 1 "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/AggMiembros.razor"
using MiembrosIglesia.Data;

#line default
#line hidden
#nullable disable
    public partial class AggMiembros : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 450 "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/AggMiembros.razor"
 
    [Parameter]
    public Guid Uid { get; set; }
    private DatosMiembrosIglesia datos = new DatosMiembrosIglesia
    {
        Id = Guid.NewGuid(),
        FechaNacimientoPersona = DateTime.Today,
        FechaAceptacion = DateTime.Today,
        FechaBautismo = DateTime.Today,
        FechaConversion = DateTime.Today
    };

    private async Task HandleSubmit()
    {
        Console.WriteLine("Se Inicio El Guardado");
        var status = await IST.SetMiembros(datos);
        if (status)
        {
            datos = new DatosMiembrosIglesia
            {
                Id = Guid.NewGuid(),
                FechaNacimientoPersona = DateTime.Today,
                FechaAceptacion = DateTime.Today,
                FechaBautismo = DateTime.Today,
                FechaConversion = DateTime.Today
            };
            StateHasChanged();
        }
        Console.WriteLine(status)
    ; Console.WriteLine("Finalizo El Guardado");

    }

    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            if (Uid != null)
            {
                datos.Id_Usuario = Uid;
            }
        }
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
    
    private async Task AlertGuardarMiembros()
    {
        await iJSRuntime.InvokeVoidAsync("AlertGuardarMiembros");
    }







#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioIglesia IST { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime iJSRuntime { get; set; }
    }
}
#pragma warning restore 1591
