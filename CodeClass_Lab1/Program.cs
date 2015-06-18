using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeClass_Lab1
{
    
    
    class Program
    {
        public static int firstUserValue;
        public static int secondUserValue;
        public static int totalSum;

        private static int methodReturnValue;

        static void Main(string[] args)
        {

            addTwoValues(firstUserValue, secondUserValue);
            Console.WriteLine(totalSum);
            Console.ReadLine();
        }

        private static int addTwoValues(int firstUserValue, int secondUserValue)
        {
            Console.WriteLine("Please enter first value for concatenation");
            firstUserValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second value for concatenation");
            secondUserValue = int.Parse(Console.ReadLine());
            totalSum = firstUserValue + secondUserValue;
              

            return totalSum;

        }

    }
}
