namespace Basics.CyclesAndConditions
{
    internal class Task1
    {
        public Task1()
        {
            Console.WriteLine("Введите вывод");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
