using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau2
{
    public class ClassCau2
    {
        public int Tong(int n)
        {
            int i = 1;
            int tong = 0;
            while (i < n)
            {
                tong += i;
                i++;
            }
            return tong;
        }
    }
}
