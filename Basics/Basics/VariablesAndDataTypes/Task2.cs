namespace Basics.VariablesAndDataTypes
{
    internal class Task2
    {
        public Task2(int[] ar)
        {
            int sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }
            Console.WriteLine(sum);
        }
    }
}
