﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230609114506_mig_300_spartans")]
    partial class mig_300_spartans
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Concrete.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<int>("AdminContact")
                        .HasColumnType("int");

                    b.Property<string>("AdminEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminNameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Computer", b =>
                {
                    b.Property<int>("ComputerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComputerId"));

                    b.Property<string>("CPU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComputerBrand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComputerSerialNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ComputerYearOfProduction")
                        .HasColumnType("int");

                    b.Property<string>("GraphicCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperatingSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ram")
                        .HasColumnType("int");

                    b.HasKey("ComputerId");

                    b.ToTable("Computers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Personal", b =>
                {
                    b.Property<int>("PersonalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonalId"));

                    b.Property<int>("ComputerId")
                        .HasColumnType("int");

                    b.Property<int>("PersonalAge")
                        .HasColumnType("int");

                    b.Property<long>("PersonalCellPhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("PersonalDepartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalGender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalNameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonalId");

                    b.HasIndex("ComputerId")
                        .IsUnique();

                    b.ToTable("Personals");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceId"));

                    b.Property<int>("ComputerId")
                        .HasColumnType("int");

                    b.Property<string>("DeviceChangingParts")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeviceDateEntry")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeviceDeliverEntry")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeviceProcessingTime")
                        .HasColumnType("int");

                    b.Property<string>("DeviceServiceHistory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceServiceReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ServiceDelayStatus")
                        .HasColumnType("bit");

                    b.Property<string>("ServicePriority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceWorker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ServisStatus")
                        .HasColumnType("bit");

                    b.HasKey("ServiceId");

                    b.HasIndex("ComputerId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ServiceHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ComputerId")
                        .HasColumnType("int");

                    b.Property<string>("DeviceChangingParts")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeviceDateEntry")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeviceDeliverEntry")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeviceProcessingTime")
                        .HasColumnType("int");

                    b.Property<string>("DeviceServiceReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ServiceDelayStatus")
                        .HasColumnType("bit");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<string>("ServicePriority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceWorker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ServisStatus")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.ToTable("ServiceHistories");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Personal", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Computer", "Computer")
                        .WithOne("Personal")
                        .HasForeignKey("EntityLayer.Concrete.Personal", "ComputerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Computer");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Service", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Computer", "Computer")
                        .WithMany("Services")
                        .HasForeignKey("ComputerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Computer");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ServiceHistory", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Service", "Service")
                        .WithMany("ServiceHistories")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Service");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Computer", b =>
                {
                    b.Navigation("Personal");

                    b.Navigation("Services");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Service", b =>
                {
                    b.Navigation("ServiceHistories");
                });
#pragma warning restore 612, 618
        }
    }
}
