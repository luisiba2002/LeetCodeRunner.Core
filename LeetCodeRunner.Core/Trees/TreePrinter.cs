namespace LeetCodeRunner.Core.Trees
{
    public static class TreePrinter
    {
        public static void PrintTree(TreeNode root)
        {
            if (root == null)
            {
                Console.WriteLine("[]");
                return;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            List<string> result = new List<string>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();

                if (node == null)
                {
                    result.Add("null");
                    continue;
                }

                result.Add(node.val.ToString());
                if (node.left == null || node.right == null)
                {
                    result.Add("null");
                }

                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }

            while (result.Count > 0 && result[^1] == "null")
            {
                result.RemoveAt(result.Count - 1);
            }

            Console.WriteLine($"[{string.Join(",", result)}]");
        }

        public static void PrintTreePretty(TreeNode? root)
        {
            if (root == null)
                return;

            Console.WriteLine($"Root: {root.val}");

            PrintNode(root.left, "", false, "L");
            PrintNode(root.right, "", true, "R");
        }

        private static void PrintNode(
            TreeNode? node,
            string indent,
            bool last,
            string side)
        {
            if (node == null)
                return;

            Console.Write(indent);
            Console.Write(last ? "└── " : "├── ");
            Console.WriteLine($"{side}: {node.val}");

            indent += last ? "    " : "│   ";

            PrintNode(node.left, indent, false, "L");
            PrintNode(node.right, indent, true, "R");
        }
    }
}