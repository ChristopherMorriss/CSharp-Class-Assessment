// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Hello, John!");

namespace Application{
    class Test // class Program
    {
        public static void Main()
        {
            Car car = new Car("carMake","v2","DLV",2000,25000); //Creates a new car object
            Console.WriteLine(car.CarMake); //Prints the CarMake value of the car to the console
            Console.WriteLine(car.CarModel); //Prints the CarModel value of the car to the console
            Console.WriteLine(car.CarRegistration); //Prints the CarRegistration value of the car to the console
            Console.WriteLine(car.CarYear); //Prints the CarYear value of the car to the console
            Console.WriteLine(car.CarCurrentValue); //Prints the CarCurrent value of the car to the console
            car.ToString(); 
        }
        
    }
    
}
// Implement a Car class which has fields to store the car’s make, model, registration, year (of initial registration), and current value.
// Implement a constructor for the Car class which takes parameters corresponding to each of the fields above and constructs an object with these values.
// Implement a C# Class methods which returns the current value of the car
// Implement a method which returns the year of the car

