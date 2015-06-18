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
            totalSum = SimpleMathGuy.addTwoValues(firstUserValue,secondUserValue);
            UserInstructionGuy.DisplayMathResults(totalSum);
            
            Console.ReadLine();

            totalSum = SimpleMathGuy.subtractTwoValues(firstUserValue, secondUserValue);
            UserInstructionGuy.DisplayMathResults(totalSum);
            Console.ReadLine();

            totalSum = SimpleMathGuy.multiplyTwoValues(firstUserValue, secondUserValue);
            UserInstructionGuy.DisplayMathResults(totalSum);
            Console.ReadLine();

            totalSum = SimpleMathGuy.divideTwoValues(firstUserValue, secondUserValue);
            UserInstructionGuy.DisplayMathResults(totalSum);
            Console.ReadLine();


        }

       




    }
}
