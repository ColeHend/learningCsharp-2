using System;
namespace learningCsharp_2
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("How many people would you like to make?");
            string strNumb = Console.ReadLine();
            int myNum = Convert.ToInt32(strNumb);

            var people = new Person[myNum];
            for (int i = 0; i < myNum; i++)
            {
                people[i] = new Person();
            }
            foreach (Person leDude in people)
            {
                Console.WriteLine(leDude.Greeting());
            }


            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
