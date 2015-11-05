using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task01
{
    public class Startup
    {
        public static Node<int> FindRootElement(List<Node<int>> nodes)
        {
            var hasParentFlags = new bool[nodes.Count];

            foreach (var node in nodes)
            {
                foreach (var child in node.Children)
                {
                    hasParentFlags[child.Value] = true; //child.Value is the number value not the index
                }
            }

            for (var i = 0; i < hasParentFlags.Length; i++)
            {
                if (hasParentFlags[i] == false)
                {
                    return nodes[i];
                }
            }

            throw new ArgumentException("The tree has no root element", "nodes");
        }

        public static void Main()
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);

            List<Node<int>> nodes = new List<Node<int>>();

            for (var i = 0; i < n; i++)
            {
                nodes.Add(new Node<int>(i));
            }

            // constructing the tree
            for (int i = 1; i <= n - 1; i++)
            {
                string input = Console.ReadLine();

                if (input == null)
                {
                    break;
                }

                string[] relation = input.Split(' ');

                int parentNodeId = int.Parse(relation[0]);
                int childNodeId = int.Parse(relation[1]);
                Node<int> childNode = nodes[childNodeId];

                nodes[parentNodeId].Children.Add(childNode);
            }

            // 1. Find the root
            var root = FindRootElement(nodes);
            Console.WriteLine("The root element is node with value {0}", root.Value);

            // 2. Find all leaf nodes
            var leafs = FindAllLeafs(nodes);
            Console.WriteLine(string.Join(", ", leafs.Select(l => l.Value)));

            // 3. Find all middle nodes
            var middleNodes = FindAllMiddleNodes(nodes);
            Console.WriteLine(string.Join(", ", middleNodes.Select(node => node.Value)));

            // 4. The logest path in the tree from the root
            //Console.WriteLine(TraverseDFS(root));
            var longestPath = TraverseDFS(root);
            Console.WriteLine("The longest path is: {0}", longestPath);

            //5. Display the longest path
            Console.WriteLine(DisplayLongestPath(root, ""));
        }

        private static int TraverseDFS(Node<int> currentNode)
        {
            if (currentNode == null)
            {
                throw new ArgumentNullException("node", "Root is null");
            }

            if (currentNode.Children.Count == 0)
            {
                return 0;
            }

            var maxPath = 0;

            foreach (var child in currentNode.Children)
            {
                TraverseDFS(child);
                maxPath++;

                // or
                //maxPath = Math.Max(maxPath, TraverseDFS(child));
            }

            //return maxPath + 1;

            return maxPath;
        }

        private static string DisplayLongestPath(Node<int> currentNode, string str)
        {
            var stringBuilder = new StringBuilder(str);
            var pointer = "-->";

            stringBuilder.Append(currentNode.Value.ToString());
            stringBuilder.Append(pointer);

            /*for (int i = 0; i < currentNode.Children.Count; i++)
            {
                Node<int> child = currentNode.Children[i];

                stringBuilder.Append(child.Value.ToString());
                stringBuilder.Append(pointer);
                TraverseDFS(child);
            }*/
            foreach(var child in currentNode.Children)
            {
                var currentSb = new StringBuilder(stringBuilder.ToString());
                currentSb.Append(child.Value.ToString());
                //currentSb.Append(pointer);
                //stringBuilder.Append(currentSb);
                DisplayLongestPath(child, currentSb.ToString());
            }

            var path = stringBuilder.ToString();

            return path;
        }

        private static List<Node<int>> FindAllMiddleNodes(List<Node<int>> nodes)
        {
            var root = FindRootElement(nodes);

            var leafs = FindAllLeafs(nodes);

            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i] == root)
                {
                    nodes.Remove(nodes[i]);
                }

                foreach (var leaf in leafs)
                {
                    if (nodes[i] == leaf)
                    {
                        nodes.Remove(nodes[i]);
                    }
                }
            }

            return nodes;
        }

        private static List<Node<int>> FindAllLeafs(List<Node<int>> nodes)
        {
            var result = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                {
                    result.Add(node);
                }
            }

            return result;
        }
    }
}
