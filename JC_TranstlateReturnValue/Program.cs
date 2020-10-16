using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC_TranstlateReturnValue
{
    class Program
    {
        static void Main(string[] args)
        {
            ASCII asc = new ASCII(15);

            Console.WriteLine(asc.ToBinaryString());
            Console.ReadKey();
            BinarySystem bin = new BinarySystem(byte.MaxValue);
            Console.WriteLine($"{bin.D.Count()},{bin.ToString()},{Byte.MaxValue}");
            bin = new BinarySystem(char.MaxValue);
            Console.WriteLine($"{bin.D.Count()},{bin.ToString()},{UInt16.MaxValue}");
            bin = new BinarySystem(int.MaxValue);
            Console.WriteLine($"{bin.D.Count()},{bin.ToString()},{Int32.MaxValue}:(int最大值的最高位为0)");
            
            ////////////////////////////////
            DecimalSystem dec = new DecimalSystem(Byte.MaxValue);
            Console.WriteLine($"{dec.D.Count()},{dec.ToString()},{Byte.MaxValue}");
            dec = new DecimalSystem(Char.MaxValue);
            Console.WriteLine($"{dec.D.Count()},{dec.ToString()},{UInt16.MaxValue}");
            dec = new DecimalSystem(int.MaxValue);
            Console.WriteLine($"{dec.D.Count()},{dec.ToString()},{Int32.MaxValue}");

            Console.ReadKey();
        }
    }
}
