using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedList_CSharp
{
    class CircularLL
    {
        Node last;
        public CircularLL()
        {
            Console.WriteLine("Please enter the elements in the space separated format");
            string[] s = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(s, int.Parse);
            for (int i = 0; i < arr.Length; i++)
            {
                this.InsertAtEnd(arr[i]);
            }
        }

        public void InsertAtStart(int data)
        {
            Node node = new Node() { Data = data, Next = null};
            if(last == null)
            {
                last = node;
                last.Next = last;
            }
            node.Next = last.Next;
            last.Next = node;
        }

        public void InsertAtEnd(int data)
        {
            Node node = new Node() { Data = data, Next = null };
            if (last == null)
            {
                node.Next = node;
            }
            else
            {
                node.Next = last.Next;
                last.Next = node;
            }
            last = node;
        }

        public void DeleteAtStart()
        {
            if (last != null && last.Next != last)
            {
                last.Next = last.Next.Next;
            }
            else
            {
                last = null;
            }
        }
        public void DeleteAtEnd()
        {
            Node itr = last.Next;
            if (last != null && last.Next != last)
            {
                while(itr.Next != last)
                {
                    itr = itr.Next;
                }
                itr.Next = last.Next;
                last = itr;
            }
            else
            {
                last = null;
            }
        }

        public void PrintAll()
        {
            if (last != null)
            {
                Node itr = last.Next;
                while (itr != last)
                {
                    Console.Write(itr.Data + " -> ");
                    itr = itr.Next;
                }
                Console.Write(itr.Data + " -> null");
            }
            else
            {
                Console.WriteLine("list is empty");
            }
        }

        public void Concat(CircularLL anotherList)
        {
            

            if (last == null)
            {
                last = anotherList.last;
            }
            else if (anotherList.last == null){ }
            else
            {
                Node start1 = last.Next;
                Node start2 = anotherList.last.Next;
                last.Next = start2;
                anotherList.last.Next = start1;
                last = anotherList.last;
            }
        }
    }
}
