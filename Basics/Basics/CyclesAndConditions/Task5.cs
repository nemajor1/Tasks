namespace Basics.CyclesAndConditions
{
    internal class Task5
    {
        public Task5()
        {
            Console.WriteLine("Введите слово");
            char[] chars = Console.ReadLine().ToCharArray();
            char[] chars1 = new char[chars.Length];
            for (int i = 0; i < chars.Length; i++) { chars1[i] = chars[chars.Length - i - 1]; }
            string word = new string(chars); string word1 = new string(chars1);
            string s = (word == word1) ? (s = "Палиндром") : (s = "Не палиндром");
            Console.WriteLine(s);
        }
    }
}
