using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
    }

   
    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} is barking.");
        }
    }

   
    Animal animal = new Animal("Unknown", 0);
    Dog dog = new Dog("Rover", 3);

    
    animal.Eat(); 
dog.Eat(); 
dog.Bark(); 
