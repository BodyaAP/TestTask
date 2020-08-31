using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    class Program
    {
        static public void Show(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }

        static void Main(string[] args)
        {
            int[] input = { 1, 2, 3, 4, 4, 56 };
            int[] temp = new int[input.Length];
            int[] output;
            int countZero = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < temp.Length; j++)
                {
                    if (input[i] == temp[j])
                    {
                        break;
                    }

                    if (input[i] != temp[j] && temp[j] == 0)
                    {
                        temp[j] = input[i];
                        break;
                    }
                }
            }

            for (int i = 0; i < temp.Length; i++)
            {
                if(temp[i] == 0)
                {
                    countZero++;
                }
            }

            output = new int[input.Length - countZero];

            for(int i = 0; i < output.Length; i++)
            {
                output[i] = temp[i];
            }

            Show(input);
            Console.WriteLine();
            Show(output);

            Console.ReadKey();
        }
    }
}
