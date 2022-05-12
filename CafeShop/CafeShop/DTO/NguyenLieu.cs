using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO
{
    [Table("NguyenLieu")]
    public class NguyenLieu
    {
        public NguyenLieu()
        {
            this.LoHangs = new HashSet<LoHang>();
            this.CongThucs = new HashSet<CongThuc>();
        }
        [Key]
        [StringLength(10)]
        public string MaNguyenLieu { get; set; }
        [StringLength(50)]
        public string TenNguyenLieu { get; set; }
        public int SoLuong { get; set; }
        [StringLength(10)]
        public string DonVi { get; set; }
        public virtual ICollection<LoHang> LoHangs { get; set; }
        public virtual ICollection<CongThuc> CongThucs { get; set; }
    }
}