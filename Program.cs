using System;
using System.Collections;
using System.Collections.Generic;

namespace TryLearnedConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> btree = CreateTree();

            InteractWithUser(btree);
            
        }
       
        static BinaryTree<int> CreateTree()
        {
            BinaryTree<int> btree = new BinaryTree<int>();
            btree.Root = new BinaryTreeNode<int>(90);
            btree.Root.Left = new BinaryTreeNode<int>(50);
            btree.Root.Right = new BinaryTreeNode<int>(150);
            btree.Root.Left.Left = new BinaryTreeNode<int>(20);
            btree.Root.Left.Right = new BinaryTreeNode<int>(75);
            btree.Root.Left.Left.Left = new BinaryTreeNode<int>(5);
            btree.Root.Left.Left.Right = new BinaryTreeNode<int>(25);
            btree.Root.Left.Right.Left = new BinaryTreeNode<int>(66);
            btree.Root.Left.Right.Right = new BinaryTreeNode<int>(80);
            btree.Root.Right.Left = new BinaryTreeNode<int>(95);
            btree.Root.Right.Right = new BinaryTreeNode<int>(175);
            btree.Root.Right.Left.Left = new BinaryTreeNode<int>(92);
            btree.Root.Right.Left.Right = new BinaryTreeNode<int>(111);
            btree.Root.Right.Right.Left = new BinaryTreeNode<int>(166);
            btree.Root.Right.Right.Right = new BinaryTreeNode<int>(200);

            return btree;
        }

        static void InteractWithUser(BinaryTree<int> btree)
        {
            while (true)
            {
                Console.WriteLine("Current Tree");
                Console.WriteLine("              90              ");
                Console.WriteLine("          /       |            ");
                Console.WriteLine("        50        150          ");
                Console.WriteLine("      /  |      /    |        ");
                Console.WriteLine("    20  75     95    175     ");
                Console.WriteLine("  / |   / |   /  |    /  |   ");
                Console.WriteLine(" 5  25 66 80 92 111 166 200 ");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Traverse a Binary Tree");
                Console.WriteLine("2. Search a graph?");
                String traverseOrSearch = Console.ReadLine();
                if (traverseOrSearch == "1")
                {
                    Console.WriteLine("1. Preorder Traversal");
                    Console.WriteLine("2. Inorder Traversal");
                    Console.WriteLine("3. Postorder Traversal");
                    Console.WriteLine("Each of these traversals takes O(n) time.");
                    String searchType = Console.ReadLine();
                    if (searchType == "Preorder Traversal" || searchType == "1")
                    {
                        Traversal.PreorderTraversal<int>(btree.Root);
                    } else if (searchType == "Inorder Traversal" || searchType == "2") {
                        Traversal.InorderTraversal<int>(btree.Root);
                    } else if (searchType == "Postorder Traversal" || searchType == "3")
                    {
                        Traversal.PostorderTraversal<int>(btree.Root);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Option Choose Again");
                    }

                }
                else if (traverseOrSearch == "2")
                {
                    Console.WriteLine("Choose Depth First Search(DFS) or Breadth First Search(BFS)");
                    String searchType = Console.ReadLine();
                    if (searchType == "DFS" || searchType == "Depth First Search")
                    {
                        Search.DepthFirstSearch<int>(btree);
                    }
                    else if (searchType == "BFS" || searchType == "Breadth First Search")
                    {
                        Search.BreadthFirstSearch<int>(btree);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Option Choose Again");
                    }

                }
                else
                {
                    Console.WriteLine("Please Try Again");
                }


            }
        }
    }
}
