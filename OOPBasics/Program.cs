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
                //PersonHandler handler = new PersonHandler();

                //handler.CreatePerson(...)
                //handler.CreatePerson(23, "", "hejfdsalpfdsafpdsaåfdlspåa", -1, 0);

                List<UserError> errors = new List<UserError>();
                errors.Add(new NumericInputError());
                errors.Add(new TextInputError());
                errors.Add(new NullInputError());

                foreach (UserError error in errors)
                {
                    Console.WriteLine(error.UEMessage());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
