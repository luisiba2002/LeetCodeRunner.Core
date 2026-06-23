namespace LeetCodeRunner.Core.Trees
{
    public static class TreeBuilder
    {
        /// <summary>
        /// Constructor a partir de un array de enteros que representa el recorrido por niveles de un árbol binario.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static TreeNode? FromLevelOrder(params int?[] values)
        {
            if (values == null || values.Length == 0 || values[0] == null)
                return null;

            var root = new TreeNode(values[0]!.Value);
            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            int index = 1;

            while (queue.Count > 0 && index < values.Length)
            {
                var current = queue.Dequeue();

                if (index < values.Length && values[index] != null)
                {
                    current.left = new TreeNode(values[index]!.Value);
                    queue.Enqueue(current.left);
                }

                index++;

                if (index < values.Length && values[index] != null)
                {
                    current.right = new TreeNode(values[index]!.Value);
                    queue.Enqueue(current.right);
                }

                index++;
            }

            return root;
        }

        /// <summary>
        /// Constructor a partir de un nodo raíz de un árbol binario, generando un array de enteros que representa el recorrido por niveles del árbol.
        /// </summary>
        /// <param name="root">Nodo raíz del árbol binario.</param>
        /// <returns>Lista de enteros que representa el recorrido por niveles del árbol.</returns>
        public static List<int?> ToLevelOrder(TreeNode? root)
        {
            var result = new List<int?>();

            if (root == null)
                return result;

            var queue = new Queue<TreeNode?>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (current == null)
                {
                    result.Add(null);
                    continue;
                }

                result.Add(current.val);

                queue.Enqueue(current.left);
                queue.Enqueue(current.right);
            }

            int lastNonNull = result.Count - 1;

            while (lastNonNull >= 0 && result[lastNonNull] == null)
            {
                lastNonNull--;
            }

            result.RemoveRange(lastNonNull + 1, result.Count - lastNonNull - 1);

            return result;
        }

        /// <summary>
        /// Método que genera un clon del árbol binario dado un nodo raíz.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static TreeNode? Clone(TreeNode? root)
        {
            if (root == null)
                return null;

            return new TreeNode(
                root.val,
                Clone(root.left),
                Clone(root.right));
        }
    }
}