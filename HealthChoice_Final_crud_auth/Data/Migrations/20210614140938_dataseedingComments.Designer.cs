﻿// <auto-generated />
using System;
using HealthChoice_Final_crud_auth.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HealthChoice_Final_crud_auth.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210614140938_dataseedingComments")]
    partial class dataseedingComments
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HealthChoice_Final_crud_auth.Models.CommentsModel", b =>
                {
                    b.Property<int>("comId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("message")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("comId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            comId = 1,
                            message = "Nice"
                        },
                        new
                        {
                            comId = 2,
                            message = "very suitable"
                        });
                });

            modelBuilder.Entity("HealthChoice_Final_crud_auth.Models.MembershipsModel", b =>
                {
                    b.Property<int>("memId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("memBenefits")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("memName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("memId");

                    b.ToTable("MembberShips");
                });

            modelBuilder.Entity("HealthChoice_Final_crud_auth.Models.ServicesModel", b =>
                {
                    b.Property<int>("servId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("servLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("servLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("servName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("servOverview")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("servType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("servWebsite")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("servId");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            servId = 1,
                            servLocation = "https://www.google.com/maps/dir/24.8540805,46.7132804/Fitness+Time+Ladies,+King+Khalid+International+Airport,+Riyadh/@24.863979,46.7113634,14.15z/data=!4m9!4m8!1m1!4e1!1m5!1m1!1s0x3e2efb358b9bd1c1:0x60f9692740fd1349!2m2!1d46.7102291!2d24.8546555",
                            servLogo = "https://seeklogo.com/images/F/fitness-time-logo-19E1048F6C-seeklogo.com.png",
                            servName = "Fitness Time",
                            servOverview = "Exercise for Health is our motto – Fitness Time strives to provide the best sports and fitness services through our growing network of facilities across the Middle East and North Africa. We believe health goals can be achieved through overall mind and body fitness.",
                            servType = "Gym",
                            servWebsite = "https://www.fitnesstime.com.sa/en-sa/"
                        },
                        new
                        {
                            servId = 2,
                            servLocation = "https://www.google.com/search?q=boga&oq=boga&aqs=chrome..69i57j69i59l3j0j46l2j0i457j0i402j46.1468j0j4&sourceid=chrome&ie=UTF-8&safe=active&tbs=lrf:!1m4!1u3!2m2!3m1!1e1!2m1!1e3!3sIAE,lf:1,lf_ui:3&tbm=lcl&sxsrf=ALeKk00BE-1ps0u0RhIkiHDQ5_HPh-SOag:1623642183699&rflfq=1&num=10&rldimm=4194740120699254277&lqi=CgRib2dhSMmPh7KGsYCACFoKEAAYACIEYm9nYZIBCnJlc3RhdXJhbnQ&ved=2ahUKEwiu1ue8mpbxAhV07eAKHZbzD_UQvS4wAHoECAQQIA&rlst=f#rlfi=hd:;si:4194740120699254277,l,CgRib2dhSMmPh7KGsYCACFoKEAAYACIEYm9nYZIBCnJlc3RhdXJhbnQ;mv:[[24.8432004,46.7455346],[24.697642,46.6107527]];tbs:lrf:!1m4!1u3!2m2!3m1!1e1!2m1!1e3!3sIAE,lf:1,lf_ui:3",
                            servLogo = "https://media-exp1.licdn.com/dms/image/C4D1BAQGllg2SUkUMGA/company-background_10000/0/1575976861836?e=2159024400&v=beta&t=ODg29H-HRO7cdmDJXe8Teg-TWGxM8d4SmUWfEbJ3FZo",
                            servName = "Boga Super Food",
                            servOverview = "BOGA is a Saudi local restaurant chain that is created and owned by Tariq Al-Hussaini.And is Offers sandwiches, salads, and fresh juices",
                            servType = "Resturent",
                            servWebsite = "https://www.instagram.com/boga_sa/?igshid=2ptrc8wda1uc"
                        },
                        new
                        {
                            servId = 3,
                            servLocation = "https://www.google.com/search?q=sport%20stores&oq=sport+stores&aqs=chrome..69i57j46i175i199j0i402j0l7.5628j0j9&sourceid=chrome&ie=UTF-8&safe=active&tbs=lf:1,lf_ui:10&tbm=lcl&sxsrf=ALeKk00f2RsQQ_0hPR9FhZkiq9OUP1w7Xw:1623642377772&rflfq=1&num=10&rldimm=5200966494054111993&lqi=CgxzcG9ydCBzdG9yZXNIoZCl-feqgIAIWh4QABABGAAYASIMc3BvcnQgc3RvcmVzKgYIAxAAEAGSARBzcG9ydHN3ZWFyX3N0b3JlmgEkQ2hkRFNVaE5NRzluUzBWSlEwRm5TVVJwZVV0aFZqbEJSUkFCqgEUEAEqECIMc3BvcnQgc3RvcmVzKAA&phdesc=pajse2hgjO8&ved=2ahUKEwifg62Zm5bxAhUsQEEAHVQoBJYQvS4wAHoECAYQLA&rlst=f#rlfi=hd:;si:11350449135811842640,l,CgxzcG9ydCBzdG9yZXNIgK6J482rgIAIWh4QABABGAAYASIMc3BvcnQgc3RvcmVzKgYIAxAAEAGSARRzcG9ydGluZ19nb29kc19zdG9yZaoBFBABKhAiDHNwb3J0IHN0b3JlcygA,y,jyheHfoLH9E;mv:[[24.825370900000003,46.8087284],[24.631175799999998,46.6077643]]",
                            servLogo = "https://c.static-nike.com/a/images/w_1920,c_limit/mdbgldn6yg1gg88jomci/image.jpg",
                            servName = "Nike Store",
                            servOverview = "Exercise for Health is our motto – Fitness Time strives to provide the best sports and fitness services through our growing network of facilities across the Middle East and North Africa. We believe health goals can be achieved through overall mind and body fitness.",
                            servType = "Store",
                            servWebsite = "https://www.fitnesstime.com.sa/en-sa/"
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

                    b.ToTable("AspNetUsers");
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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
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
#pragma warning restore 612, 618
        }
    }
}
