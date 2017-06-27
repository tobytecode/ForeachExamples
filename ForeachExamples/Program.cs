using System;
using System.Collections.Generic;

namespace ForeachExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayofweek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            foreach (var item in dayofweek)
            {
                Console.WriteLine(item);
            }
            System.Console.ReadLine();
        }


        //Basic
        static void Basic()
        {
            int[] numbers = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            foreach (int element in numbers)
            {
                System.Console.WriteLine(element);
            }
            System.Console.ReadLine();
        }


        //Using List
        static void List()
        {
            List<int> mylist = new List<int>();
            mylist.Add(101);
            mylist.Add(201);
            mylist.Add(301);
            mylist.Add(401);
            mylist.Add(501);

            foreach (int element in mylist)
            {
                Console.WriteLine(element);
            }
            System.Console.ReadLine();
        }


        //Array 7 days
        static void DayName()
        {
            string[] dayofweek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            foreach (var item in dayofweek)
            {
                Console.WriteLine(item);
            }
            System.Console.ReadLine();
        }




    }
}
