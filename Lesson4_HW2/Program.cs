namespace Lesson4_HW2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //1. Создать массив элементов произвольного типа. С помощью циклов переберать
            //все элементы этого массива и вывести их на консоль.

            //2. С помощью цикла со счетчиком вывести на экран в одну строку все двузначные числа, кратные 5.

            //3. С помощью цикла с постусловием вывести на экран в столбик
            //последовательность чисел : -20, -40, ...,-100.


            //Task1
            Console.WriteLine("Задание 1");
            int[] ints = { 1, 2, 3, 4, 5 };
            foreach (int i in ints)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //Task2
            Console.WriteLine("Задание 2");
            for (int i = 10; i <100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            //Task3
            Console.WriteLine("Задание 3");
            int number = -20;
            do
            {
                Console.WriteLine(number);
                number -= 20;
            } while (number >= -100);


            //          CODEWARS
            // Task1
            Console.WriteLine("Codewars Task1");
            List<int> test1 = Codewars.CountBy(3, 10);

            foreach (int e in test1)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();

            // Task 2
            Console.WriteLine("Codewars Task2");
            List<string> test2 = Codewars.StringToListOfWords("qwe qw q asd dd d");
            foreach (string e in test2)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            // Task 3
            Console.WriteLine("Codewars Task3");
            var test3 = Codewars.CountOfPositiveAndSumOfNegative(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 });
            Console.WriteLine();
            foreach (int e in test3)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();

            // Task 4
            Console.WriteLine("Codewars Task4");
            Console.WriteLine($"{Codewars.SquareThenSum(new List<int> {1,2,2 })}");
            Console.WriteLine();

            // Task 5
            Console.WriteLine("Codewars Task 5");
            foreach (var item in Codewars.ReversedListOfDigits(123456))
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            // Additional Task 1
            Console.WriteLine("Additional Task 1");
            Console.WriteLine(Codewars.IsPalindrome("Additional Task 1"));
            Console.WriteLine(Codewars.IsPalindrome("asdsa"));
            Console.WriteLine(Codewars.IsPalindrome(99999));
            Console.WriteLine(Codewars.IsPalindrome(12));
            Console.WriteLine();

            // Additional Task 2
            Console.WriteLine("Additional Task 2");
            List<int> test33 = Codewars.PlusOneToArray(new List<int> { 9, 9, 9 });
            foreach (int e in test33)
            {
                Console.Write(e);
            }
            Console.WriteLine();

            // Additional Task 3
            Console.WriteLine("Additional Task 3");
            var test43 = Codewars.Pyramid(4);
            int counter = 0;
            Console.WriteLine();
            foreach (var e in test43)
            {
                Console.WriteLine($"Массив {++counter}:");
                foreach (var t in e)
                {
                    Console.Write($"{t} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Additional Task 4

            Console.ReadKey(); 












        }
    }
}