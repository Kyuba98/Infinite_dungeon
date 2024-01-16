﻿// <auto-generated />
using System;
using Infinite_dungeon.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infinite_dungeon.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Infinite_dungeon.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BaseAttack")
                        .HasColumnType("int");

                    b.Property<int>("BaseDefense")
                        .HasColumnType("int");

                    b.Property<int>("BaseMagic")
                        .HasColumnType("int");

                    b.Property<int>("BaseMaxHealthPoints")
                        .HasColumnType("int");

                    b.Property<int>("BaseMaxMana")
                        .HasColumnType("int");

                    b.Property<int>("Coins")
                        .HasColumnType("int");

                    b.Property<int>("ExperiencePoints")
                        .HasColumnType("int");

                    b.Property<int>("HealthPoints")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("Mana")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("WeaponId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("WeaponId");

                    b.ToTable("Character");
                });

            modelBuilder.Entity("Infinite_dungeon.Models.Enemy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BaseDamage")
                        .HasColumnType("int");

                    b.Property<int>("BaseHealthPoints")
                        .HasColumnType("int");

                    b.Property<int>("HealthPoints")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Enemy");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BaseDamage = 150,
                            BaseHealthPoints = 200,
                            HealthPoints = 2,
                            Level = 1,
                            Name = "Goblin"
                        },
                        new
                        {
                            Id = 2,
                            BaseDamage = 200,
                            BaseHealthPoints = 300,
                            HealthPoints = 3,
                            Level = 1,
                            Name = "Chimera"
                        },
                        new
                        {
                            Id = 3,
                            BaseDamage = 150,
                            BaseHealthPoints = 250,
                            HealthPoints = 2,
                            Level = 1,
                            Name = "Orc"
                        },
                        new
                        {
                            Id = 4,
                            BaseDamage = 120,
                            BaseHealthPoints = 180,
                            HealthPoints = 1,
                            Level = 1,
                            Name = "Skeleton"
                        },
                        new
                        {
                            Id = 5,
                            BaseDamage = 120,
                            BaseHealthPoints = 280,
                            HealthPoints = 2,
                            Level = 1,
                            Name = "Troll"
                        },
                        new
                        {
                            Id = 6,
                            BaseDamage = 200,
                            BaseHealthPoints = 180,
                            HealthPoints = 1,
                            Level = 1,
                            Name = "Witch"
                        },
                        new
                        {
                            Id = 7,
                            BaseDamage = 150,
                            BaseHealthPoints = 400,
                            HealthPoints = 4,
                            Level = 1,
                            Name = "Dragon"
                        },
                        new
                        {
                            Id = 8,
                            BaseDamage = 80,
                            BaseHealthPoints = 120,
                            HealthPoints = 1,
                            Level = 1,
                            Name = "Slime"
                        },
                        new
                        {
                            Id = 9,
                            BaseDamage = 100,
                            BaseHealthPoints = 350,
                            HealthPoints = 3,
                            Level = 1,
                            Name = "Cyclops"
                        },
                        new
                        {
                            Id = 10,
                            BaseDamage = 200,
                            BaseHealthPoints = 150,
                            HealthPoints = 1,
                            Level = 1,
                            Name = "Ghost"
                        },
                        new
                        {
                            Id = 11,
                            BaseDamage = 120,
                            BaseHealthPoints = 280,
                            HealthPoints = 2,
                            Level = 1,
                            Name = "Werewolf"
                        },
                        new
                        {
                            Id = 12,
                            BaseDamage = 180,
                            BaseHealthPoints = 200,
                            HealthPoints = 2,
                            Level = 1,
                            Name = "Harpy"
                        },
                        new
                        {
                            Id = 13,
                            BaseDamage = 200,
                            BaseHealthPoints = 180,
                            HealthPoints = 1,
                            Level = 1,
                            Name = "Mummy"
                        },
                        new
                        {
                            Id = 14,
                            BaseDamage = 240,
                            BaseHealthPoints = 160,
                            HealthPoints = 1,
                            Level = 1,
                            Name = "Banshee"
                        },
                        new
                        {
                            Id = 15,
                            BaseDamage = 100,
                            BaseHealthPoints = 320,
                            HealthPoints = 3,
                            Level = 1,
                            Name = "Minotaur"
                        });
                });

            modelBuilder.Entity("Infinite_dungeon.Models.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<int>("Damage")
                        .HasColumnType("int");

                    b.Property<int>("DefenseBonus")
                        .HasColumnType("int");

                    b.Property<int>("MagicPower")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("Weapon");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cost = 50,
                            Damage = 5,
                            DefenseBonus = 15,
                            MagicPower = 0,
                            Name = "Iron Sword",
                            Type = 0
                        },
                        new
                        {
                            Id = 2,
                            Cost = 50,
                            Damage = 15,
                            DefenseBonus = 0,
                            MagicPower = 5,
                            Name = "Wooden Bow",
                            Type = 1
                        },
                        new
                        {
                            Id = 3,
                            Cost = 50,
                            Damage = 0,
                            DefenseBonus = 5,
                            MagicPower = 15,
                            Name = "Novice Staff",
                            Type = 2
                        },
                        new
                        {
                            Id = 4,
                            Cost = 250,
                            Damage = 12,
                            DefenseBonus = 25,
                            MagicPower = 0,
                            Name = "Steel Sword",
                            Type = 0
                        },
                        new
                        {
                            Id = 5,
                            Cost = 250,
                            Damage = 25,
                            DefenseBonus = 0,
                            MagicPower = 12,
                            Name = "Reinforced Bow",
                            Type = 1
                        },
                        new
                        {
                            Id = 6,
                            Cost = 250,
                            Damage = 0,
                            DefenseBonus = 12,
                            MagicPower = 25,
                            Name = "Adept Staff",
                            Type = 2
                        },
                        new
                        {
                            Id = 7,
                            Cost = 500,
                            Damage = 25,
                            DefenseBonus = 50,
                            MagicPower = 0,
                            Name = "Golden Sword",
                            Type = 0
                        },
                        new
                        {
                            Id = 8,
                            Cost = 500,
                            Damage = 50,
                            DefenseBonus = 0,
                            MagicPower = 25,
                            Name = "Master Archer Bow",
                            Type = 1
                        },
                        new
                        {
                            Id = 9,
                            Cost = 500,
                            Damage = 0,
                            DefenseBonus = 25,
                            MagicPower = 50,
                            Name = "Enchanter's Staff",
                            Type = 2
                        },
                        new
                        {
                            Id = 10,
                            Cost = 1000,
                            Damage = 50,
                            DefenseBonus = 100,
                            MagicPower = 25,
                            Name = "Legendary Sword",
                            Type = 0
                        },
                        new
                        {
                            Id = 11,
                            Cost = 1000,
                            Damage = 100,
                            DefenseBonus = 25,
                            MagicPower = 50,
                            Name = "Dragon's Breath Bow",
                            Type = 1
                        },
                        new
                        {
                            Id = 12,
                            Cost = 1000,
                            Damage = 25,
                            DefenseBonus = 50,
                            MagicPower = 100,
                            Name = "Archmage's Staff",
                            Type = 2
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Infinite_dungeon.Models.Character", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("Infinite_dungeon.Models.Weapon", "Weapon")
                        .WithMany()
                        .HasForeignKey("WeaponId");

                    b.Navigation("User");

                    b.Navigation("Weapon");
                });

            modelBuilder.Entity("Infinite_dungeon.Models.Weapon", b =>
                {
                    b.HasOne("Infinite_dungeon.Models.Character", null)
                        .WithMany("Inventory")
                        .HasForeignKey("CharacterId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Infinite_dungeon.Models.Character", b =>
                {
                    b.Navigation("Inventory");
                });
#pragma warning restore 612, 618
        }
    }
}
