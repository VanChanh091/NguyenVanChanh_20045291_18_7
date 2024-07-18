using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau1
{
    public class ClassCau1
    {
        string[] ssList = new string[100];
        int ssCount = 0;

        public int SIndex(string s) {
            for(int i = 0; i < ssCount; i++)
            {
                if(ssList[i] == s)
                {
                    return i;
                }
            }
            ssList[ssCount] = s;
            ssCount++;
            return ssCount;
        }
    }
}
