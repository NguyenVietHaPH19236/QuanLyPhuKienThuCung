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
    [Migration("20230202085728_AddRelationofSPCT_ncc")]
    partial class AddRelationofSPCT_ncc
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

                    b.HasKey("Id");

                    b.HasIndex("Id_SPCT");

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

                    b.Property<double>("GiaSP")
                        .HasColumnType("float");

                    b.Property<string>("HinhThucThanhToan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_diachi")
                        .HasColumnType("int");

                    b.Property<int>("Id_spct")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayThanhToan")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Id_diachi");

                    b.HasIndex("Id_spct");

                    b.ToTable("hoaDons");
                });

            modelBuilder.Entity("CSharp5.Models.Mau", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaHex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaRGB")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("maus");
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

                    b.HasKey("Id");

                    b.HasIndex("Id_SPCT");

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

                    b.HasKey("Id");

                    b.HasIndex("Id_phanquyen");

                    b.ToTable("quanLis");
                });

            modelBuilder.Entity("CSharp5.Models.SPCT_Mau", b =>
                {
                    b.Property<int>("Id_mau")
                        .HasColumnType("int");

                    b.Property<int>("Id_spct")
                        .HasColumnType("int");

                    b.HasKey("Id_mau", "Id_spct");

                    b.HasIndex("Id_spct");

                    b.ToTable("sPCT_Maus");
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

                    b.HasKey("Id");

                    b.HasIndex("Id_SP");

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

                    b.Property<int>("size")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_SPCT");

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

                    b.HasKey("Id");

                    b.HasIndex("Id_hoadon");

                    b.HasIndex("Id_quanli");

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
                        .HasForeignKey("Id_SPCT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
                        .HasForeignKey("Id_spct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("diaChi");

                    b.Navigation("sanPhamChiTiet");
                });

            modelBuilder.Entity("CSharp5.Models.NhaCungCap", b =>
                {
                    b.HasOne("CSharp5.Models.SanPhamChiTiet", "sanPhamChiTiet")
                        .WithMany("nhaCungCaps")
                        .HasForeignKey("Id_SPCT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("sanPhamChiTiet");
                });

            modelBuilder.Entity("CSharp5.Models.QuanLi", b =>
                {
                    b.HasOne("CSharp5.Models.PhanQuyen", "phanQuyen")
                        .WithMany("quanLis")
                        .HasForeignKey("Id_phanquyen")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("phanQuyen");
                });

            modelBuilder.Entity("CSharp5.Models.SPCT_Mau", b =>
                {
                    b.HasOne("CSharp5.Models.Mau", "mau")
                        .WithMany("sPCT_Maus")
                        .HasForeignKey("Id_mau")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CSharp5.Models.SanPhamChiTiet", "sanPhamChiTiet")
                        .WithMany("sPCT_Maus")
                        .HasForeignKey("Id_spct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("mau");

                    b.Navigation("sanPhamChiTiet");
                });

            modelBuilder.Entity("CSharp5.Models.SanPhamChiTiet", b =>
                {
                    b.HasOne("CSharp5.Models.SanPham", "sanPham")
                        .WithMany("sanPhamChiTiets")
                        .HasForeignKey("Id_SP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("sanPham");
                });

            modelBuilder.Entity("CSharp5.Models.Size", b =>
                {
                    b.HasOne("CSharp5.Models.SanPhamChiTiet", "sanPhamChiTiet")
                        .WithMany("Sizes")
                        .HasForeignKey("Id_SPCT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
                        .HasForeignKey("Id_quanli")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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

            modelBuilder.Entity("CSharp5.Models.Mau", b =>
                {
                    b.Navigation("sPCT_Maus");
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

                    b.Navigation("sPCT_Maus");
                });
#pragma warning restore 612, 618
        }
    }
}
