using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC_TranstlateReturnValue
{
    enum TypeASCII
    {
        二进制,
        十进制,
        十六进制,
        字符串,
    }



    /// <summary>
    /// 二进制ascii码
    /// </summary>
    class ASCII:Hexadecimal
    {
        byte val;
        public ASCII():base(0)
        {
        }
        public ASCII(byte val):base(val)
        {
            this.val = val;
        }
        public static char GetHex(byte d)
        => Convert.ToChar(d);
        public string ToBinaryString()
        {
            int length = d.Length - 1;
            string res = "";
            for (int i = 0; i < length; i+=2)
            {
                int before = d[i];
                int after = d[i + 1];
                if (after > 0)
                    res += GetHex((byte)(before + after));
                else
                {
                    res += GetHex((byte)(before));
                    res += "0";
                }                
            }
            return length % 2 > 0 ? res + GetHex((byte)d[length - 1]) : res;
        }
    }
}
