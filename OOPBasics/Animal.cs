using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public abstract class Animal
    {
        protected string name { get; set; }
        protected uint age { get; set; }
        protected double weight { get; set; }

        public abstract void DoSound();
    }

    public class Horse : Animal
    {
        string breed { get; set; }
        public Horse()
        {
            name = "Zeke";
            age = 58;
            weight = 300.0;
            breed = "Pony";
        }
        public override void DoSound()
        {
            Console.WriteLine($"{name}, a {breed} breed, is neighing...");
        }
    }

    public class Dog : Animal
    {
        string favoriteToy { get; set; }
        public Dog()
        {
            name = "Paul";
            age = 6;
            weight = 24.0;
            favoriteToy = "Ball";
        }

        public override void DoSound()
        {
            Console.WriteLine($"{name} is woofing!");
        }
    }

    public class Hedgehog : Animal
    {
        int numberOfSpikes {  get; set; }
        public Hedgehog()
        {
            name = "Spike";
            age = 3;
            weight = 0.8;
            numberOfSpikes = 3000;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{name} makes a snorting sound...");
        }
    }

    public class Worm : Animal
    {
        bool isPoisionOus { get; set; }
        public Worm()
        {
            name = "Fizz";
            age = 1;
            weight = 0.1;
            isPoisionOus = true;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{name} is quiet...");
        }
    }

    public class Bird : Animal
    {
        protected double spanOfWings { get; set; }
        public Bird()
        {
            name = "Chirpy";
            age = 3;
            weight = 30;
            spanOfWings = 0.25;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{name} is chirping");
        }
    }

    public class Wolf : Animal
    {
        string packName { get; set; }
        public Wolf()
        {
            name = "Luna";
            age = 4;
            weight = 40;
            packName = "Night howlers";
        }

        public override void DoSound()
        {
            Console.WriteLine($"{name} is hoooooowling");
        }
    }

    public class Pelican : Bird
    {
        protected double beakLength { get; set; }
        public Pelican()
        {
            name = "Percy";
            age = 5;
            weight = 12.0;
            spanOfWings = 3.0;
            beakLength = 0.45;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{name} is squawking");
        }
    }

    public class Flamingo : Bird
    {
        protected double legLength { get; set; }

        public Flamingo()
        {
            name = "Fiora";
            age = 4;
            weight = 4.0;
            spanOfWings = 1.5;
            legLength = 1.5;
        }
    }

    public class Swan : Bird
    {
        protected double neckLength { get; set; }

        public Swan()
        {
            name = "Serennia";
            age = 6;
            weight = 9.0;
            spanOfWings = 2.4;
            neckLength = 0.6;
        }
        public override void DoSound()
        {
            Console.WriteLine($"{name} is flapping..");
        }
    }

    public class Wolfman: Wolf, IPerson
    {
        // 13 F:
        // om vi vill ge en ny attribut till alla fåglar kan vi lägga en ny set get attribut till Bird abstrakt klassen
        // och då kan alla subklasser använda attributen

        // 14 F:
        // lite samma sak, vi lägger in en ny set get till Animal abstrakt klassen

        // men en abstrakt klass gör att det nya attributet inte behöver implementeras (valfritt),
        // medan ett interface kräver att det implementeras, så frågan är: kräver vi att attributen
        // implementeras? i så fall, använd ett interface, och klasser som ärver från det måste implementera
        // attributen. om inte, kör med en abstrakt klass

        public Wolfman()
        {
            //...
            name = "Wolfie";
        }

        public void Talk()
        {
            Console.WriteLine($"{name} says: I'm not human!");
        }
    }


    interface IPerson
    {
        // denna kan läggas i Person klass... 
        void Talk();
    }
}