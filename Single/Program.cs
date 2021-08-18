using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

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

                //returns 5
                Console.WriteLine(nums.Find(n => n == 5));

                //returns System.Collections.Generic.List`1[System.Int32]
                Console.WriteLine(nums.FindAll(n => n == 9));

                //9 9
                Console.WriteLine(string.Join(" ", nums.FindAll(n => n == 9)));

                //41
                Console.WriteLine(nums.Sum());

                //false - what is this lol 
                Console.WriteLine(string.IsNullOrEmpty(nums.Where(n => n < 2).ToString()));

                //1 3
                Console.WriteLine(string.Join(" ", nums.Where(n => n < 4)));

                // 0
                Console.WriteLine(nums.SingleOrDefault(n => n == 7));

                //json
                Console.WriteLine(JsonConvert.SerializeObject(nums));


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
