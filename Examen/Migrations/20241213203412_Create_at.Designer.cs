﻿// <auto-generated />
using System;
using Examen.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Examen.Migrations
{
    [DbContext(typeof(ExamenContext))]
    [Migration("20241213203412_Create_at")]
    partial class Create_at
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AvionesBackNet.Models.BinnacleBody", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("binnacleHeaderId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("createAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("deleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("field")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("newValue")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("previousValue")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("updateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("userCreateId")
                        .HasColumnType("text");

                    b.Property<string>("userUpdateId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("binnacleHeaderId");

                    b.HasIndex("userCreateId");

                    b.HasIndex("userUpdateId");

                    b.ToTable("binnacleBody");
                });

            modelBuilder.Entity("AvionesBackNet.Models.binnacleHeader", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime?>("createAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("deleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("idRegister")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("table")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("transactionType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("updateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("userCreateId")
                        .HasColumnType("text");

                    b.Property<string>("userId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("userUpdateId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("userCreateId");

                    b.HasIndex("userId");

                    b.HasIndex("userUpdateId");

                    b.ToTable("binnacleHeaders");
                });

            modelBuilder.Entity("Examen.Context.Models.Brand", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime?>("createAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("deleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("updateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("userCreateId")
                        .HasColumnType("text");

                    b.Property<string>("userUpdateId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("userCreateId");

                    b.HasIndex("userUpdateId");

                    b.ToTable("brands");
                });

            modelBuilder.Entity("Examen.Context.Models.Catalogue", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime?>("createAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("deleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("updateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("userCreateId")
                        .HasColumnType("text");

                    b.Property<string>("userUpdateId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("userCreateId");

                    b.HasIndex("userUpdateId");

                    b.ToTable("catalogues");
                });

            modelBuilder.Entity("Examen.Context.Models.Client", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("createAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("deleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("dpi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nit")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("updateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("userCreateId")
                        .HasColumnType("text");

                    b.Property<string>("userUpdateId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("userCreateId");

                    b.HasIndex("userUpdateId");

                    b.ToTable("clients");
                });

            modelBuilder.Entity("Examen.Context.Models.Invoice", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("authNum")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("clientId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("createAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("deleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("docNum")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("serie")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("updateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("userCreateId")
                        .HasColumnType("text");

                    b.Property<string>("userUpdateId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("clientId");

                    b.HasIndex("userCreateId");

                    b.HasIndex("userUpdateId");

                    b.ToTable("invoices");
                });

            modelBuilder.Entity("Examen.Context.Models.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("brandId")
                        .HasColumnType("bigint");

                    b.Property<long>("catalogueId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("createAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("deleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<DateTime?>("updateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("userCreateId")
                        .HasColumnType("text");

                    b.Property<string>("userUpdateId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("brandId");

                    b.HasIndex("catalogueId");

                    b.HasIndex("userCreateId");

                    b.HasIndex("userUpdateId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("Examen.Context.Models.invoice_detail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("amount")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("createAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("deleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<float>("discount")
                        .HasColumnType("real");

                    b.Property<float>("discount_per")
                        .HasColumnType("real");

                    b.Property<long>("invoiceId")
                        .HasColumnType("bigint");

                    b.Property<long>("invoice_id")
                        .HasColumnType("bigint");

                    b.Property<long>("productId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("updateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("userCreateId")
                        .HasColumnType("text");

                    b.Property<string>("userUpdateId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("invoiceId");

                    b.HasIndex("productId");

                    b.HasIndex("userCreateId");

                    b.HasIndex("userUpdateId");

                    b.ToTable("invoice_Details");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("project.roles.rolEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<DateTime?>("createAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("deleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("updateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("userCreateId")
                        .HasColumnType("text");

                    b.Property<string>("userUpdateId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.HasIndex("userCreateId");

                    b.HasIndex("userUpdateId");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("project.users.userEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<DateTime?>("createAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("deleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("updateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("userCreateId")
                        .HasColumnType("text");

                    b.Property<string>("userUpdateId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("userCreateId");

                    b.HasIndex("userUpdateId");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("AvionesBackNet.Models.BinnacleBody", b =>
                {
                    b.HasOne("AvionesBackNet.Models.binnacleHeader", "binnacleHeader")
                        .WithMany("binnacleBody")
                        .HasForeignKey("binnacleHeaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("project.users.userEntity", "userCreate")
                        .WithMany()
                        .HasForeignKey("userCreateId");

                    b.HasOne("project.users.userEntity", "userUpdate")
                        .WithMany()
                        .HasForeignKey("userUpdateId");

                    b.Navigation("binnacleHeader");

                    b.Navigation("userCreate");

                    b.Navigation("userUpdate");
                });

            modelBuilder.Entity("AvionesBackNet.Models.binnacleHeader", b =>
                {
                    b.HasOne("project.users.userEntity", "userCreate")
                        .WithMany()
                        .HasForeignKey("userCreateId");

                    b.HasOne("project.users.userEntity", "User")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("project.users.userEntity", "userUpdate")
                        .WithMany()
                        .HasForeignKey("userUpdateId");

                    b.Navigation("User");

                    b.Navigation("userCreate");

                    b.Navigation("userUpdate");
                });

            modelBuilder.Entity("Examen.Context.Models.Brand", b =>
                {
                    b.HasOne("project.users.userEntity", "userCreate")
                        .WithMany()
                        .HasForeignKey("userCreateId");

                    b.HasOne("project.users.userEntity", "userUpdate")
                        .WithMany()
                        .HasForeignKey("userUpdateId");

                    b.Navigation("userCreate");

                    b.Navigation("userUpdate");
                });

            modelBuilder.Entity("Examen.Context.Models.Catalogue", b =>
                {
                    b.HasOne("project.users.userEntity", "userCreate")
                        .WithMany()
                        .HasForeignKey("userCreateId");

                    b.HasOne("project.users.userEntity", "userUpdate")
                        .WithMany()
                        .HasForeignKey("userUpdateId");

                    b.Navigation("userCreate");

                    b.Navigation("userUpdate");
                });

            modelBuilder.Entity("Examen.Context.Models.Client", b =>
                {
                    b.HasOne("project.users.userEntity", "userCreate")
                        .WithMany()
                        .HasForeignKey("userCreateId");

                    b.HasOne("project.users.userEntity", "userUpdate")
                        .WithMany()
                        .HasForeignKey("userUpdateId");

                    b.Navigation("userCreate");

                    b.Navigation("userUpdate");
                });

            modelBuilder.Entity("Examen.Context.Models.Invoice", b =>
                {
                    b.HasOne("Examen.Context.Models.Client", "client")
                        .WithMany()
                        .HasForeignKey("clientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("project.users.userEntity", "userCreate")
                        .WithMany()
                        .HasForeignKey("userCreateId");

                    b.HasOne("project.users.userEntity", "userUpdate")
                        .WithMany()
                        .HasForeignKey("userUpdateId");

                    b.Navigation("client");

                    b.Navigation("userCreate");

                    b.Navigation("userUpdate");
                });

            modelBuilder.Entity("Examen.Context.Models.Product", b =>
                {
                    b.HasOne("Examen.Context.Models.Brand", "brand")
                        .WithMany()
                        .HasForeignKey("brandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examen.Context.Models.Catalogue", "catalogue")
                        .WithMany()
                        .HasForeignKey("catalogueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("project.users.userEntity", "userCreate")
                        .WithMany()
                        .HasForeignKey("userCreateId");

                    b.HasOne("project.users.userEntity", "userUpdate")
                        .WithMany()
                        .HasForeignKey("userUpdateId");

                    b.Navigation("brand");

                    b.Navigation("catalogue");

                    b.Navigation("userCreate");

                    b.Navigation("userUpdate");
                });

            modelBuilder.Entity("Examen.Context.Models.invoice_detail", b =>
                {
                    b.HasOne("Examen.Context.Models.Invoice", "invoice")
                        .WithMany()
                        .HasForeignKey("invoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examen.Context.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("project.users.userEntity", "userCreate")
                        .WithMany()
                        .HasForeignKey("userCreateId");

                    b.HasOne("project.users.userEntity", "userUpdate")
                        .WithMany()
                        .HasForeignKey("userUpdateId");

                    b.Navigation("invoice");

                    b.Navigation("product");

                    b.Navigation("userCreate");

                    b.Navigation("userUpdate");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("project.roles.rolEntity", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("project.users.userEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("project.users.userEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("project.roles.rolEntity", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("project.users.userEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("project.users.userEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("project.roles.rolEntity", b =>
                {
                    b.HasOne("project.users.userEntity", "userCreate")
                        .WithMany()
                        .HasForeignKey("userCreateId");

                    b.HasOne("project.users.userEntity", "userUpdate")
                        .WithMany()
                        .HasForeignKey("userUpdateId");

                    b.Navigation("userCreate");

                    b.Navigation("userUpdate");
                });

            modelBuilder.Entity("project.users.userEntity", b =>
                {
                    b.HasOne("project.users.userEntity", "userCreate")
                        .WithMany()
                        .HasForeignKey("userCreateId");

                    b.HasOne("project.users.userEntity", "userUpdate")
                        .WithMany()
                        .HasForeignKey("userUpdateId");

                    b.Navigation("userCreate");

                    b.Navigation("userUpdate");
                });

            modelBuilder.Entity("AvionesBackNet.Models.binnacleHeader", b =>
                {
                    b.Navigation("binnacleBody");
                });
#pragma warning restore 612, 618
        }
    }
}
