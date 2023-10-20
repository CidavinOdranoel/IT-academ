using Bogus;
using System.Collections;

namespace Lesson10_HM5
{
    internal class Program
    {
        static void PrintArray(ArrayList list)
        {
            foreach (var i in list)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.WriteLine();
        }
        static void PrintArray(List<int> list)
        {
            foreach (var i in list)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            #region TASK 1
            // TASK 1

            // Создание массивов
            ArrayList list1 = new ArrayList() {"One", "Two" };
            List<int> list2 = new List<int>() { 1, 2 };
            Console.WriteLine("Создание массивов:");
            Console.Write("ArrayList: ");
            PrintArray(list1);
            Console.Write("List<int>: ");
            PrintArray(list2);
            Console.WriteLine();

            // Добавление элементов в списки
            list1.Add("Three"); list1.Add("Four");
            list2.Add(3); list2.Add(4);
            Console.WriteLine("Добавление элементов в списки:");
            Console.Write("ArrayList: ");
            PrintArray(list1);
            Console.Write("List<int>: ");
            PrintArray(list2);
            Console.WriteLine();

            // Удаление элемента с индексом 3
            list1.RemoveAt(3);
            list2.RemoveAt(3);
            Console.WriteLine("Удаление элемента с индексом 3:");
            Console.Write("ArrayList: ");
            PrintArray(list1);
            Console.Write("List<int>: ");
            PrintArray(list2);
            Console.WriteLine();

            // Удение одного добавленного элемента
            list1.Remove("Three");
            list2.Remove(3);
            Console.WriteLine("Удаление одного добавленного элемента:");
            Console.Write("ArrayList: ");
            PrintArray(list1);
            Console.Write("List<int>: ");
            PrintArray(list2);
            Console.WriteLine();

            // Сортировка
            list1.Sort();  
            list2.Sort();
            Console.WriteLine("Сортировка:");
            Console.Write("ArrayList: ");
            PrintArray(list1);
            Console.Write("List<int>: ");
            PrintArray(list2);
            Console.WriteLine();

            #endregion

            #region TASK 2

            //  Создайте пользовательский список.
            // Реализуйте добавление в список нового объекта так,
            // чтобы после добавления список сортировался по одному из свойств вашего класса.
            //
            // Заполните список начальными данными.
            // Добавьте в ваш список новый элемент.
            //
            // После каждого изменения списка выводите его на экран.

            // Создание списка
            Console.WriteLine("Создание пользовательского списка:");
            Task2<int> task2 = new Task2<int>(new int[] {5,3,1 }, "Comment");
            Console.WriteLine(task2);
            Console.WriteLine();

            // Добавление новых элементов
            Console.WriteLine("Добавление новых элементов:");
            task2.Add(4);
            task2.Add(9);
            Console.WriteLine(task2);
            Console.WriteLine();

            // Отключение автосортирооовки и добаление новых элементов
            Console.WriteLine("Отключение автосортирооовки и добаление новых элементов:");
            task2.AutoSort();
            task2.Add(1);
            Console.WriteLine(task2);
            Console.WriteLine();
            #endregion

            #region TASK 3

            Console.WriteLine("TASK 3");
            Faker faker = new Faker(); // Bogus package

            Dictionary<DateTime,string> books = new Dictionary<DateTime,string>();

            DateTime dateToAdd;
            string bookNameToAdd;

            // Generating books
            for (int i = 0; i < 5000; i++)
            {
                dateToAdd = faker.Date.Between(new DateTime(1950, 1, 1), new DateTime(2020, 12, 31));
                bookNameToAdd = faker.Random.Words();
                books.Add(dateToAdd, bookNameToAdd);
            }

            // Print ordered books
            Console.WriteLine("Ordered books");
            books = books.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var e in books)
            {
                Console.WriteLine($"{e.Key} - \"{e.Value}\"");
            }
            #endregion

        }
    }
}