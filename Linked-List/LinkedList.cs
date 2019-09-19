using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    class Node
    {
        public int data { get; set; }
        public Node Next { get; set; }
    }
    class LinkedList
    {
        Node START;
        
        public void Insert(int item)
        {
            Node newNode = new Node();
            newNode.data = item;
            if (START == null)
            {
                START = newNode;
            }
            //else if (item < START.data)
            //{
            //    newNode.Next = START;
            //    START = newNode;
            //}
            else
            {
                Node CurrentNode = START;
                Node previous = null;
                while (CurrentNode != null && CurrentNode.data <= item)
                {
                    previous = CurrentNode;
                    CurrentNode = CurrentNode.Next;
                }
                if (previous.data != item)
                {
                    previous.Next = newNode;
                    newNode.Next = CurrentNode;
                }
            }
        }

        public void Delete(int item)
        {
            Node DelNode = new Node();
            DelNode.data = item;
            if (START == null)
            {
                Console.WriteLine("Nothing");
            }
            //else if (START.data == item)
            //{
            //    START = START.Next;
            //}
            else
            {
                Node CurrentNode = START;
                Node previous = null;
                while (CurrentNode != null && CurrentNode.data != item)
                {
                    previous = CurrentNode;
                    CurrentNode = CurrentNode.Next;
                }
                if (previous == null)
                {
                    START = START.Next;
                }
                else
                {
                    previous.Next = CurrentNode.Next;
                }
            }
        }

        public void Traverse()
        {
            Node CurrentNode = START;
            while (CurrentNode != null)
            {
                Console.WriteLine(CurrentNode.data);
                CurrentNode = CurrentNode.Next;
            }
        }
    }
}
