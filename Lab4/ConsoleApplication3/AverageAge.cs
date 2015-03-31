namespace Lab4
{
    public class AverageAge
    {
        private double _sumOfAllAges;
        private int _totalNumberOfPeople;
        //Person Age;
        //Person Sage;

        public void AddPerson(int Age,int Sage) //a void method collect info one person at a time
        {
            _sumOfAllAges = (Age + Sage);
            _totalNumberOfPeople = _totalNumberOfPeople + 1;
        }
        public double Get() //
        {
            return _sumOfAllAges / _totalNumberOfPeople; // use (double) in front the percedding if no 0.0
        }
            

    }
}