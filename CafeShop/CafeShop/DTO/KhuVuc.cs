using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO
{
    [Table("KhuVuc")]
    public class KhuVuc
    {
        public KhuVuc()
        {
            this.Bans = new HashSet<Ban>();
        }

        [Key]
        [StringLength(10)]
        public string MaKhuVuc { get; set; }
        [StringLength(50)]
        public string TenKhuVuc { get; set; }
        public int SoLuongBan { get; set; }

        public virtual ICollection<Ban> Bans { get; set; }

        public override string ToString()
        {
            return TenKhuVuc;
        }
    }
}