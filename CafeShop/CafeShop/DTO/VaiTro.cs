using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO
{
    [Table("VaiTro")]
    public class VaiTro
    {
        public VaiTro()
        {
            this.TaiKhoans = new HashSet<TaiKhoan>();
        }
        [Key]
        [StringLength(10)]
        public string MaVaiTro { get; set; }
        [StringLength(20)]
        public string TenVaiTro { get; set; }
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
        public override string ToString()
        {
            return TenVaiTro;
        }
    }
}