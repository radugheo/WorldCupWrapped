﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WorldCupWrapped.Data;

#nullable disable

namespace WorldCupWrapped.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20230119210557_migrare2")]
    partial class migrare2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WorldCupWrapped.Models.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Population")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("WorldCupWrapped.Models.Manager", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("WorldCupWrapped.Models.Match", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AwayGoals")
                        .HasColumnType("integer");

                    b.Property<string>("AwayTeam")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("AwayTeamId")
                        .HasColumnType("uuid");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("HomeGoals")
                        .HasColumnType("integer");

                    b.Property<string>("HomeTeam")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("HomeTeamId")
                        .HasColumnType("uuid");

                    b.Property<string>("Phase")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("StadiumId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("StadiumId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("WorldCupWrapped.Models.MatchReferee", b =>
                {
                    b.Property<Guid>("MatchId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RefereeId")
                        .HasColumnType("uuid");

                    b.HasKey("MatchId", "RefereeId");

                    b.HasIndex("RefereeId");

                    b.ToTable("MatchReferees");
                });

            modelBuilder.Entity("WorldCupWrapped.Models.Player", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Goals")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("TeamId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("WorldCupWrapped.Models.Referee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Referees");
                });

            modelBuilder.Entity("WorldCupWrapped.Models.Stadium", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("FoundationYear")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Stadiums");
                });

            modelBuilder.Entity("WorldCupWrapped.Models.Team", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FifaName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Flag")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("GroupRanking")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("KnockoutRanking")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ManagerId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TopScorer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId")
                        .IsUnique();

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("WorldCupWrapped.Models.TeamTrophy", b =>
                {
                    b.Property<Guid>("TeamId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TrophyId")
                        .HasColumnType("uuid");

                    b.HasKey("TeamId", "TrophyId");

                    b.HasIndex("TrophyId");

                    b.ToTable("TeamTrophies");
                });

            modelBuilder.Entity("WorldCupWrapped.Models.Trophy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Trophies");
                });

            modelBuilder.Entity("WorldCupWrapped.Models.Match", b =>
                {
                    b.HasOne("WorldCupWrapped.Models.Stadium", "Stadium")
                        .WithMany("Matches")
                        .HasForeignKey("StadiumId");

                    b.Navigation("Stadium");
                });

            modelBuilder.Entity("WorldCupWrapped.Models.MatchReferee", b =>
                {
                    b.HasOne("WorldCupWrapped.Models.Match", "Match")
                        .WithMany("MatchesReferees")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WorldCupWrapped.Models.Referee", "Referee")
                        .WithMany("MatchesReferees")
                        .HasForeignKey("RefereeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Match");

                    b.Navigation("Referee");
                });

            modelBuilder.Entity("WorldCupWrapped.Models.Player", b =>
                {
                    b.HasOne("WorldCupWrapped.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("WorldCupWrapped.Models.Stadium", b =>
                {
                    b.HasOne("WorldCupWrapped.Models.City", "City")
                        .WithMany("Stadiums")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("WorldCupWrapped.Models.Team", b =>
                {
                    b.HasOne("WorldCupWrapped.Models.Manager", "Manager")
                        .WithOne("Team")
                        .HasForeignKey("WorldCupWrapped.Models.Team", "ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("WorldCupWrapped.Models.TeamTrophy", b =>
                {
                    b.HasOne("WorldCupWrapped.Models.Team", "Team")
                        .WithMany("TeamsTrophies")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WorldCupWrapped.Models.Trophy", "Trophy")
                        .WithMany("TeamsTrophies")
                        .HasForeignKey("TrophyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");

                    b.Navigation("Trophy");
                });

            modelBuilder.Entity("WorldCupWrapped.Models.City", b =>
                {
                    b.Navigation("Stadiums");
                });

            modelBuilder.Entity("WorldCupWrapped.Models.Manager", b =>
                {
                    b.Navigation("Team");
                });

            modelBuilder.Entity("WorldCupWrapped.Models.Match", b =>
                {
                    b.Navigation("MatchesReferees");
                });

            modelBuilder.Entity("WorldCupWrapped.Models.Referee", b =>
                {
                    b.Navigation("MatchesReferees");
                });

            modelBuilder.Entity("WorldCupWrapped.Models.Stadium", b =>
                {
                    b.Navigation("Matches");
                });

            modelBuilder.Entity("WorldCupWrapped.Models.Team", b =>
                {
                    b.Navigation("Players");

                    b.Navigation("TeamsTrophies");
                });

            modelBuilder.Entity("WorldCupWrapped.Models.Trophy", b =>
                {
                    b.Navigation("TeamsTrophies");
                });
#pragma warning restore 612, 618
        }
    }
}
