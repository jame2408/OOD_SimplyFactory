﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("請輸入第一個數字：");
                double firstNumber = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("請輸入運算元(+-*/)：");
                string operate = Console.ReadLine();

                Console.WriteLine("請輸入第二個數字：");
                double secondNumber = Convert.ToDouble(Console.ReadLine());

                string result = string.Empty;
                if (operate == "/" && secondNumber == 0d)
                {
                    result = "除數不能為0";
                }
                else
                {
                    result = CalculatorResult(operate, firstNumber, secondNumber);
                }

                Console.WriteLine("計算結果：" + result);
            }
            catch (Exception ex)
            {

                Console.WriteLine("您的輸入有誤：" + ex.Message);
            }


        }

        private static string CalculatorResult(string operate, double firstNumber, double secondNumber)
        {
            var oper = Operation.OperationFactory.createOperation(operate);
            oper.firstNumber = firstNumber;
            oper.secondNumber = secondNumber;
            return oper.GetResult().ToString();
        }
    }
}
