using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[args.Length];

            for (int i = 0; i < args.Length; i++)
            {
                A[i] = int.Parse(args[i]);
            }

            Console.WriteLine("divisible by 3");

            for (int i = 0; i < args.Length; i++) // divisible by 3
            {
                if(A[i]%3 == 0)
                {
                    Console.WriteLine(A[i]);
                }
            }

            Console.WriteLine("not divisible by 5");

            for (int i = 0; i < args.Length; i++) // not divisible by 5
            {
                if (A[i] % 5 != 0)
                {
                    Console.WriteLine(A[i]);
                }
            }

            Console.WriteLine("divisible by 3 but not divisible by 5");

            for (int i = 0; i < args.Length; i++) // divisible by 3 but not divisible by 5
            {
                if (A[i]%3 == 0 && A[i] % 5 != 0)
                {
                    Console.WriteLine(A[i]);
                }
            }
        }
    }
}
