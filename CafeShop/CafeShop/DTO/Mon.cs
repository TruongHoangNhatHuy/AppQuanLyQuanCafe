using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO
{
    [Table("Mon")]
    public class Mon
    {
        public Mon()
        {
            this.CongThucs = new HashSet<CongThuc>();
            this.DonGoiMons = new HashSet<DonGoiMon>();
        }
        [Key]
        [StringLength(10)]
        public string MaMon { get; set; }
        [StringLength(50)]
        public string TenMon { get; set; }
        public int DonGia { get; set; }
        [StringLength(10)]
        public string DonVi { get; set; }
        [StringLength(10)]
        public string MaDanhMuc { get; set; }
        [ForeignKey("MaDanhMuc")]
        public virtual DanhMucThucDon DanhMucThucDon { get; set; }
        public virtual ICollection<CongThuc> CongThucs { get; set; }
        public virtual ICollection<DonGoiMon> DonGoiMons { get; set; }
        public override string ToString()
        {
            return TenMon;
        }
    }
}