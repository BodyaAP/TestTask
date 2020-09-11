using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Stopwatch swr = new Stopwatch();
            Stopwatch sw = new Stopwatch();

            int n = 45;
            int fr;
            int f;

            swr.Start();
            fr = fibonacciRec(n);
            swr.Stop();

            sw.Start();
            f = fibonacci(n);
            sw.Stop();

            Console.WriteLine(fr);
            Console.WriteLine(swr.ElapsedMilliseconds);
            Console.WriteLine(new string('-', 10));

            Console.WriteLine(f);
            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.WriteLine(new string('-', 10));

            Console.ReadKey();
        }
    }
}
