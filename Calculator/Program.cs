using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入第一個數字：");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("請輸入運算元(+-*/)：");
            string operate = Console.ReadLine();

            Console.WriteLine("請輸入第二個數字：");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            string result = string.Empty;
            switch (operate)
            {
                case "+":
                    result = (firstNumber + secondNumber).ToString();
                    break;
                case "-":
                    result = (firstNumber - secondNumber).ToString();
                    break;
                case "*":
                    result = (firstNumber * secondNumber).ToString();
                    break;
                case "/":
                    if (secondNumber != 0)
                    {
                        result = (firstNumber / secondNumber).ToString();
                    }
                    else
                    {
                        result = "不能除以0";
                    }
                    break;
            }

            Console.WriteLine("計算結果：" + result);

        }
    }
}
