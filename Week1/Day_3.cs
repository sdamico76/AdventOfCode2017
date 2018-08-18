using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent {
    public class Day_3 {
        
        public static int GetSpiralLocation(int n) {
            if (n == 1) return 0;

            var x = 0;
            var y = 0;

            var stepCount = 1; // Initial step amount.
            var stepCountChange = true; // Change when true.
            var direction = 0; // right, up, left, down
            // Get the x,y coordinate for each step of i. 
            for (var i = 1; ;) {
                for (var j = 0; j < stepCount; j += 1) {
                    // Take a step
                    switch (direction) {
                        case 0:
                            // r
                            x += 1;
                            break;
                        case 1:
                            // u
                            y += 1;
                            break;

                        case 2:
                            // l
                            x -= 1;
                            break;

                        case 3:
                            // d
                            y -= 1;
                            break;
                        default:
                            break;
                    }
                    i += 1;

                    if (i == n) return Math.Abs(x) + Math.Abs(y);
                }

                direction = (direction + 1) % 4;
                stepCountChange = !stepCountChange;
                if (stepCountChange) stepCount += 1;
            }
        }

        public static int GetSpiralLocationPart2(int n) {
            if (n == 1) return 1;

            var x = 0;
            var y = 0;

            var stepCount = 1;
            var stepCountChange = true;
            var direction = 0;
            var values = new Dictionary<string, int> {
                ["0,0"] = 1
            };

            for (; ; )
            {
                for (var j = 0; j < stepCount; j += 1) {
                    // Take a step
                    switch (direction) {
                        case 0:
                            // r
                            x += 1;
                            break;
                        case 1:
                            // u
                            y += 1;
                            break;

                        case 2:
                            // l
                            x -= 1;
                            break;

                        case 3:
                            // d
                            y -= 1;
                            break;
                        default:
                            break;
                    }
                    
                    int sum = 0, val = 0;

                    if (values.TryGetValue(string.Format("{0},{1}", x + 1, y), out val)) sum += val;
                    if (values.TryGetValue(string.Format("{0},{1}", x + 1, y + 1), out val)) sum += val;
                    if (values.TryGetValue(string.Format("{0},{1}", x, y + 1), out val)) sum += val;
                    if (values.TryGetValue(string.Format("{0},{1}", x - 1, y + 1), out val)) sum += val;
                    if (values.TryGetValue(string.Format("{0},{1}", x - 1, y), out val)) sum += val;
                    if (values.TryGetValue(string.Format("{0},{1}", x - 1, y - 1), out val)) sum += val;
                    if (values.TryGetValue(string.Format("{0},{1}", x, y - 1), out val)) sum += val;
                    if (values.TryGetValue(string.Format("{0},{1}", x + 1, y - 1), out val)) sum += val;

                    if (sum > n) return sum;
                    values[string.Format("{0},{1}", x, y)] = sum;
                }

                direction = (direction + 1) % 4;
                stepCountChange = !stepCountChange;
                if (stepCountChange) stepCount += 1;
            }
        }
    }
}
