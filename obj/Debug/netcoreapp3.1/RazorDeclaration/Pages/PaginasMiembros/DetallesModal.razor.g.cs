#pragma checksum "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DetallesModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "809e2cf88a189b8fa126325a53d3ca22e23f58e2"
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
#line 1 "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DetallesModal.razor"
using MiembrosIglesia.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DetallesModal.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public partial class DetallesModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 268 "/home/itachi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DetallesModal.razor"
 
  [Parameter]
      public string Id { get; set; }
      [Parameter]
      public DatosMiembrosIglesia ts { get; set; }
      private bool personal = true;
      private bool Familiares = false;

      private bool Laborales = false;

      private bool Eclesiasticos = false;

      private bool Academico = false;

      private void viewDetails()
      {
          personal = true;
          Familiares = false;
          Laborales = false;
          Eclesiasticos = false;
          Academico = false;
      }

      private void VerDatosFamiliares()
      {
          personal = false;
          Familiares = true;
          Laborales = false;
          Eclesiasticos = false;
          Academico = false;
      }

      private void VerDatosLaborales()
      {
          personal = false;
          Familiares = false;
          Laborales = true;
          Eclesiasticos = false;
          Academico = false;
      }

      private void VerDatosEclesiasticos()
      {
          personal = false;
          Familiares = false;
          Laborales = false;
          Eclesiasticos = true;
          Academico = false;
      }

    private void VerDatosAcademicos()
      {
          personal = false;
          Familiares = false;
          Laborales = false;
          Eclesiasticos = false;
          Academico = true;
    }

      private async Task MostrarDetallesPersonales()
      {
          await iJSRuntime.InvokeVoidAsync("MostrarDetallesPersonales");
      }

      private async Task MostrarDetallesFamiliares()
      {
          await iJSRuntime.InvokeVoidAsync("MostrarDetallesFamiliares");
      }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime iJSRuntime { get; set; }
    }
}
#pragma warning restore 1591
