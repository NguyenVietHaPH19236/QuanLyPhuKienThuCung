﻿using System.Collections.Generic;

namespace CSharp5.Models
{
    public class SanPhamChiTiet
    {
        public int Id { get; set; }
        public string TenSP { get; set; }
        public string MoTa { get; set; }
        public double GiaNhap { get; set; }
        public double GianBan { get; set; }
        public int SoLuong { get; set; }
        public bool TrangThai { get; set; }

        public int Id_SP { get; set; }
        public SanPham sanPham { get; set; }

        public List<HoaDon> hoaDons { get; set; }

        public List<HinhAnhSP> hinhAnhSPs { get; set; }
        public List<Size> Sizes { get; set; }
        public List<NhaCungCap> nhaCungCaps { get; set; }
        public List<SPCT_Mau> sPCT_Maus { get; set; }

    }
}
