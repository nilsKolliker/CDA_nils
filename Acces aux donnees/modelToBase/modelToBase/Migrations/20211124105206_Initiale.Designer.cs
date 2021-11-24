﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using modelToBase.Data;

namespace modelToBase.Migrations
{
    [DbContext(typeof(myDbContext))]
    [Migration("20211124105206_Initiale")]
    partial class Initiale
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("modelToBase.Data.Departement", b =>
                {
                    b.Property<int>("IdDepartement")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdDepartement");

                    b.ToTable("Departement");
                });

            modelBuilder.Entity("modelToBase.Data.Ville", b =>
                {
                    b.Property<int>("IdVille")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("DepartementIdDepartement")
                        .HasColumnType("int");

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdVille");

                    b.HasIndex("DepartementIdDepartement");

                    b.ToTable("Ville");
                });

            modelBuilder.Entity("modelToBase.Data.Ville", b =>
                {
                    b.HasOne("modelToBase.Data.Departement", null)
                        .WithMany("ListeVilles")
                        .HasForeignKey("DepartementIdDepartement");
                });

            modelBuilder.Entity("modelToBase.Data.Departement", b =>
                {
                    b.Navigation("ListeVilles");
                });
#pragma warning restore 612, 618
        }
    }
}
