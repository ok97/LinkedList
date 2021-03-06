using System;
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

        public Node()
        {
        }

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
        public void Add(int new_data)
        {
            Node new_node = new Node(new_data); //create object Node  
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node lastnode = GetLastNode();
                lastnode.next = new_node; //add new node

            }
            Console.WriteLine($"Inserted into List:- {new_node.data}");
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
            Console.WriteLine($"Inserted into list:- {new_node.data}"); //print

        }

        /* UC3:- Ability to create Linked List by appending 30 and 70 to 56.
                 - Node with data 56 is First Created.
                 - Next Append 30 to 56. 
                 - Finally Append 70 to 30.
                 - LinkedList Sequence: 56->30->70.
        */

        public void Appending(int value)
        {
            Add(value);
        }


        /* UC4:- Ability to insert 30 between 56 and 70.
                 - Final Sequence: 56->30->70.
         */
        public Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine($"Invalid Position{ position}");
            }
            if (position == 1)
            {
                var newNode = new Node(data); //create object and passing data
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                {
                    Console.WriteLine($"Position Out Of Range{ position}");
                }
            }
            Console.WriteLine($"Successfully added Position of Element {position},{data}");
            return head;
        }

        /* UC5:- Ability to delete the first element in the LinkedList of sequence 56->30->70.
                 - Write pop method. 
                 - Note there is new head.
                 - Final Sequence: 30->70.
          */

        public void DeleteFirstNode()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            head = temp.next;
            Console.WriteLine($"Successfully Delete First Element {temp.data}");

        }

        /* UC6:- Ability to delete the last element in the LinkedList of sequence 56->30->70.
                 - Write popLast method.
                 - Note there is new tail.
                 - Final Sequence: 56->30
         */

        public void DeleteLastNode()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            else
            {
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }

                Console.WriteLine($"Successfully Delete Last Element {temp.next.data}");
                temp.next = null;
            }

        }

        /* UC7:- Ability to search LinkedList to find Node with value 30.
                 - Write MSTest Test Case as demonstrated in class.
                 - Loop through LinkedList to find node with key 30.
        */

        public int Search(int value)
        {
            int count = 0;
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine($"{value} Searching Element Present in Linked List");
                    return count;
                }

                temp = temp.next;
                count++;
            }
            Console.WriteLine($"{value} Element Not Found in Linked List");
            return count;
        }

        /* UC8:- Ability to insert 40 after 30 to the Linked List sequence of 56->30->70.
                 - Write MSTest Test Case as demonstrated in class.
                 - Search LinkedList to find Node with key value 30.
                 - Then Insert 40 to 30.
                 - Final Sequence: 56->30->40->70. 
         */

        public void InsertAtAfterValue(int after, int data)
        {           

            if (head == null)
            {
                Console.WriteLine("Linked list is Empty");
            }
            else
            {
                Node temp = head;

                while (temp != null)
                {
                    if (temp.data == after)
                    {
                        Node node = new Node(data);
                        node.next = temp.next;
                        temp.next = node;
                        break;
                    }
                    temp = temp.next;                    
                }               
                Console.WriteLine($"Successfully added Element {after} After {data}");           

            }
        }


        /* UC9:- Ability to delete 40 from the Linked List sequence of 56->30->40->70 and show the size of LinkedList is 3.
                - Write MSTest Test Case as demonstrated in class.
                - Search LinkedList to find node with key value 40.
                - Delete the node. 
                - Implement size() and show the Linked List size is 3.
                - Final Sequence: 56->30->70.
        */

        public void DeleteElement(int data)
        {
            bool flag = false;
            int count = 0;

            if (head == null)
            { 
                Console.WriteLine("List is Empty");
            }
            else
            {
                Node temp = head;
                Node previousNode = null;
                while (temp != null)
                {                  
                    
                    if (temp.data == data)
                    {
                        if (count == 1)
                        {
                            head = temp.next;
                        }                       
                        previousNode.next = temp.next;                           
                     
                        flag = true;
                       
                        break;
                    }
                    previousNode = temp;
                    temp = temp.next;
                   
                }
                if (!flag)
                {
                    Console.WriteLine($"{data} Element Not Found in Linked List");
                }
                else
                {
                    Console.WriteLine($"Successfully Delete Element {data}");

                }
            }            
           
        }

        public int Count()
        {
            int count = 0;

            Node temp = head;
            while (temp != null)
            {
                temp = temp.next;
                count++;
            }
            Console.WriteLine($"Linked List Count is {count}");
            return count;
        }


        /* UC10:- Ability to create Ordered Linked List in ascending order of data entered 
                  in following sequence 56, 30, 40, and 70.
                  - Refactor the code to create SortedLinkedList Class.
                  - Create Node that takes data that is Comparable .
                  - Perform Sorting during the add method call.
                  - Final Sequence: 30->40->56->70.
        */

        public Node LinkedListSorted(Node head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            Node temp = head;
            Node slow = head;
            Node fast = head;
            while (fast!=null && fast.next!=null)
            {
                temp = slow;
                slow = slow.next;
                fast = fast.next.next;

            }
            temp.next = null;
           Node leftside = LinkedListSorted(head);
           Node rightside = LinkedListSorted(slow);
            return Merge(leftside,rightside);
        }

        public Node Merge(Node l1, Node l2)
        {
            Node sorted_temp = new Node();
            Node current_node = sorted_temp;

            while (l1 != null && l2 != null)
            {
                if (l1.data < l2.data)
                {
                    current_node.next = l1;

                    l1 = l1.next;
                }
                else
                {
                    current_node.next = l2;

                    l2 = l2.next;
                }
                current_node = current_node.next;
            }

            if (l1 != null)
            {
                current_node.next = l1;
                l1 = l1.next;
            }

            if (l2 != null)
            {
                current_node.next = l2;
                l2 = l2.next;
            }
            
            return sorted_temp.next;

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
                while (temp != null)
                {
                    Console.WriteLine($"Linked List Element:- {temp.data} ");//print Node
                    temp = temp.next; //point to next node
                }
            }

        }




    }
}
