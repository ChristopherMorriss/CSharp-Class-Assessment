// See https://aka.ms/new-console-template for more information
namespace Application{
    class Test 
    {
        public static void Main()
        {
            Car car = new Car("carMake","v2","DLV",2000,25000); //Creates a new car object with the specified values
            Console.WriteLine(car.CarMake); //Prints the CarMake value of the car to the console
            Console.WriteLine(car.CarModel); //Prints the CarModel value of the car to the console
            Console.WriteLine(car.CarRegistration); //Prints the CarRegistration value of the car to the console
            Console.WriteLine(car.CarYear); //Prints the CarYear value of the car to the console
            Console.WriteLine(car.CarCurrentValue); //Prints the CarCurrent value of the car to the console
            car.ToString(); 
        }
        
    }
    
}


