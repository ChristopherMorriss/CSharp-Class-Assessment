namespace Application{
    class Car

    {
        public string carMake;
        public string carModel;
        public string carRegistration;
        public string carYear;
        public string carCurrentValue;
        static void Main (string[] arg){
            //console.WriteLine("Hello world!");
            //console.WriteLine("This is working");
        }

        Car(string carMake, string carModel, string carRegistration, int carYear, double carCurrentValue)
        {
            CarMake = carMake;
            CarModel = carModel;
            CarRegistration = carRegistration;
            CarYear = carYear;
            CarCurrentValue = carCurrentValue;
        }

        public int carRegYear (int carYear){
            carRegistrationYear = carYear;
            return carRegistrationYear;
        }
    }
    }
// Implement a Car class which has fields to store the car’s make, model, registration, year (of initial registration), and current value.

// Implement a constructor for the Car class which takes parameters corresponding to each of the fields above and constructs an object with these values.

// Implement a C# Class methods which returns the current value of the car

// Implement a method which returns the year of the car

// Override ToString to return a string containing full information about the car

// Write a test class which constructs a Car and prints its details to the console