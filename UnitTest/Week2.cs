using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Advent;
using System.IO;

namespace Week2 {
    [TestClass]
    public class Day8 {
        [TestMethod]
        public void Day8_0() {
            Assert.AreEqual(6611, Day_8.HighestRegisterValue(File.ReadAllText(@"C:\Personal Projects\Advent\Inputs\Day_8_0.txt")));
        }

        [TestMethod]
        public void Day8_1() {
            Assert.AreEqual(6619, Day_8.HighestRegisterValueAllTime(File.ReadAllText(@"C:\Personal Projects\Advent\Inputs\Day_8_0.txt")));
        }
    }

    [TestClass]
    public class Day9 {
        [TestMethod]
        public void Day9_1() {
            Assert.AreEqual(17537, Day_9.StreamProcessing(File.ReadAllText(@"C:\Personal Projects\Advent\Inputs\Day_9_0.txt")));
        }

        [TestMethod]
        public void Day9_2() {
            Assert.AreEqual(7539, Day_9.CountGarbage(File.ReadAllText(@"C:\Personal Projects\Advent\Inputs\Day_9_0.txt")));
        }
    }

    [TestClass]
    public class Day10 {
        [TestMethod]
        public void Day10_1() {
            Assert.AreEqual(12, Day_10.KnotHash("3,4,1,5", 5));
        }

        [TestMethod]
        public void Day10_2() {
            Assert.AreEqual(12, Day_10.BigKnotHash("147,37,249,1,31,2,226,0,161,71,254,243,183,255,30,70", 256));
        }
    }

    [TestClass]
    public class Day11 {
        [TestMethod]
        public void Day11_1() {
            Assert.AreEqual(670, Day_11.HexGrid(File.ReadAllText(@"C:\Users\Sam\Projects\AdventOfCode2017\Inputs\Day_11_0.txt")));
        }
        [TestMethod]
        public void Day11_2() {
            Assert.AreEqual(1426, Day_11.HexGridMaxDist(File.ReadAllText(@"C:\Users\Sam\Projects\AdventOfCode2017\Inputs\Day_11_0.txt")));
        }
    }

    [TestClass]
    public class Day12 {
        [TestMethod]
        public void Day12_1() {
            Assert.AreEqual(134, Day_12.PipeNetwork(File.ReadAllText(@"C:\Users\Sam\Projects\AdventOfCode2017\Inputs\Day_12_0.txt")));
        }
        [TestMethod]
        public void Day12_2() {
            Assert.AreEqual(193, Day_12.PipeNetworkGroups(File.ReadAllText(@"C:\Users\Sam\Projects\AdventOfCode2017\Inputs\Day_12_0.txt")));
        }
    }
}
