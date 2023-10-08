namespace tree_first
{
    internal class Program
    {
        static Dictionary<int, Tree<int>> nodeByValue = new Dictionary<int, Tree<int>>();
        public static void Main()
        {
            ReadTree();
            Console.WriteLine("Root: " + GetRootNode().Value);
            Console.WriteLine("Middles: " + String.Join(", ", GetMiddleNodes()));
            Console.WriteLine("Leaves: " + String.Join(", ", GetLeavesNodes()));
            Console.WriteLine("Deepest node: " + DeepestLeftNode());
        }

        public static Tree<int> GetTreeNodeByValue(int value)
        {
            if (!nodeByValue.ContainsKey(value))
                nodeByValue[value] = new Tree<int>(value);

            return nodeByValue[value];
        }

        public static void AddEdge(int parent, int child)
        {
            Tree<int> parentNode = GetTreeNodeByValue(parent);
            Tree<int> childNode = GetTreeNodeByValue(child);

            parentNode.Children.Add(childNode);
            childNode.Parent = parentNode;
        }

        public static void ReadTree()
        {
            int nodeCount = int.Parse(Console.ReadLine());
            for (int i = 1; i < nodeCount; i++)
            {
                string[] edge = Console.ReadLine().Split(" ");
                AddEdge(int.Parse(edge[0]), int.Parse(edge[1]));
            }
        }

        static Tree<int> GetRootNode()
        {
            return nodeByValue.Values
                .FirstOrDefault(x => x.Parent == null);
        }

        static List<int> GetLeavesNodes()
        {
            return nodeByValue.Values
                .Where(x => x.Children.Count == 0)
                .Select(x => x.Value)
                .OrderBy(x => x)
                .ToList();
        }

        static List<int> GetMiddleNodes()
        {
            return nodeByValue.Values
                .Where(x => x.Children.Count != 0 && x.Parent != null)
                .Select(x => x.Value)
                .OrderBy(x => x)
                .ToList();
        }

        static int DeepestLeftNode()
        {
            Tree<int> deepestNode = null;
            int maxDepth = 0;

            Stack<(Tree<int>, int)> stack = new Stack<(Tree<int>, int)>();
            stack.Push((GetRootNode(), 1));

            while (stack.Count > 0)
            {
                var (node, depth) = stack.Pop();

                if (depth > maxDepth)
                {
                    maxDepth = depth;
                    deepestNode = node;
                }

                foreach (var child in node.Children)
                {
                    stack.Push((child, depth + 1));
                }
            }

            return deepestNode.Value;
        }

    }
}