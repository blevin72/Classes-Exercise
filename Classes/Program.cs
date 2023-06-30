namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Honda";
            car1.Model = "Civic";
            car1.Year = 2019;

            Console.WriteLine($"Make:" + car1.Make);
            Console.WriteLine($"Model:" + car1.Model);
            Console.WriteLine($"Year:" + car1.Year);
        }
    }
}
