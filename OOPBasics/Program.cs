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

                //List<UserError> errors = new List<UserError>();
                //errors.Add(new NumericInputError());
                //errors.Add(new TextInputError());
                //errors.Add(new NullInputError());

                //foreach (UserError error in errors)
                //{
                //    Console.WriteLine(error.UEMessage());
                //}

                List<Animal> list = new List<Animal>();

                list.Add(new Bird());
                list.Add(new Wolf());
                list.Add(new Hedgehog());
                list.Add(new Worm());
                list.Add(new Wolfman());
                list.Add(new Horse());
                list.Add(new Dog());
                list.Add(new Pelican());
                list.Add(new Flamingo());
                list.Add(new Swan());

                List<Dog> list2 = new List<Dog>();
                list2.Add(new Dog { favoriteToy = "Tennis ball" });

                // ------------------------------------------------------------------------------------------------------
                // Arv 13 F:
                // Om vi vill ge en ny attribut till alla fåglar kan vi lägga en ny set get attribut till Bird abstrakt klassen
                // och då kan alla subklasser använda attributen

                // ------------------------------------------------------------------------------------------------------
                // Arv 14 F:
                // Lite samma sak, vi lägger in en ny set get till Animal abstrakt klassen

                // men en abstrakt klass gör att det nya attributet inte behöver implementeras (valfritt),
                // medan ett interface kräver att det implementeras, så frågan är: kräver vi att attributen
                // implementeras? i så fall, använd ett interface, och klasser som ärver från det måste implementera
                // attributen. om inte, kör med en abstrakt klass

                // ------------------------------------------------------------------------------------------------------

                // ------------------------------------------------------------------------------------------------------
                // Mer polymorfism 9 F:
                //
                // För översättaren klagar och säger att det inte går att konvertera häst till dog
                // object typ (I detta fallet är listan av Dog typ, inte Horse typ)
                // ------------------------------------------------------------------------------------------------------
                // Mer polymorfism 10 F:
                //
                // För att kunna lagra alla klasser som är subklasser av Animal i en lista bör listan
                // deklareras som av typen Animal. Detta gör att alla objekt som ärver från Animal kan
                // lagras i samma lista
                // ------------------------------------------------------------------------------------------------------
                // Mer polymorfism 13 F:
                //
                // Detta händer eftersom Animal klassen har en virtual metod Stats(),
                // subklasser kan välja att "override" denna metod och implementera sin egen version av Stats().
                // Om en subklass inte använder override, kommer den att ärva och anropa Stats() metoden från sin föräldraklass,
                // med andra ord, om ett objekt inte har en egen Stats metod, anropas den från den klass det ärver ifrån.
                // Till exempel, Pelican, Flamingo och Swan ärver från Bird, och eftersom de inte har någon 
                // egen Stats metod, anropas den som definieras i Bird
                // ------------------------------------------------------------------------------------------------------
                // Mer polymorfism 17 F:
                //
                // Eftersom Animal och alla andra subklasser förutom Dog, inte har den nya metoden så
                // blir kompilatorn förvirrad.
                // Det går ju inte att anropa en metod som inte har definierats i dessa klasser
                // ------------------------------------------------------------------------------------------------------

                // list2.Add(new Horse());


                foreach (var animal in list)
                {
                    // man kan printa ut object typ genom gettype().name
                    Console.WriteLine("Animal type: " + animal.GetType().Name + " - stats: " + animal.Stats());
                    animal.DoSound();

                    // animal.TestReturnString(); <---- Animal != Dog (utan virtual och override)
                    // Console.WriteLine(animal.TestReturnString()); // nu med virtual och override går det

                    // om man vill printa alla hund kan man göra här: 
                    //if (animal is Dog)
                    //{
                    //    Console.WriteLine("STATS: " + animal.Stats());
                    //}

                    if (animal is IPerson)
                    {
                        IPerson p = (IPerson)animal;
                        p.Talk();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
