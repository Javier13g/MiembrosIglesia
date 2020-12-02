using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MiembrosIglesia.Data
{
    public class ApplicationDbContext : IdentityDbContext<Usuarios>
    {
        public DbSet<Usuarios> UsuariosApps { get; set; }

        public DbSet<DatosMiembrosIglesia> DatosMiembros { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Usuarios>(entityTypeBuilder =>
            {
                entityTypeBuilder.ToTable("USUARIOS");
                entityTypeBuilder.Property(u => u.Id_Usuario).HasMaxLength(100).IsRequired();
                entityTypeBuilder.Property(u => u.Nombre_Usuario).HasMaxLength(100);
                entityTypeBuilder.Property(u => u.Color_Usuario).HasMaxLength(8).HasDefaultValue("#ffffff");
            });
        }
    }

    public class Usuarios : IdentityUser
    {
        public Guid Id_Usuario { get; set; }

        public string Nombre_Usuario { get; set; }

        public string Color_Usuario { get; set; }
    }

    public class DatosMiembrosIglesia
    {
        public Guid Id_Usuario { get; set; }

        public Guid Id { get; set; }

        /*DATOS PERSONALES*/
        public string SexoPersona { get; set; }
        

        public string NombrePersona { get; set; }

        public string ApellidoPersona { get; set; }

        public DateTime FechaNacimientoPersona { get; set; }

        public string PaisOrigenPersona { get; set; }

        public string CiudadOrigenPersona { get; set; }

        public string PaisActualPersona { get; set; }

        public string CiudadActualPersona { get; set; }

        public string DireccionPersona { get; set; }

        public string TelefonoPersona { get; set; }

        public string CelularPersona { get; set; }

        public string EmailPersona { get; set; }

        public string TipoDocumento { get; set; }

        public string DocumentoIdentidad { get; set; }

        /*DATOS FAMILIARES*/

        public string EstadoCivil { get; set; }

        public string NombreConyuge { get; set; }

        public string Hijos { get; set; }

        public string NumeroHijos { get; set; }

        /*DATOS LABORALES*/

        public string ProfesionPersona { get; set; }

        public string OcupacionPersona { get; set; }

        public string NombreEmpresa { get; set; }

        public string TelefonoEmpresa { get; set; }

        /*DATOS ECLESIASTICOS*/

        public DateTime FechaConversion { get; set; }

        public DateTime FechaBautismo { get; set; }

        public DateTime FechaAceptacion { get; set; }

        public string Denominacion { get; set; }

        public string NombreIglesia { get; set; }

        public string TiempoAsistencia { get; set; }

        public string IglesiaAnterior { get; set; }

        public string NombrePastor { get; set; }

        public string Disciplinado { get; set; }

        public string NumeroVeces { get; set; }

        public string CausaDisciplina { get; set; }

        public string FuncionesIglesia { get; set; }

        public string MinisteriosServidos { get; set; }

        public string MinisterioExito { get; set; }

        public string LlamadoDios { get; set; }

        public string MetasVida { get; set; }

        public string RespaldoAuto { get; set; }

        /*DATOS ACADEMICOS*/

        public string NivelEstudio { get; set; }

        public string Expulsion { get; set; }

        public string RazonExpulsion { get; set; }
    }


}

