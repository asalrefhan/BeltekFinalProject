﻿// <auto-generated />
using BeltekFinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BeltekFinalProject.Migrations
{
    [DbContext(typeof(OkulDbContext))]
    [Migration("20231226112001_AddTables")]
    partial class AddTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BeltekFinalProject.Models.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OgrenciId"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.Property<string>("Bolum")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar");

                    b.Property<string>("Numara")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar");

                    b.HasKey("OgrenciId");

                    b.ToTable("tblOgrenciler", (string)null);
                });

            modelBuilder.Entity("BeltekFinalProject.Models.Ogretmen", b =>
                {
                    b.Property<string>("TcKimlik")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.Property<string>("Alan")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar");

                    b.HasKey("TcKimlik")
                        .HasName("TcKimlik");

                    b.ToTable("tblOgretmenler", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
