using System.Security.AccessControl;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            global::Car car1 = new global::Car();

            car1.Year = 2023;
            car1.Make = "Audi";
            car1.Model = "R8";

            Console.WriteLine($"I want a { car1.Year} { car1.Make} { car1.Model}");
        }
    }
}
