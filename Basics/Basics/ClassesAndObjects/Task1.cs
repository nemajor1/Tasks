namespace Basics.ClassesAndObjects
{
    internal class Task1
    {
        public Task1()
        {
            Person person = new Person();
            Console.WriteLine("Введите имя");
            person.Name = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            person.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Блок Set");
            Console.WriteLine(person.Name + " " + person.Age);
            Console.WriteLine("Блок Get");

        }
    }
    internal class Person
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }
}
