namespace OOPBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // det går inte att accessa privata fields direkt, så vi accessar dem med get istället
                //Person person = new Person();
                //person.Age = 10;
                //person.Weight = -1;
                PersonHandler handler = new PersonHandler();
                handler.CreatePerson(33, "Johan", "Ahlsson", 185, 75);
                handler.CreatePerson(23, "", "hejfdsalpfdsafpdsaåfdlspåa", -1, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
