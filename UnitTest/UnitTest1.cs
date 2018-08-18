using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Advent;
using System.IO;

namespace UnitTest {
    [TestClass]
    public class Day1 {
        [TestMethod]
        public void Day1_0() {
            Assert.AreEqual(Day_1.CalculateSumOfRepeats("1122"), 3);//TODO swap Assert Params
            Assert.AreEqual(Day_1.CalculateSumOfRepeats("1111"), 4);
            Assert.AreEqual(Day_1.CalculateSumOfRepeats("1234"), 0);
            Assert.AreEqual(Day_1.CalculateSumOfRepeats("91212129"), 9);
        }
        [TestMethod]
        public void Day1_1() {
            Assert.AreEqual(Day_1.CalculateSumOfAntipodes("1212"), 6);
            Assert.AreEqual(Day_1.CalculateSumOfAntipodes("1221"), 0);
            Assert.AreEqual(Day_1.CalculateSumOfAntipodes("123425"), 4);
            Assert.AreEqual(Day_1.CalculateSumOfAntipodes("123123"), 12);
            Assert.AreEqual(Day_1.CalculateSumOfAntipodes("12131415"), 4);
        }
    }

    [TestClass]
    public class Day2 {
        [TestMethod]
        public void Day2_0() {
            var input = "5\t1\t9\t5\n7\t5\t3\n2\t4\t6\t8";
            Assert.AreEqual(Day_2.CorruptionChecksum(input), 18);
        }
        [TestMethod]
        public void Day2_1() {
            var input = "5\t9\t2\t8\n9\t4\t7\t3\n3\t8\t6\t5";
            Assert.AreEqual(9, Day_2.CorruptionChecksum_EvenlyDivisible(input));
        }
    }

    [TestClass]
    public class Day3 {
        [TestMethod]
        public void Day3_0() {

            Assert.AreEqual(0, Day_3.GetSpiralLocation(1));
            Assert.AreEqual(3, Day_3.GetSpiralLocation(12));
            Assert.AreEqual(2, Day_3.GetSpiralLocation(23));
            Assert.AreEqual(31, Day_3.GetSpiralLocation(1024));
        }
        [TestMethod]
        public void Day3_1() {
            Assert.AreEqual(133, Day_3.GetSpiralLocationPart2(122));
            //TODO There is a bug here involving corner numbers, got lucky the problem didnt hit this
        }
    }

    [TestClass]
    public class Day4 {
        [TestMethod]
        public void Day4_0() {
            Assert.AreEqual(383, Day_4.HighEntropyPassphrases(File.ReadAllText(@"C:\Personal Projects\Advent\ConsoleApp1\Day_4_0.txt")));
        }

        [TestMethod]
        public void Day4_1() {
            Assert.AreEqual(265, Day_4.HighEntropyPassphrasesAnagram(File.ReadAllText(@"C:\Personal Projects\Advent\ConsoleApp1\Day_4_0.txt")));
        }
    }

    [TestClass]
    public class Day5 {
        [TestMethod]
        public void Day5_0() {
            Assert.AreEqual(5, Day_5.TrampolineMaze("0\n3\n0\n1\n-3"));
        }

        [TestMethod]
        public void Day5_1() {
            Assert.AreEqual(10, Day_5.TrampolineMazeWithNegative("0\n3\n0\n1\n-3"));
        }
    }

    [TestClass]
    public class Day6 {
        [TestMethod]
        public void Day6_0() {
            Assert.AreEqual(5, Day_6.MemoryReallocation("0\t2\t7\t0"));
        }

        [TestMethod]
        public void Day6_1() {
            Assert.AreEqual(4, Day_6.MemoryReallocationCycleTime("0\t2\t7\t0"));
        }
    }

    [TestClass]
    public class Day7 {
        [TestMethod]
        public void Day7_0() {
            Assert.AreEqual("qibuqqg", Day_7.RecursiveCircus(File.ReadAllText(@"C:\Personal Projects\Advent\ConsoleApp1\Day_7_0.txt")));
        }
        
    }

}
