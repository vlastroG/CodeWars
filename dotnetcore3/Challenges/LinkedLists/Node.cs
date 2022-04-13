using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcore3.Challenges.LinkedLists
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }

        public static Node Push(Node head, int data)
        {
            var n = new Node(data);
            n.Next = head;
            return n;

        }

        public static Node BuildOneTwoThree()
        {
            var n3 = new Node(3);
            var n2 = Node.Push(n3, 2);
            var n1 = Node.Push(n2, 1);

            return n1;
        }
    }
}
