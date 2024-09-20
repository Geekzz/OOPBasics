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

        public virtual string Stats()
        {
            return $"{name} is {age} old and weighs {weight} kg";
        }

        public virtual string TestReturnString() 
        {
            return "";
        }
    }

    public class Horse : Animal
    {
        public string breed { get; set; }
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

        public override string Stats()
        {
            return $"{name} is {age} old, weighs {weight} and race is {breed}";
        }
    }

    public class Dog : Animal
    {
        public string favoriteToy { get; set; }
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

        public override string Stats()
        {
            return $"{name} is {age} old, weighs {weight} and favorite toy is {favoriteToy}";
        }

        public override string TestReturnString()
        {
            return "Hejsan från hund!";
        }
    }

    public class Hedgehog : Animal
    {
        public int numberOfSpikes {  get; set; }
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

        public override string Stats()
        {
            return $"{name} is {age} old, weighs {weight} and number of spikes is {numberOfSpikes}";
        }
    }

    public class Worm : Animal
    {
        public bool isPoisionOus { get; set; }
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

        public override string Stats()
        {
            return $"{name} is {age} old, weighs {weight} and is poisionous {isPoisionOus}";
        }
    }

    public class Bird : Animal
    {
        public double spanOfWings { get; set; }
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

        public override string Stats()
        {
            return $"{name} is {age} old, weighs {weight} and got {spanOfWings} meter of span wings";
        }
    }

    public class Wolf : Animal
    {
        public string packName { get; set; }
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

        public override string Stats()
        {
            return $"{name} is {age} old, weighs {weight} and pack name is {packName}";
        }
    }

    public class Pelican : Bird
    {
        public double beakLength { get; set; }
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
        public double legLength { get; set; }

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
        public double neckLength { get; set; }

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