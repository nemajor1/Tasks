namespace Basics.ClassesAndObjects
{
    internal class Task2
    {
        public Task2()
        {
            Console.WriteLine("Введите длину и ширину");
            int x = Convert.ToInt32 (Console.ReadLine());
            int y = Convert.ToInt32 (Console.ReadLine());
            Rectangle rec = new Rectangle (x, y);
        }
    }
    internal class Rectangle
    {
        public int length {  get; set; }
        public int width { get; set; }
        internal Rectangle(int length, int width)
        {
            Console.WriteLine($"Площадь - {length * width}, Периметр - {2 * (length + width)}");
        }
    }
}
