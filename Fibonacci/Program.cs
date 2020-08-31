using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static public int fibonacciRec(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return fibonacciRec(n - 1) + fibonacciRec(n - 2);
            }
        }

        static public int fibonacci(int n)
        {
            int f1 = 0;
            int f2 = 0;
            int fn = 0;

            for(int i = 1; i<=n;i++)
            {
                fn = f1 + f2;

                if(i==1)
                {
                    fn = 1;
                }

                f1 = f2;
                f2 = fn;
            }

            return fn;
        }

        static void Main(string[] args)
        {
            int n = 41;
            int fr;
            int f;

            fr = fibonacciRec(n);
            f = fibonacci(n);

            Console.WriteLine(fr);
            Console.WriteLine(f);

            Console.ReadKey();
        }
    }
}
