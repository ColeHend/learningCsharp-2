using System;
namespace learningCsharp_2
{

    public class Person
    {
        private string firstname;
        private string lastname;
        private string age;
        public Person()
        {
            Fname(); Lname(); Age();
        }
        private void Fname()
        {
            Console.WriteLine("What is your first name?");
            firstname = Console.ReadLine();
        }
        private void Lname()
        {
            Console.WriteLine("What is your last name?");
            lastname = Console.ReadLine();
        }
        private void Age()
        {
            Console.WriteLine("What is your age?");
            age = Console.ReadLine();
        }
        public string Greeting()
        {
            return $"Hello {firstname} {lastname} you are {age} years old!";
        }
    }
}