namespace Lab4
{
    public class AverageAge
    {
        private double _sumOfAllAges;
        private int _totalNumberOfPeople;
        Person Age;
        Person Hu;
        Person Spouse;
        
       
        // use += to incremnt 
     
        public void AddPerson(int Age) 
        {
            _sumOfAllAges = Hu.Age + Spouse.Age;
            _totalNumberOfPeople += _totalNumberOfPeople ;
        }
        public double Get() 
        {
            return _sumOfAllAges / _totalNumberOfPeople; // use (double) in front the percedding if no 0.0
        }
            

    }
}