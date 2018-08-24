using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public static class Day_11
    {
        public static int HexGrid(string input)
        {
            var steps = input.Split(',').ToList();
            int x = 0;
            int y = 0;
            int z = 0;

            foreach (var d in steps)
            {
                switch (d)
                {
                    case "n":
                        y += 1;
                        z -= 1;
                        break;
                    case "s":
                        y -= 1;
                        z += 1;
                        break;
                    case "ne":
                        x += 1;
                        z -= 1;
                        break;
                    case "se":
                        x += 1;
                        y -= 1;
                        break;
                    case "sw":
                        z += 1;
                        x -= 1;
                        break;
                    case "nw":
                        y += 1;
                        x -= 1;
                        break;
                }
            }


            return (Math.Abs(x) + Math.Abs(y) + Math.Abs(z)) / 2;
        }
        public static int HexGridMaxDist(string input)
        {
            var steps = input.Split(',').ToList();
            int x = 0;
            int y = 0;
            int z = 0;
            var maxDistList = new List<int>();

            foreach (var d in steps)
            {
                switch (d)
                {
                    case "n":
                        y += 1;
                        z -= 1;
                        break;
                    case "s":
                        y -= 1;
                        z += 1;
                        break;
                    case "ne":
                        x += 1;
                        z -= 1;
                        break;
                    case "se":
                        x += 1;
                        y -= 1;
                        break;
                    case "sw":
                        z += 1;
                        x -= 1;
                        break;
                    case "nw":
                        y += 1;
                        x -= 1;
                        break;
                }
                maxDistList.Add((Math.Abs(x) + Math.Abs(y) + Math.Abs(z)) / 2);
            }
            return maxDistList.Max();
        }
    }
}
