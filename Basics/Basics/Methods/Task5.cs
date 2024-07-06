namespace Basics.Methods
{
    internal class Task5
    {
        private int number;
        private int fac;
        public Task5()
        {
            Console.WriteLine("Введите число");
            number = Convert.ToInt32 (Console.ReadLine());
            Factorial(number, out fac);
            Console.WriteLine($"факториал = {fac}");
        }
        private int Factorial(int number, out int f)
        {
            f = 1;
            for (int i = 1; i <= number; i++)
            {
                f = f * i;
            }
            return f;
        }
    }
}
