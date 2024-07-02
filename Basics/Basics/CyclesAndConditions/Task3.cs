namespace Basics.CyclesAndConditions
{
    internal class Task3
    {
        char[][] chars1 =
        {
            new char[] { 'а', 'е', 'ы', 'о', 'э', 'я', 'и', 'ю' },
            new char[] { 'й', 'ц', 'к', 'н', 'г', 'ш', 'щ','з',
                         'х', 'ъ', 'ф', 'в', 'п', 'р', 'л', 'д',
                         'д', 'ж', 'ч','с', 'м', 'т', 'ь', 'б' }
        };
    public Task3()
        {
            int i = 0; int h = 0;
            Console.WriteLine("Введите предложение");
            char[] symbols = Console.ReadLine().ToCharArray();
            for (int j = 0; j < symbols.Length; j++)
            {
                foreach (char x in chars1[0])
                {
                    var z = (x == symbols[j]) ? (i++) : 0;
                }
                foreach (char x in chars1[1])
                {
                    var z = (x == symbols[j]) ? (h++) : 0;
                }
            }
            Console.WriteLine(i + " - количество гласных");
            Console.WriteLine(h + " - количество согласных");
        }
    }
}
