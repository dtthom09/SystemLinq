using System;
using System.Collections.Generic;
using System.Linq;

namespace Single
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try
            {
                var nums = new List<int>() { 1, 3, 5, 6, 8, 9, 9 };

                //returns 1
                Console.WriteLine(nums.Single(n => n == 1));

                //exception, more than 1
                //Console.WriteLine(nums.Single(n => n == 9));

                //Exception, no 10 found
                //Console.WriteLine(nums.Single(n => n == 10));


                //There is no 10 so it beings back a null (0)
                Console.WriteLine(nums.SingleOrDefault(n => n == 10));

                //returns 1
                Console.WriteLine(nums.First());

                //returns 5
                Console.WriteLine(nums.First(n => n == 5));

                //There is no 10 so it beings back a null (0)
                Console.WriteLine(nums.FirstOrDefault(n => n == 10));

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
