using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Day 1 Problem 0:");
            Console.WriteLine(Day_1.CalculateSumOfRepeats(File.ReadAllText(@"C:\Personal Projects\Advent\ConsoleApp1\Day_1_0.txt")));

            Console.WriteLine("Day 1 Problem 1:");
            Console.WriteLine(Day_1.CalculateSumOfAntipodes(File.ReadAllText(@"C:\Personal Projects\Advent\ConsoleApp1\Day_1_0.txt")));









            Console.ReadLine();
        }
    }
}
