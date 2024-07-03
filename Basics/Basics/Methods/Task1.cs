namespace Basics.Methods
{
    internal class Task1
    {
        public Task1()
        {
            Console.WriteLine("Введите первое число");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Divisor(firstNumber, secondNumber);
        }
        private void Divisor(int a, int b)
        {
            while (b != 0)
            {
                int c = a % b;
                a = b;
                b = c;
            }
            Console.WriteLine($"Наибольший общий делитель = {a}");
        }
    }
}
