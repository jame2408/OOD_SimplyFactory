namespace Calculator.Operation
{
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = firstNumber / secondNumber;
            return result;
        }
    }
}
