using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent {
    public class Day_7 {
        public static string RecursiveCircus(string input) {
            var lines = input.Split('\n').ToArray();

            List<string> allList = new List<string>();
            allList = lines.Select(l => l.Split(' ')[0]).ToList();

            List<string> foundList = new List<string>();
            var arrow = new string[] { "->" };
            foreach (var line in lines) {
                if (line.Contains("->")) {
                    var children = line.Split(arrow, StringSplitOptions.None)[1];
                    foreach (var child in children.Split(',').Select(p => p.Trim())) {
                        if (!foundList.Contains(child)) foundList.Add(child);
                    }
                }
            }


            return allList.Except(foundList).First();
        }

        public static string RecursiveCircusWeights(string input) {
            var lines = input.Split('\n').Select(p=>p.Trim()).ToArray();

            var allList = new List<Tuple<string, int>>();
            allList = lines.Select(l => new Tuple<string,int>(l.Split(' ')[0], int.Parse(l.Split('(', ')')[1]))).ToList();

            List<string> foundList = new List<string>();
            var arrow = new string[] { "->" };
            foreach (var line in lines) {
                if (line.Contains("->")) {
                    var children = line.Split(arrow, StringSplitOptions.None)[1];
                    var childwords = new List<Tuple<string, int>>();
                    foreach (var child in children.Split(',').Select(p => p.Trim())) {
                        foreach(var itm in allList) {
                            if(itm.Item1 == child) {
                                childwords.Add(itm);
                            }
                        }
                    }

                    //Look for odd man out
                    var res = 0;
                    foreach(var c in childwords) {
                        if (res == 0) {
                            res = c.Item2;
                        } else {
                            if(res != c.Item2) {//Found an unbalanced node
                                if(lines.Contains(c.Item1 + " (" + c.Item2 + ")")) {
                                }
                            }
                        }
                    }
                }
            }
            return "a";
        }
    }
}
