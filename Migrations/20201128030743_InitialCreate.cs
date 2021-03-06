﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiembrosIglesia.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DatosMiembros",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Id_Usuario = table.Column<Guid>(nullable: false),
                    SexoPersona = table.Column<string>(nullable: true),
                    NombrePersona = table.Column<string>(nullable: true),
                    ApellidoPersona = table.Column<string>(nullable: true),
                    FechaNacimientoPersona = table.Column<DateTime>(nullable: false),
                    PaisOrigenPersona = table.Column<string>(nullable: true),
                    CiudadOrigenPersona = table.Column<string>(nullable: true),
                    PaisActualPersona = table.Column<string>(nullable: true),
                    CiudadActualPersona = table.Column<string>(nullable: true),
                    DireccionPersona = table.Column<string>(nullable: true),
                    TelefonoPersona = table.Column<string>(nullable: true),
                    CelularPersona = table.Column<string>(nullable: true),
                    EmailPersona = table.Column<string>(nullable: true),
                    TipoDocumento = table.Column<string>(nullable: true),
                    DocumentoIdentidad = table.Column<string>(nullable: true),
                    EstadoCivil = table.Column<string>(nullable: true),
                    NombreConyuge = table.Column<string>(nullable: true),
                    Hijos = table.Column<string>(nullable: true),
                    NumeroHijos = table.Column<string>(nullable: true),
                    ProfesionPersona = table.Column<string>(nullable: true),
                    OcupacionPersona = table.Column<string>(nullable: true),
                    NombreEmpresa = table.Column<string>(nullable: true),
                    TelefonoEmpresa = table.Column<string>(nullable: true),
                    FechaConversion = table.Column<DateTime>(nullable: false),
                    FechaBautismo = table.Column<DateTime>(nullable: false),
                    FechaAceptacion = table.Column<DateTime>(nullable: false),
                    Denominacion = table.Column<string>(nullable: true),
                    NombreIglesia = table.Column<string>(nullable: true),
                    TiempoAsistencia = table.Column<string>(nullable: true),
                    IglesiaAnterior = table.Column<string>(nullable: true),
                    NombrePastor = table.Column<string>(nullable: true),
                    Disciplinado = table.Column<string>(nullable: true),
                    NumeroVeces = table.Column<string>(nullable: true),
                    CausaDisciplina = table.Column<string>(nullable: true),
                    FuncionesIglesia = table.Column<string>(nullable: true),
                    MinisteriosServidos = table.Column<string>(nullable: true),
                    MinisterioExito = table.Column<string>(nullable: true),
                    LlamadoDios = table.Column<string>(nullable: true),
                    MetasVida = table.Column<string>(nullable: true),
                    RespaldoAuto = table.Column<string>(nullable: true),
                    NivelEstudio = table.Column<string>(nullable: true),
                    Expulsion = table.Column<string>(nullable: true),
                    RazonExpulsion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosMiembros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "USUARIOS",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Id_Usuario = table.Column<Guid>(maxLength: 100, nullable: false),
                    Nombre_Usuario = table.Column<string>(maxLength: 100, nullable: true),
                    Color_Usuario = table.Column<string>(maxLength: 8, nullable: true, defaultValue: "#ffffff")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_USUARIOS_UserId",
                        column: x => x.UserId,
                        principalTable: "USUARIOS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_USUARIOS_UserId",
                        column: x => x.UserId,
                        principalTable: "USUARIOS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_USUARIOS_UserId",
                        column: x => x.UserId,
                        principalTable: "USUARIOS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_USUARIOS_UserId",
                        column: x => x.UserId,
                        principalTable: "USUARIOS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "USUARIOS",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "USUARIOS",
                column: "NormalizedUserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DatosMiembros");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "USUARIOS");
        }
    }
}
