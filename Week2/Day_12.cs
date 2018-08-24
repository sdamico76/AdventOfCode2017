using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent {
    public static class Day_12 {
        
        public static int PipeNetwork(string input) {
            var lines = input.Split('\n');
            var nodes = new List<Node>();
            foreach(var line in lines) {
                nodes.Add(new Node {
                    HomeID = int.Parse(line.Split(new char[] { '<', '-', '>' })[0]),
                    ChildIDs = line
                                .Split(new char[] { '<', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)[1]
                                .Split(',').Select(x => int.Parse(x.Trim())).ToList()
                });
            }
            var foundNodes = new List<int>();
            FindNeighbors(0, ref foundNodes, ref nodes);
            return foundNodes.Count;

        }

        public static int PipeNetworkGroups(string input) {
            var lines = input.Split('\n');
            var nodes = new List<Node>();
            foreach (var line in lines) {
                nodes.Add(new Node {
                    HomeID = int.Parse(line.Split(new char[] { '<', '-', '>' })[0]),
                    ChildIDs = line
                                .Split(new char[] { '<', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)[1]
                                .Split(',').Select(x => int.Parse(x.Trim())).ToList()
                });
            }
            var groups = 0;
            while(nodes.Count > 0) {
                var foundNodes = new List<int>();
                FindNeighbors(nodes.First().HomeID, ref foundNodes, ref nodes);
                groups++;
            }
            return groups;

        }


        private static void FindNeighbors(int node, ref List<int> currentList, ref List<Node> allNodes) {
            
            if(allNodes.Any(x => x.HomeID == node) && !currentList.Contains(node)) {
                currentList.Add(node);
                var n = allNodes.Find(x => x.HomeID == node).ChildIDs;
                foreach(var c in n) {
                    FindNeighbors(c, ref currentList, ref allNodes);
                }

                allNodes.RemoveAll(x => x.HomeID == node);
            }

        }

        private class Node {
            public int HomeID { get; set; }
            public List<int> ChildIDs { get; set; }
        }
    }
}