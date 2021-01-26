using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person() { Id = 10, Name = "ali", SurName = "kılıç" };
            Console.WriteLine(person1.Name); 

            Person person2 = new Person(20,"yusuf","kızıl");
            Console.WriteLine(person2.Name);

        }
    }
    class Person 
    {
        public Person()
        {

        }
        public Person(int id,string name,string surname)
        {
            Id = id;
            Name = name;
            SurName = surname;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
    }
}
