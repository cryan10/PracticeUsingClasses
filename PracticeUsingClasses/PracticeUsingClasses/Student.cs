using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeUsingClasses
{
    class Student
    {
        string firstName;
        string lastName;
        string fullName;
        string email;
        string phoneNumber;



        public string FullName
        {
            get { return this.firstName + " " + this.lastName; }

        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }

        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public Student()
        {
            //this is default constructor
        }

        public Student(string firstName, string lastName, string email, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }


        public void PrintInfo()
        {
            Console.WriteLine("Hello, {0}!", this.FullName);
            Console.WriteLine("Your email is {0}", this.email);
            Console.WriteLine("Your phone number is {0}", this.phoneNumber);
        }
    }
}
