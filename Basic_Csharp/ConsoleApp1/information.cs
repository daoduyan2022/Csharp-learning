using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class information
    {
        public string name { get; set; }

        public int yearborn  { get; set;}
        public string numberPhone  { get; set;}


        public void print_information()
        {
            Console.WriteLine("Name is : " + name.ToString());
            Console.WriteLine("Year of born is : " + yearborn.ToString());
            Console.WriteLine("Number phone is : " + numberPhone.ToString());
        }


    }
}
