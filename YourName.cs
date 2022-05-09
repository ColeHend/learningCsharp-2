using System;
namespace learningCsharp_2
{

    public class Person
    {
        private string firstname;
        private string lastname;
        private string age;
        public int Salary { get; set; }
        private string book;
        public string Book
        {
            get
            {
                return this.book;
            }
            set
            {
                book = value;
            }
        }

        public Person()
        {
            loopMap(); setFirstName(); setLastName(); setAge();
        }
        private void setFirstName()
        {
            Console.WriteLine("What is your first name?");
            firstname = Console.ReadLine();
        }
        private void setLastName()
        {
            Console.WriteLine("What is your last name?");
            lastname = Console.ReadLine();
        }
        private void setAge()
        {
            Console.WriteLine("What is your age?");
            age = Console.ReadLine();
        }
        public string Greeting()
        {
            return $"Hello {firstname} {lastname} you are {age} years old!";
        }
        public int[][] map =
        {
            new int[] {0,1,2},
            new int[] {3,4,5},
            new int[] {6,7,8}
        };
        public void loopMap()
        {
            for (int i = 0; i < map.Length; i++)
            {
                var arr = String.Join(",", Array.ConvertAll(map[i], x => x.ToString()));
                Console.WriteLine("{0}", arr);
                for (int j = 0; j < map[i].Length; j++)
                {
                    Console.WriteLine(map[i][j]);
                }

            }
        }
    }
}