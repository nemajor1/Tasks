namespace Basics.Methods
{
    internal class Task4
    {
        private string[] mass1 = { "apple", "honda", "hyi" };
        private string[] mass2 = { "apple", "honday", "hyi" };
        public Task4()
        {
            Intersect(mass1, mass2);
        }
        private void Intersect(string[] mass1, string[] mass2)
        {
            var result = mass1.Intersect(mass2);
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
