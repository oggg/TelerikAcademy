namespace TreeTraversal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
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

            // Subtask 1 - the root node
            var root = allNodes.FirstOrDefault(r => r.Parent == null);
            Console.WriteLine("Root node value -> {0}", root.Value);

            // Subtask 2 - all leaf nodes
            var leafs = allNodes.Where(l => l.ChildrenCount == 0);
            foreach (var leaf in leafs)
            {
                Console.WriteLine("Leaf node value -> {0}", leaf.Value);
            }

            // Subtask 3 - all middle nodes


            //var tree = new Tree(root);
            // tree.TraverseDFS(root, "    ");


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
    }
}
