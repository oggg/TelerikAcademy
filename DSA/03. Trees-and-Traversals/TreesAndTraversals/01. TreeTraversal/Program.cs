namespace TreeTraversal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        private const int SumOfNodeValues = 10;
        private const int SumOfSubtrees = 12;

        static void Main()
        {
            int linesNumber = int.Parse(Console.ReadLine());
            ICollection<TreeNode> allNodes = new List<TreeNode>();

            for (int i = 0; i < linesNumber - 1; i++)
            {
                string currentLine = Console.ReadLine();
                int parentValue = ReadValues(currentLine)[0];
                TreeNode parentNode = null;
                if (NodeExists(allNodes, parentValue) != null)
                {
                    parentNode = NodeExists(allNodes, parentValue);
                }
                else
                {
                    parentNode = new TreeNode(parentValue);
                    allNodes.Add(parentNode);
                }

                int childValue = ReadValues(currentLine)[1];
                TreeNode childNode = null;
                if (NodeExists(allNodes, childValue) != null)
                {
                    childNode = NodeExists(allNodes, childValue);
                }
                else
                {
                    childNode = new TreeNode(childValue);
                    allNodes.Add(childNode);
                }

                parentNode.AddChild(childNode);
            }

            // var tree = new Tree(root);
            // tree.TraverseDFS(root, "    ");

            // Subtask 1 - the root node
            var root = allNodes.FirstOrDefault(r => r.Parent == null);
            Console.WriteLine("Root node value -> {0}", root.Value);

            // Subtask 2 - all leaf nodes
            var leafs = allNodes.Where(l => l.ChildrenCount == 0);

            // Subtask 3 - all middle nodes
            var middleNodes = allNodes.Where(m => m.Parent != null && m.ChildrenCount > 0);

            // Subtask 4 - longest path
            var longestPath = root.LongestPath();
            //foreach (var node in longestPath)
            //{
            //    Console.Write(string.Format("{0} - ", node.ToString()));
            //}

            // Subtask 5 - all paths with given sum
            string path = string.Empty;
            SubsetSum(root, 9, path);

            // Subtask 6 - all subtrees with given sum of their nodes
            Console.WriteLine("Subtask 6");
            foreach (var node in middleNodes)
            {
                var currentTree = new Tree(node);
                int subTreeSum = currentTree.SumBFS(node);
                if (subTreeSum == SumOfSubtrees)
                {
                    Console.WriteLine("Subtree with required sum:");
                    currentTree.TraverseDFS(node, " ");
                }
            }
        }

        private static IList<int> ReadValues(string input)
        {
            string[] splitted = input.Split(' ');
            int parentValue = int.Parse(splitted[0]);
            int childValue = int.Parse(splitted[1]);

            int[] results = { parentValue, childValue };
            return results;
        }

        private static TreeNode NodeExists(ICollection<TreeNode> nodes, int value)
        {
            var node = nodes.FirstOrDefault(n => n.Value == value);
            return node;
        }

        private static void SubsetSum(TreeNode root, int sum, string path)
        {
            if (root != null)
            {
                if (root.Value > sum)
                {
                    return;
                }
                else
                {
                    path += string.Format(" {0}", root);
                    sum -= root.Value;
                    if (sum == 0)
                    {
                        Console.WriteLine(path);
                    }

                    for (int i = 0; i < root.ChildrenCount; i++)
                    {
                        SubsetSum(root.GetChild(i), sum, path);
                    }
                }
            }
        }
    }
}
