namespace BinaryTreeNode
{
    public class Node
    {
        private Node left;
        private Node right;
        private int value;

        public Node(int value)
        {
            this.left = null;
            this.right = null;
            this.value = value;
        }

        public Node(Node left, Node right, int value)
        {
            this.left = left;
            this.right = right;
            this.value = value;
        }

        public bool IsLeafNode() => this.left == null & this.right == null;
        public void SetValue(int value) => this.value = value;
        public void SetLeftNode(Node node) => this.left= node;
        public void SetRightNode(Node node) => this.right = node;

        public void Add(Node node)
        {
            if (node.value > this.value)
            {
                if (this.right == null)
                {
                    this.right = node;
                }
                else
                {
                    this.right.Add(node);
                }
            }
            else if (node.value < this.value)
            {
                if (this.left == null)
                {
                    this.left = node;
                }
                else
                {
                    this.left.Add(node);
                }
            }
        }

        public override string ToString()
        {
            return this.value.ToString();
        }
    }
}
