﻿// <auto-generated />
using BemEstar.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BemEstar.Infrastructure.Migrations
{
    [DbContext(typeof(BemEstarDbContext))]
    [Migration("20231123015825_CriacaoInicial")]
    partial class CriacaoInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BemEstar.Domain.Entities.Alimento", b =>
                {
                    b.Property<int>("IdAlimento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdAlimento"));

                    b.Property<int>("Calorias")
                        .HasColumnType("integer");

                    b.Property<int>("IdRefeicao")
                        .HasColumnType("integer");

                    b.Property<string>("NomeAlimento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdAlimento");

                    b.HasIndex("IdRefeicao");

                    b.ToTable("Alimentos");
                });

            modelBuilder.Entity("BemEstar.Domain.Entities.Refeicao", b =>
                {
                    b.Property<int>("IdRefeicao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdRefeicao"));

                    b.Property<string>("NomeRefeicao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdRefeicao");

                    b.ToTable("Refeicoes");
                });

            modelBuilder.Entity("BemEstar.Domain.Entities.Alimento", b =>
                {
                    b.HasOne("BemEstar.Domain.Entities.Refeicao", "Refeicao")
                        .WithMany("Alimentos")
                        .HasForeignKey("IdRefeicao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Refeicao");
                });

            modelBuilder.Entity("BemEstar.Domain.Entities.Refeicao", b =>
                {
                    b.Navigation("Alimentos");
                });
#pragma warning restore 612, 618
        }
    }
}
