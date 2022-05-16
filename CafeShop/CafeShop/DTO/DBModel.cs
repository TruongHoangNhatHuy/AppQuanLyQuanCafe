using System;
using System.Data.Entity;
using System.Linq;

namespace CafeShop.DTO
{
    public class DBModel : DbContext
    {
        private static DBModel _Instance;
        public static DBModel Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DBModel();
                }
                return _Instance;
            }
            private set { }
        }
        private DBModel()
                    : base("name=DBModel")
        {
            Database.SetInitializer<DBModel>(new CreateDB());
        }
        public virtual DbSet<Ban> Bans { get; set; }
        public virtual DbSet<DanhMucThucDon> DanhMucThucDons { get; set; }
        public virtual DbSet<DonGoiMon> DonGoiMons { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<KhuVuc> KhuVucs { get; set; }
        public virtual DbSet<LoHang> LoHangs { get; set; }
        public virtual DbSet<Mon> Mons { get; set; }
        public virtual DbSet<NguyenLieu> NguyenLieux { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<VaiTro> VaiTroes { get; set; }
        public virtual DbSet<CongThuc> CongThucs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Sửa lỗi DateTime OutOfRange
            modelBuilder.Properties<DateTime>().Configure(c => c.HasColumnType("datetime2"));
        }
    }
}