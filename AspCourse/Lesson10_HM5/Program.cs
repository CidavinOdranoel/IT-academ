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

            // Заполните список начальными данными.
            // Добавьте в ваш список новый элемент.

            // После каждого изменения списка выводите его на экран.

            Task2 aga = new Task2(3, "3");

            #endregion

        }
    }
}