using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent {
    public static class Day_7 {
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
            var lines = input.Split('\n').Select(p => p.Trim()).ToArray();
            var plates = lines.Select(l => new Plate(l)).ToList();

            plates.ForEach(x => x.LinkChildren(plates));

            var root = GetRootPlate(plates);
            var currentPlate = root;
            var tarWeight = 0;

            while (!currentPlate.IsBalanced()) {
                (currentPlate, tarWeight) = currentPlate.GetUnbalanced();
            }

            var diff = tarWeight - currentPlate.GetFullWeight();
            return (currentPlate.Weight + diff).ToString();
        }

        public static Plate GetRootPlate(List<Plate> plates) {
            var plate = plates.First();
            while (plate.Parent != null){
                plate = plate.Parent;
            }
            return plate;
        }
    }

    public class Plate {
        public int Weight { get; set; }
        public string Name { get; set; }
        public List<Plate> Children { get; set; }
        public List<string> ChildNames { get; set; }
        public Plate Parent { get; set; }

        public Plate(string line) {
            Name = line.Split(' ')[0];
            Weight = int.Parse(line.Split('(', ')')[1]);
            ChildNames = new List<string>();

            if (line.Contains("->")) {
                foreach (var c in line.Split('>')[1].Trim().Split(' ')) {
                    ChildNames.Add(c.TrimEnd(','));
                }
            }
        }

        public void LinkChildren(List<Plate> list) {
            Children = ChildNames.Select(cName => list.First(x => x.Name == cName)).ToList();
            Children.ForEach(x => x.Parent = this);
        }

        public int GetFullWeight() {
            var childrenWeight = Children.Sum(x => x.GetFullWeight());
            return Weight + childrenWeight;
        }

        public bool IsBalanced() {
            return Children.GroupBy(x => x.GetFullWeight()).Count() == 1;
        }

        public (Plate plate, int newWeight) GetUnbalanced() {
            var groups = Children.GroupBy(x => x.GetFullWeight());
            var newWeight = groups.First(x => x.Count() > 1).Key;
            var plate = groups.First(x => x.Count() == 1).First();
            return (plate, newWeight);
        }
    }
}
