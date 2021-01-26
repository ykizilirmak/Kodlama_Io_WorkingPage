using System;
using System.Collections.Generic;


namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> Student = new Dictionary<int,string>();
            Student.Add(123, "Sinan Aslan");
            Student.Add(321, "yusuf kızıl");
            Console.WriteLine(Student.Count);
            Student.Remove(123);
            Console.WriteLine(Student.Count);
            Console.WriteLine(Student[321]);  //index yerine key ile işlem yapılıyor.

        }
    }
}
