using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeShop.DTO
{
    [Table("HangHoa")]
    public class HangHoa
    {
        public HangHoa()
        {
            this.LoHangs = new HashSet<LoHang>();
        }
        [Key]
        [StringLength(10)]
        public string MaHangHoa { get; set; }
        [StringLength(50)]
        public string TenHangHoa { get; set; }
        public int SoLuong { get; set; }
        [StringLength(10)]
        public string DonVi { get; set; }
        [StringLength(10)]
        public string MaMon { get; set; }
        //[ForeignKey("MaMon")]
        //public virtual Mon Mon { get; set; }

        public virtual ICollection<LoHang> LoHangs { get; set; }
    }
}
