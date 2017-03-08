using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeUsingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter your email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Please enter your phone number: ");
            string phonenumber = Console.ReadLine();


            Student student = new Student(firstName, lastName, email, phonenumber);

            student.PrintInfo();

        }
    }
}
