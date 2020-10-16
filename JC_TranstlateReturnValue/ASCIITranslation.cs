using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Runtime.InteropServices;

namespace JC_TranstlateReturnValue
{
    /// <summary>
    /// 进制的基类
    /// </summary>
    public class BaseDigitSystem
    {
        protected int step;   //进制
        protected int[] d;
        public int[] D => d;
        public BaseDigitSystem(int originData,int step) 
        {
            this.step = step;
            GetData(originData);
        }

        /// <summary>
        /// 除n取余法
        /// 除2取余法，即每次将整数部分除以2，余数为该位权上的数，
        /// 而商继续除以2，余数又为上一个位权上的数，
        /// 这个步骤一直持续下去，直到商为0为止，
        /// 最后读数时候，从最后一个余数读起，一直到最前面的一个余数。 
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public virtual int[] GetData(int originData)
        {
            List<int> temp = new List<int>();           
            int startQuotient = originData;
            while (startQuotient > 0)
            {
                int quotient = startQuotient / step;
                int Remainder = startQuotient % step;
                temp.Add(Remainder);
                startQuotient = quotient;
            }
            d = ((IEnumerable<int>)temp).Reverse().ToArray();
            return d;
        }

        public override string ToString()
        {
            string res = "";
            foreach(var v in d)
            {
                res += v.ToString();
            }
            return res;
        }
    }

    /// <summary>
    /// 二进制
    /// </summary>
    public class BinarySystem : BaseDigitSystem
    {
        public BinarySystem(int originData) : base(originData, 2) { }
    }

    /// <summary>
    /// 10进制
    /// </summary>
    public class DecimalSystem : BaseDigitSystem
    {
        public DecimalSystem(int originData) : base(originData, 10) { }
    }

    /// <summary>
    /// 16进制
    /// </summary>
    public class Hexadecimal : BaseDigitSystem
    {
        public Hexadecimal(int originData) : base(originData, 16) { }

    }
}
