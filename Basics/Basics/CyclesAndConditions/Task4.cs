namespace Basics.CyclesAndConditions
{
    internal class Task4
    {
        private int number = 0;
        private int[] ar; 
        public Task4()
        {
            Console.WriteLine("Введите диапозон");
            number = Convert.ToInt32(Console.ReadLine());
            ar = new int[number + 2];
            for (int i = 0; i < number; i ++) { ar[i] = i; }
            for (int i = 2; i < ar.Length; i++)
            {
                ar[i] = ar[i - 1] + ar[i - 2];
                Console.Write(ar[i] + " ");
            }
        }
    }
}
