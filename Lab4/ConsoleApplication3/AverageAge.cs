namespace Lab4
{
    public class AverageAge
    {
        private double _sumOfAllAges;
        private int _totalNumberOfPeople;
        public Person Spouse;
        
       
        // use += to incremnt 
     
        public void AddPerson(int Age) 
        {
            _sumOfAllAges += Age ;
            
            _totalNumberOfPeople = _totalNumberOfPeople + 1;
          
        }
        public void checkSpouseAge(Person Age)
        {
           
             _totalNumberOfPeople = _totalNumberOfPeople + 1;
          

        }
        public double Get() 
        {
            return _sumOfAllAges / _totalNumberOfPeople; // use (double) in front the percedding if no 0.0
        }
            

    }
}