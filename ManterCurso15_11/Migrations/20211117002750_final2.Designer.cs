﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ManterCurso15_11.Migrations
{
    [DbContext(typeof(ManterCurso15_11Context))]
    [Migration("20211117002750_final2")]
    partial class final2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ManterCurso15_11.Model.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeCategoria")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("ManterCurso15_11.Model.Curso", b =>
                {
                    b.Property<int>("CursoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoriaId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CategoriaId1")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataTermino")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QtdAlunosTurma")
                        .HasColumnType("int");

                    b.HasKey("CursoId");

                    b.HasIndex("CategoriaId1");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("ManterCurso15_11.Model.Log", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataInclusao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataUltimaAtualizacao")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CursoId");

                    b.ToTable("Log");
                });

            modelBuilder.Entity("ManterCurso15_11.Model.Curso", b =>
                {
                    b.HasOne("ManterCurso15_11.Model.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId1");

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("ManterCurso15_11.Model.Log", b =>
                {
                    b.HasOne("ManterCurso15_11.Model.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");
                });
#pragma warning restore 612, 618
        }
    }
}