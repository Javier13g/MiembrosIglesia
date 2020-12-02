﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiembrosIglesia.Data;

namespace MiembrosIglesia.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201128030743_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MiembrosIglesia.Data.DatosMiembrosIglesia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ApellidoPersona")
                        .HasColumnType("TEXT");

                    b.Property<string>("CausaDisciplina")
                        .HasColumnType("TEXT");

                    b.Property<string>("CelularPersona")
                        .HasColumnType("TEXT");

                    b.Property<string>("CiudadActualPersona")
                        .HasColumnType("TEXT");

                    b.Property<string>("CiudadOrigenPersona")
                        .HasColumnType("TEXT");

                    b.Property<string>("Denominacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("DireccionPersona")
                        .HasColumnType("TEXT");

                    b.Property<string>("Disciplinado")
                        .HasColumnType("TEXT");

                    b.Property<string>("DocumentoIdentidad")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailPersona")
                        .HasColumnType("TEXT");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("TEXT");

                    b.Property<string>("Expulsion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaAceptacion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaBautismo")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaConversion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimientoPersona")
                        .HasColumnType("TEXT");

                    b.Property<string>("FuncionesIglesia")
                        .HasColumnType("TEXT");

                    b.Property<string>("Hijos")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Id_Usuario")
                        .HasColumnType("TEXT");

                    b.Property<string>("IglesiaAnterior")
                        .HasColumnType("TEXT");

                    b.Property<string>("LlamadoDios")
                        .HasColumnType("TEXT");

                    b.Property<string>("MetasVida")
                        .HasColumnType("TEXT");

                    b.Property<string>("MinisterioExito")
                        .HasColumnType("TEXT");

                    b.Property<string>("MinisteriosServidos")
                        .HasColumnType("TEXT");

                    b.Property<string>("NivelEstudio")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreConyuge")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreEmpresa")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreIglesia")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombrePastor")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombrePersona")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroHijos")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroVeces")
                        .HasColumnType("TEXT");

                    b.Property<string>("OcupacionPersona")
                        .HasColumnType("TEXT");

                    b.Property<string>("PaisActualPersona")
                        .HasColumnType("TEXT");

                    b.Property<string>("PaisOrigenPersona")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProfesionPersona")
                        .HasColumnType("TEXT");

                    b.Property<string>("RazonExpulsion")
                        .HasColumnType("TEXT");

                    b.Property<string>("RespaldoAuto")
                        .HasColumnType("TEXT");

                    b.Property<string>("SexoPersona")
                        .HasColumnType("TEXT");

                    b.Property<string>("TelefonoEmpresa")
                        .HasColumnType("TEXT");

                    b.Property<string>("TelefonoPersona")
                        .HasColumnType("TEXT");

                    b.Property<string>("TiempoAsistencia")
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoDocumento")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DatosMiembros");
                });

            modelBuilder.Entity("MiembrosIglesia.Data.Usuarios", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Color_Usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasMaxLength(8)
                        .HasDefaultValue("#ffffff");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("Id_Usuario")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre_Usuario")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("USUARIOS");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MiembrosIglesia.Data.Usuarios", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MiembrosIglesia.Data.Usuarios", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MiembrosIglesia.Data.Usuarios", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MiembrosIglesia.Data.Usuarios", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}