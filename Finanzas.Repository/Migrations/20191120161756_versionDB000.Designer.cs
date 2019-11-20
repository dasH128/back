﻿// <auto-generated />
using System;
using Finanzas.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Finanzas.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191120161756_versionDB000")]
    partial class versionDB000
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Finanzas.Entity.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("Finanzas.Entity.Distrito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.Property<int>("ProvinciaId");

                    b.HasKey("Id");

                    b.HasIndex("ProvinciaId");

                    b.ToTable("Distrito");
                });

            modelBuilder.Entity("Finanzas.Entity.Girado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Correo");

                    b.Property<int>("DepartamentoId");

                    b.Property<string>("Domicilio");

                    b.Property<string>("Telefono");

                    b.Property<string>("tipoCliente");

                    b.Property<string>("tipoDocumento");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Girado");
                });

            modelBuilder.Entity("Finanzas.Entity.GiradoEmpresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GiradoId");

                    b.Property<string>("RazonSocial");

                    b.Property<string>("Ruc");

                    b.HasKey("Id");

                    b.HasIndex("GiradoId");

                    b.ToTable("GiradoEmpresa");
                });

            modelBuilder.Entity("Finanzas.Entity.GiradoPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Dni");

                    b.Property<int>("GiradoId");

                    b.Property<string>("Nombre");

                    b.Property<string>("apellidoMaterno");

                    b.Property<string>("apellidoPaterno");

                    b.HasKey("Id");

                    b.HasIndex("GiradoId");

                    b.ToTable("DeGiradoPersonapartamento");
                });

            modelBuilder.Entity("Finanzas.Entity.Letra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartamentoId");

                    b.Property<int>("GiradoId");

                    b.Property<int>("MonedaId");

                    b.Property<int>("UsuarioId");

                    b.Property<DateTime>("fechaGiro");

                    b.Property<DateTime>("fechaVencimiento");

                    b.Property<float>("valorNominal");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.HasIndex("GiradoId");

                    b.HasIndex("MonedaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Letra");
                });

            modelBuilder.Entity("Finanzas.Entity.Moneda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.Property<string>("Valor");

                    b.HasKey("Id");

                    b.ToTable("Moneda");
                });

            modelBuilder.Entity("Finanzas.Entity.Provincia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartamentoId");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Provincia");
                });

            modelBuilder.Entity("Finanzas.Entity.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Clave");

                    b.Property<string>("Correo");

                    b.Property<string>("Direccion");

                    b.Property<int>("DistritoId");

                    b.Property<string>("RazonSocial");

                    b.Property<string>("Ruc");

                    b.Property<string>("Telefono");

                    b.HasKey("Id");

                    b.HasIndex("DistritoId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Finanzas.Entity.Distrito", b =>
                {
                    b.HasOne("Finanzas.Entity.Provincia", "Provincia")
                        .WithMany()
                        .HasForeignKey("ProvinciaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Finanzas.Entity.Girado", b =>
                {
                    b.HasOne("Finanzas.Entity.Departamento", "Departamento")
                        .WithMany()
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Finanzas.Entity.GiradoEmpresa", b =>
                {
                    b.HasOne("Finanzas.Entity.Girado", "Girado")
                        .WithMany()
                        .HasForeignKey("GiradoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Finanzas.Entity.GiradoPersona", b =>
                {
                    b.HasOne("Finanzas.Entity.Girado", "Girado")
                        .WithMany()
                        .HasForeignKey("GiradoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Finanzas.Entity.Letra", b =>
                {
                    b.HasOne("Finanzas.Entity.Departamento", "Departamento")
                        .WithMany()
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Finanzas.Entity.Girado", "Girado")
                        .WithMany()
                        .HasForeignKey("GiradoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Finanzas.Entity.Moneda", "Moneda")
                        .WithMany()
                        .HasForeignKey("MonedaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Finanzas.Entity.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Finanzas.Entity.Provincia", b =>
                {
                    b.HasOne("Finanzas.Entity.Departamento", "Departamento")
                        .WithMany()
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Finanzas.Entity.Usuario", b =>
                {
                    b.HasOne("Finanzas.Entity.Distrito", "Distrito")
                        .WithMany()
                        .HasForeignKey("DistritoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}