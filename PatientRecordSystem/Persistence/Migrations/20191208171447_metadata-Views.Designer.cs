﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PatientRecordSystem.Persistence.Contexts;

namespace PatientRecordSystem.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191208171447_metadata-Views")]
    partial class metadataViews
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(50000);

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes");
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(50000);

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Key");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.ToTable("PersistedGrants");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PatientRecordSystem.Domain.Models.MetaData", b =>
                {
                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("PatientId", "Key");

                    b.ToTable("MetaData");

                    b.HasData(
                        new
                        {
                            PatientId = 1,
                            Key = "Age",
                            Value = "56"
                        },
                        new
                        {
                            PatientId = 1,
                            Key = "Diabetes",
                            Value = "yes"
                        },
                        new
                        {
                            PatientId = 1,
                            Key = "city",
                            Value = "Salfeet"
                        },
                        new
                        {
                            PatientId = 1,
                            Key = "heart",
                            Value = "open surgery"
                        },
                        new
                        {
                            PatientId = 2,
                            Key = "Age",
                            Value = "35"
                        },
                        new
                        {
                            PatientId = 2,
                            Key = "City",
                            Value = "Ramallah"
                        },
                        new
                        {
                            PatientId = 3,
                            Key = "Age",
                            Value = "20"
                        },
                        new
                        {
                            PatientId = 3,
                            Key = "City",
                            Value = "Jenin"
                        },
                        new
                        {
                            PatientId = 3,
                            Key = "Diabetes",
                            Value = "yes"
                        },
                        new
                        {
                            PatientId = 4,
                            Key = "Age",
                            Value = "60"
                        },
                        new
                        {
                            PatientId = 4,
                            Key = "Cancer",
                            Value = "yes"
                        },
                        new
                        {
                            PatientId = 4,
                            Key = "Asthma",
                            Value = "yes"
                        },
                        new
                        {
                            PatientId = 5,
                            Key = "City",
                            Value = "Ramallah"
                        },
                        new
                        {
                            PatientId = 5,
                            Key = "Age",
                            Value = "28"
                        });
                });

            modelBuilder.Entity("PatientRecordSystem.Domain.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<int>("OffcialId")
                        .HasColumnType("int");

                    b.Property<string>("PatientName")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("OffcialId")
                        .IsUnique();

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(1992, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ahmad@tt.com",
                            OffcialId = 1,
                            PatientName = "Ahmad"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1997, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Sami@tt.com",
                            OffcialId = 2,
                            PatientName = "Sami"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1998, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Mohammad@tt.com",
                            OffcialId = 3,
                            PatientName = "Mohammad"
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(1996, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OffcialId = 4,
                            PatientName = "Jane"
                        },
                        new
                        {
                            Id = 5,
                            DateOfBirth = new DateTime(2000, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ahmad@tt.com",
                            OffcialId = 5,
                            PatientName = "Ameen"
                        });
                });

            modelBuilder.Entity("PatientRecordSystem.Domain.Models.Record", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0);

                    b.Property<string>("Discription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiseaseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeOfEntry")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("Records");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 50.0,
                            DiseaseName = "Allergies",
                            PatientId = 1,
                            TimeOfEntry = new DateTime(2019, 12, 8, 19, 14, 46, 606, DateTimeKind.Local).AddTicks(9260)
                        },
                        new
                        {
                            Id = 2,
                            Amount = 100.0,
                            DiseaseName = "ER",
                            PatientId = 1,
                            TimeOfEntry = new DateTime(2019, 12, 8, 19, 14, 46, 610, DateTimeKind.Local).AddTicks(8035)
                        },
                        new
                        {
                            Id = 3,
                            Amount = 60.0,
                            DiseaseName = "Eye",
                            PatientId = 1,
                            TimeOfEntry = new DateTime(2019, 12, 8, 19, 14, 46, 610, DateTimeKind.Local).AddTicks(8079)
                        },
                        new
                        {
                            Id = 4,
                            Amount = 30000.0,
                            DiseaseName = "Surgery",
                            PatientId = 1,
                            TimeOfEntry = new DateTime(2019, 12, 8, 19, 14, 46, 610, DateTimeKind.Local).AddTicks(8088)
                        },
                        new
                        {
                            Id = 5,
                            Amount = 50.0,
                            DiseaseName = "Allergies",
                            PatientId = 5,
                            TimeOfEntry = new DateTime(2019, 12, 8, 19, 14, 46, 610, DateTimeKind.Local).AddTicks(8092)
                        },
                        new
                        {
                            Id = 6,
                            Amount = 70.0,
                            DiseaseName = "Asthma",
                            PatientId = 1,
                            TimeOfEntry = new DateTime(2019, 12, 8, 19, 14, 46, 610, DateTimeKind.Local).AddTicks(8096)
                        },
                        new
                        {
                            Id = 7,
                            Amount = 70.0,
                            DiseaseName = "Asthma",
                            PatientId = 5,
                            TimeOfEntry = new DateTime(2019, 12, 8, 19, 14, 46, 610, DateTimeKind.Local).AddTicks(8100)
                        },
                        new
                        {
                            Id = 8,
                            Amount = 50.0,
                            DiseaseName = "Allergies",
                            PatientId = 2,
                            TimeOfEntry = new DateTime(2019, 12, 8, 19, 14, 46, 610, DateTimeKind.Local).AddTicks(8103)
                        });
                });

            modelBuilder.Entity("PatientRecordSystem.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
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
                    b.HasOne("PatientRecordSystem.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PatientRecordSystem.Models.ApplicationUser", null)
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

                    b.HasOne("PatientRecordSystem.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PatientRecordSystem.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PatientRecordSystem.Domain.Models.MetaData", b =>
                {
                    b.HasOne("PatientRecordSystem.Domain.Models.Patient", "Patient")
                        .WithMany("MetaData")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PatientRecordSystem.Domain.Models.Record", b =>
                {
                    b.HasOne("PatientRecordSystem.Domain.Models.Patient", "Patient")
                        .WithMany("Records")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
