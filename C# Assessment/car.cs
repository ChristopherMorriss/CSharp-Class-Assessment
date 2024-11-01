namespace Application{
     class Car
    {
        public string CarMake; 
        public string CarModel;
        public string CarRegistration;
        public int CarYear;
        public int CarCurrentValue;
       
        
        public Car(string carMake, string carModel, string carRegistration, int carYear, int carCurrentValue)
        {
            CarMake = carMake;
            CarModel = carModel;
            CarRegistration = carRegistration;
            CarYear = carYear;
            CarCurrentValue = carCurrentValue;
        }
        public int CarRegistrationYear(int CarRegistrationYear)
        {
            CarRegistrationYear = CarYear;
            return CarRegistrationYear;
        }
        public int CarValue(int CarValue)
        {
            CarValue = CarCurrentValue;
            return CarValue;
        }
        public override string ToString()
        {
            return CarMake + ',' + CarModel + ',' + CarRegistration + ',' + CarYear + ',' +  + ',' + CarCurrentValue;
        }

    }
}