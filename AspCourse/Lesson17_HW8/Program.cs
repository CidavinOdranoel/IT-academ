namespace Lesson17_HW8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PersonInfo person1 = new PersonInfo("Oleg", "", "Ylica");
                person1.ChangeSurname("Shachlinov");
            }
            catch (EmptyStringException ex)
            {
                Console.Write(ex.Message + ": ");
                Console.WriteLine($"person1 is not created");
            }

            PersonInfo person2 = new PersonInfo("Ivan", "Ivanov", "Ylica");
            try
            {
                person2.ChangeName("Petr");
                person2.ChangeSurname("Petrov");
                person2.ChangeAdress("");
            }
            catch (EmptyStringException ex)
            {
                Console.Write(ex.Message + ": ");
                Console.WriteLine("person2 proterties wasn't changed");
            }
        }
    }
}