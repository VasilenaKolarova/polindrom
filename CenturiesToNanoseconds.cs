using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vekove_kum_nanosekundi
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte cent = sbyte.Parse(Console.ReadLine());
            int years = cent * 100;
            uint days = (uint)(years * 365.2422);
            uint hours = days * 24;
            ulong mins = hours * 60;
            ulong sec = mins * 60;
            ulong milisec = sec * 1000;
            ulong microsec = milisec * 1000;
            ulong nano = microsec * 1000;
            
            Console.WriteLine($"{cent} centuries = {years} years = {days} days = {hours} hours = " +
            $"{mins} minutes = {sec} seconds = {milisec} miliseconds = {microsec} microseconds = {nano} nanoseconds");



        }
    }
}
