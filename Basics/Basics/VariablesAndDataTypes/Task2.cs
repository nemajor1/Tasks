namespace Basics.VariablesAndDataTypes
{
    internal class Task2
    {
        public void SumForArray(int[] ar)
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
