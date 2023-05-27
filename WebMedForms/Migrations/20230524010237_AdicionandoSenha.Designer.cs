﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebMedForms.Data;

#nullable disable

namespace WebMedForms.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20230524010237_AdicionandoSenha")]
    partial class AdicionandoSenha
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebMedForms.Models.Solicitacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("cep");

                    b.Property<string>("CID")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("cid");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("cpf");

                    b.Property<string>("CadUnicoSaude")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("cad_unico_saude");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("celular");

                    b.Property<string>("ChaveAutenticacao")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("chave_autenticacao");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("cidade");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("complemento");

                    b.Property<string>("CrmMedicoSolicitante")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("crm");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("endereco");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("estado");

                    b.Property<string>("IndicacaoMedica")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("indicacao_medica");

                    b.Property<int>("IndicacaoTratamento")
                        .HasColumnType("int")
                        .HasColumnName("indicacao_tratamento");

                    b.Property<string>("NomeMedicoSolicitante")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome_medico");

                    b.Property<string>("NomePaciente")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome_paciente");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("rg");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.ToTable("Solicitacao");
                });

            modelBuilder.Entity("WebMedForms.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Senha");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
