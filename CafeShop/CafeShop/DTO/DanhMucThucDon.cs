using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO
{
    [Table("DanhMucThucDon")]
    public class DanhMucThucDon
    {
        public DanhMucThucDon()
        {
            this.Mons = new HashSet<Mon>();
        }
        [Key]
        [StringLength(10)]
        public string MaDanhMuc { get; set; }
        [StringLength(50)]
        public string TenDanhMuc { get; set; }
        public virtual ICollection<Mon> Mons { get; set; }
        public override string ToString()
        {
            return TenDanhMuc;
        }
    }
}