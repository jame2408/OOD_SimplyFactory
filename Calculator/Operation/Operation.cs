namespace Calculator.Operation
{
    public class Operation
    {
        private double _firstNumber = 0;
        private double _secondNumber = 0;

        public double firstNumber
        {
            get { return _firstNumber; }
            set { _firstNumber = value; }
        }

        public double secondNumber
        {
            get { return _secondNumber; }
            set { _secondNumber = value; }
        }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
}