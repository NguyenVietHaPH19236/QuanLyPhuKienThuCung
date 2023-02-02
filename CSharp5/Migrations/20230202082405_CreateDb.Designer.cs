﻿// <auto-generated />
using System;
using CSharp5.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CSharp5.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230202082405_CreateDb")]
    partial class CreateDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CSharp5.Models.DiaChi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_Nguoidung")
                        .HasColumnType("int");

                    b.Property<string>("diachi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Nguoidung");

                    b.ToTable("diaChis");
                });

            modelBuilder.Entity("CSharp5.Models.HinhAnhSP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_SPCT")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("sanPhamChiTietId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("sanPhamChiTietId");

                    b.ToTable("hinhAnhSPs");
                });

            modelBuilder.Entity("CSharp5.Models.HoaDon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HinhThucThanhToan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_diachi")
                        .HasColumnType("int");

                    b.Property<int>("Id_spct")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayThanhToan")
                        .HasColumnType("datetime2");

                    b.Property<int?>("sanPhamChiTietId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_diachi");

                    b.HasIndex("sanPhamChiTietId");

                    b.ToTable("hoaDons");
                });

            modelBuilder.Entity("CSharp5.Models.NguoiDung", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NguoiDungs");
                });

            modelBuilder.Entity("CSharp5.Models.NhaCungCap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_SPCT")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("sanPhamChiTietId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("sanPhamChiTietId");

                    b.ToTable("nhaCungCaps");
                });

            modelBuilder.Entity("CSharp5.Models.PhanQuyen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("phanQuyens");
                });

            modelBuilder.Entity("CSharp5.Models.QuanLi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_phanquyen")
                        .HasColumnType("int");

                    b.Property<string>("Matkhau")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.Property<int?>("phanQuyenId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("phanQuyenId");

                    b.ToTable("quanLis");
                });

            modelBuilder.Entity("CSharp5.Models.SanPham", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DanhMuc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TheLoai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("sanPhams");
                });

            modelBuilder.Entity("CSharp5.Models.SanPhamChiTiet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("GiaNhap")
                        .HasColumnType("float");

                    b.Property<double>("GianBan")
                        .HasColumnType("float");

                    b.Property<int>("Id_SP")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenSP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.Property<int?>("sanPhamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("sanPhamId");

                    b.ToTable("sanPhamChiTiets");
                });

            modelBuilder.Entity("CSharp5.Models.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_SPCT")
                        .HasColumnType("int");

                    b.Property<int?>("sanPhamChiTietId")
                        .HasColumnType("int");

                    b.Property<int>("size")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("sanPhamChiTietId");

                    b.ToTable("sizes");
                });

            modelBuilder.Entity("CSharp5.Models.TrangThai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan>("Gio")
                        .HasColumnType("time");

                    b.Property<int>("Id_hoadon")
                        .HasColumnType("int");

                    b.Property<int>("Id_quanli")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayThang")
                        .HasColumnType("datetime2");

                    b.Property<int?>("quanLiId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_hoadon");

                    b.HasIndex("quanLiId");

                    b.ToTable("trangThais");
                });

            modelBuilder.Entity("CSharp5.Models.DiaChi", b =>
                {
                    b.HasOne("CSharp5.Models.NguoiDung", "nguoiDung")
                        .WithMany("diaChis")
                        .HasForeignKey("Id_Nguoidung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("nguoiDung");
                });

            modelBuilder.Entity("CSharp5.Models.HinhAnhSP", b =>
                {
                    b.HasOne("CSharp5.Models.SanPhamChiTiet", "sanPhamChiTiet")
                        .WithMany("hinhAnhSPs")
                        .HasForeignKey("sanPhamChiTietId");

                    b.Navigation("sanPhamChiTiet");
                });

            modelBuilder.Entity("CSharp5.Models.HoaDon", b =>
                {
                    b.HasOne("CSharp5.Models.DiaChi", "diaChi")
                        .WithMany("hoaDons")
                        .HasForeignKey("Id_diachi")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CSharp5.Models.SanPhamChiTiet", "sanPhamChiTiet")
                        .WithMany("hoaDons")
                        .HasForeignKey("sanPhamChiTietId");

                    b.Navigation("diaChi");

                    b.Navigation("sanPhamChiTiet");
                });

            modelBuilder.Entity("CSharp5.Models.NhaCungCap", b =>
                {
                    b.HasOne("CSharp5.Models.SanPhamChiTiet", "sanPhamChiTiet")
                        .WithMany("nhaCungCaps")
                        .HasForeignKey("sanPhamChiTietId");

                    b.Navigation("sanPhamChiTiet");
                });

            modelBuilder.Entity("CSharp5.Models.QuanLi", b =>
                {
                    b.HasOne("CSharp5.Models.PhanQuyen", "phanQuyen")
                        .WithMany("quanLis")
                        .HasForeignKey("phanQuyenId");

                    b.Navigation("phanQuyen");
                });

            modelBuilder.Entity("CSharp5.Models.SanPhamChiTiet", b =>
                {
                    b.HasOne("CSharp5.Models.SanPham", "sanPham")
                        .WithMany("sanPhamChiTiets")
                        .HasForeignKey("sanPhamId");

                    b.Navigation("sanPham");
                });

            modelBuilder.Entity("CSharp5.Models.Size", b =>
                {
                    b.HasOne("CSharp5.Models.SanPhamChiTiet", "sanPhamChiTiet")
                        .WithMany("Sizes")
                        .HasForeignKey("sanPhamChiTietId");

                    b.Navigation("sanPhamChiTiet");
                });

            modelBuilder.Entity("CSharp5.Models.TrangThai", b =>
                {
                    b.HasOne("CSharp5.Models.HoaDon", "hoaDon")
                        .WithMany("trangThais")
                        .HasForeignKey("Id_hoadon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CSharp5.Models.QuanLi", "quanLi")
                        .WithMany("trangThais")
                        .HasForeignKey("quanLiId");

                    b.Navigation("hoaDon");

                    b.Navigation("quanLi");
                });

            modelBuilder.Entity("CSharp5.Models.DiaChi", b =>
                {
                    b.Navigation("hoaDons");
                });

            modelBuilder.Entity("CSharp5.Models.HoaDon", b =>
                {
                    b.Navigation("trangThais");
                });

            modelBuilder.Entity("CSharp5.Models.NguoiDung", b =>
                {
                    b.Navigation("diaChis");
                });

            modelBuilder.Entity("CSharp5.Models.PhanQuyen", b =>
                {
                    b.Navigation("quanLis");
                });

            modelBuilder.Entity("CSharp5.Models.QuanLi", b =>
                {
                    b.Navigation("trangThais");
                });

            modelBuilder.Entity("CSharp5.Models.SanPham", b =>
                {
                    b.Navigation("sanPhamChiTiets");
                });

            modelBuilder.Entity("CSharp5.Models.SanPhamChiTiet", b =>
                {
                    b.Navigation("hinhAnhSPs");

                    b.Navigation("hoaDons");

                    b.Navigation("nhaCungCaps");

                    b.Navigation("Sizes");
                });
#pragma warning restore 612, 618
        }
    }
}
