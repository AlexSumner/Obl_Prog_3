﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PruebaProgramacion3_Guia.Datos;

#nullable disable

namespace Obl_Prog_3.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230715201129_CreacionFuncionesTableDb")]
    partial class CreacionFuncionesTableDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Obl_Prog_3.Models.Funcion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Horario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<int?>("SalaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PeliculaId");

                    b.HasIndex("SalaId");

                    b.ToTable("Funciones");
                });

            modelBuilder.Entity("Obl_Prog_3.Models.Pelicula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cartelera")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clasificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duracion")
                        .HasColumnType("int");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sinopsis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Peliculas");
                });

            modelBuilder.Entity("Obl_Prog_3.Models.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Obl_Prog_3.Models.Sala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CantidadAsientos")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Salas");
                });

            modelBuilder.Entity("Obl_Prog_3.Models.Administrativo", b =>
                {
                    b.HasBaseType("Obl_Prog_3.Models.Persona");

                    b.Property<int>("NumeroTrabajador")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Administrativo");
                });

            modelBuilder.Entity("Obl_Prog_3.Models.Usuario", b =>
                {
                    b.HasBaseType("Obl_Prog_3.Models.Persona");

                    b.HasDiscriminator().HasValue("Usuario");
                });

            modelBuilder.Entity("Obl_Prog_3.Models.Funcion", b =>
                {
                    b.HasOne("Obl_Prog_3.Models.Pelicula", "Pelicula")
                        .WithMany()
                        .HasForeignKey("PeliculaId");

                    b.HasOne("Obl_Prog_3.Models.Sala", "Sala")
                        .WithMany()
                        .HasForeignKey("SalaId");

                    b.Navigation("Pelicula");

                    b.Navigation("Sala");
                });
#pragma warning restore 612, 618
        }
    }
}
