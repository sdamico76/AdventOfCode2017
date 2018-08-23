using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent {
    public static class Day_10 {

        public static int KnotHash(string input, int size) {
            var lengths = input.Split(',').Select(x => int.Parse(x)).ToList();
            var circle = Enumerable.Range(0, size).ToList();
            int skipSize = 0;
            int currentPos = 0;

            foreach(var length in lengths) {
                ReverseCircle(ref circle, currentPos, length);
                currentPos += length + skipSize;
                currentPos = currentPos % circle.Count();
                skipSize++;
            }

            return circle[0] * circle[1];
        }

        public static string BigKnotHash(string input, int size) {
            var lengths = input
                            .ToCharArray()
                            .Select(x => (byte)x)
                            .Concat(new byte[] { 0x11, 0x1f, 0x49, 0x2f, 0x17 })
                            .ToList();

            var circle = Enumerable.Range(0, size).ToList();
            int skipSize = 0;
            int currentPos = 0;
            foreach (var i in Enumerable.Range(0, 64)) {
                foreach (var length in lengths) {
                    ReverseCircle(ref circle, currentPos, length);
                    currentPos += length + skipSize;
                    currentPos = currentPos % circle.Count();
                    skipSize++;
                }
            }
            var denseHash = new List<byte>();
            foreach(var i in Enumerable.Range(0, 16)) {
                var range = circle.GetRange(i * 16, 16);
                int total = 0;
                foreach (int value in range) {
                    total ^= value;
                }
                denseHash.Add((byte)total);
            }

            return denseHash
                    .Select(x => x.ToString("x2"))
                    .Aggregate((x,y) => x + y);
        }

        private static void ReverseCircle(ref List<int> circle, int currentPos, int length) {
            var hold = new List<int>();
            for(var i = currentPos; i < + currentPos + length; i++) {
                hold.Add(circle[i % circle.Count()]);
            }
            hold.Reverse();
            for (var i = 0; i < hold.Count(); i++) {
                circle[(currentPos + i) % circle.Count()] = hold[i];
            }
        }
    }
}
