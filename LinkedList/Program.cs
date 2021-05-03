using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList(); //Create object of LinkedList class

            //list.Add(56); // Adding data in list //UC1
            //list.Add(30); // Adding data in list //UC1
            //list.Add(70); // Adding data in list //UC1


            //list.InsertFront(70);// Adding data in list //UC2
            //list.InsertFront(30);// Adding data in list //UC2
            //list.InsertFront(56);// Adding data in list //UC2

            //list.Appending(56);// Adding data in list //UC3
            //list.Appending(30);// Adding data in list //UC3
            //list.Appending(70);// Adding data in list //UC3

            //list.Add(56); // Adding data in list //UC4            
            //list.Add(70); // Adding data in list //UC4
            //list.InsertAtParticularPosition(2, 30);//Insert At position Element UC4


            //list.Add(56); // Adding data in list //UC5
            //list.Add(30); // Adding data in list //UC5
            //list.Add(70); // Adding data in list //UC5
            //list.Display(); //call Display method to print data
            //list.DeleteFirstNode(); // Delete First Element data in list //UC5

            //list.Add(56); // Adding data in list //UC6
            //list.Add(30); // Adding data in list //UC6
            //list.Add(70); // Adding data in list //UC6
            //list.Display(); //call Display method to print data
            //list.DeleteLastNode(); // Delete Last Element data in list //UC6

            //list.Add(56); // Adding data in list //UC7
            //list.Add(30); // Adding data in list //UC7
            //list.Add(70); // Adding data in list //UC7
            //list.Display(); //call Display method to print data//UC7
            //list.Search(50); //Search Element in Linked List //UC7list.Add(56); // Adding data in list //UC7


            //list.Add(56); // Adding data in list //UC8
            //list.Add(30); // Adding data in list //UC8
            //list.Add(70); // Adding data in list //UC8
            //list.Display(); //call Display method to print data//UC8
            //list.InsertAtAfterValue(30,40); //Call InsertAtAfterValue pass value //UC8
            //list.Display(); // Display //UC8



            list.Add(56); // Adding data in list //UC9
            list.Add(30); // Adding data in list //UC9
            list.Add(40); // Adding data in list //UC9
            list.Add(70); // Adding data in list //UC9
            list.Display(); //call Display method to print data//UC9
            list.Count(); //call count method
            list.DeleteElement(40); //call DeleteElement method pass parameter // UC9     
            list.Display(); // Display //UC9
            list.Count(); //call count method and print count//UC9


            Console.ReadLine();
        }
    }
}
