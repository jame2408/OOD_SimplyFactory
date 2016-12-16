namespace Calculator.Operation
{
    class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = firstNumber * secondNumber;
            return result;
        }
    }
}
