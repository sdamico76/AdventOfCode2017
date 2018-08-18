using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent {
    public class Day_1 {
        public static int CalculateSumOfRepeats(string input) {
            var nums = input.Select(x => new String(x, 1)).ToList().Select(int.Parse);
            var numsLinked = new LinkedList<int>(nums);
            numsLinked.AddLast(numsLinked.First());
            var sum = 0;
            LinkedListNode<int> currentNode = numsLinked.First;
            while(currentNode != null) {
                if (currentNode.Value == currentNode.Next?.Value) {
                    sum += currentNode.Value;
                }
                currentNode = currentNode.Next;
            }
            return sum;
        }

        public static int CalculateSumOfAntipodes(string input) {
            var nums = input.Select(x => new String(x, 1)).ToList().Select(int.Parse).ToArray();
            var half = nums.Count() / 2;
            var sum = 0;

            for (var i = 0; i < half; i++) {
                if (nums[i] == nums[i + half]){
                    sum += nums[i];
                }
            }
            return sum * 2;
        }
    }
}
