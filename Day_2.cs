using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent {
    public class Day_2 {
        public static int CorruptionChecksum(string input) {
            var lines = input.Split('\n');
            var sum = 0;
            foreach(var line in lines) {
                var nums = Array.ConvertAll(line.Split('\t'), s => int.Parse(s));
                sum += nums.Max() - nums.Min();
            }
            return sum;
        }

        public static int CorruptionChecksum_EvenlyDivisible(string input) {
            var lines = input.Split('\n');
            var sum = 0;
            foreach (var line in lines) {
                var nums = Array.ConvertAll(line.Split('\t'), s => int.Parse(s));
                for(var i = 0; i < nums.Count(); i++) {
                    for(var j = 0; j < nums.Count(); j++) {
                        if(i != j && nums[i] % nums[j] == 0) {
                            sum += nums[i] / nums[j];
                            i = nums.Count();//Exit Early
                            j = nums.Count();
                        }
                    }
                }
            }
            return sum;
        }
    }
}
