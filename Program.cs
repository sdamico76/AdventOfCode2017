using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Day 1 Problem 0:" + Day_1.CalculateSumOfRepeats(File.ReadAllText(@"C:\Personal Projects\Advent\ConsoleApp1\Day_1_0.txt")));
            Console.WriteLine("Day 1 Problem 1:" + Day_1.CalculateSumOfAntipodes(File.ReadAllText(@"C:\Personal Projects\Advent\ConsoleApp1\Day_1_0.txt")));
            Console.WriteLine("Day 2 Problem 0:" + Day_2.CorruptionChecksum(File.ReadAllText(@"C:\Personal Projects\Advent\ConsoleApp1\Day_2_0.txt")));
            Console.WriteLine("Day 2 Problem 1:" + Day_2.CorruptionChecksum_EvenlyDivisible(File.ReadAllText(@"C:\Personal Projects\Advent\ConsoleApp1\Day_2_0.txt")));
            Console.WriteLine("Day 3 Problem 0:" + Day_3.GetSpiralLocation(368078));
            Console.WriteLine("Day 2 Problem 1:" + Day_3.GetSpiralLocationPart2(368078));
            Console.WriteLine("Day 4 Problem 0:" + Day_4.HighEntropyPassphrases(File.ReadAllText(@"C:\Personal Projects\Advent\ConsoleApp1\Day_4_0.txt")));
            Console.WriteLine("Day 4 Problem 1:" + Day_4.HighEntropyPassphrasesAnagram(File.ReadAllText(@"C:\Personal Projects\Advent\ConsoleApp1\Day_4_0.txt")));
            Console.WriteLine("Day 5 Problem 0:" + Day_5.TrampolineMaze(File.ReadAllText(@"C:\Personal Projects\Advent\ConsoleApp1\Day_5_0.txt")));
            Console.WriteLine("Day 5 Problem 0:" + Day_5.TrampolineMazeWithNegative(File.ReadAllText(@"C:\Personal Projects\Advent\ConsoleApp1\Day_5_0.txt")));




            Console.ReadLine();
        }
    }
}
