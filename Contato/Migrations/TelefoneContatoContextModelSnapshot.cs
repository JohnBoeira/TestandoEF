﻿// <auto-generated />
using System;
using Contato.Infraestrutura;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Contato.Migrations
{
    [DbContext(typeof(TelefoneContatoContext))]
    partial class TelefoneContatoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Contato.Contato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Id");

                    b.ToTable("TBContato");
                });

            modelBuilder.Entity("Contato.Dominio.Telefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("contatoId")
                        .HasColumnType("int");

                    b.Property<int>("ddd")
                        .HasColumnType("INT");

                    b.Property<int>("numero")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.HasIndex("contatoId");

                    b.ToTable("TBTelefone");
                });

            modelBuilder.Entity("Contato.Dominio.Telefone", b =>
                {
                    b.HasOne("Contato.Contato", "contato")
                        .WithMany("Telefones")
                        .HasForeignKey("contatoId");

                    b.Navigation("contato");
                });

            modelBuilder.Entity("Contato.Contato", b =>
                {
                    b.Navigation("Telefones");
                });
#pragma warning restore 612, 618
        }
    }
}
