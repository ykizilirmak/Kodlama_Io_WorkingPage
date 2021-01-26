using System;

namespace Referance_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
           
            person1.Name ="yusuf";
            person2 = person1;
            person1.Name = "derin";
            Console.WriteLine(person2.Name);


            Customer customer = new Customer();
            customer.Name ="yusuf";
            customer.CustomerId = 1;
            customer.SurName ="kızıl";

            Employee employee = new Employee();
            

            Person person3 = customer;
            Console.WriteLine(person3.SurName);  //customer id yi görmüyor.
            Console.WriteLine(((Customer)person3).CustomerId);  //Boxing sayesinde customer id yi görüyor.

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);

            


        }
    }
    class Person //BASE CLASS KENDİNDEN TÜRETİLEN CLASSLARIN REFLERİNİ TUTABİLİR.
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
    }
    class Customer :Person
    {
        public int CustomerId { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.Name);
        }
    }
}
