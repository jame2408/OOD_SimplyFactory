namespace Calculator.Operation
{
    class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = firstNumber - secondNumber;
            return result;
        }
    }
}
