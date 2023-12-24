using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlgoLab4
{
    public class TreeNode
    {
        public string Value { get; set; }
        public TreeNode? Left { get; set; }
        public TreeNode? Right { get; set; }
        public TreeNode? Parent { get; set; }

        public TreeNode(string value)
        {
            Value = value;
        }
    }
    public class BinarySearchTree
    {
        public TreeNode? Root { get; set; }
        public int MaxDepth { get; set; }
        public BinarySearchTree() { }
        public void Add(string word)
        {
            TreeNode z = new TreeNode(word);
            TreeNode? y = null;
            TreeNode? x = Root;
            int currDepth = 0;
            while (x != null)
            {
                y = x;

                int result = string.CompareOrdinal(z.Value, x.Value);
                if (result < 0)
                {
                    x = x.Left;
                } else
                {
                    x = x.Right;
                }
                currDepth++;
            }
            z.Parent = y;
            if (y == null)
            {
                Root = z;
                return;
            }
            int result2 = string.CompareOrdinal(z.Value, y.Value);
            if (result2 < 0)
            {
                y.Left = z;
            } else
            {
                y.Right = z;
            }
            if (currDepth > MaxDepth) { 
                MaxDepth = currDepth;
            }
        }

        public TreeNode? Find(string word, TreeNode? node)
        {
            if (node == null)
            {
                return null;
            }
            if (node.Value == word)
            {
                return node;
            }
            int result = string.CompareOrdinal(word, node.Value);
            if ( result < 0 )
            {
                return Find(word, node.Left);
            } else
            {
                return Find(word, node.Right);
            }
        }

        // Функция печатает значения бинарного дерева поиска в симметричном порядке.
        // То есть в отсортированном порядке
        public List<string> TraverseForward()
        {
            List<string> array = new List<string>();
            if (Root != null)
            {
                TraverseForwardInner(Root, array);
            } else
            {
                array.Add("");
            }
            return array;
        }
        private void TraverseForwardInner(TreeNode? root, List<string> array) {
            if (root == null)   // Базовый случай
            {

                return;
            }
            TraverseForwardInner(root.Left, array);   //рекурсивный вызов левого поддерева
            array.Add(root.Value);
            TraverseForwardInner(root.Right, array);
        }

        public List<string> TraverseBackward()
        {
            List<string> array = new List<string>();
            if (Root != null)
            {
                TraverseBackwardInner(Root, array);
            }
            else
            {
                array.Add("");
            }
            return array;
        }
        private void TraverseBackwardInner(TreeNode? root, List<string> array)
        {
            if (root == null)   // Базовый случай
            {
                return;
            }
            TraverseBackwardInner(root.Right, array);   //рекурсивный вызов левого поддерева
            array.Add(root.Value);
            TraverseBackwardInner(root.Left, array);
        }
        public static BinarySearchTree CreateFromStringOfWords(string str)
        {
            string[] words = str.Replace("\r", " ").Replace("\n", " ").Split(' ', StringSplitOptions.RemoveEmptyEntries);

            BinarySearchTree tree = new();

            for (int i = 0; i < words.Length; i++)
            {
                tree.Add(words[i]);
            }

            return tree;
        }
    }
}
