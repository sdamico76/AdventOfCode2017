using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent {
    public static class Day_8 {

        public static int HighestRegisterValue(string input) {
            var lines = input.Split('\n');
            var registers = new Dictionary<string, int>();

            foreach(var line in lines) {
                var reg = line.Split(' ')[0];

                if (!registers.ContainsKey(reg)) {
                    registers.Add(reg, 0);
                }
            }

            foreach (var line in lines) {
                var reg = line.Split(' ')[0];
                registers[reg] += ParseRegisterModify(line, registers);
            }

            return registers.Values.Max();
        }

        public static int HighestRegisterValueAllTime(string input) {
            var lines = input.Split('\n');
            var registers = new Dictionary<string, int>();
            var max = 0;

            foreach (var line in lines) {//Fill Dictionary
                var reg = line.Split(' ')[0];

                if (!registers.ContainsKey(reg)) {
                    registers.Add(reg, 0);
                }
            }

            foreach (var line in lines) {
                var reg = line.Split(' ')[0];
                registers[reg] += ParseRegisterModify(line, registers);
                if(registers.Values.Max() > max) {
                    max = registers.Values.Max();
                }
            }
            return max;
        }

        public static int ParseRegisterModify(string line, Dictionary<string, int> registers) {
            var words = line.Split(' ');

            switch (words[5]) {
                case ">":
                    if (registers[words[4]] > int.Parse(words[6])) {
                        return words[1] == "inc" ? int.Parse(words[2]) : int.Parse(words[2]) * -1;
                    }
                    break;
                case "<":
                    if (registers[words[4]] < int.Parse(words[6])) {
                        return words[1] == "inc" ? int.Parse(words[2]) : int.Parse(words[2]) * -1;
                    }
                    break;
                case ">=":
                    if (registers[words[4]] >= int.Parse(words[6])) {
                        return words[1] == "inc" ? int.Parse(words[2]) : int.Parse(words[2]) * -1;
                    }
                    break;
                case "<=":
                    if (registers[words[4]] <= int.Parse(words[6])) {
                        return words[1] == "inc" ? int.Parse(words[2]) : int.Parse(words[2]) * -1;
                    }
                    break;
                case "==":
                    if (registers[words[4]] == int.Parse(words[6])) {
                        return words[1] == "inc" ? int.Parse(words[2]) : int.Parse(words[2]) * -1;
                    }
                    break;
                case "!=":
                    if (registers[words[4]] != int.Parse(words[6])) {
                        return words[1] == "inc" ? int.Parse(words[2]) : int.Parse(words[2]) * -1;
                    }
                    break;
            }
            return 0;
        }

    }
}
