#pragma checksum "/home/javi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DatosMiembros.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91afc376cabe283a3f90a144e32265366f51a1e6"
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
#line 8 "/home/javi/Documentos/GitHub/MiembrosIglesia/Pages/PaginasMiembros/DatosMiembros.razor"
 
    [Parameter]
    public Guid Uid { get; set; }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<Usuarios> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<Usuarios> SignInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioIglesia IST { get; set; }
    }
}
#pragma warning restore 1591