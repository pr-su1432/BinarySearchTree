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
            tree.AddNode(22);
            tree.AddNode(40);
            tree.AddNode(11);
            tree.AddNode(3);
            tree.AddNode(16);
            tree.AddNode(60);
            tree.AddNode(95);
            tree.AddNode(65);
            tree.AddNode(63);
            tree.AddNode(67);
            Console.WriteLine("Enter node to search:");
            int element = Convert.ToInt32(Console.ReadLine());
            tree.search(element, tree);
            tree.Display();
        }
    }
}
