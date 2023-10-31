namespace Lesson13_HW6
{

    //                      Homework6
    //                  https://docs.google.com/document/d/1ydVfxWZIRwaKI30SoG3_qaHFJsq8IqHRdJi5EopOHx0
    //
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car("BMW");
            Vehicle bicycle = new Bicycle("Bicycle Type 13");
            Vehicle motorbike = new Motorbike(400);
            Vehicle horse = new Horse("Loshad", "British Warmblood");

            List<Vehicle> list = new List<Vehicle>();
            list.Add(car);
            list.Add(bicycle);
            list.Add(motorbike);
            list.Add(horse);

            foreach (Vehicle v in list)
            {
                v.Move();
                v.ToFuel(600);
            }
            
        }
    }
}