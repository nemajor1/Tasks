using System;

namespace Basics.VariablesAndDataTypes
{
    internal class Task4
    {
        private double firstNumber = 0;
        private double secondNumber = 0;
        private string? action = null;
        public void Start()
        {
            Console.WriteLine("Выберите дейсвтие +, -, *, /");
            action = Console.ReadLine();
            if (action != "+" && action != "-" && action != "*" && action != "/")
            {
                Console.WriteLine("Неверное значение");
                Start();
            }
            Console.WriteLine("Введите первое число");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            switch (action)
            {
                case "+":
                    Console.WriteLine(Sum(firstNumber, secondNumber)); Start(); break;
                case "-":
                    Console.WriteLine(Dif(firstNumber, secondNumber)); Start(); break;
                case "*":
                    Console.WriteLine(Mul(firstNumber, secondNumber)); Start(); break;
                case "/":
                    Console.WriteLine(Div(firstNumber, secondNumber)); Start(); break;
            }
        }
        private double Sum(double fN, double sN)
        {
            return fN + sN;
        }
        private double Dif(double fN, double sN)
        {
            return fN - sN;
        }
        private double Mul(double fN, double sN)
        {
            return fN * sN;
        }
        private double Div(double fN, double sN)
        {
            if (sN == 0)
            {
                Console.WriteLine("На ноль делить нельзя");
                Start();
            }
            return fN / sN;
        }
    }
}
