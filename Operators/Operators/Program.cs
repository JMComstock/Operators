using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            Console.WriteLine(a + b);

            var c = 10;
            var d = 3;
            Console.WriteLine((float)c / (float)d);

            var e = 1;
            var f = 2;
            var g = 3;
            Console.WriteLine(e + f * g);
            Console.WriteLine((e + f) * g);


        }
    }
}
