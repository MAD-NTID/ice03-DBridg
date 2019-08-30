using System;
/*  Name: Dylan Bridges
    Date: August 30, 2019
    Course: NMAD.180 Programming Fundementals I: Mobile Domain
    Purpose: To practice creating, naming, and using different variables
 */
namespace VarPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Practicing creating variables and standard naming conventions 
            int myAge = 26;
            int myBirthYear = 1993;
            string myHighSchool = "North Valley School";
            int myHighSchoolGraduationDate = 2011;
            string momsFirstName = "Nancylynn";
            string dadsFirstName = "Byron";
            int collegeCreditNumber = 13;
            string collegeProgramName = "Mobile App Development";
            string myFirstName = "Dylan";
            string myLastName = "Bridges";

            //Practice using the variables above

            Console.WriteLine("\n Hi! My name is "+myFirstName+" "+myLastName+". I am "+myAge+" years old.\n");

            Console.WriteLine("I went to "+myHighSchool+" and I graduated in "+myHighSchoolGraduationDate+
            ". After that I decided to come to NTID for college. Both my Mom "+momsFirstName+" and Dad "
            +dadsFirstName+" thought NTID would be a great choice for me.\n");

            Console.WriteLine("So, now I'm a student here at RIT/NTID. I'm in the "+collegeProgramName+
            " program, taking "+collegeCreditNumber+" credits. That's pretty crazy for someone born in "
            +myBirthYear+".\n");

        }
    }
}
