using System;
using System.Collections.Generic;
using System.Text;

namespace TryLearnedConcepts
{
    internal class Traversal
    {
        // this uses recursion to go down each branch of the tree 
        // it is similar to DFS
        internal static void PreorderTraversal<T>(BinaryTreeNode<T> current)
        {
            if (current != null)
            {
                // Output the value of the current node
                Console.WriteLine(current.Value);

                // Recursively print the left and right children
                PreorderTraversal<T>(current.Left);
                PreorderTraversal<T>(current.Right);
            }
        }

        // this uses recursion to get to the most left of each tree from left to right
        // this means that is prints the numbers in order
        internal static void InorderTraversal<T>(BinaryTreeNode<T> current)
        {
            if (current != null)
            {
                // Visit the left child
                // This also uses recursion
                InorderTraversal(current.Left);
                //Output the value of the current node
                Console.WriteLine(current.Value);
                //Visit the right child
                InorderTraversal(current.Right);
            }
        }

        // this uses recursion to go left child, right child, node -> from the bottom up
        internal static void PostorderTraversal<T>(BinaryTreeNode<T> current)
        {
            if (current != null)
            {
                PostorderTraversal<T>(current.Left);
                PostorderTraversal<T>(current.Right);
                Console.WriteLine(current.Value);
            }
        }

    }
}
