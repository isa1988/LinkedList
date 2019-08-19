using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListData;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> linkedList = new MyList<string>();
            // добавление элементов
            linkedList.Add("Tom");
            linkedList.Add("Alice");
            linkedList.Add("Bob");
            linkedList.Add("Sam");

            // выводим элементы
            PrintList(linkedList);
            // удаляем элемент
            Console.WriteLine("Remove Alice");
            linkedList.Remove("Alice");
            PrintList(linkedList);
            // проверяем наличие элемента

            Console.WriteLine("Check Sum");
            bool isPresent = linkedList.Contains("Sam");
            Console.WriteLine(isPresent == true ? "Sam присутствует" : "Sam отсутствует");

            // добавляем элемент в начало 

            Console.WriteLine("Add to start Bill");
            linkedList.AppendFirst("Bill");
            PrintList(linkedList);
            Console.ReadKey();
        }

        private static void PrintList(MyList<string> myList)
        {
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(string.Empty);
        }
    }
}
