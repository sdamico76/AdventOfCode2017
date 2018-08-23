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

}
