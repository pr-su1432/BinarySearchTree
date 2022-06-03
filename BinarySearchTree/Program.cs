using System;
namespace BinarySearchTree
{
    class program
    {
        public static void Main(string[] args)
        {
            BinarySearchTree.BinarySearch<int> tree = new BinarySearchTree.BinarySearch<int>(56);
            tree.AddNode(30);
            tree.AddNode(70);
            tree.Display();

        }
    }
}
