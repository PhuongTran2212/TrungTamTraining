﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrungTamDaoTao.Data;

#nullable disable

namespace TrungTamDaoTao.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250420033135_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TrungTamDaoTao.Models.DangKyHoc", b =>
                {
                    b.Property<int>("HocVienId")
                        .HasColumnType("int");

                    b.Property<int>("KhoaHocId")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayDangKy")
                        .HasColumnType("datetime(6)");

                    b.HasKey("HocVienId", "KhoaHocId");

                    b.HasIndex("KhoaHocId");

                    b.ToTable("DangKyHocs");
                });

            modelBuilder.Entity("TrungTamDaoTao.Models.HocVien", b =>
                {
                    b.Property<int>("HocVienId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TaiKhoan")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("HocVienId");

                    b.ToTable("HocViens");
                });

            modelBuilder.Entity("TrungTamDaoTao.Models.KhoaHoc", b =>
                {
                    b.Property<int>("KhoaHocId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("GiangVien")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("HocPhi")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("SoLuongToiDa")
                        .HasColumnType("int");

                    b.Property<string>("TenKhoaHoc")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ThoiGianKhaiGiang")
                        .HasColumnType("datetime(6)");

                    b.HasKey("KhoaHocId");

                    b.ToTable("KhoaHocs");
                });

            modelBuilder.Entity("TrungTamDaoTao.Models.DangKyHoc", b =>
                {
                    b.HasOne("TrungTamDaoTao.Models.HocVien", "HocVien")
                        .WithMany("DangKyHocs")
                        .HasForeignKey("HocVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrungTamDaoTao.Models.KhoaHoc", "KhoaHoc")
                        .WithMany("DangKyHocs")
                        .HasForeignKey("KhoaHocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HocVien");

                    b.Navigation("KhoaHoc");
                });

            modelBuilder.Entity("TrungTamDaoTao.Models.HocVien", b =>
                {
                    b.Navigation("DangKyHocs");
                });

            modelBuilder.Entity("TrungTamDaoTao.Models.KhoaHoc", b =>
                {
                    b.Navigation("DangKyHocs");
                });
#pragma warning restore 612, 618
        }
    }
}
