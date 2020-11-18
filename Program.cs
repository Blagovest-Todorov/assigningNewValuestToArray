using System;

namespace _02.arraysTuition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {10, 4, 3, 5, 9 };//5 elements with their values, then indexing is :[0 -4] --five indexers

            Console.WriteLine("We print the numbers of given array");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("We assign now  new values of the same array elements :");
            Console.WriteLine("See the difference We print them now :");
            Console.WriteLine("We print the value of the given keyIndex to , and assigh it to the current elemetsValue");

            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = i; //We assign at any given key the new value of the current key on we we pass on with forLoop;
                Console.WriteLine(arr[i]);
            }
        }
    }
}
