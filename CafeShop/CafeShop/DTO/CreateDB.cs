using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO
{
    public class CreateDB :
            //CreateDatabaseIfNotExists<DBModel>
            //DropCreateDatabaseIfModelChanges<DBModel>
            DropCreateDatabaseAlways<DBModel>
    {
        protected override void Seed(DBModel context)
        {
            context.VaiTroes.AddRange(new VaiTro[]
            {
                new VaiTro { MaVaiTro = "VT00000001", TenVaiTro = "Chủ cửa hàng"},
                new VaiTro { MaVaiTro = "VT00000002", TenVaiTro = "Nhân viên"}
            });
            context.TaiKhoans.AddRange(new TaiKhoan[]
            {
                new TaiKhoan { ID = "TK00000001", TenTaiKhoan = "admin", MatKhau = "admin", HoTen = "Trương Hoàng Nhật Huy", GioiTinh = true, NgaySinh = DateTime.MinValue, NgayBatDauLamViec = DateTime.MinValue, MaVaiTro = "VT00000001"},
                new TaiKhoan { ID = "TK00000002", TenTaiKhoan = "user", MatKhau = "user", HoTen = "Nguyễn Ngọc Hải", GioiTinh = true, NgaySinh = DateTime.MinValue, NgayBatDauLamViec = DateTime.MinValue, MaVaiTro = "VT00000002"}
            });
            context.KhachHangs.AddRange(new KhachHang[]
            {
                new KhachHang { IDKhachHang = "", HoTenKH = "Không có", NgaySinhKH = DateTime.MinValue, SoDienThoaiKH = "0", NgayDangKi = DateTime.MinValue},
                new KhachHang { IDKhachHang = "KH00000001", HoTenKH = "Trương Hoàng Nhật Huy", NgaySinhKH = DateTime.MinValue, SoDienThoaiKH = "0123456789", NgayDangKi = DateTime.MinValue},
                new KhachHang { IDKhachHang = "KH00000002", HoTenKH = "Nguyễn Ngọc Hải", NgaySinhKH = DateTime.MinValue, SoDienThoaiKH = "9876543210", NgayDangKi = DateTime.MinValue}
            });
            context.KhuVucs.AddRange(new KhuVuc[]
            {
                new KhuVuc { MaKhuVuc = "KV00000001", TenKhuVuc = "Trong nhà", SoLuongBan = 0},
                new KhuVuc { MaKhuVuc = "KV00000002", TenKhuVuc = "Ngoài trời", SoLuongBan = 0}
            });
            context.Bans.AddRange(new Ban[]
            {
                new Ban { MaBan = "B00000001", TenBan = "Bàn 1 trong nhà", TinhTrang = true, MaKhuVuc = "KV00000001"},
                new Ban { MaBan = "B00000002", TenBan = "Bàn 1 ngoài trời", TinhTrang = false, MaKhuVuc = "KV00000002"}
            });
            context.DanhMucThucDons.AddRange(new DanhMucThucDon[]
            {
                new DanhMucThucDon { MaDanhMuc = "DM00000001", TenDanhMuc = "Cà phê"},
                new DanhMucThucDon { MaDanhMuc = "DM00000002", TenDanhMuc = "Trà"},
                new DanhMucThucDon { MaDanhMuc = "DM00000003", TenDanhMuc = "Giải khát"}
            });
            context.Mons.AddRange(new Mon[]
            {
                new Mon { MaMon = "M00000001", TenMon = "Cà phê đen", DonGia = 10000, DonVi = "Ly", MaDanhMuc = "DM00000001"},
                new Mon { MaMon = "M00000002", TenMon = "Cà phê sữa", DonGia = 12000, DonVi = "Ly", MaDanhMuc = "DM00000001"},
                new Mon { MaMon = "M00000003", TenMon = "Trà gừng", DonGia = 20000, DonVi = "Ly", MaDanhMuc = "DM00000002"},
                new Mon { MaMon = "M00000004", TenMon = "Trà chanh", DonGia = 10000, DonVi = "Ly", MaDanhMuc = "DM00000002"},
                new Mon { MaMon = "M00000005", TenMon = "Cola chai", DonGia = 12000, DonVi = "Chai", MaDanhMuc = "DM00000003"},
                new Mon { MaMon = "M00000006", TenMon = "Sting chai", DonGia = 12000, DonVi = "Chai", MaDanhMuc = "DM00000003"}
            });
            context.NguyenLieux.AddRange(new NguyenLieu[]
            {
                new NguyenLieu { MaNguyenLieu = "NL00000001", TenNguyenLieu = "Cà phê hạt", SoLuong = 0, DonVi = "g"},
                new NguyenLieu { MaNguyenLieu = "NL00000002", TenNguyenLieu = "Sữa đặc", SoLuong = 0, DonVi = "ml"},
                new NguyenLieu { MaNguyenLieu = "NL00000003", TenNguyenLieu = "Trà", SoLuong = 0, DonVi = "g"},
                new NguyenLieu { MaNguyenLieu = "NL00000004", TenNguyenLieu = "Gừng khô", SoLuong = 0, DonVi = "g"},
                new NguyenLieu { MaNguyenLieu = "NL00000005", TenNguyenLieu = "Chanh tươi", SoLuong = 0, DonVi = "quả"},
                new NguyenLieu { MaNguyenLieu = "NL00000006", TenNguyenLieu = "Cola chai", SoLuong = 0, DonVi = "chai"},
                new NguyenLieu { MaNguyenLieu = "NL00000007", TenNguyenLieu = "Sting chai", SoLuong = 0, DonVi = "chai"}
            });
            context.CongThucs.AddRange(new CongThuc[]
            {
                new CongThuc { MaCongThuc = "CT00000001", MaMon = "M00000001", MaNguyenLieu = "NL00000001", DinhLuong = 100},
                new CongThuc { MaCongThuc = "CT00000002", MaMon = "M00000002", MaNguyenLieu = "NL00000001", DinhLuong = 100},
                new CongThuc { MaCongThuc = "CT00000003", MaMon = "M00000002", MaNguyenLieu = "NL00000002", DinhLuong = 50},
                new CongThuc { MaCongThuc = "CT00000004", MaMon = "M00000003", MaNguyenLieu = "NL00000003", DinhLuong = 100},
                new CongThuc { MaCongThuc = "CT00000005", MaMon = "M00000003", MaNguyenLieu = "NL00000004", DinhLuong = 30},
                new CongThuc { MaCongThuc = "CT00000006", MaMon = "M00000004", MaNguyenLieu = "NL00000003", DinhLuong = 100},
                new CongThuc { MaCongThuc = "CT00000007", MaMon = "M00000004", MaNguyenLieu = "NL00000005", DinhLuong = 1},
                new CongThuc { MaCongThuc = "CT00000008", MaMon = "M00000005", MaNguyenLieu = "NL00000006", DinhLuong = 1},
                new CongThuc { MaCongThuc = "CT00000009", MaMon = "M00000006", MaNguyenLieu = "NL00000007", DinhLuong = 1}
            });
            context.HoaDons.AddRange(new HoaDon[]
            {
                new HoaDon { MaHoaDon = "2022051117352773", IDNhanVien = "TK00000002", IDKhachHang = "", MaBan = "B00000001", PhuThu = "0", GiamGia = "0", ThanhTien = 0, ThoiGianThanhToan = DateTime.MinValue},
                new HoaDon { MaHoaDon = "2022051119401331", IDNhanVien = "TK00000002", IDKhachHang = "", MaBan = "B00000002", PhuThu = "0", GiamGia = "0", ThanhTien = 0, ThoiGianThanhToan = DateTime.MinValue}
            });
            context.DonGoiMons.AddRange(new DonGoiMon[]
            {
                new DonGoiMon { MaDonGoiMon = "2022051117353082", MaHoaDon = "2022051117352773", MaMon = "M00000002", SoLuong = 2, GiaTien = 24000, ThoiGianGoiMon = DateTime.MinValue, TinhTrang = "Hoàn thành"},
                new DonGoiMon { MaDonGoiMon = "2022051117354263", MaHoaDon = "2022051117352773", MaMon = "M00000005", SoLuong = 1, GiaTien = 12000, ThoiGianGoiMon = DateTime.MinValue, TinhTrang = "Hoàn thành"},
                new DonGoiMon { MaDonGoiMon = "2022051118042729", MaHoaDon = "2022051117352773", MaMon = "M00000001", SoLuong = 1, GiaTien = 00000, ThoiGianGoiMon = DateTime.MinValue, TinhTrang = "Đang chờ"},
                new DonGoiMon { MaDonGoiMon = "2022051119402318", MaHoaDon = "2022051119401331", MaMon = "M00000003", SoLuong = 1, GiaTien = 20000, ThoiGianGoiMon = DateTime.MinValue, TinhTrang = "Hoàn thành"},
                new DonGoiMon { MaDonGoiMon = "2022051119402733", MaHoaDon = "2022051119401331", MaMon = "M00000004", SoLuong = 3, GiaTien = 30000, ThoiGianGoiMon = DateTime.MinValue, TinhTrang = "Đang thực hiện"},
                new DonGoiMon { MaDonGoiMon = "2022051119454893", MaHoaDon = "2022051119401331", MaMon = "M00000006", SoLuong = 1, GiaTien = 12000, ThoiGianGoiMon = DateTime.MinValue, TinhTrang = "Hoàn thành"}
            });
        }
    }
}
