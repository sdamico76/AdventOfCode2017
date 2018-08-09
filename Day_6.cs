using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Advent {
    public class Day_6 {
        public static int MemoryReallocation(string input) {
            int[] arr = input.Split('\t').Select(int.Parse).ToArray();
            int steps = 0;
            List<int[]> foundList = new List<int[]>();
            foundList.Add(arr.ToArray());//Add a copy of the array
            while (true) {
                var highestLoc = Array.IndexOf(arr, arr.Max());
                var currentLoc = highestLoc;
                var redisVal = arr[highestLoc];
                arr[highestLoc] = 0;

                while (redisVal > 0) {
                    if(currentLoc < arr.Length - 1) {
                        currentLoc++;
                    } else {
                        currentLoc = 0;
                    }
                    arr[currentLoc]++;
                    redisVal--;
                }
                steps++;

                if (foundList.Any(p => p.SequenceEqual(arr))) { return steps; }
                foundList.Add(arr.ToArray());
            }
        }
    }
}
