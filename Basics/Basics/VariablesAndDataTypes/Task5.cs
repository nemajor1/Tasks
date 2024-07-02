namespace Basics.VariablesAndDataTypes
{
    internal class Task5
    {
        private double number = 0;
        public Task5()
        {
            Console.WriteLine("Введите число");
            number = Convert.ToDouble(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Четное");
            }
            else
            {
                Console.WriteLine("Не четное");
            }
        }
    }
}
