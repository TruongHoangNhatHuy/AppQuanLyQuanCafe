using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShop.BLL
{
    public class BLLCustomerInfo
    {
        //design pattern singleton
        private static BLLCustomerInfo _Instance;
        public static BLLCustomerInfo Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLLCustomerInfo();
                }
                return _Instance;
            }
            private set { }
        }
    }
}
