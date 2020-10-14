﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using proyecto1.Data;

namespace proyecto1.Migrations
{
    [DbContext(typeof(OContext))]
    [Migration("20201013184103_partidas")]
    partial class partidas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("proyecto1.Models.Partida", b =>
                {
                    b.Property<int>("IdPartida")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioIdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("adversario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numTurnos")
                        .HasColumnType("int");

                    b.Property<string>("resultado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPartida");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Partida");
                });

            modelBuilder.Entity("proyecto1.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(8)")
                        .HasMaxLength(8);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("nac")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("proyecto1.Models.Partida", b =>
                {
                    b.HasOne("proyecto1.Models.Usuario", "Usuario")
                        .WithMany("Partidas")
                        .HasForeignKey("UsuarioIdUsuario");
                });
#pragma warning restore 612, 618
        }
    }
}