using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeClass_Lab1
{
    public class SimpleTypographyGuy
    {


        public static string perfectMicroPitch(
            string nameOfYourCompany,
            string aDefinedOffering,
            string aTargetAudence,
            string problemToSolve,
            string withSecretSauce)
        {
            Console.WriteLine("");

            return "My company, " +
                nameOfYourCompany +
                " is developing a "
                + aDefinedOffering +
                " to help "
                + aTargetAudence +
                " "
                + withSecretSauce;
        }

    }
}
