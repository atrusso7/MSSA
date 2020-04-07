using System.Collections.Generic;
using System;

namespace _6Apr_LinkedList
{
    class Node<T> where T : IComparable<T>
    {
        public T Val;
        public Node<T> left;
        public Node<T> right;
        public Node(T val)
        {
            val = Val;
        }
        public void Add(T toInsert)
        {
            if (toInsert.CompareTo(Val) > 0)
            {
                if (left == null)
                {
                    left = new Node<T>(toInsert);
                }
                else
                {
                    left.Add(toInsert);
                }
            }
            else
            {
                if (right == null)
                {
                    right = new Node<T>(toInsert);
                }
                else
                {
                    right.Add(toInsert);
                }
            }
        }
        public List<T> ToList()
        {
            var result = new List<T>();
            if (left != null)
            {
                var leftSide = left.ToList();
                result.AddRange(leftSide);
            }
            if (right != null)
            {
                var rightSide = right.ToList();
                result.AddRange(rightSide);
            }
            result.Add(Val);
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var headNode = new Node<int>(7);
            headNode.Add(5);
            headNode.Add(6);
            headNode.Add(2);
            headNode.Add(3);
            headNode.Add(1);
            headNode.Add(13);
            headNode.ToList().ForEach(System.Console.WriteLine);
        }
    }
}
