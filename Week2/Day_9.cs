using System.Linq;
using System.Text.RegularExpressions;

namespace Advent {
    public static class Day_9 {

       public static int StreamProcessing(string input) {
            input = Regex.Replace(input, "!.", "");//Remove ! and the following char
            input = Regex.Replace(input, "<.*?>", ""); //Remove Garbage

            var total = 0;
            var score = 0;

            foreach(var c in input.ToCharArray()) {
                if (c == '{') score++;
                if (c == '}') total += score--;
            }

            return total;
        }

        public static int CountGarbage(string input) {
            input = Regex.Replace(input, "!.", "");//Remove ! and the following char
            var garbages = Regex.Matches(input, "<.*?>").Cast<Match>().Select(match => match.Value).ToList();

            return garbages.Sum(x => x.Length - 2);
        }
    }
}