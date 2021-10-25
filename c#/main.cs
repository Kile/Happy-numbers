using System;
using System.Collections.Generic;
using System.Linq;


namespace main
{
    class Program
    {
        private int Thing(int number)
        {
            /// Returns a number based on the happy number thing
            int num = 0;
            for (int i; i < number.ToString().Length; i++)
            {
                num += Math.Pow(number.ToString().ToCharArray().Select(n => int.Parse(n.ToString()))[i], 2);
            }
        }

        private bool IsHappy(int number)
        {
            /// Returns a bool that states wether a number is happy or not
            List<int> results = new List<int> { };
            int result = this.Thing(number);
            results.Add(result);

            while (results.Where(x => x.Equals(result)).Count() < 2)
            {
                result = this.Thing(result);
                results.Add(result);
            }

            return result == 1;
        }

        public void Main()
        {
            Console.WriteLine("19 " + this.IsHappy(19) ? "is" : "isn't" + " a happy number"); // Expected result: true

            Console.WriteLine("5 " + this.IsHappy(5) ? "is" : "isn't" + " a happy number"); // Expected output: false
        }
    }
}