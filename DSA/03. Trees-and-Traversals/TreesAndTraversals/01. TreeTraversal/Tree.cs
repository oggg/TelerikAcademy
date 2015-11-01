using System;

namespace TreeTraversal
{
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
    }
}
