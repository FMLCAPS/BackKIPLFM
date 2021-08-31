﻿// <auto-generated />
using System;
using KIPLModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KIPLModel.Migrations
{
    [DbContext(typeof(Bdd))]
    [Migration("20210804100113_v3")]
    partial class v3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KIPLModel.Cabinet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("HeureFermeture")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("HeureOuverture")
                        .HasColumnType("time");

                    b.Property<string>("Libelle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NombrePlaces")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cabinets");
                });

            modelBuilder.Entity("KIPLModel.Kine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CabinetId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateDeNaissance")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CabinetId");

                    b.ToTable("Kines");
                });

            modelBuilder.Entity("KIPLModel.Kine", b =>
                {
                    b.HasOne("KIPLModel.Cabinet", "Cabinet")
                        .WithMany("Kines")
                        .HasForeignKey("CabinetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cabinet");
                });

            modelBuilder.Entity("KIPLModel.Cabinet", b =>
                {
                    b.Navigation("Kines");
                });
#pragma warning restore 612, 618
        }
    }
}
