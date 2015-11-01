using System;
using System.Collections.Generic;

namespace TreeTraversal
{
    public class TreeNode
    {
        private int value;
        private List<TreeNode> children;
        private TreeNode parent;

        public TreeNode(int value)
        {
            this.Value = value;
            this.children = new List<TreeNode>();
        }

        public int Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public TreeNode Parent
        {
            get { return this.parent; }
            private set { this.parent = value; }
        }

        public void AddChild(TreeNode child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("Child element could not be null.");
            }

            if (child.parent != null)
            {
                throw new ArgumentException("Chuld already has a parent.");
            }

            this.children.Add(child);
            child.Parent = this;
        }

        public int ChildrenCount
        {
            get { return this.children.Count; }
        }

        public TreeNode GetChild(int index)
        {
            return this.children[index];
        }
    }
}
