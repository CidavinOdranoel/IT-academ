namespace Lesson6
{
    internal class REcursion
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(0));
            Console.WriteLine(Factorial(1));
            Console.WriteLine(Factorial(2));
            Console.WriteLine(Factorial(3));
            Console.WriteLine(Factorial(4));
            Console.WriteLine(Factorial(5));
            Console.WriteLine(Factorial(6));
        }

        static int Factorial (int x)
        {
            if (x < 0)
            {
                return 0;
            } else if (x == 0) 
            {
                return 1;
            }
            int result = x * Factorial(x-1);

            return result;
        }
    }
}