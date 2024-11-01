namespace Application{
     class Car
    {
        public string CarMake; //Field
        public string CarModel;
        public string CarRegistration;
        public int CarYear;
        public int CarCurrentValue;
       
        
        public Car(string carMake, string carModel, string carRegistration, int carYear, int carCurrentValue) //Constructor
        {
            CarMake = carMake;
            CarModel = carModel;
            CarRegistration = carRegistration;
            CarYear = carYear;
            CarCurrentValue = carCurrentValue;
        }
        public int CarRegistrationYear(int CarRegistrationYear) //Method for the car's registration year
        {
            CarRegistrationYear = CarYear;
            return CarRegistrationYear;
        }
        public int CarValue(int CarValue) //Method for the car's current value
        {
            CarValue = CarCurrentValue;
            return CarValue;
        }
        public override string ToString() //ToString override
        {
            return CarMake + ',' + CarModel + ',' + CarRegistration + ',' + CarYear + ',' +  + ',' + CarCurrentValue;
        }

    }
}