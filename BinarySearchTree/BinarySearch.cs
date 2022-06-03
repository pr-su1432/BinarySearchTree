using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class BinarySearch<T> where T : IComparable<T>
    {
        public T data;
        public BinarySearch<T> left;
        public BinarySearch<T> right;
        public BinarySearch(T data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
        int leftIdx = 0, rightIdx = 0;
        public void AddNode(T value)
        {
            T nodeValue = this.data;
            if (nodeValue.CompareTo(value) > 0)
            {
                if (this.left == null)
                    this.left = new BinarySearch<T>(value);
                else
                    this.left.AddNode(value);
            }
            else
            {
                if (this.right == null)
                    this.right = new BinarySearch<T>(value);
                else
                    this.right.AddNode(value);
            }
        }
        public void Display()
        {
            if (this.left != null)
            {
                this.leftIdx++;
                this.left.Display();
            }
            Console.WriteLine(this.data);
            if (this.right != null)
            {
                rightIdx++;
                this.right.Display();
            }
        }
    }
}
