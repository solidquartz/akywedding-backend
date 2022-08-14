﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using akywedding_backend.Models.Database;

#nullable disable

namespace akywedding_backend.Migrations
{
    [DbContext(typeof(WeddingContext))]
    partial class WeddingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("akywedding_backend.Models.Database.Guest", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("id"));

                    b.Property<long?>("Partyid")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("dietary_restrictions")
                        .HasColumnType("text");

                    b.Property<bool?>("is_attending")
                        .HasColumnType("boolean");

                    b.Property<bool>("is_child")
                        .HasColumnType("boolean");

                    b.Property<long?>("meal_choiceid")
                        .HasColumnType("bigint");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("updated_at")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("id");

                    b.HasIndex("Partyid");

                    b.HasIndex("meal_choiceid");

                    b.ToTable("guests");
                });

            modelBuilder.Entity("akywedding_backend.Models.Database.MealOption", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("id"));

                    b.Property<DateTime>("created_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("updated_at")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("id");

                    b.ToTable("mealOptions");
                });

            modelBuilder.Entity("akywedding_backend.Models.Database.Party", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("id"));

                    b.Property<DateTime>("created_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("updated_at")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("id");

                    b.ToTable("parties");
                });

            modelBuilder.Entity("akywedding_backend.Models.Database.Rsvp", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("id"));

                    b.Property<string>("comments")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("music")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("partyid")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("updated_at")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("id");

                    b.HasIndex("partyid");

                    b.ToTable("rsvps");
                });

            modelBuilder.Entity("akywedding_backend.Models.Database.Guest", b =>
                {
                    b.HasOne("akywedding_backend.Models.Database.Party", null)
                        .WithMany("guests")
                        .HasForeignKey("Partyid");

                    b.HasOne("akywedding_backend.Models.Database.MealOption", "meal_choice")
                        .WithMany()
                        .HasForeignKey("meal_choiceid");

                    b.Navigation("meal_choice");
                });

            modelBuilder.Entity("akywedding_backend.Models.Database.Rsvp", b =>
                {
                    b.HasOne("akywedding_backend.Models.Database.Party", "party")
                        .WithMany()
                        .HasForeignKey("partyid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("party");
                });

            modelBuilder.Entity("akywedding_backend.Models.Database.Party", b =>
                {
                    b.Navigation("guests");
                });
#pragma warning restore 612, 618
        }
    }
}
