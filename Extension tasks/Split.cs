using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_tasks
{
    public static class Split
    {
        public static string[] CustomSplit(this string sentence, char simvol)
        {
            string st1 = "";
            string[] arry = new string[0];

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == simvol)
                {
                    Array.Resize(ref arry, arry.Length + 1);
                    arry[arry.Length - 1] = st1;
                    st1 = string.Empty;
                }
                else
                {
                    st1 += sentence[i];
                }
            }
            Array.Resize(ref arry, arry.Length + 1);
            arry[arry.Length - 1] = st1;
            return arry;
        }
    }
}


