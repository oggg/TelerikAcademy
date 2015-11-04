namespace TreeTraversal
{
    using System;
    using System.Collections.Generic;

    public class Tree
    {
        private TreeNode root;

        public Tree(TreeNode value)
        {
            this.Root = value;
        }

        public TreeNode Root
        {
            get { return this.root; }
            set { this.root = value; }
        }

        public void TraverseDFS(TreeNode root, string spaces)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(spaces + root.Value);

            TreeNode child = null;
            for (int i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);
                this.TraverseDFS(child, spaces + "  ");
            }
        }

        public IList<TreeNode> GetSubRoots(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            var parentsList = new List<TreeNode>();

            while (queue.Count > 0)
            {
                var parent = queue.Dequeue();

                if (parent.ChildrenCount > 0)
                {
                    parentsList.Add(parent);
                }
                else
                {
                    continue;
                }
                foreach (var child in parent.Children)
                {
                    queue.Enqueue(child);
                }
            }
            return new List<TreeNode>(parentsList);
        }

        public int SumBFS(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var sum = 0;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var parent = queue.Dequeue();
                sum += parent.Value;

                if (parent.Children == null)
                {
                    continue;
                }

                foreach (var child in parent.Children)
                {
                    queue.Enqueue(child);
                }
            }

            return sum;
        }
    }
}
