using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suzdavane_na_duma
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte n = sbyte.Parse(Console.ReadLine());
            string word = "";
            for (sbyte i = 1; i <= n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                word = word + letter;
            }
            Console.WriteLine(word);
            Console.ReadLine();
        }
    }
}
