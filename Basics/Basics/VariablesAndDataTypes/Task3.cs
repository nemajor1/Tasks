namespace Basics.VariablesAndDataTypes
{
    internal class Task3
    {
        private int action;
        private int degree;
        public void Start()
        {
            Console.WriteLine("Выберите действие: 1 - из C' в F', 2 - из F' в C'");
            action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите величину");
            degree = Convert.ToInt32(Console.ReadLine());

            switch(action)
            {
                case 1:
                    InF(degree); break;
                case 2:
                    OutF(degree); break;
                default: Console.WriteLine("Неверное значение");Start(); break;
            }
        }
        private void InF(int degree)
        {
            Console.WriteLine(((degree * (9 / 5)) + 32) + " градусов по Фаренгейту");
            Start();
        }
        private void OutF(int degree)
        {
            Console.WriteLine(((degree - 32) * 5/9) + " градусов по Цельсия");
            Start();
        }
    }
}
