using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO
{
    public class KhuvucCBItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
