using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Advent {
    public class Day_4 {
        public static int HighEntropyPassphrases(string input) {
            var validCount = 0;
            foreach (var line in input.Split('\n')) {
                var lineWords = line.Trim().Split(' ');
                if (lineWords.Count() == lineWords.Distinct().Count()) validCount++;
            }
            return validCount;
        }

        public static int HighEntropyPassphrasesAnagram(string input) {
            var validCount = 0;
            foreach (var line in input.Split('\n')) {
                var lineWords = line.Trim().Split(' ');
                List<string> sortedWords = new List<string>();
                foreach (var word in lineWords) {
                    sortedWords.Add(String.Concat(word.OrderBy(c => c)));
                }
                if (sortedWords.Count() == sortedWords.Distinct().Count()) validCount++;
            }
            return validCount;
        }
    }
}
