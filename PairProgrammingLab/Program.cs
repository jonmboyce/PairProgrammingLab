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
            string userNameEntered = "";

            do
            {
                Console.WriteLine("Please enter the student's name");
                userNameEntered = Console.ReadLine();

                if (userNameEntered.Count() > 0)
                {
                    students.Add(userNameEntered);
                }
                else
                {
                    nameEntered = true;
                }

            }
            while (!nameEntered);
            do
            {
                if (students.Count ==3)
                {
                    Console.WriteLine($"Student group:\n{students[0]}\n{students[1]}\n{students[2]}");
                    students.RemoveRange(0, 3);
                }
                else if (students.Count > 3)
                {
                    Console.WriteLine($"Student group:\n{students[0]}\n{students[1]}\n");
                    students.RemoveRange(0,2);
                }
                else
                {
                    Console.WriteLine($"Student group:\n{students[0]}\n{students[1]}\n");
                    students.RemoveRange(0, 2);
                }

            } while (students.Count > 0);

        }
    }
}

