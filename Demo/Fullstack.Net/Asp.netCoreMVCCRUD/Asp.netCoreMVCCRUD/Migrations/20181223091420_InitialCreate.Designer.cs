﻿// <auto-generated />
using Asp.netCoreMVCCRUD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Asp.netCoreMVCCRUD.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20181223091420_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Asp.netCoreMVCCRUD.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Position")
                        .HasColumnType("varchar(100)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
