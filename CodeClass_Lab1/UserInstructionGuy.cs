using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeClass_Lab1
{
   public class UserInstructionGuy
    {
        //input instructions
        public static void PromptUserForInput1(string action)
        {
            Console.WriteLine("Please enter first value for " + action + " operation.");
        }

        public static void PromptUserForInput2(string action)
        {
            Console.WriteLine("Please enter second value for " + action + " operation.");   
        }

       public static int DisplayMathResults(int results)
       {
           Console.WriteLine("\nThe value of your operation is " + results);
           return results;
       }

       //todo rethink business Mad Lib do simple one scentence Mad Lib

       public static void WalkThoughThePerfectMicroPitch()
       {
           Console.WriteLine("Please enter a cool name for a company...?");
           string companyName = Console.ReadLine();
           Console.Clear();
           Console.WriteLine("Thank you\nIn 3 words or less please describe a 'Defined Offering' ie miracle product or total offering to customers\n"
               + "Fat Burning Hamburgers ? Bluetooth Dream Recovery?  ");
           string definedOffering = Console.ReadLine();
           Console.Clear();

       }

    }
}
