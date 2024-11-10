﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Tarea_7.Migrations
{
    [DbContext(typeof(DetencionContext))]
    [Migration("20241110022126_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Detencion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaDetencion")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("FechaNacomiento")
                        .HasColumnType("TEXT");

                    b.Property<double>("Latitud")
                        .HasColumnType("REAL");

                    b.Property<double>("Longitud")
                        .HasColumnType("REAL");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Pasaporte")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Detenciones");
                });
#pragma warning restore 612, 618
        }
    }
}