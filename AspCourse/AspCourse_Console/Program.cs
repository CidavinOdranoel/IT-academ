

namespace AspCourse_Console
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //Task1
            Console.WriteLine(  Homework2.ReverseString("123456789 987654321"));

            //Task2
            Console.WriteLine(  Homework2.RepeatString(4, "Repeat"));

            //Task3
            Console.WriteLine(  Homework2.GetHighestAndLowestInt("1 9 3 4 -5"));

            //Task4
            Console.WriteLine(  Homework2.IsIsogram("abca"));
            Console.WriteLine(  Homework2.IsIsogram("abcde"));

            //Task5
            Console.WriteLine(Homework2.RepeatSymbols("abcde"));

            Console.ReadKey();
        }
    }
}