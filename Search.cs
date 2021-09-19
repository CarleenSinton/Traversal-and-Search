using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TryLearnedConcepts
{
    internal class Search
    {
        internal static void DepthFirstSearch<T>(BinaryTree<T> binaryTree)
        {
            Console.WriteLine("Depth First Search");
            // create a hashtable of seen
            Hashtable seen = new Hashtable();
            // create a stack
            Stack<BinaryTreeNode<T>> toProcess = new Stack<BinaryTreeNode<T>>();
            // push the root
            toProcess.Push(binaryTree.Root);

            // while stack is not empty
            while (toProcess.Count != 0)
            {
                // pop
                var temp = toProcess.Pop();
                // check if seen
                if (!seen.ContainsKey(temp) && temp != null)
                {
                    // add current to seen
                    seen.Add(temp, 1);
                    // add children to stack
                    if (temp.Right != null)
                    {
                        toProcess.Push(temp.Right);
                    }
                    if (temp.Left != null)
                    {
                        toProcess.Push(temp.Left);
                    }
                    // process node
                    Console.WriteLine(temp.Value);
                }
            }
        }

        internal static void BreadthFirstSearch<T>(BinaryTree<T> binaryTree)
        {
            Console.WriteLine("Breadth First Search");
            // create a hashtable of seen
            Hashtable seen = new Hashtable();
            // create a queue
            Queue<BinaryTreeNode<T>> toProcess = new Queue<BinaryTreeNode<T>>();
            // enqueue the root
            toProcess.Enqueue(binaryTree.Root);

            // while queue is not empty
            while (toProcess.Count != 0)
            {
                // dequeue
                var temp = toProcess.Dequeue();
                // check if seen

                if (!seen.ContainsKey(temp))
                {
                    // add children to queue
                    if (temp.Left != null)
                    {
                        toProcess.Enqueue(temp.Left);
                    }
                    if (temp.Right != null)
                    {
                        toProcess.Enqueue(temp.Right);
                    }
                    // process dequeued node
                    Console.WriteLine(temp.Value);
                }
            }
        }

    }
}
