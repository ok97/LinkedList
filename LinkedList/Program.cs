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
            //list.InsertAtParticularPosition(2, 30);//UC4


            list.Add(56); // Adding data in list //UC5
            list.Add(30); // Adding data in list //UC5
            list.Add(70); // Adding data in list //UC5
            list.Display(); //call Display method to print data
            list.DeleteFirstNode(); // Adding data in list //UC5




            list.Display(); //call Display method to print data
       
            Console.ReadLine();
        }
    }
}
