using System.Runtime.CompilerServices;

namespace Basics.Methods
{
    internal class Task2
    {
        private int lastNumber;
        public Task2()
        {
            Console.WriteLine("Введите конечное число в массиве");
            lastNumber = Convert.ToInt32(Console.ReadLine());
            Coup(lastNumber);
        }
        private void Coup(int number)
        {
            int[] mass = new int[number];
            int n = number;
            for (int i = 0; i < number; i++)
            {
                mass[i] = n;
                n -= 1;
                Console.WriteLine(mass[i] + $" = {i} элементу ");
            }
        }
    }
}
