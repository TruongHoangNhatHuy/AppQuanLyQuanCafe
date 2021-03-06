using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO
{
    [Table("Ban")]
    public class Ban
    {
        [Key]
        [StringLength(10)]
        public string MaBan { get; set; }
        [StringLength(20)]
        public string TenBan { get; set; }
        public bool TinhTrang { get; set; } // true:trống, false:bận

        [StringLength(10)]
        public string MaKhuVuc { get; set; }
        [ForeignKey("MaKhuVuc")]
        public virtual KhuVuc KhuVuc { get; set; }
    }
}
