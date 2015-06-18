using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeClass_Lab1
{
    class SimpleMathGuy
    {
        public static int firstUserValue;
        public static int secondUserValue;
        public static string actionOfOperation;

        public static int totalSum;

        public static int addTwoValues(int firstUserValue, int secondUserValue)
        {
            UserInstructionGuy.PromptUserForInput1("Addition");
            firstUserValue = int.Parse(Console.ReadLine());
            UserInstructionGuy.PromptUserForInput2("Addition");
            secondUserValue = int.Parse(Console.ReadLine());
            totalSum = firstUserValue + secondUserValue;
            return totalSum;
        }

        public static int subtractTwoValues(int firstUserValue, int secondUserValue)
        {
            UserInstructionGuy.PromptUserForInput1("Subtraction");
            firstUserValue = int.Parse(Console.ReadLine());
            UserInstructionGuy.PromptUserForInput2("Subtraction");
            secondUserValue = int.Parse(Console.ReadLine());
            totalSum = firstUserValue - secondUserValue;
            return totalSum;
        }

        public static int multiplyTwoValues(int firstUserValue, int secondUserValue)
        {
            UserInstructionGuy.PromptUserForInput1("Multiplication");
            firstUserValue = int.Parse(Console.ReadLine());
            UserInstructionGuy.PromptUserForInput2("Multiplication");
            secondUserValue = int.Parse(Console.ReadLine());
            totalSum = firstUserValue * secondUserValue;
            return totalSum;
        }

        public static int divideTwoValues(int firstUserValue, int secondUserValue)
        {
            UserInstructionGuy.PromptUserForInput1("Multiplication");
            firstUserValue = int.Parse(Console.ReadLine());
            UserInstructionGuy.PromptUserForInput2("Multplication");
            secondUserValue = int.Parse(Console.ReadLine());
            totalSum = firstUserValue/secondUserValue;
            return totalSum;
        }
    }
}
