using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent {
    public static class Day_13 {
        public static int PacketScanners(string input) {
            var lines = input.Split('\n');
            var columns = new Column[97];

            foreach (var line in lines) {
                columns[int.Parse(line.Split(':')[0])] = new Column {
                    Height = int.Parse(line.Split(':')[1]),
                };
            }
            var total = 0;

            foreach (var i in Enumerable.Range(0, 96)) {
                if (columns[i]?.Position == 0) {
                    total += columns[i].Height * i;
                }

                foreach (var col in columns) {
                    if (col != null) {
                        if (col.MovingDown) {
                            if (col.Position == col.Height - 1) {
                                col.MovingDown = false;
                                col.Position--;
                            } else {
                                col.Position++;
                            }
                        } else {
                            if (col.Position == 0) {
                                col.MovingDown = true;
                                col.Position++;
                            } else {
                                col.Position--;
                            }
                        }
                    }
                }
            }

            return total;
        }

        public static int PacketScannersDodge(string input) {
            var lines = input.Split('\n');
            List<int> layers = new List<int>();
            List<int> depth = new List<int>();
            foreach (string line in lines) {
                layers.Add(int.Parse(line.Split(':')[0]));
                depth.Add(int.Parse(line.Split(':')[1]));
            }

            int delay = 0;
            bool caught = false;
            while (!caught) {
                caught = true;
                for (int i = 0; i < layers.Count(); i++) {
                    if ((layers[i] + delay) % (2 * depth[i] - 2) == 0) {
                        caught = false;
                        delay++;
                        break;
                    }

                }
            }
            return delay;
        }

        private static void IncrementColumns(ref Column[] columns) {
            foreach (var col in columns) {
                if (col != null) {
                    if (col.MovingDown) {
                        if (col.Position == col.Height - 1) {
                            col.MovingDown = false;
                            col.Position--;
                        } else {
                            col.Position++;
                        }
                    } else {
                        if (col.Position == 0) {
                            col.MovingDown = true;
                            col.Position++;
                        } else {
                            col.Position--;
                        }
                    }
                }
            }
        }
    }



    class Column {
        public int Height { get; set; }
        public int Position { get; set; } = 0;
        public bool MovingDown { get; set; } = true;
    }
}