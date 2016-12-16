namespace Calculator
{
    class Operation
    {
        public static double GetResult(double firstNumber, double secondNumber, string operate)
        {
            double result = 0d;
            switch (operate)
            {
                case "+":
                    result = (firstNumber + secondNumber);
                    break;
                case "-":
                    result = (firstNumber - secondNumber);
                    break;
                case "*":
                    result = (firstNumber * secondNumber);
                    break;
                case "/":
                    result = (firstNumber / secondNumber);
                    break;
            }
            return result;
        }
    }
}