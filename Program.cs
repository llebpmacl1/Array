/*
    Author: Loni Campbell
    Date: 2/5/20
    Comment: Showing an auto populated array
*/

using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is my Auto-populated array!");
            Console.WriteLine("");
            int total_elements = 26;
            int[] countdown = new int[total_elements];
            int element = 1;
            for(int i = 1; i < total_elements; i++)
            {
                countdown[i] = element;
                Console.WriteLine("Element Value = " + i);
                Console.WriteLine("");
            }
        }
    }
}
