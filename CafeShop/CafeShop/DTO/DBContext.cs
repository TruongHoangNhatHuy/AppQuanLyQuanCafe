using System;
using System.Data.Entity;
using System.Linq;

namespace CafeShop.DTO
{
    public class DBContext : DbContext
    {
        private static DBContext _Instance;
        public static DBContext Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DBContext();
                }
                return _Instance;
            }
            private set { }
        }
        private DBContext()
                    : base("name=DBContext")
        {
            Database.SetInitializer<DBContext>(new CreateDB());
        }
        public virtual DbSet<Ban> Bans { get; set; }
        public virtual DbSet<DanhMucThucDon> DanhMucThucDons { get; set; }
        public virtual DbSet<DonGoiMon> DonGoiMons { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<KhuVuc> KhuVucs { get; set; }
        public virtual DbSet<LoHang> LoHangs { get; set; }
        public virtual DbSet<Mon> Mons { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; } 
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<VaiTro> VaiTroes { get; set; }
    }
}