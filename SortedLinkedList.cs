using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    internal class SortedLinkedList
    {

        internal NodeS<int> head;
        internal void Add(int data)
        {
            NodeS<int> newNode = new NodeS<int>(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                NodeS<int> temp = head;
                if (newNode.CompareTo(temp) < 0 || newNode.CompareTo(temp) == 0)
                {
                    head = newNode;
                    head.next = temp;
                }
                else
                {
                    if (temp.next == null)
                    {
                        temp.next = newNode;
                    }
                    else
                    {
                        while (temp.next != null)   //checks from start to the end of LinkedList
                        {
                            if (newNode.CompareTo(temp.next) > 0)   //if you write this in while condition, will give error in runtime for inserting largest number in last position
                            {
                                temp = temp.next;
                            }
                            else
                            {
                                break;  //without break, while loops for infinite times
                            }
                        }

                        if (temp.next != null)
                        {
                            newNode.next = temp.next;
                            temp.next = newNode;
                        }
                        else
                        {
                            temp.next = newNode;
                        }
                    }

                }

            }

        }

        internal void Display()
        {
            NodeS<int> temp = head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

    }
}
