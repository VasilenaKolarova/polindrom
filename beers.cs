using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beers
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte n = sbyte.Parse(Console.ReadLine());
            decimal v = 0.0M;
            decimal bigV = 0.0M;
            string bigModel = "";
            for(sbyte i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                decimal r = decimal.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());
                v = (decimal)Math.PI * r * r * h;
                if (bigV < v)
                {
                    bigV = v;
                    bigModel = model;
                }
            }
            Console.WriteLine(bigModel);
        }
    }
}
