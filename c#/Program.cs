using System;
using System.Linq;
using System.Collections.Generic;

namespace c_
{
    class Program
    {
        private static int Thing(in int number)
        {
            int n = 0;
            foreach (string letter in number.ToString().ToCharArray().Select(c => c.ToString()))
            {
                n += (int)Math.Pow(Convert.ToInt32(letter), 2);
            }
            return n;
        }

        private static bool IsHappy(int number)
        {
            List<int> results = new List<int> {};
            int result = Thing(in number);
            
            while (results.Where(r => r == result).Count() < 2)
            {
                result = Thing(in result);
                results.Add(result);
            }
            return result == 1;
        }

        public static void Main()
        {
            Console.WriteLine("Is 19 a happy number? " + (IsHappy(19) ? "Yes" : "No")); // Expected output: yes 
            Console.WriteLine("Is 5 a happy number? " + (IsHappy(5) ? "Yes" : "No")); // Expected output: no
        }
    }
}