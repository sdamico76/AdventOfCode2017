using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent {
    public class Day_5 {
        public static int TrampolineMaze(string input) {
            var instructions = input.Split('\n').Select(int.Parse).ToArray();
            var jumps = 0;
            var currentLoc = 0;
            while (true) {
                if (currentLoc >= instructions.Length || currentLoc < 0) return jumps;
                var oldLoc = currentLoc;

                currentLoc += instructions[currentLoc];
                instructions[oldLoc]++;

                jumps++;
            }
        }

        public static int TrampolineMazeWithNegative(string input) {
            var instructions = input.Split('\n').Select(int.Parse).ToArray();
            var jumps = 0;
            var currentLoc = 0;
            while (true) {
                if (currentLoc >= instructions.Length || currentLoc < 0) return jumps;
                var oldLoc = currentLoc;

                currentLoc += instructions[currentLoc];
                if(instructions[oldLoc] >= 3) {
                    instructions[oldLoc]--;
                } else {
                    instructions[oldLoc]++;
                }

                jumps++;
            }
        }
    }
}
