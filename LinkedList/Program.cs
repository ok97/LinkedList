﻿using System;
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
          
            //list.InsertLast(56); // Adding data in list //UC1
            //list.InsertLast(30); // Adding data in list //UC1
            //list.InsertLast(70); // Adding data in list  //UC1
           
            
            list.InsertFront(70); // Adding data in list //UC2
            list.InsertFront(30);// Adding data in list //UC2
            list.InsertFront(56);// Adding data in list //UC2


            list.Display(); //call Display method to print data
            Console.ReadLine();
        }
    }
}
