using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedList_CSharp
{
    class Program
    {
        static int GetData()
        {
            Console.WriteLine("Please enter the value of data for the selected oprations");
            return int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            CircularLL list = new CircularLL();
            CircularLL AnotherList;

            Console.WriteLine("\nPlease find below the list of elements");
            list.PrintAll();

            int choice = 5;
            int data = 0;

            while (choice != 0)
            {
                Console.WriteLine("\n");
                list.PrintAll();
                Console.WriteLine("\n");

                Console.WriteLine("MENU");
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Insert At Start");
                Console.WriteLine("2.Insert At End");
                Console.WriteLine("3.Delete At Start");
                Console.WriteLine("4.Delete At End");
                Console.WriteLine("5.Print All");
                Console.WriteLine("6.Create Second List Concat with First List");
                //Console.WriteLine("7.Exit");
                //Console.WriteLine("8.Exit");

                Console.WriteLine("Please Enter choice here: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        break;
                    case 1:
                        data = GetData();
                        list.InsertAtStart(data);
                        break;
                    case 2:
                        data = GetData();
                        list.InsertAtEnd(data);
                        break;
                    case 3:
                        list.DeleteAtStart();
                        break;
                    case 4:
                        list.DeleteAtEnd();
                        break;
                    case 5:
                        list.PrintAll();
                        break;
                    case 6:
                        AnotherList = new CircularLL();
                        list.Concat(AnotherList);
                        list.PrintAll();
                        break;
                    default:
                        break;
                }
                
            }
        }
    }
}
