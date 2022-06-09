using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.BLL
{
    public class PrimaryKeyGenerator
    {
        public static string GetCurrentKey(List<string> list) => list.Max();

        // Phương thức tạo khóa chính tiếp theo cho các bảng
        public static string NextPrimaryKey(string currentKey)
        {
            string nextKey = "";
            int nextIndex = 0;
            if (currentKey.Length == 10)
            {
                nextKey = currentKey.Substring(0, 2);
                nextIndex = Convert.ToInt32(currentKey.Substring(2)) + 1;
                for (int i = 8; i > nextIndex.ToString().Length; i--)
                {
                    nextKey += '0';
                }
                nextKey += nextIndex.ToString();
            }
            else if (currentKey.Length == 9)
            {
                nextKey = currentKey.Substring(0, 1);
                nextIndex = Convert.ToInt32(currentKey.Substring(1)) + 1;
                for (int i = 8; i > nextIndex.ToString().Length; i--)
                {
                    nextKey += '0';
                }
                nextKey += nextIndex.ToString();
            }
            else
                nextKey = "Error";
            return nextKey;
        }

        // Phương thức tạo khóa chính cho HoaDon và DonGoiMon
        public static string OrderBillPrimaryKey()
        {
            return DateTime.Now.ToString("yyyy:MM:dd:HH:mm:ss:fff").Replace(":", String.Empty);
        }
    }
}
