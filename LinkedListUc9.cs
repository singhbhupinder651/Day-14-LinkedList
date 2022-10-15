﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class LinkedList
    {
        internal Node head;
        internal void AddReverseData(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next = temp;
            }
        }


        internal void AddAppend(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }


        internal void Insert(int position, int data)
        {
            Node newNode = new Node(data);

            if (position < 1)
            {
                Console.WriteLine("Invalid position");
            }
            else if (position == 1)
            {
                Node temp = head;
                newNode.next = temp;
                head = newNode;
            }
            else
            {
                Node temp = head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp.next != null)
                    {
                        temp = temp.next;
                    }
                }

                if (temp.next != null)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
                else
                {
                    Console.WriteLine("Node at position {0} is null", position - 1);
                }
            }


        }

        internal void PopFirst()
        {
            if (head != null)
            {
                Node temp = this.head;
                this.head = this.head.next;
                temp = null;
            }
            else
            {
                Console.WriteLine("LinkedList is empty");
            }
        }


        internal void PopLast()
        {
            if (this.head != null)
            {
                if (this.head.next == null)
                {
                    this.head = null;
                }
                else
                {
                    Node temp = this.head;
                    while(temp.next.next != null)
                    {
                        temp = temp.next;
                    }
                    Node lastNode = temp.next;
                    temp.next = null;
                    lastNode = null;
                }
            }
            else
            {
                Console.WriteLine("LinkedList is empty");
            }

        }

        internal int FindNode(int data)
        {
            int count = 1;
            if (head != null)
            {
                Node temp = head;
                while (temp.data != data)
                {
                    count++;
                    temp = temp.next;
                }
                Console.WriteLine("\nNode with key {0} is at position: {1}", data, count);
            }
            return count;
        }


        internal void DeleteAtPosition(int position)
        {
            if (position > 0)
            {
                Node temp = head;
                if (position == 1)
                {
                    head = temp.next;
                }
                else
                {
                    for (int i = 1; i < position - 1; i++)
                    {
                        if (temp.next.next != null)
                        {
                            temp = temp.next;
                        }
                    }
                    if (temp.next.next == null)
                    {
                        Console.WriteLine("\n[ERROR] Enter a valid position");
                    }
                    else
                    {
                        Node deleteNode = temp.next;
                        temp.next = deleteNode.next;
                    }
                }
            }
            else
            {
                Console.WriteLine("Enter a valid position");
            }
        }


        internal void Size()
        {
            if (head == null)
            {
                Console.WriteLine("\nLinkedList is empty");
            }
            else
            {
                Node temp = head;
                int count = 1;
                while (temp.next != null)
                {
                    temp = temp.next;
                    count++;
                }
                Console.WriteLine("\nSize of LinkedList is: {0}", count);
            }

        }


        internal void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
            }
        }


    }
}
