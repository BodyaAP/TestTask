using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "The “C# Professional” course includes the topics I discuss in my CLR via C# book and teaches how the CLR works thereby showing you how to develop applications and reusable components for the .NET Framework.";

            string[] words = s.Split(' ');

            var querty = from item in words.Distinct()
                    group item by item.Length into grp
                    orderby grp.Key
                    select new
                    {
                        Length = grp.Key,
                        Words = grp,
                        WordCount = grp.Count()
                    };

            foreach (var item in querty)
            {
                Console.WriteLine("Words of length: {0}, Count: {1}", item.Length, item.WordCount);

                foreach(var word in item.Words)
                    Console.WriteLine("   {0}", word);
            }

            Console.ReadKey();
        }
    }
}
