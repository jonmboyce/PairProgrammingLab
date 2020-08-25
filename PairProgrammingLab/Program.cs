using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            bool nameEntered = false;


            Console.WriteLine("Enter new student names.");
            string newStudent = Console.ReadLine();
            do
            {

            
            if (newStudent.Length<1)
            {
                Console.WriteLine("Sorry, no characters receiveed.");
            }
            else
            {
                Console.WriteLine(newStudent + "***");
                students.Add(newStudent);
            }
            } while (nameEntered);
        }
    }
}
