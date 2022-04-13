using System;
using System.Collections.Generic;
using System.Linq;
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

        public static Node InsertNth(Node head, int index, int data)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(index)} should be in the range [0..length-1]");
            }
            else if (index > Node.Length(head) && index != 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(index)} should be in the range [0..length-1]");
            }
            else
            {
                if (head == null)
                {
                    return Node.Push(head, data);
                }
                else if (index == Node.Length(head))
                {
                    Node.GetNth(head, index - 1).Next = new Node(data);
                    return head;
                }
                else
                {
                    var nextNode = Node.GetNth(head, index);
                    if (index == 0)
                    {
                        return Node.Push(nextNode, data);
                    }
                    else
                    {
                        var node = new Node(data);
                        Node.GetNth(head, index - 1).Next = node;
                        node.Next = nextNode;
                        return head;
                    }
                }
            }
        }

        public static Node GetNth(Node node, int index)
        {
            if (!(index >= 0 && index < Node.Length(node)))
            {
                throw new ArgumentException($"{nameof(index)} should be in the range [0..length-1]");
            }
            else
            {
                var nodeNum = 0;
                var nodeNth = node;

                while (nodeNum != index)
                {
                    nodeNth = nodeNth.Next;
                    nodeNum++;
                }
                return nodeNth;
            }
        }

        public static int Length(Node head)
        {
            var sum = 0;
            var node = head;
            while (node != null)
            {
                node = node.Next;
                sum++;
            }
            return sum;
        }

        public static int Count(Node head, Predicate<int> func)
        {
            var count = 0;
            var node = head;

            while (node != null)
            {
                if (func(node.Data))
                    count++;
                node = node.Next;
            }
            return count;
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
