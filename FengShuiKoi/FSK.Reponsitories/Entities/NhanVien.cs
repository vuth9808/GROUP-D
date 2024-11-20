using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FSK.Reponsitories.Entities;

public partial class NhanVien
{
    public string MaNhanVien { get; set; } = null!;
    [Display(Name = "Họ và tên")]
    public string HoTen { get; set; } = null!;
    [Display(Name = "Ngày Tháng Năm Sinh")]
    public DateOnly NgayThangNamSinh { get; set; }
    [Display(Name = "Tuổi")]
    public int Tuoi { get; set; }
    [Display(Name = "Giới tính")]
    public bool GioiTinh { get; set; }
    [Display(Name = "Số điện thoại")]
    public string SoDienThoai { get; set; } = null!;
    [Display(Name = "Email")]
    public string? Email { get; set; }
    [Display(Name = "Mật Khẩu")]
    public string MatKhau { get; set; } = null!;
    [Display(Name = "Ngày Thêm ")]
    public DateTime? NgayThem { get; set; }
    [Display(Name = "Ngày Chỉnh sửa")]
    public DateTime? NgayChinhSua { get; set; }
}
