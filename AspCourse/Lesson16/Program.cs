namespace Lesson16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

        }

        internal abstract class Car
        {
            internal void StartMovement()
            {
                Console.WriteLine("Car starts moving");
            }
            internal abstract void StopMovement();
            internal double Fuel {  get; set; }
            internal string Mark{  get; set; }
            internal enum FuelType
            { 
                Disel,
                ElectroCar
            }


        }
        internal interface IFlying
        {

        }

    }
}