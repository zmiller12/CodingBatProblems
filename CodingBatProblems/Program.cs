using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatProblems
{
    class Program
    {
        static void Main()
        {
            RecursionProblems rp = new RecursionProblems();


            Console.WriteLine(rp.factorial(5));
            Console.WriteLine(rp.bunnyEars(3));
            Console.WriteLine(rp.fibonacci(7));
            Console.WriteLine(rp.bunnyEars2(10));
            Console.WriteLine(rp.triangle(7));
            Console.WriteLine(rp.sumDigits(123));
            Console.WriteLine(rp.count7(78778));
            Console.WriteLine(rp.count8(88028));
            Console.WriteLine(rp.powerN(3, 6));
            Console.WriteLine(rp.countX("xxhixx"));
            Console.WriteLine(rp.countHi("xhixhxihihhhih"));
            Console.WriteLine(rp.changeXY("codex"));
            Console.WriteLine(rp.changePi("pixxpi"));
            Console.WriteLine(rp.noX("p90xxabxx"));
            Console.WriteLine(rp.array6(new int[] { 1, 0, 8, 6},0));
            Console.WriteLine(rp.array11(new int[] { 1, 11, 2, 11, 6, 4, 11 }, 0));
        }
    }
}
