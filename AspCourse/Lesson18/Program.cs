namespace Lesson18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                throw new MyExeption(); 
            } 
            catch (MyExeption ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}