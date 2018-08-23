using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent {
    class Program {
        static void Main(string[] args) {
            //RunWeek1();
            RunWeek2();
            Console.ReadLine();
        }

        static void RunWeek2() {
            //Console.WriteLine("Day 8 Problem 1:" + Day_8.HighestRegisterValue(File.ReadAllText(@"C:\Personal Projects\Advent\Inputs\Day_8_0.txt")));
            //Console.WriteLine("Day 8 Problem 2:" + Day_8.HighestRegisterValueAllTime(File.ReadAllText(@"C:\Personal Projects\Advent\Inputs\Day_8_0.txt")));
            //Console.WriteLine("Day 9 Problem 1:" + Day_9.StreamProcessing(File.ReadAllText(@"C:\Personal Projects\Advent\Inputs\Day_9_0.txt")));
            //Console.WriteLine("Day 9 Problem 2:" + Day_9.CountGarbage(File.ReadAllText(@"C:\Personal Projects\Advent\Inputs\Day_9_0.txt")));
            //Console.WriteLine("Day 10 Problem 1:" + Day_10.KnotHash("147,37,249,1,31,2,226,0,161,71,254,243,183,255,30,70", 256));
            Console.WriteLine("Day 10 Problem 2:" + Day_10.BigKnotHash("147,37,249,1,31,2,226,0,161,71,254,243,183,255,30,70", 256));

        }

        static void RunWeek1() {
            Console.WriteLine("Day 1 Problem 1:" + Day_1.CalculateSumOfRepeats(File.ReadAllText(@"C:\Personal Projects\Advent\Inputs\Day_1_0.txt")));
            Console.WriteLine("Day 1 Problem 2:" + Day_1.CalculateSumOfAntipodes(File.ReadAllText(@"C:\Personal Projects\Advent\Inputs\Day_1_0.txt")));
            Console.WriteLine("Day 2 Problem 1:" + Day_2.CorruptionChecksum(File.ReadAllText(@"C:\Personal Projects\Advent\Inputs\Day_2_0.txt")));
            Console.WriteLine("Day 2 Problem 2:" + Day_2.CorruptionChecksum_EvenlyDivisible(File.ReadAllText(@"C:\Personal Projects\Advent\Inputs\Day_2_0.txt")));
            Console.WriteLine("Day 3 Problem 1:" + Day_3.GetSpiralLocation(368078));
            Console.WriteLine("Day 2 Problem 2:" + Day_3.GetSpiralLocationPart2(368078));
            Console.WriteLine("Day 4 Problem 1:" + Day_4.HighEntropyPassphrases(File.ReadAllText(@"C:\Personal Projects\Advent\Inputs\Day_4_0.txt")));
            Console.WriteLine("Day 4 Problem 2:" + Day_4.HighEntropyPassphrasesAnagram(File.ReadAllText(@"C:\Personal Projects\Advent\Inputs\Day_4_0.txt")));
            Console.WriteLine("Day 5 Problem 1:" + Day_5.TrampolineMaze(File.ReadAllText(@"C:\Personal Projects\Advent\Inputs\Day_5_0.txt")));
            Console.WriteLine("Day 5 Problem 2:" + Day_5.TrampolineMazeWithNegative(File.ReadAllText(@"C:\Personal Projects\Advent\Inputs\Day_5_0.txt")));
            Console.WriteLine("Day 6 Problem 1:" + Day_6.MemoryReallocation("0	5	10	0	11	14	13	4	11	8	8	7	1	4	12	11"));
            Console.WriteLine("Day 6 Problem 2:" + Day_6.MemoryReallocationCycleTime("0	5	10	0	11	14	13	4	11	8	8	7	1	4	12	11"));
            Console.WriteLine("Day 7 Problem 1:" + Day_7.RecursiveCircus(File.ReadAllText(@"C:\Personal Projects\Advent\Inputs\Day_7_0.txt")));
            Console.WriteLine("Day 7 Problem 2:" + Day_7.RecursiveCircusWeights(File.ReadAllText(@"C:\Personal Projects\Advent\Inputs\Day_7_0.txt")));
        }
    }
}
