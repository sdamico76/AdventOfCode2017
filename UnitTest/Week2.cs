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

}
