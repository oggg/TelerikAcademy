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

        public List<TreeNode> Children
        {
            get { return new List<TreeNode>(this.children); }
            private set { this.children = value; }
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

        public IList<TreeNode> LongestPath()
        {
            IList<TreeNode> path = new List<TreeNode>();
            foreach (var node in this.children)
            {
                IList<TreeNode> tmp = node.LongestPath();
                if (tmp.Count > path.Count)
                {
                    path = tmp;
                }
            }
            path.Insert(0, this);
            return path;
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
