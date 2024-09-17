using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public int Age { 
            get { return age; } 
            set 
            {
                if (value < 0)
                    throw new ArgumentException("Age must be atleast 0");
                age = value; 
            }
        }
        public string FName { 
            get { return fName; } 
            set 
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("First name cannot be empty");
                else if (value.Length < 2 || value.Length > 10)
                    throw new ArgumentException("First name cannot be fewer than 2 or more than 10 characters long");
                fName = value; 
            } 
        }
        public string LName { 
            get {return lName; } 
            set 
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Last name cannot be empty");
                else if (value.Length < 3 || value.Length > 15)
                    throw new ArgumentException("Last name cannot be fewer than 3 or more than 15 charactrs long");
                lName = value; 
            } 
        }
        public double Height { 
            get { return height; } 
            set 
            {
                if (value < 0)
                    throw new ArgumentException("Height must be more than 0");
                height = value; 
            } 
        }
        public double Weight { 
            get { return weight; } 
            set 
            {
                if (value <= 0)
                    throw new ArgumentException("Weight must be more than 0");
                weight = value; 
            } 
        }
    }
}
