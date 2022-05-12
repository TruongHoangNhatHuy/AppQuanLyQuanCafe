using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO
{
    [Table("CongThuc")]
    public class CongThuc
    {
        [Key]
        [StringLength(10)]
        public string MaCongThuc { get; set; }
        [StringLength(10)]
        public string MaMon { get; set; }
        [StringLength(10)]
        public string MaNguyenLieu { get; set; }
        public int DinhLuong { get; set; }
        [ForeignKey("MaMon")]
        public virtual Mon Mon { get; set; }
        [ForeignKey("MaNguyenLieu")]
        public virtual NguyenLieu NguyenLieu { get; set; }
    }
}