namespace Lesson8_HM4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");


            DayCollection day = new DayCollection();

            Console.Write("Sunday of European is ");
            Console.WriteLine(day[DayCollection.WeekStyle.European, DayCollection.WeekDay.Sunday]);

            Thermo thermo = new Thermo();
            Console.WriteLine(thermo[Thermo.Month.February, 2]);

            Task2 task2 = new Task2();
            Console.WriteLine(task2.GetRandomName());

            Task3 task3 = new Task3();
            int a = task3.CompareVersions("1.01.2", "1.1.2");
            Console.WriteLine(a);
        }
    }
}