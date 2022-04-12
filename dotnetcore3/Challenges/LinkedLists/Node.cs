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
            if (head != null && head.Next == null)
            {
                return head.Next = new Node(data);
            }
            else if (head != null && head.Next != null)
            {
                Node buff = head.Next;
                head.Next = new Node(data);
                head.Next.Next = buff;

                return head.Next;
            }

            else return new Node(data);
        }

        public static Node BuildOneTwoThree()
        {
            var head = new Node(1);
            var n2 = Node.Push(head, 2);
            Node.Push(n2, 3);

            return head;
        }
    }
}
