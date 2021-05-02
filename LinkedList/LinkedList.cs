﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node //node class
    {
        public int data; // integer value store data
        public Node next; //Public Node head; data type is Node holding the address of the next node
        public Node(int d) // parameter constructor
        {
            data = d; //data store
            next = null; //next is null
        }

    }
    public class LinkedList
    {
        public Node head; //first node head
        /* UC1:- Lets create a simple Linked List of 56, 30 and 70
          */
        public void InsertLast(int new_data)
        {
            Node new_node = new Node(new_data); //create object Node  
                if(this.head == null)
            {
                this.head = new_node;
            }
                else
            {
                Node lastnode = GetLastNode();
                lastnode.next = new_node; //add new node

            }
            Console.WriteLine($"Inserted into List {new_node.data}");
        }
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        /*UC2:- Ability to create Linked List by adding 30 and 56 to 70
                - Node with data 70 is First Created- Next 30 is added to 70
                - Finally 56 is added to 30
                - LinkedList Sequence: 56->30->70
        */
        public void InsertFront(int new_data)
        {
            Node new_node = new Node(new_data);//create new node then new node point to the head of the linked list
            new_node.next = this.head;// add any node at the front point head 
            this.head = new_node; // The Previous Head is now the second node of linked List the new node is added at the
            Console.WriteLine($"Inserted into list {new_node.data}"); //print
             
        }

         /* UC3:- Ability to create Linked List by appending 30 and 70 to 56.
                  - Node with data 56 is First Created.
                  - Next Append 30 to 56. 
                  - Finally Append 70 to 30.
                  - LinkedList Sequence: 56->30->70.
         */

        public void Appending(int value)
        {
            InsertLast(value);
        }


        public void Display() //create Display Method
        {
            Node temp = this.head;
            if (temp == null)  
            {
                Console.WriteLine("Linked List Empty");
                return;
            }
            else
            {
                while (temp!=null)
                {
                    Console.WriteLine($" {temp.data} ");//print Node
                    temp = temp.next; //point to next node
                }
            }

        }
    }
}
