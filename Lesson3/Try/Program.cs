namespace Try
{
    internal class Program
    {
        static bool IsEven (int x)
        {
            if (x % 2 == 0)
            {
                return true;
            }
            return false;          
        }

        static int Fibanachi (int number)
        {
            int firstFibanachiNumber = 0;
            int secondFibanachiNumber = 1;
            int sum = 0;


            for (int i = 1; i < number; i++)
            {                
                sum = firstFibanachiNumber + secondFibanachiNumber;
                firstFibanachiNumber = secondFibanachiNumber;
                secondFibanachiNumber = sum;
            }

            return firstFibanachiNumber;
        }
        static void Main(string[] args)
        {

            //Console.WriteLine("Введите начальное значение");
            //int start = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите конечное значение");
            //int finish = Convert.ToInt32(Console.ReadLine());

            //for (int i = start; i <= finish; i++)
            //{
            //    if (IsEven(i))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            Console.WriteLine(Fibanachi(166));
            Console.ReadKey();
        }
    }
}