namespace Basics.Methods
{
    internal class Task3
    {
        private char[] chars;
        public Task3()
        {
            Console.WriteLine("Введите строку");
            chars = Console.ReadLine().ToCharArray();
            Words(chars);
        }
        private void Words(char[] chars)
        {
            int w = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i].ToString() == " ")
                {
                    w++;
                }
            }
            Console.WriteLine(w + 1 + " - количество слов");
        }
    }
}
