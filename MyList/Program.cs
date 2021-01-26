using System;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(3);
            myList.Add(5);
            myList.Add(3);
            myList.View();
            Console.WriteLine(myList.Count);
        }
    }

    class MyList<T>
    {
        T[] Array;
        T[] TempArray;
        public MyList()
        {
             Array= new T[0];
        }
        public void Add(T item) 
        {
            TempArray = Array;
            Array = new T[Array.Length + 1];
            for (int i = 0; i < TempArray.Length; i++)
            {
                Array[i] = TempArray[i];
            }
            Array[Array.Length - 1] = item;

        }
        public void View()
        {
            foreach (var item in Array)
            {
                Console.WriteLine(item);
            }
            
        }
      
        public int Count
        {
            get { return Array.Length; }
           
        }



    }
}
