namespace Lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emplStr = new EmploeeStruct { FirstName = "Иван", LastName = "Иваныч" };
            var emplClass = new Emploee { FirstName = "Иван", LastName = "Иваныч" };

            Console.WriteLine(emplStr.ToString());
            Console.WriteLine(emplClass.ToString());

            Console.WriteLine("Hello, World!");
        }
    }
}