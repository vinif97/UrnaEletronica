﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UrnaEletronica.Data;

namespace UrnaEletronica.Migrations
{
    [DbContext(typeof(DbAcess))]
    [Migration("20220126172857_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("UrnaEletronica.Model.Candidate", b =>
                {
                    b.Property<int>("Label")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("RegistryDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ViceName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Label");

                    b.ToTable("Candidate");
                });

            modelBuilder.Entity("UrnaEletronica.Model.Vote", b =>
                {
                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<DateTime>("VoteDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("CandidateId", "VoteDate");

                    b.ToTable("Vote");
                });

            modelBuilder.Entity("UrnaEletronica.Model.Vote", b =>
                {
                    b.HasOne("UrnaEletronica.Model.Candidate", "Candidate")
                        .WithMany("Votes")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidate");
                });

            modelBuilder.Entity("UrnaEletronica.Model.Candidate", b =>
                {
                    b.Navigation("Votes");
                });
#pragma warning restore 612, 618
        }
    }
}
