namespace OOPBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // det går inte att accessa privata fields direkt, så vi accessar dem med get istället
                Person person = new Person();
                person.Age = 10;
                person.Weight = -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
