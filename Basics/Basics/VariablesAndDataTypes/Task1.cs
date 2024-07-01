namespace Basics.VariablesAndDataTypes
{
    internal class Task1
    {
        public void GetDataUser()
        {
            Console.WriteLine("Напиши свой возвраст");
            string? age = Console.ReadLine();
            Console.WriteLine("Напиши свое имя");
            string? name = Console.ReadLine();
            Console.WriteLine($"Привет, { name }, тебе { age } лет");
        }
    }
}
